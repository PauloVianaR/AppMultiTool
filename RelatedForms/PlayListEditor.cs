using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using AppMultiTool.Utils;
using AppMultiTool.MainForms;
using AppMultiTool.Models;
using MasterWindowsForms;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using Google.Apis.Http;
using AppMultiTool.Utils.GlobalItems;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.RelatedForms
{
    public partial class PlayListEditor : Form
    {
        private readonly MasterMySQLService sql;

        private List<PlayListItem> playlists;
        private List<SongItem> songs;
        private List<string> checkedSongs;
        private string currentPlaylist = string.Empty;

        public PlayListEditor()
        {
            InitializeComponent();

            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));

            InitializeAll();
        }

        public PlayListEditor(string playlist, bool isMaximized = false)
        {
            InitializeComponent();

            sql = new(MySQLService.GetConnectString(Databases.AppMultiTool));

            InitializeAll();

            currentPlaylist = playlist;

            if(isMaximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void InitializeAll()
        {
            cbbPlaylists.SelectedIndex = 0;

            playlists = [];
            songs = [];
            checkedSongs = [];

            XMLHandler xml = new(CommonFile.AppSettings);
            ThemeType ttype = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response) ? ThemeType.Dark : ThemeType.White;
            WallPaper wpp = Enum.Parse<WallPaper>(xml.GetValueByAddKey(AppKeys.WallPaper).Response);
            ThemeHandler.ApplyTheme(Master.ListControls(this), ttype);
            ThemeHandler.ApplyWallPaper(this, wpp);

            Global.GlobalTimer.UpdateTitleTime += (object sender, EventArgs e) => Global.GlobalTimer.UpdateTitleTimeLabelForm(lblTitle);
        }

        #region Control
        private void PlayListEditor_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Global.Forms.PlaylistMaker.IsDisposed)
                Global.Forms.PlaylistMaker.Dispose();

            bool isMaximized = this.WindowState == FormWindowState.Maximized;

            if (cbbPlaylists.SelectedIndex > 0)
            {
                Global.Forms.PlaylistMaker = new(currentPlaylist, isMaximized);
            }
            else
            {
                Global.Forms.PlaylistMaker = new(isMaximized);
            }

            Master.SwitchScreen(Global.Forms.PlaylistMaker, this);
        }        

        private async void PlayListEditor_Shown(object sender, EventArgs e)
        {
            await ConnectBd();

            var _playlist = playlists.Find(p => p.Title == currentPlaylist);
            int index = playlists.IndexOf(_playlist) + 1;

            cbbPlaylists.SelectedIndex = index;
        }

        private async Task ConnectBd()
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
                    listItems.ForEach(item => playlists.Add(new PlayListItem(item)));
                }

                playlists.ForEach(p => cbbPlaylists.Items.Add(p.Title));

                listItems.Clear();

                await UpdateSongsCatalogue();

                if (cbbPlaylists.Items.Count > 1 && currentPlaylist != string.Empty)
                {
                    int index = cbbPlaylists.Items.IndexOf(currentPlaylist);
                    cbbPlaylists.SelectedIndex = index;

                    PlayListItem _playlist = playlists.Find(p => p.Title == currentPlaylist);
                    DeployPlayListColorCBB(_playlist);
                }

                lblLoading.Visible = false;

                List<Button> renameButtons = [btnRenamePlaylist, btnRenameSong];
                List<Button> buttons = Master.ListControls<Button>(this).Except(renameButtons).ToList();
                Master.EnableControls<Button>(buttons);

                Master.EnableControls(Master.ListControls<ComboBox>(this));
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async Task UpdateSongsCatalogue()
        {
            try
            {
                string query = "SELECT * FROM songs_view";

                var resp = await sql.ReadQuery(query);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                var listItems = resp.Response;

                songs.Clear();
                clbCatalogue.Items.Clear();

                if (listItems.Count > 0)
                {
                    listItems.ForEach(item =>
                    {
                        songs.Add(new SongItem(item));

                        if (!clbCatalogue.Items.Contains(item.Title))
                            clbCatalogue.Items.Add(item.Title, false);
                    });
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        #endregion

        #region PlayListEditor

        private void DeployPlayListColorCBB(PlayListItem _playlist)
        {
            List<string> argb = _playlist.ForeColor.Split("--").ToList();
            Color pl_color = Color.FromArgb(Convert.ToInt32(argb[0]), Convert.ToInt32(argb[1]), Convert.ToInt32(argb[2]), Convert.ToInt32(argb[3]));

            cbbPlaylists.ForeColor = pl_color;
            lblPlayListName.ForeColor = pl_color;
        }

        private void cbbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCatalogue.SelectedIndex = -1;

            for (int i = 0; i < clbCatalogue.Items.Count; i++)
            {
                clbCatalogue.SetItemChecked(i, false);
            }

            if (cbbPlaylists.SelectedIndex > 0)
            {
                lsbSongs.Items.Clear();
                txtSongName.Text = string.Empty;

                currentPlaylist = cbbPlaylists.SelectedItem.ToString();
                PlayListItem _playlist = playlists.Find(p => p.Title == currentPlaylist);
                DeployPlayListColorCBB(_playlist);

                List<SongItem> _songs = songs.Where(s => s.IdPlaylist == _playlist.ID).OrderBy(s => s.NumSeq).ToList();
                _songs.ForEach(s =>
                {
                    lsbSongs.Items.Add(s.ConcatNumSeq());

                    int catalogueIndex = clbCatalogue.Items.IndexOf(s.Title);
                    clbCatalogue.SetItemChecked(catalogueIndex, true);
                });

                numChangeSongPos.Maximum = _songs.Count;

                lblPlayListName.Text = currentPlaylist;
            }
            else if (cbbPlaylists.SelectedIndex == 0)
            {
                currentPlaylist = string.Empty;
                lblPlayListName.Text = "[Playlist]";
                lblPlayListName.ForeColor = Color.Black;
                lsbSongs.Items.Clear();
                cbbPlaylists.ForeColor = Color.Black;
                txtSongName.Text = string.Empty;
                numChangeSongPos.Maximum = 0;
            }

            lblPlayListName.Focus();
        }

        private async void btnRenamePlaylist_Click(object sender, EventArgs e)
        {
            btnRenamePlaylist.Enabled = false;

            if (cbbPlaylists.SelectedIndex > 0)
            {
                try
                {
                    int selectedIndex = cbbPlaylists.SelectedIndex;
                    string newPLname = Prompt.ShowDialog("Novo nome: ", "Renomear playlist");

                    if (string.IsNullOrWhiteSpace(newPLname))
                        throw new Exception("O novo nome não pode ser vazio!");

                    var playlst = playlists.Find(p => p.Title == cbbPlaylists.Items[selectedIndex].ToString());

                    if (newPLname.Equals(playlst.Title))
                        throw new Exception("A playlist já está com esse nome!");

                    string query1 = $"UPDATE playlists SET name_pl = '{newPLname}' WHERE idplaylist = {playlst.ID}";

                    var resp = await sql.ExecuteQuery(query1);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (resp.Response > 0)
                    {
                        playlst.Title = newPLname;
                        cbbPlaylists.Items[selectedIndex] = playlst.Title;

                        currentPlaylist = newPLname;

                        Master.ShowQuickly(lblRenameFineshed);
                    }
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }

            btnRenamePlaylist.Enabled = true;
        }

        private async void btnChangePlaylistColor_Click(object sender, EventArgs e)
        {
            if (cbbPlaylists.SelectedIndex > 0)
            {
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var _color = colorPicker.Color;
                        string forecolor = string.Concat(_color.A.ToString(), "--", _color.R.ToString(), "--", _color.G.ToString(), "--", _color.B.ToString());
                        var playlist = playlists.Find(p => p.Title == cbbPlaylists.SelectedItem.ToString());

                        string query = $"UPDATE playlists SET forecolor = '{forecolor}' WHERE idplaylist = {playlist.ID}";
                        var resp = await sql.ExecuteQuery(query);

                        if (!resp.WasSuccessful)
                            throw new Exception(resp.ResponseErr);

                        if (resp.Response > 0)
                        {
                            playlist.ForeColor = forecolor;
                            DeployPlayListColorCBB(playlist);

                            Master.ShowQuickly(lblChangeColorFineshed);
                        }
                    }
                    catch (Exception ex)
                    {
                        Master.ShowErrorMessage(ex.Message);
                    }
                }
            }
        }

        private async void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            btnDeletePlaylist.Enabled = false;

            if (cbbPlaylists.SelectedIndex > 0)
            {
                if (Master.ShowQuestionMessage("Deseja mesmo remover a playlist?") == DialogResult.Yes)
                {
                    try
                    {
                        var playlist = playlists.Find(p => p.Title == cbbPlaylists.SelectedItem.ToString());
                        string query = $"DELETE FROM playlists WHERE idplaylist = {playlist.ID}";

                        var resp = await sql.ExecuteQuery(query);

                        if (!resp.WasSuccessful)
                            throw new Exception(resp.ResponseErr);

                        if (resp.Response > 0)
                        {
                            playlists.Remove(playlist);
                            await UpdateSongsCatalogue();
                            cbbPlaylists.Items.Remove(playlist.Title);
                            cbbPlaylists.SelectedIndex = 0;
                        }
                        else
                            Master.ShowInfoMessage("Nenhum registro foi removido!");
                    }
                    catch (Exception ex)
                    {
                        Master.ShowErrorMessage(ex.Message);
                    }
                }
            }

            btnDeletePlaylist.Enabled = true;
        }

        private void btnSortPlaylist_Click(object sender, EventArgs e)
        {
            // to do --> criar uma procedure no banco pra fazer isso e só recarregar os dados na tela
        }

        #endregion

        #region SongEditor

        private SongItem GetSelectedSong()
        {
            var playList = playlists.FirstOrDefault(p => p.Title == cbbPlaylists.Text);
            return songs.FirstOrDefault(s => s.Title == SongItem.GetSongName(lsbSongs.SelectedItem.ToString()) && s.IdPlaylist == playList.ID);
        }

        private async void btnDownloadSong_Click(object sender, EventArgs e)
        {
            btnDownloadSong.Enabled = false;
            btnDownloadSong.Text = "Aguarde...";
            pgbDownloadProgress.Value = 0;
            lblPercentDownload.Text = "0.00%";

            try
            {
                if (cbbPlaylists.SelectedIndex == 0)
                    throw new Exception("Selecione uma playlist para inserir a música.");

                string url = txtURL.Text;

                if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
                    throw new Exception("Informe a URL.");

                var progress = new Progress<double>(percent =>
                {
                    Invoke((Action)(() =>
                    {
                        pgbDownloadProgress.Value = (int)(percent * 100);
                        lblPercentDownload.Text = $"{percent * 100:0.00}%";
                    }));
                });

                var _playList = playlists.Find(p => p.Title == currentPlaylist);
                string _path = _playList.Path + @"\";

                var resp = await SongItem.GetNextNumSeq(_playList, sql.Connection);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                int _numSeq = resp.Response;

                YTDownloader downloader = new();
                var respVideo = await downloader.DownloadAudio(url, _path, progress);

                if (!respVideo.WasSuccessful)
                    throw new Exception(respVideo.ResponseErr);

                string videoTitle = respVideo.Response;
                string filePath = Path.Combine(_path, $"{videoTitle}.mp3");

                SongItem song = new(9999999, videoTitle, filePath, _playList.ID, _numSeq, true);

                if (await InsertSongSuccess(song))
                {
                    Master.ShowQuickly(lblDownloadEnded);
                    txtURL.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message, "FALHA");
            }

            btnDownloadSong.Text = "Baixar e adicionar";
            btnDownloadSong.Enabled = true;
        }

        private async void btnAddSongFromPC_Click(object sender, EventArgs e)
        {
            if (cbbPlaylists.SelectedIndex > 0 && !string.IsNullOrEmpty(txtSongPath.Text) && !string.IsNullOrWhiteSpace(txtSongPath.Text))
            {
                try
                {
                    if (Utilix.TextContains(txtSongPath.Text,"youtube.com") || Utilix.TextContains(txtSongPath.Text,"youtu.be"))
                        throw new Exception("Acho que você informou o link de download no campo errado :D");

                    string songnameExtesion = txtSongPath.Text.Split(@"\").Last();
                    string songname = Regex.Replace(songnameExtesion, ".mp3|.wav|.ogg|.m4a|.aiff|.flac|.aac", "");

                    string path = txtSongPath.Text;
                    var _playList = playlists.Find(p => p.Title == currentPlaylist);

                    var resp = await SongItem.GetNextNumSeq(_playList, sql.Connection);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    int _numSeq = resp.Response;

                    string newPath = Path.Combine(_playList.Path, songnameExtesion);

                    if (!File.Exists(newPath))
                        File.Copy(path, newPath);

                    SongItem _song = new(9999999, songname, newPath, _playList.ID, _numSeq, true);

                    if (await InsertSongSuccess(_song))
                    {
                        txtSongPath.Text = string.Empty;
                        Master.ShowQuickly(lblPCSongAdded);
                    }
                    else
                        File.Delete(newPath);
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnPickSong_Click(object sender, EventArgs e)
        {
            if (cbbPlaylists.SelectedIndex > 0)
            {
                btnPickSong.Enabled = false;
                btnAddSongFromPC.Enabled = false;
                lblWaitPath.Visible = true;

                OpenFileDialog fd = new();
                fd.Filter = "Arquivo de áudio|*.mp3;*.wav;*.ogg;*.m4a;*.aiff;*.flac;*.aac";
                fd.Multiselect = false;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string path = fd.FileName;
                    txtSongPath.Text = path;
                }

                btnPickSong.Enabled = true;
                btnAddSongFromPC.Enabled = true;
                lblWaitPath.Visible = false;
            }
        }

        private async Task<bool> InsertSongSuccess(SongItem song)
        {
            bool isSucessful = false;

            try
            {
                string query1 = $"INSERT INTO songs(name_song,path) VALUES ('{song.Title}','{song.Path.Replace("\\", "\\\\")}')";
                string query2 = $"INSERT INTO songs_playlist(idsong,idplaylist,numseq,active) SELECT max(idsong),{song.IdPlaylist},{song.NumSeq},1 FROM songs";

                var resp = await sql.ExecuteTransactionQuery(query1, query2);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    query1 = "SELECT max(idsong) FROM songs";

                    var _resp = await sql.ReadSingledQuery(query1);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    string result = _resp.Response;
                    int newID = result != string.Empty ? Convert.ToInt32(result) : 1;

                    SongItem _song = new(newID, song.Title, song.Path, song.IdPlaylist, song.NumSeq, true);

                    songs.Add(_song);
                    lsbSongs.Items.Add(song.ConcatNumSeq());

                    if (!clbCatalogue.Items.Contains(_song.Title))
                        clbCatalogue.Items.Add(_song.Title, true);

                    isSucessful = true;
                    numChangeSongPos.Maximum += 1;
                }
                else
                    Master.ShowInfoMessage("Nenhum valor inserido!");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            return isSucessful;
        }

        private void lsbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dynamic selectedIndex = lsbSongs?.SelectedIndex;

                if (selectedIndex is not null && selectedIndex >= 0)
                {
                    string song = lsbSongs.SelectedItem.ToString();
                    int catalog_index = clbCatalogue.Items.IndexOf(SongItem.GetSongName(song));
                    clbCatalogue.SelectedIndex = catalog_index;
                    numChangeSongPos.Value = SongItem.GetNumSeq(song);
                }
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }

            lsbSongs.Focus();
        }

        private void txtSongName_TextChanged(object sender, EventArgs e) => btnRenameSong.Enabled = Utilix.IsNotNullOrEmptyOrWhiteSpace(txtSongName.Text);

        private void ResetLsbSongsItems(PlayListItem _playList)
        {
            lsbSongs.Items.Clear();
            var _songs = songs.Where(s => s.IdPlaylist == _playList.ID).OrderBy(s => s.NumSeq).ToList();
            _songs.ForEach(s => lsbSongs.Items.Add(s.ConcatNumSeq()));
        }

        private void btnUpNumSeqSong_Click(object sender, EventArgs e) => ChangeSongPositionUpDown(true);
        private void btnDownNumSeqSong_Click(object sender, EventArgs e) => ChangeSongPositionUpDown(false);

        private async void ChangeSongPositionUpDown(bool isMovingUp)
        {
            if (lsbSongs.SelectedIndex >= 0)
            {
                try
                {
                    var song = this.GetSelectedSong();
                    int lastNumSeq = songs.Where(s => s.IdPlaylist == song.IdPlaylist).OrderByDescending(s => s.NumSeq).FirstOrDefault().NumSeq;

                    int newNumSeq = isMovingUp ? song.NumSeq - 1 : song.NumSeq + 1;
                    bool canMove = isMovingUp ? song.NumSeq > 1 : song.NumSeq < lastNumSeq;

                    if (canMove)
                    {
                        var resp = await SwitchPosSongs(song, newNumSeq);

                        if (!resp.WasSuccessful)
                            throw new Exception(resp.ResponseErr);

                        if (resp.Response)
                            Master.ShowQuickly(isMovingUp ? lblUpMusicPositionConcluded : lblDownMusicPositionConcluded);
                    }
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }
        }

        private async void ChangePositionValue(object sender, EventArgs e)
        {
            try
            {
                var song = this.GetSelectedSong();
                int newNumSeq = (int)numChangeSongPos.Value;

                if (song is null)
                    return;

                if (song.NumSeq == newNumSeq)
                    return;

                if (newNumSeq > numChangeSongPos.Maximum)
                    throw new Exception("Posição não pode ser maior que a quantidade máxima de músicas na playlist!");

                if (newNumSeq == 0)
                    throw new Exception("O valor não pode ser 0!");

                var resp = await SwitchPosSongs(song, newNumSeq);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response)
                    Master.ShowQuickly(lblChangePosSuccess);
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async Task<ResponseHandler<bool>> SwitchPosSongs(SongItem song, int newNumSeq)
        {
            var response = new ResponseHandler<bool>();

            try
            {
                var otherSong = songs.FirstOrDefault(s => s.NumSeq == newNumSeq && s.IdPlaylist == song.IdPlaylist);
                string query1 = $"UPDATE songs_playlist SET numseq = {song.NumSeq} WHERE idsong = {otherSong.ID} AND idplaylist = {song.IdPlaylist}";
                string query2 = $"UPDATE songs_playlist SET numseq = {newNumSeq} WHERE idsong = {song.ID} AND idplaylist = {song.IdPlaylist}";

                var resp = await sql.ExecuteTransactionQuery(query1, query2);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    otherSong.NumSeq = song.NumSeq;
                    song.NumSeq = newNumSeq;

                    var _playlist = playlists.First(p => p.Title == currentPlaylist);
                    ResetLsbSongsItems(_playlist);

                    int index = lsbSongs.Items.IndexOf(song.ConcatNumSeq());
                    lsbSongs.SelectedIndex = index;
                    numChangeSongPos.Value = newNumSeq;

                    response.IsSuccess(true);
                }
                else
                    throw new Exception("Nenhum registro foi atualizado!");
            }
            catch (Exception ex)
            {
                response.IsNotSuccess(ex.Message);
            }

            return response;
        }

        private async void btnRenameSong_Click(object sender, EventArgs e)
        {
            try
            {
                string _newsongname = Utilix.SanitizeFileName(txtSongName.Text);
                var _oldsongname = (clbCatalogue?.SelectedItem?.ToString()) ?? throw new Exception("Música não selecionada no catálogo!");

                if (string.IsNullOrEmpty(_newsongname) || string.IsNullOrWhiteSpace(_newsongname))
                    throw new Exception("Selecione uma música para renomear!");

                var song = songs.Find(s => s.Title == _oldsongname);

                string sqlquery = $"UPDATE songs SET name_song = '{_newsongname}',path = replace(path,'{_oldsongname}','{_newsongname}') WHERE idsong = {song.ID}";

                var resp = await sql.ExecuteQuery(sqlquery);

                if (!resp.WasSuccessful)
                    throw new Exception(resp.ResponseErr);

                if (resp.Response > 0)
                {
                    bool fileRenamed = (PathHandler.MoveFile(song.Path, song.Path.Replace(_oldsongname, _newsongname))).WasSuccessful;

                    int lsbSongsindex = lsbSongs.Items.IndexOf(song.ConcatNumSeq(_oldsongname));
                    if (lsbSongsindex >= 0)
                    {
                        lsbSongs.Items.RemoveAt(lsbSongsindex);
                        lsbSongs.Items.Insert(lsbSongsindex, song.ConcatNumSeq(_newsongname));
                        lsbSongs.SelectedIndex = lsbSongsindex;
                    }

                    int clb_index = clbCatalogue.Items.IndexOf(_oldsongname);
                    if (clb_index >= 0)
                    {
                        clbCatalogue.Items.RemoveAt(clb_index);
                        clbCatalogue.Items.Insert(clb_index, _newsongname);

                        if (lsbSongsindex >= 0)
                            clbCatalogue.SetItemChecked(clb_index, true);

                        clbCatalogue.SelectedIndex = clb_index;
                    }

                    song.Title = _newsongname;

                    Master.ShowQuickly(lblRenameSongCompleted);

                    if (!fileRenamed)
                        Master.ShowInfoMessage("Arquivo não alterado!");
                }
                else
                    Master.ShowInfoMessage("Nenhum registro atualizado.");
            }
            catch (Exception ex)
            {
                Master.ShowErrorMessage(ex.Message);
            }
        }

        private async void btnDeleteSong_Click(object sender, EventArgs e)
        {
            string selectedSong = txtSongName.Text;

            if (Utilix.IsNullOrEmptyOrWhiteSpace(selectedSong))
                return;

            if (Master.ShowQuestionMessage("Deseja remover a música do catálogo e de todas as playlists?", "DELETAR") == DialogResult.Yes)
            {
                try
                {
                    var song = songs.Find(s => s.Title == selectedSong) ?? throw new Exception("Música não identificada!");
                    string query1 = $"DELETE FROM songs WHERE idsong = {song.ID}";
                    string query2 = $"CALL RecalculaNumSeq({song.IdPlaylist})";

                    List<string> queries = [query1, query2];

                    var resp = await sql.ExecuteTransactionQuerys(queries);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (resp.Response >= 0)
                    {
                        File.Delete(song.Path);

                        songs.Remove(song);

                        await UpdateSongsCatalogue();
                        cbbPlaylists_SelectedIndexChanged(this, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }
        }

        private void lsbSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Delete)
                btnDeleteSong_Click(sender, e);
        }

        #endregion

        #region Catalogue

        private void clbCatalogue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = clbCatalogue?.SelectedItem?.ToString();

            if (selectedItem is not null)
                txtSongName.Text = selectedItem;
        }

        private void clbCatalogue_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string song = clbCatalogue.Items[e.Index].ToString();

            if ((e.NewValue == CheckState.Checked || e.NewValue == CheckState.Indeterminate) && !checkedSongs.Contains(song))
                checkedSongs.Add(song);
            else if(e.NewValue == CheckState.Unchecked)
                checkedSongs.Remove(song);
        }

        private void txtFindInCatalogue_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtFindInCatalogue.Text.ToLower();

            var filteredSongs = string.IsNullOrWhiteSpace(searchText)
                ? songs
                : songs.Where(song => song.Title.Contains(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();

            var uniqueSongs = filteredSongs.GroupBy(song => song.Title).Select(g => g.First()).ToList();

            clbCatalogue.Items.Clear();

            uniqueSongs.ForEach(song =>
            {
                if (cbbPlaylists.SelectedIndex > 0)
                {
                    bool songChecked = checkedSongs.Any(checkedSong => checkedSong == song.Title);
                    clbCatalogue.Items.Add(song.Title, songChecked);
                }
                else
                {
                    clbCatalogue.Items.Add(song.Title, false);
                }
            });
        }
        

        private async void btnAttSongFromCatalogue_Click(object sender, EventArgs e)
        {
            if (cbbPlaylists.SelectedIndex > 0)
            {
                try
                {
                    var playlist = playlists.Find(p => p.Title == currentPlaylist);
                    List<string> songsInPlaylist = songs.Where(s => s.IdPlaylist == playlist.ID).Select(s => s.Title).ToList();
                    var newSongs = songs.Where(s => checkedSongs.Contains(s.Title) && !songsInPlaylist.Contains(s.Title)).ToList();

                    List<string> querys = [];

                    newSongs.ForEach(song =>
                    {
                        string query =
                            @$"INSERT INTO songs_playlist(idsong,idplaylist,numseq,active) 
                            SELECT {song.ID},{playlist.ID},ifnull(max(numseq)+1,1),1
                            FROM songs_playlist WHERE idplaylist = {playlist.ID}";
                        querys.Add(query);
                    });

                    var uncheckedSongs = songs.Where(s => !checkedSongs.Contains(s.Title) && s.IdPlaylist == playlist.ID).ToList();

                    if (uncheckedSongs.Count > 0)
                    {
                        uncheckedSongs.ForEach(song =>
                        {
                            string query = $"DELETE FROM songs_playlist WHERE idsong = {song.ID} AND idplaylist = {playlist.ID}";
                            querys.Add(query);
                        });

                        querys.Add($"CALL RecalculaNumSeq({playlist.ID})");
                    }

                    var resp = await sql.ExecuteTransactionQuerys(querys);

                    if (!resp.WasSuccessful)
                        throw new Exception(resp.ResponseErr);

                    if (resp.Response > 0)
                    {
                        await UpdateSongsCatalogue();
                        cbbPlaylists_SelectedIndexChanged(this, EventArgs.Empty);

                        Master.ShowQuickly(lblAttSongsCatalogueCompleted);
                    }
                    else
                        Master.ShowInfoMessage("Nenhum valor foi alterado!");
                }
                catch (Exception ex)
                {
                    Master.ShowErrorMessage(ex.Message);
                }
            }

            txtFindInCatalogue.Text = string.Empty;
        }

        #endregion        
    }
}
