using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AppMultiTool.Utils;
using AppMultiTool.Models;
using MasterWindowsForms;
using MySql.Data.MySqlClient;
using WMPLib;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.MainForms
{
    public partial class PlaylistMaker : Form
    {
        private readonly PlayListMakerModel control;
        private readonly MasterMySQLService sql;
        private readonly List<Button> actionbuttons;
        private readonly XMLHandler xml;
        private readonly string returnedPlaylist;

        public PlaylistMaker(bool isMaximized = false) : this(string.Empty, isMaximized) { }

        public PlaylistMaker(string _playlist, bool isMaximized = false)
        {
            InitializeComponent();

            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));
            this.returnedPlaylist = _playlist;
            actionbuttons = [btnCanRepeat, btnRandomizePlaylist];
            control = new();
            cbbListPlaylists.SelectedIndex = 0;
            control.Player = new WindowsMediaPlayer();
            control.Player.PlayStateChange += Player_PlayStateChange;
            control.Playlists = [];
            control.Songs = [];
            control.Boolpropsbtns = [control.LoopPlaylist, control.RandomPlaylist];

            this.Width = 924;

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);

            xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            if (isMaximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        #region Control
        private void pnlLyricsPanel_Move(object sender, EventArgs e)
        {
            if (pnlLyricsPanel.Location.X < 908)
                pnlLyricsPanel.Location = new Point(908, 27);
        }

        private void PlaylistMaker_Resize(object sender, EventArgs e)
        {
            if (this.Width > 1300)
            {
                pnlLyricsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            }
            else if (this.Width <= 1300)
            {
                pnlLyricsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                pnlLyricsPanel.Location = new Point(1543, 27);
            }

            pnlMainPanel.Width = pnlLyricsPanel.Left - clbListSongs.Left - 8;
        }

        private void PlaylistMaker_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private async void PlaylistMaker_Shown(object sender, EventArgs e)
        {
            await ConnectDB();

            if (!string.IsNullOrEmpty(this.returnedPlaylist))
            {
                var pl = control.Playlists.FirstOrDefault(p => p.Title == this.returnedPlaylist);
                int index = cbbListPlaylists.Items.IndexOf(pl.Title);
                cbbListPlaylists.SelectedIndex = index;
            }

            btnPlayPause.Focus();
        }

        private async Task ConnectDB()
        {
            try
            {
                string query = "SELECT * FROM playlists";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                if (listItems.Count > 0)
                {
                    listItems.ForEach(item => control.Playlists.Add(new PlayListItem(item)));
                }

                control.Playlists.ForEach(p => cbbListPlaylists.Items.Add(p.Title));

                listItems.Clear();

                query = "SELECT * FROM songs_view";

                resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                listItems = resp.Response;

                if (listItems.Count > 0)
                {
                    listItems.ForEach(item => control.Songs.Add(new SongItem(item)));
                }

                query = "SELECT configvalue FROM playlistmaker_configs WHERE idplaylistconfig = 2";

                var _resp = await sql.ReadSingledQuery(query);

                if (!_resp.WasSuccessful)
                    throw new Exception(_resp.ResponseErr);

                int volume = _resp.Response != string.Empty ? Convert.ToInt32(_resp.Response) : 100;
                trackBarVolume.Value = volume;
                lblInfoVolume.Text = volume.ToString();
                control.Player.settings.volume = volume;

                query = "SELECT group_concat(configvalue) FROM playlistmaker_configs WHERE idplaylistconfig in(3,4)";

                _resp = await sql.ReadSingledQuery(query);

                if (!_resp.WasSuccessful)
                    throw new Exception(_resp.ResponseErr);

                if (_resp.Response != string.Empty)
                {
                    var boolConfigList = _resp.Response.Split(",").ToList();

                    for (int i = 0; i < boolConfigList.Count; i++)
                    {
                        control.Boolpropsbtns[i] = boolConfigList[i] == "1";

                        if (control.Boolpropsbtns[i])
                            Repeat_Randomize_BtnEvent(actionbuttons[i], EventArgs.Empty);
                    }
                }

                lblLoading.Visible = false;

                List<Button> buttons = Master.ListControls<Button>(this);
                Master.EnableControls<Button>(buttons);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void OpenNewTabMenu(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            List<ToolStripMenuItem> itens = [tsmiClipBoardCopies, tsmiSSConverter, tsmiDateCalculator, tsmiTextConverter];
            List<Form> forms = [Global.Forms.ClipboardCopies, Global.Forms.SpreadSheetConverter, Global.Forms.DateCalculator, Global.Forms.TextConverter];
            List<Type> typeForms = [typeof(ClipboardCopies), typeof(SpreadSheetConverter), typeof(DateCalculator), typeof(TextConverter)];

            int index = itens.IndexOf(item);
            var form = forms[index];
            var type = typeForms[index];

            if (form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(type);
                forms[index] = form;
            }

            Global.AllowCloseApp = false;

            form.Show();
        }

        private void PauseSongAndResetGlobal()
        {
            PauseSong();
            Global.AllowCloseApp = true;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseSongAndResetGlobal();
            Master.SwitchScreen(Global.Forms.MainMenu, this);
        }

        private void tsmiConfigs_Click(object sender, EventArgs e)
        {
            PauseSongAndResetGlobal();
            Global.Forms.PlayListConfigs = new();
            Master.ShowScreen(Global.Forms.PlayListConfigs);
        }

        private void tsmiCreatePlaylist_Click(object sender, EventArgs e)
        {
            PauseSongAndResetGlobal();
            Global.Forms.PlayListCreator = new();
            Master.ShowScreen(Global.Forms.PlayListCreator);
        }

        private void tsmiCommandLine_Click(object sender, EventArgs e) => CommandLine.Show(this);

        private void SortPlaylist(object sender, EventArgs e)
        {
            try
            {
                if (cbbListPlaylists.SelectedIndex <= 0)
                    throw new Exception("Necessário que uma playlist esteja selecionada para ser ordenada!");

                PauseSong();

                var tsmi = sender as ToolStripMenuItem;
                bool canParse = int.TryParse(tsmi.Tag.ToString(), out int result);
                int op = canParse ? result : 1;

                switch (op)
                {
                    case 1:
                        control.CurrentPlaylist = control.DeepCopyPlaylist(control.OriginalPlaylist);
                        break;
                    case 2:
                        var sortedPlaylist = control.SortPlayList(control.DeepCopyPlaylist(control.CurrentPlaylist)
                            .OrderBy(s => s.Title.Contains("-") ? s.Title.Split("-").GetValue(1).ToString().Trim() : s.Title)
                            .ToList());
                        control.CurrentPlaylist = sortedPlaylist;
                        break;
                    case 3:
                        sortedPlaylist = control.SortPlayList(control.DeepCopyPlaylist(control.CurrentPlaylist)
                            .OrderByDescending(s => s.Title.Contains("-") ? s.Title.Split("-").GetValue(1).ToString().Trim() : s.Title)
                            .ToList());
                        control.CurrentPlaylist = sortedPlaylist;
                        break;
                }

                this.BuildClbListSongs();
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            var song = control.Songs?.Find(s => s.Title == txtSongName.Text);

            if (song is not null)
                rtxtLyrics.Text = song.Lyrics;
        }

        private void clbListSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(clbListSongs?.SelectedItem?.ToString()) && !control.AutoNextSong)
            {
                txtSongName.Text = SongItem.GetSongName(clbListSongs.SelectedItem.ToString());
                control.CurrentTrackIndex = clbListSongs.SelectedIndex;
                control.SelectedSongTitle = clbListSongs.SelectedIndex == -1 ? string.Empty : clbListSongs.SelectedItem.ToString();
                control.ManualSongSelected = true;
            }
        }

        private void cbbListPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbListPlaylists.SelectedIndex > 0)
            {
                this.BuildClbListSongs();
                control.OriginalPlaylist = control.DeepCopyPlaylist(control.CurrentPlaylist);
            }
            else if (cbbListPlaylists.SelectedIndex == 0)
            {
                cbbListPlaylists.ForeColor = Color.Black;
                clbListSongs.Items.Clear();
                control.CurrentPlaylist?.Clear();

                txtSongName.Text = string.Empty;
                rtxtLyrics.Text = string.Empty;
            }

            btnPlayPause.Focus();
        }

        private void BuildClbListSongs()
        {
            clbListSongs.Items.Clear();

            PlayListItem _playlist = control.Playlists.Find(p => p.Title == cbbListPlaylists.SelectedItem.ToString());
            DeployPlayListColorCBB(_playlist);

            List<SongItem> _songs = control.Songs.Where(s => s.IdPlaylist == _playlist.ID).OrderBy(s => s.NumSeq).ToList();

            _songs.ForEach(s => clbListSongs.Items.Add(s.ConcatNumSeq(), s.Active));
            control.CurrentPlaylist = _songs;

            txtSongName.Text = string.Empty;
            rtxtLyrics.Text = string.Empty;
        }

        private void lblPlayingInfo_TextChanged(object sender, EventArgs e)
        {
            if (!lblPlayingInfo.Text.Contains("(PAUSADO)"))
            {
                control.AutoNextSong = true;

                int songIndex = control.CurrentPlaylist.IndexOf(control.CurrentPlaylist.FirstOrDefault(s => s.Title == lblPlayingInfo.Text));
                int index = clbListSongs.Items.IndexOf(control.CurrentPlaylist[songIndex].ConcatNumSeq());

                clbListSongs.SelectedIndex = index;
                txtSongName.Text = control.CurrentPlaylist[songIndex].Title;

                control.AutoNextSong = false;
            }
        }

        private void DeployPlayListColorCBB(PlayListItem _playlist)
        {
            List<string> argb = _playlist.ForeColor.Split("--").ToList();
            Color pl_color = Color.FromArgb(Convert.ToInt32(argb[0]), Convert.ToInt32(argb[1]), Convert.ToInt32(argb[2]), Convert.ToInt32(argb[3]));

            cbbListPlaylists.ForeColor = pl_color;
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            if (cbbListPlaylists.SelectedIndex > 0)
            {
                PauseSongAndResetGlobal();
                control.Player.close();

                PlayListItem _playlist = control.Playlists.Find(p => p.Title == cbbListPlaylists.SelectedItem.ToString());
                Global.Forms.PlayListEditor = new(_playlist.Title, this.WindowState == FormWindowState.Maximized);
                Master.SwitchScreen(Global.Forms.PlayListEditor, this);
            }
        }

        #endregion

        #region MusicControl

        private void txtSearchSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbListPlaylists.SelectedIndex > 0)
                {
                    string searchText = txtSearchSong.Text.ToLower();

                    var filteredSongs = string.IsNullOrWhiteSpace(searchText)
                        ? control.CurrentPlaylist
                        : control.CurrentPlaylist.Where(song => song.Title.ToLower().Contains(searchText)).ToList();

                    var uniqueSongs = filteredSongs.GroupBy(song => song.Title).Select(g => g.First()).ToList();

                    clbListSongs.Items.Clear();

                    uniqueSongs.ForEach(song => clbListSongs.Items.Add(song.ConcatNumSeq(), song.Active));

                    if (clbListSongs.Items.Count > 0 && !string.IsNullOrEmpty(control.SelectedSongTitle))
                    {
                        int index = clbListSongs.Items.IndexOf(control.SelectedSongTitle);

                        if (index >= 0)
                            clbListSongs.SelectedIndex = index;
                    }
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private void btnSongLyrics_Click(object sender, EventArgs e) => this.Width = this.Width == 924 ? 1300 : 924;

        private async void btnUpdateLyrics_Click(object sender, EventArgs e)
        {
            string selectedsong = txtSongName.Text;

            if (Utilix.IsNullOrEmptyOrWhiteSpace(selectedsong) || cbbListPlaylists.SelectedIndex <= 0)
                return;

            try
            {
                string newLyrics = rtxtLyrics.Text;
                var song = control.Songs.Find(s => s.Title == selectedsong);

                string query = $"UPDATE songs SET lyrics = @lyric WHERE idsong = {song.ID}";
                var command = new MySqlCommand(query, sql.Connection);
                command.Parameters.AddWithValue("@lyric", newLyrics);

                var resp = await sql.ExecuteQuery(command);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    song.Lyrics = newLyrics;
                    Master.ShowQuickly(lblLyricsUpdated);
                }
                else
                    Master.ShowInfoMessage("Nenhum valor alterado!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async void btnSearchLyrics_Click(object sender, EventArgs e)
        {
            btnSearchLyrics.Enabled = false;
            btnSearchLyrics.Text = "Aguarde...";
            string selectedsong = txtSongName.Text;

            if (Utilix.IsNullOrEmptyOrWhiteSpace(selectedsong) || cbbListPlaylists.SelectedIndex <= 0)
                return;

            try
            {
                var artist_song = selectedsong.Split('-');
                string artist = artist_song[0].Trim();
                string song = artist_song[1].Trim();

                var resp = await LyricsExtractor.WebExtraction(artist, song);

                if(!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                rtxtLyrics.Text = resp.Response;
            }
            catch(Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnSearchLyrics.Enabled = true;
            btnSearchLyrics.Text = "Buscar Letra🔎";
        }

        private void Player_PlayStateChange(int newState)
        {
            switch ((WMPPlayState)newState)
            {
                case WMPPlayState.wmppsPlaying:
                    control.ManualSongSelected = false;
                    lblPlayingInfo.Text = control.CurrentPlaylist[control.CurrentTrackIndex].Title;
                    break;
                case WMPPlayState.wmppsPaused:
                    control.IsSongPaused = true;
                    lblPlayingInfo.Text = string.Concat(lblPlayingInfo.Text, " (PAUSADO)");
                    break;
                case WMPPlayState.wmppsMediaEnded:
                    Thread thread = new(() =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            btnNext_Click((object)true, EventArgs.Empty);
                        });
                    });
                    thread.Start();
                    break;
            }
        }

        private void PauseSong()
        {
            control.IsSongStarted = false;
            control.Player.controls.pause();
            btnPlayPause.Text = "▶";
        }

        private void StopSong()
        {
            timer?.Stop();
            control.IsSongStarted = false;
            control.Player.controls.stop();
            btnPlayPause.Text = "▶";
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (cbbListPlaylists.SelectedIndex == 0)
                return;

            try
            {
                if (cbbListPlaylists.SelectedIndex == 0)
                    throw new Exception("Playlist não selecionada!");

                if (control.IsSongStarted)
                {
                    timer.Stop();
                    control.Player.controls.pause();
                    btnPlayPause.Text = "▶";
                }
                else
                {
                    txtSearchSong.Text = string.Empty;

                    if (!control.IsSongPaused || control.ManualSongSelected)
                    {
                        control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;

                        if (!control.SongsPlayedIndex.Contains(control.CurrentTrackIndex))
                            control.SongsPlayedIndex.Add(control.CurrentTrackIndex);
                    }

                    timer.Start();
                    control.Player.controls.play();
                    btnPlayPause.Text = "II";
                }
                control.IsSongStarted = !control.IsSongStarted;
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            btnPlayPause.Focus();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cbbListPlaylists.SelectedIndex == 0)
                return;

            if (control.RandomPlaylist)
                control.SongsPlayedIndex.Clear();

            control.Player.controls.stop();
            control.CurrentTrackIndex--;
            if (control.CurrentTrackIndex >= 0)
            {
                control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;
                control.Player.controls.play();
            }
            else
            {
                control.CurrentTrackIndex = control.CurrentPlaylist.Count - 1;
                control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;
                control.Player.controls.play();
            }

            btnPlayPause.Text = "II";
            control.IsSongStarted = true;

            if (control.RandomPlaylist)
                control.SongsPlayedIndex.Add(control.CurrentTrackIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbbListPlaylists.SelectedIndex == 0)
                return;

            Thread newThread = new(() =>
            {
                if (sender is bool)
                {
                    Thread.Sleep(1000);
                }

                this.Invoke((MethodInvoker)delegate
                {
                    control.Player.controls.stop();

                    if (control.RandomPlaylist)
                    {
                        if (control.SongsPlayedIndex.Count != control.CurrentPlaylist.Count)
                        {
                            bool canRunningLoop = true;

                            while (canRunningLoop)
                            {
                                Random x = new();
                                int index = x.Next(0, control.CurrentPlaylist.Count + 1);

                                if (control.SongsPlayedIndex.Contains(index))
                                    continue;

                                control.CurrentTrackIndex = index;
                                canRunningLoop = false;
                            }
                        }
                    }
                    else
                        control.CurrentTrackIndex++;

                    if ((control.CurrentTrackIndex < control.CurrentPlaylist.Count && !control.RandomPlaylist)
                    || (control.RandomPlaylist && control.SongsPlayedIndex.Count != control.CurrentPlaylist.Count))
                    {
                        control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;
                        control.Player.controls.play();

                        if (control.RandomPlaylist)
                            control.SongsPlayedIndex.Add(control.CurrentTrackIndex);
                    }
                    else if (control.LoopPlaylist)
                    {
                        control.CurrentTrackIndex = 0;
                        control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;
                        control.Player.controls.play();

                        if (control.RandomPlaylist)
                        {
                            control.SongsPlayedIndex.Clear();
                            control.SongsPlayedIndex.Add(control.CurrentTrackIndex);
                        }
                    }
                    else
                    {
                        control.CurrentTrackIndex = 0;
                        control.Player.URL = control.CurrentPlaylist[control.CurrentTrackIndex].Path;
                        StopSong();
                        return;
                    }

                    btnPlayPause.Text = "II";
                    control.IsSongStarted = true;
                });
            });

            newThread.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (control.Player.currentMedia != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    trackBarSong.Maximum = (int)control.Player.currentMedia.duration;
                    trackBarSong.Value = (int)control.Player.controls.currentPosition;

                    double currentPosition = control.Player.controls.currentPosition;
                    double duration = control.Player.currentMedia.duration;
                    lblDuration.Text = $"{FormatTime(currentPosition)} / {FormatTime(duration)}";
                });
            }
        }

        private static string FormatTime(double seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        }

        private void trackBarSong_Scroll(object sender, EventArgs e) => control.Player.controls.currentPosition = trackBarSong.Value;

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            control.Player.settings.volume = trackBarVolume.Value;
            lblInfoVolume.Text = trackBarVolume.Value.ToString();
        }

        private void Repeat_Randomize_BtnEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.ForeColor == Color.DarkGreen)
            {
                control.Boolpropsbtns[actionbuttons.IndexOf(btn)] = false;
                bool usingDarkTheme = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response);

                Font font = new(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular, GraphicsUnit.Point);
                btn.Font = font;
                btn.ForeColor = usingDarkTheme ? Color.White : Color.Black;

                if (btn == btnCanRepeat)
                    control.LoopPlaylist = false;

                if (btn == btnRandomizePlaylist)
                {
                    control.SongsPlayedIndex.Clear();
                    control.RandomPlaylist = false;
                }
            }
            else
            {
                control.Boolpropsbtns[actionbuttons.IndexOf(btn)] = true;

                Font font = new(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold, GraphicsUnit.Point);
                btn.Font = font;
                btn.ForeColor = Color.DarkGreen;

                if (btn == btnCanRepeat)
                    control.LoopPlaylist = true;

                if (btn == btnRandomizePlaylist)
                {
                    control.RandomPlaylist = true;
                }
            }
        }

        #endregion
    }
}
