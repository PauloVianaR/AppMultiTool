
using System;

namespace AppMultiTool.MainForms
{
    partial class PlaylistMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistMaker));
            lblTitle = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCreatePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            tsmiConfigs = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCommandLine = new System.Windows.Forms.ToolStripMenuItem();
            tsmiOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            tsmiOrderByDefault = new System.Windows.Forms.ToolStripMenuItem();
            tsmiOrderByAlphabetical = new System.Windows.Forms.ToolStripMenuItem();
            tsmiOrderByReverseAlphabetical = new System.Windows.Forms.ToolStripMenuItem();
            menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiClipBoardCopies = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSSConverter = new System.Windows.Forms.ToolStripMenuItem();
            tsmiDateCalculator = new System.Windows.Forms.ToolStripMenuItem();
            tsmiTextConverter = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            cbbListPlaylists = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtSongName = new System.Windows.Forms.TextBox();
            btnSongLyrics = new System.Windows.Forms.Button();
            clbListSongs = new System.Windows.Forms.CheckedListBox();
            btnEditPlaylist = new System.Windows.Forms.Button();
            trackBarSong = new System.Windows.Forms.TrackBar();
            btnPlayPause = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            lblLoading = new System.Windows.Forms.Label();
            timer = new System.Windows.Forms.Timer(components);
            lblDuration = new System.Windows.Forms.Label();
            lblRenameFineshed = new System.Windows.Forms.Label();
            trackBarVolume = new System.Windows.Forms.TrackBar();
            lblInfoVolume = new System.Windows.Forms.Label();
            lblPlayingInfo = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            rtxtLyrics = new System.Windows.Forms.RichTextBox();
            lblLetra = new System.Windows.Forms.Label();
            btnUpdateLyrics = new System.Windows.Forms.Button();
            lblLyricsUpdated = new System.Windows.Forms.Label();
            btnCanRepeat = new System.Windows.Forms.Button();
            btnRandomizePlaylist = new System.Windows.Forms.Button();
            txtSearchSong = new System.Windows.Forms.TextBox();
            pnlLyricsPanel = new System.Windows.Forms.Panel();
            btnSearchLyrics = new System.Windows.Forms.Button();
            pnlMainPanel = new System.Windows.Forms.Panel();
            pnlMiscControlPanel = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            pnlLyricsPanel.SuspendLayout();
            pnlMainPanel.SuspendLayout();
            pnlMiscControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(389, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(136, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Playlist Maker";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem, optionsToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1284, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiCreatePlaylist, tsmiConfigs, tsmiCommandLine, tsmiOrderBy });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            optionsToolStripMenuItem.Text = "Opções";
            // 
            // tsmiCreatePlaylist
            // 
            tsmiCreatePlaylist.Name = "tsmiCreatePlaylist";
            tsmiCreatePlaylist.Size = new System.Drawing.Size(175, 22);
            tsmiCreatePlaylist.Text = "Criar nova playlist";
            tsmiCreatePlaylist.Click += tsmiCreatePlaylist_Click;
            // 
            // tsmiConfigs
            // 
            tsmiConfigs.Name = "tsmiConfigs";
            tsmiConfigs.Size = new System.Drawing.Size(175, 22);
            tsmiConfigs.Text = "Configurações";
            tsmiConfigs.Click += tsmiConfigs_Click;
            // 
            // tsmiCommandLine
            // 
            tsmiCommandLine.Name = "tsmiCommandLine";
            tsmiCommandLine.Size = new System.Drawing.Size(175, 22);
            tsmiCommandLine.Text = "Linha de Comando";
            tsmiCommandLine.Click += tsmiCommandLine_Click;
            // 
            // tsmiOrderBy
            // 
            tsmiOrderBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiOrderByDefault, tsmiOrderByAlphabetical, tsmiOrderByReverseAlphabetical });
            tsmiOrderBy.Name = "tsmiOrderBy";
            tsmiOrderBy.Size = new System.Drawing.Size(175, 22);
            tsmiOrderBy.Text = "Ordernar por >";
            // 
            // tsmiOrderByDefault
            // 
            tsmiOrderByDefault.Name = "tsmiOrderByDefault";
            tsmiOrderByDefault.Size = new System.Drawing.Size(170, 22);
            tsmiOrderByDefault.Tag = "1";
            tsmiOrderByDefault.Text = "Padrão";
            tsmiOrderByDefault.Click += SortPlaylist;
            // 
            // tsmiOrderByAlphabetical
            // 
            tsmiOrderByAlphabetical.Name = "tsmiOrderByAlphabetical";
            tsmiOrderByAlphabetical.Size = new System.Drawing.Size(170, 22);
            tsmiOrderByAlphabetical.Tag = "2";
            tsmiOrderByAlphabetical.Text = "Alfabética";
            tsmiOrderByAlphabetical.Click += SortPlaylist;
            // 
            // tsmiOrderByReverseAlphabetical
            // 
            tsmiOrderByReverseAlphabetical.Name = "tsmiOrderByReverseAlphabetical";
            tsmiOrderByReverseAlphabetical.Size = new System.Drawing.Size(170, 22);
            tsmiOrderByReverseAlphabetical.Tag = "3";
            tsmiOrderByReverseAlphabetical.Text = "Alfabética Reversa";
            tsmiOrderByReverseAlphabetical.Click += SortPlaylist;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiClipBoardCopies, tsmiSSConverter, tsmiDateCalculator, tsmiTextConverter });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiClipBoardCopies
            // 
            tsmiClipBoardCopies.Name = "tsmiClipBoardCopies";
            tsmiClipBoardCopies.Size = new System.Drawing.Size(248, 22);
            tsmiClipBoardCopies.Text = "Cópias para área de transferência";
            tsmiClipBoardCopies.Click += OpenNewTabMenu;
            // 
            // tsmiSSConverter
            // 
            tsmiSSConverter.Name = "tsmiSSConverter";
            tsmiSSConverter.Size = new System.Drawing.Size(248, 22);
            tsmiSSConverter.Text = "Planilha Conversora";
            tsmiSSConverter.Click += OpenNewTabMenu;
            // 
            // tsmiDateCalculator
            // 
            tsmiDateCalculator.Name = "tsmiDateCalculator";
            tsmiDateCalculator.Size = new System.Drawing.Size(248, 22);
            tsmiDateCalculator.Text = "Calculador de Datas";
            tsmiDateCalculator.Click += OpenNewTabMenu;
            // 
            // tsmiTextConverter
            // 
            tsmiTextConverter.Name = "tsmiTextConverter";
            tsmiTextConverter.Size = new System.Drawing.Size(248, 22);
            tsmiTextConverter.Text = "Conversor de Texto";
            tsmiTextConverter.Click += OpenNewTabMenu;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(8, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Playlists:";
            // 
            // cbbListPlaylists
            // 
            cbbListPlaylists.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbbListPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbListPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cbbListPlaylists.FormattingEnabled = true;
            cbbListPlaylists.Items.AddRange(new object[] { "Selecione" });
            cbbListPlaylists.Location = new System.Drawing.Point(83, 38);
            cbbListPlaylists.Name = "cbbListPlaylists";
            cbbListPlaylists.Size = new System.Drawing.Size(729, 25);
            cbbListPlaylists.TabIndex = 3;
            cbbListPlaylists.SelectedIndexChanged += cbbListPlaylists_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(8, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 21);
            label3.TabIndex = 4;
            label3.Text = "Música:";
            // 
            // txtSongName
            // 
            txtSongName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSongName.Location = new System.Drawing.Point(83, 76);
            txtSongName.Name = "txtSongName";
            txtSongName.ReadOnly = true;
            txtSongName.Size = new System.Drawing.Size(729, 23);
            txtSongName.TabIndex = 5;
            txtSongName.TextChanged += txtSongName_TextChanged;
            // 
            // btnSongLyrics
            // 
            btnSongLyrics.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSongLyrics.BackColor = System.Drawing.Color.White;
            btnSongLyrics.Enabled = false;
            btnSongLyrics.Location = new System.Drawing.Point(818, 76);
            btnSongLyrics.Name = "btnSongLyrics";
            btnSongLyrics.Size = new System.Drawing.Size(70, 23);
            btnSongLyrics.TabIndex = 6;
            btnSongLyrics.Text = "Letra";
            btnSongLyrics.UseVisualStyleBackColor = false;
            btnSongLyrics.Click += btnSongLyrics_Click;
            // 
            // clbListSongs
            // 
            clbListSongs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            clbListSongs.Font = new System.Drawing.Font("Segoe UI", 16F);
            clbListSongs.FormattingEnabled = true;
            clbListSongs.Location = new System.Drawing.Point(8, 145);
            clbListSongs.Name = "clbListSongs";
            clbListSongs.Size = new System.Drawing.Size(880, 345);
            clbListSongs.TabIndex = 7;
            clbListSongs.SelectedIndexChanged += clbListSongs_SelectedIndexChanged;
            // 
            // btnEditPlaylist
            // 
            btnEditPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditPlaylist.BackColor = System.Drawing.Color.White;
            btnEditPlaylist.Enabled = false;
            btnEditPlaylist.Location = new System.Drawing.Point(818, 38);
            btnEditPlaylist.Name = "btnEditPlaylist";
            btnEditPlaylist.Size = new System.Drawing.Size(70, 23);
            btnEditPlaylist.TabIndex = 8;
            btnEditPlaylist.Text = "Editar";
            btnEditPlaylist.UseVisualStyleBackColor = false;
            btnEditPlaylist.Click += btnEditPlaylist_Click;
            // 
            // trackBarSong
            // 
            trackBarSong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            trackBarSong.BackColor = System.Drawing.SystemColors.Control;
            trackBarSong.Location = new System.Drawing.Point(10, 3);
            trackBarSong.Maximum = 100;
            trackBarSong.Name = "trackBarSong";
            trackBarSong.Size = new System.Drawing.Size(880, 45);
            trackBarSong.TabIndex = 9;
            trackBarSong.Scroll += trackBarSong_Scroll;
            // 
            // btnPlayPause
            // 
            btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnPlayPause.BackColor = System.Drawing.SystemColors.Highlight;
            btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlayPause.Enabled = false;
            btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 13F);
            btnPlayPause.Location = new System.Drawing.Point(429, 54);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.Size = new System.Drawing.Size(57, 39);
            btnPlayPause.TabIndex = 10;
            btnPlayPause.Text = "▶";
            btnPlayPause.UseVisualStyleBackColor = false;
            btnPlayPause.Click += btnPlayPause_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnPrevious.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPrevious.Enabled = false;
            btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevious.Location = new System.Drawing.Point(366, 54);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(57, 39);
            btnPrevious.TabIndex = 11;
            btnPrevious.Text = "l◀◀◀";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Location = new System.Drawing.Point(492, 54);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(57, 39);
            btnNext.TabIndex = 12;
            btnNext.Text = "▶▶▶l";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblLoading
            // 
            lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblLoading.AutoSize = true;
            lblLoading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Location = new System.Drawing.Point(817, 11);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(69, 15);
            lblLoading.TabIndex = 13;
            lblLoading.Text = "(aguarde...)";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblDuration
            // 
            lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblDuration.AutoSize = true;
            lblDuration.Location = new System.Drawing.Point(817, 33);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(72, 15);
            lblDuration.TabIndex = 14;
            lblDuration.Text = "00:00 / 00:00";
            // 
            // lblRenameFineshed
            // 
            lblRenameFineshed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblRenameFineshed.AutoSize = true;
            lblRenameFineshed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRenameFineshed.ForeColor = System.Drawing.Color.DarkGreen;
            lblRenameFineshed.Location = new System.Drawing.Point(827, 102);
            lblRenameFineshed.Name = "lblRenameFineshed";
            lblRenameFineshed.Size = new System.Drawing.Size(61, 15);
            lblRenameFineshed.TabIndex = 15;
            lblRenameFineshed.Text = "Concluído";
            lblRenameFineshed.Visible = false;
            // 
            // trackBarVolume
            // 
            trackBarVolume.BackColor = System.Drawing.SystemColors.Control;
            trackBarVolume.Location = new System.Drawing.Point(10, 48);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new System.Drawing.Size(173, 45);
            trackBarVolume.TabIndex = 16;
            trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            trackBarVolume.Value = 100;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // lblInfoVolume
            // 
            lblInfoVolume.AutoSize = true;
            lblInfoVolume.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblInfoVolume.Location = new System.Drawing.Point(180, 62);
            lblInfoVolume.Name = "lblInfoVolume";
            lblInfoVolume.Size = new System.Drawing.Size(33, 20);
            lblInfoVolume.TabIndex = 17;
            lblInfoVolume.Text = "100";
            // 
            // lblPlayingInfo
            // 
            lblPlayingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPlayingInfo.AutoSize = true;
            lblPlayingInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPlayingInfo.Location = new System.Drawing.Point(83, 493);
            lblPlayingInfo.Name = "lblPlayingInfo";
            lblPlayingInfo.Size = new System.Drawing.Size(52, 20);
            lblPlayingInfo.TabIndex = 18;
            lblPlayingInfo.Text = "[nada]";
            lblPlayingInfo.TextChanged += lblPlayingInfo_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(8, 493);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 20);
            label4.TabIndex = 19;
            label4.Text = "Tocando: ";
            // 
            // rtxtLyrics
            // 
            rtxtLyrics.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            rtxtLyrics.Font = new System.Drawing.Font("Segoe UI", 11F);
            rtxtLyrics.Location = new System.Drawing.Point(3, 32);
            rtxtLyrics.Name = "rtxtLyrics";
            rtxtLyrics.Size = new System.Drawing.Size(364, 582);
            rtxtLyrics.TabIndex = 20;
            rtxtLyrics.Text = "";
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblLetra.Location = new System.Drawing.Point(3, 4);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new System.Drawing.Size(57, 25);
            lblLetra.TabIndex = 21;
            lblLetra.Text = "Letra";
            // 
            // btnUpdateLyrics
            // 
            btnUpdateLyrics.BackColor = System.Drawing.Color.White;
            btnUpdateLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdateLyrics.Location = new System.Drawing.Point(265, 6);
            btnUpdateLyrics.Name = "btnUpdateLyrics";
            btnUpdateLyrics.Size = new System.Drawing.Size(102, 23);
            btnUpdateLyrics.TabIndex = 22;
            btnUpdateLyrics.Text = "Atualizar Letra";
            btnUpdateLyrics.UseVisualStyleBackColor = false;
            btnUpdateLyrics.Click += btnUpdateLyrics_Click;
            // 
            // lblLyricsUpdated
            // 
            lblLyricsUpdated.AutoSize = true;
            lblLyricsUpdated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLyricsUpdated.ForeColor = System.Drawing.Color.DarkGreen;
            lblLyricsUpdated.Location = new System.Drawing.Point(197, 12);
            lblLyricsUpdated.Name = "lblLyricsUpdated";
            lblLyricsUpdated.Size = new System.Drawing.Size(61, 15);
            lblLyricsUpdated.TabIndex = 23;
            lblLyricsUpdated.Text = "Concluído";
            lblLyricsUpdated.Visible = false;
            // 
            // btnCanRepeat
            // 
            btnCanRepeat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCanRepeat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCanRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCanRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCanRepeat.Font = new System.Drawing.Font("Segoe UI", 18F);
            btnCanRepeat.ForeColor = System.Drawing.Color.Black;
            btnCanRepeat.Location = new System.Drawing.Point(702, 55);
            btnCanRepeat.Margin = new System.Windows.Forms.Padding(0);
            btnCanRepeat.Name = "btnCanRepeat";
            btnCanRepeat.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnCanRepeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnCanRepeat.Size = new System.Drawing.Size(42, 42);
            btnCanRepeat.TabIndex = 24;
            btnCanRepeat.Text = "🔄";
            btnCanRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCanRepeat.UseVisualStyleBackColor = false;
            btnCanRepeat.Click += Repeat_Randomize_BtnEvent;
            // 
            // btnRandomizePlaylist
            // 
            btnRandomizePlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRandomizePlaylist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnRandomizePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRandomizePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRandomizePlaylist.Font = new System.Drawing.Font("Segoe UI", 18F);
            btnRandomizePlaylist.ForeColor = System.Drawing.Color.Black;
            btnRandomizePlaylist.Location = new System.Drawing.Point(757, 55);
            btnRandomizePlaylist.Margin = new System.Windows.Forms.Padding(0);
            btnRandomizePlaylist.Name = "btnRandomizePlaylist";
            btnRandomizePlaylist.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnRandomizePlaylist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnRandomizePlaylist.Size = new System.Drawing.Size(42, 42);
            btnRandomizePlaylist.TabIndex = 25;
            btnRandomizePlaylist.Text = "🔀";
            btnRandomizePlaylist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnRandomizePlaylist.UseVisualStyleBackColor = false;
            btnRandomizePlaylist.Click += Repeat_Randomize_BtnEvent;
            // 
            // txtSearchSong
            // 
            txtSearchSong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearchSong.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearchSong.Location = new System.Drawing.Point(8, 115);
            txtSearchSong.Name = "txtSearchSong";
            txtSearchSong.PlaceholderText = "Buscar música na playlist... 🔍";
            txtSearchSong.Size = new System.Drawing.Size(880, 25);
            txtSearchSong.TabIndex = 26;
            txtSearchSong.TextChanged += txtSearchSong_TextChanged;
            // 
            // pnlLyricsPanel
            // 
            pnlLyricsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlLyricsPanel.BackColor = System.Drawing.Color.Transparent;
            pnlLyricsPanel.Controls.Add(btnSearchLyrics);
            pnlLyricsPanel.Controls.Add(lblLetra);
            pnlLyricsPanel.Controls.Add(rtxtLyrics);
            pnlLyricsPanel.Controls.Add(btnUpdateLyrics);
            pnlLyricsPanel.Controls.Add(lblLyricsUpdated);
            pnlLyricsPanel.Location = new System.Drawing.Point(908, 27);
            pnlLyricsPanel.MinimumSize = new System.Drawing.Size(375, 623);
            pnlLyricsPanel.Name = "pnlLyricsPanel";
            pnlLyricsPanel.Size = new System.Drawing.Size(376, 623);
            pnlLyricsPanel.TabIndex = 27;
            pnlLyricsPanel.Move += pnlLyricsPanel_Move;
            // 
            // btnSearchLyrics
            // 
            btnSearchLyrics.BackColor = System.Drawing.Color.White;
            btnSearchLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearchLyrics.Location = new System.Drawing.Point(61, 6);
            btnSearchLyrics.Name = "btnSearchLyrics";
            btnSearchLyrics.Size = new System.Drawing.Size(102, 23);
            btnSearchLyrics.TabIndex = 24;
            btnSearchLyrics.Text = "Buscar Letra🔎";
            btnSearchLyrics.UseVisualStyleBackColor = false;
            btnSearchLyrics.Click += btnSearchLyrics_Click;
            // 
            // pnlMainPanel
            // 
            pnlMainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlMainPanel.BackColor = System.Drawing.Color.Transparent;
            pnlMainPanel.Controls.Add(lblTitle);
            pnlMainPanel.Controls.Add(label2);
            pnlMainPanel.Controls.Add(txtSearchSong);
            pnlMainPanel.Controls.Add(cbbListPlaylists);
            pnlMainPanel.Controls.Add(label4);
            pnlMainPanel.Controls.Add(lblPlayingInfo);
            pnlMainPanel.Controls.Add(label3);
            pnlMainPanel.Controls.Add(txtSongName);
            pnlMainPanel.Controls.Add(btnSongLyrics);
            pnlMainPanel.Controls.Add(btnEditPlaylist);
            pnlMainPanel.Controls.Add(lblLoading);
            pnlMainPanel.Controls.Add(lblRenameFineshed);
            pnlMainPanel.Controls.Add(clbListSongs);
            pnlMainPanel.Location = new System.Drawing.Point(5, 27);
            pnlMainPanel.MinimumSize = new System.Drawing.Size(893, 515);
            pnlMainPanel.Name = "pnlMainPanel";
            pnlMainPanel.Size = new System.Drawing.Size(893, 515);
            pnlMainPanel.TabIndex = 24;
            // 
            // pnlMiscControlPanel
            // 
            pnlMiscControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlMiscControlPanel.Controls.Add(lblDuration);
            pnlMiscControlPanel.Controls.Add(trackBarSong);
            pnlMiscControlPanel.Controls.Add(btnRandomizePlaylist);
            pnlMiscControlPanel.Controls.Add(btnPlayPause);
            pnlMiscControlPanel.Controls.Add(btnCanRepeat);
            pnlMiscControlPanel.Controls.Add(btnPrevious);
            pnlMiscControlPanel.Controls.Add(lblInfoVolume);
            pnlMiscControlPanel.Controls.Add(btnNext);
            pnlMiscControlPanel.Controls.Add(trackBarVolume);
            pnlMiscControlPanel.Location = new System.Drawing.Point(5, 548);
            pnlMiscControlPanel.MinimumSize = new System.Drawing.Size(893, 100);
            pnlMiscControlPanel.Name = "pnlMiscControlPanel";
            pnlMiscControlPanel.Size = new System.Drawing.Size(893, 100);
            pnlMiscControlPanel.TabIndex = 27;
            // 
            // PlaylistMaker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1284, 659);
            Controls.Add(pnlMiscControlPanel);
            Controls.Add(pnlMainPanel);
            Controls.Add(pnlLyricsPanel);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new System.Drawing.Size(1920, 1080);
            MinimumSize = new System.Drawing.Size(924, 698);
            Name = "PlaylistMaker";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += PlaylistMaker_FormClosed;
            Shown += PlaylistMaker_Shown;
            Resize += PlaylistMaker_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSong).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            pnlLyricsPanel.ResumeLayout(false);
            pnlLyricsPanel.PerformLayout();
            pnlMainPanel.ResumeLayout(false);
            pnlMainPanel.PerformLayout();
            pnlMiscControlPanel.ResumeLayout(false);
            pnlMiscControlPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbListPlaylists;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Button btnSongLyrics;
        private System.Windows.Forms.CheckedListBox clbListSongs;
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.TrackBar trackBarSong;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblRenameFineshed;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblInfoVolume;
        private System.Windows.Forms.Label lblPlayingInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtLyrics;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Button btnUpdateLyrics;
        private System.Windows.Forms.Label lblLyricsUpdated;
        private System.Windows.Forms.Button btnCanRepeat;
        private System.Windows.Forms.Button btnRandomizePlaylist;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClipBoardCopies;
        private System.Windows.Forms.ToolStripMenuItem tsmiSSConverter;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateCalculator;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextConverter;
        private System.Windows.Forms.TextBox txtSearchSong;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatePlaylist;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigs;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderBy;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderByDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderByAlphabetical;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrderByReverseAlphabetical;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommandLine;
        private System.Windows.Forms.Panel pnlLyricsPanel;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Panel pnlMiscControlPanel;
        private System.Windows.Forms.Button btnSearchLyrics;
    }
}