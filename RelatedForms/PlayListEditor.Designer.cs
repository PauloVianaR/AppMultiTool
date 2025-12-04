
namespace AppMultiTool.RelatedForms
{
    partial class PlayListEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListEditor));
            lblTitle = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            btnRenamePlaylist = new System.Windows.Forms.Button();
            btnChangePlColor = new System.Windows.Forms.Button();
            lblLoading = new System.Windows.Forms.Label();
            lsbSongs = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            txtURL = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDeletePlaylist = new System.Windows.Forms.Button();
            btnDownloadSong = new System.Windows.Forms.Button();
            btnAddSongFromPC = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtSongPath = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnPickSong = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            lblWaitPath = new System.Windows.Forms.Label();
            lblPCSongAdded = new System.Windows.Forms.Label();
            lblDownloadEnded = new System.Windows.Forms.Label();
            pgbDownloadProgress = new System.Windows.Forms.ProgressBar();
            lblPercentDownload = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnChangePos = new System.Windows.Forms.Button();
            lblChangePosSuccess = new System.Windows.Forms.Label();
            numChangeSongPos = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            lblDownMusicPositionConcluded = new System.Windows.Forms.Label();
            lblUpMusicPositionConcluded = new System.Windows.Forms.Label();
            lblRenameSongCompleted = new System.Windows.Forms.Label();
            btnRenameSong = new System.Windows.Forms.Button();
            btnDownNumSeqSong = new System.Windows.Forms.Button();
            btnUpNumSeqSong = new System.Windows.Forms.Button();
            btnDeleteSong = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            txtSongName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            cbbPlaylists = new System.Windows.Forms.ComboBox();
            lblPlayListName = new System.Windows.Forms.Label();
            lblRenameFineshed = new System.Windows.Forms.Label();
            colorPicker = new System.Windows.Forms.ColorDialog();
            lblChangeColorFineshed = new System.Windows.Forms.Label();
            clbCatalogue = new System.Windows.Forms.CheckedListBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            btnAttSongFromCatalogue = new System.Windows.Forms.Button();
            txtFindInCatalogue = new System.Windows.Forms.TextBox();
            lblAttSongsCatalogueCompleted = new System.Windows.Forms.Label();
            btnSortPlaylist = new System.Windows.Forms.Button();
            lblSortCompleted = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChangeSongPos).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(346, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(138, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PlayList Editor";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1660, 24);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(17, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 21);
            label2.TabIndex = 2;
            label2.Text = "Playlist:";
            // 
            // btnRenamePlaylist
            // 
            btnRenamePlaylist.BackColor = System.Drawing.Color.DarkCyan;
            btnRenamePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRenamePlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnRenamePlaylist.ForeColor = System.Drawing.Color.White;
            btnRenamePlaylist.Location = new System.Drawing.Point(18, 126);
            btnRenamePlaylist.Name = "btnRenamePlaylist";
            btnRenamePlaylist.Size = new System.Drawing.Size(75, 23);
            btnRenamePlaylist.TabIndex = 4;
            btnRenamePlaylist.Text = "Renomear";
            btnRenamePlaylist.UseVisualStyleBackColor = false;
            btnRenamePlaylist.Click += btnRenamePlaylist_Click;
            // 
            // btnChangePlColor
            // 
            btnChangePlColor.BackColor = System.Drawing.Color.DarkOrange;
            btnChangePlColor.Enabled = false;
            btnChangePlColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangePlColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnChangePlColor.ForeColor = System.Drawing.Color.White;
            btnChangePlColor.Location = new System.Drawing.Point(99, 126);
            btnChangePlColor.Name = "btnChangePlColor";
            btnChangePlColor.Size = new System.Drawing.Size(75, 23);
            btnChangePlColor.TabIndex = 5;
            btnChangePlColor.Text = "Alterar Cor";
            btnChangePlColor.UseVisualStyleBackColor = false;
            btnChangePlColor.Click += btnChangePlaylistColor_Click;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Location = new System.Drawing.Point(373, 71);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(85, 21);
            lblLoading.TabIndex = 6;
            lblLoading.Text = "aguarde...";
            // 
            // lsbSongs
            // 
            lsbSongs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lsbSongs.Font = new System.Drawing.Font("Segoe UI", 12F);
            lsbSongs.FormattingEnabled = true;
            lsbSongs.ItemHeight = 21;
            lsbSongs.Location = new System.Drawing.Point(806, 49);
            lsbSongs.Name = "lsbSongs";
            lsbSongs.Size = new System.Drawing.Size(378, 613);
            lsbSongs.TabIndex = 7;
            lsbSongs.SelectedIndexChanged += lsbSongs_SelectedIndexChanged;
            lsbSongs.KeyDown += lsbSongs_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(200, 21);
            label3.TabIndex = 8;
            label3.Text = "Adicionar música (youtube)";
            // 
            // txtURL
            // 
            txtURL.Location = new System.Drawing.Point(60, 43);
            txtURL.Name = "txtURL";
            txtURL.Size = new System.Drawing.Size(546, 23);
            txtURL.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(12, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 21);
            label4.TabIndex = 10;
            label4.Text = "URL:";
            // 
            // btnDeletePlaylist
            // 
            btnDeletePlaylist.BackColor = System.Drawing.Color.Red;
            btnDeletePlaylist.Enabled = false;
            btnDeletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletePlaylist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeletePlaylist.ForeColor = System.Drawing.Color.White;
            btnDeletePlaylist.Location = new System.Drawing.Point(685, 124);
            btnDeletePlaylist.Name = "btnDeletePlaylist";
            btnDeletePlaylist.Size = new System.Drawing.Size(105, 31);
            btnDeletePlaylist.TabIndex = 11;
            btnDeletePlaylist.Text = "APAGAR ✖";
            btnDeletePlaylist.UseVisualStyleBackColor = false;
            btnDeletePlaylist.Click += btnDeletePlaylist_Click;
            // 
            // btnDownloadSong
            // 
            btnDownloadSong.BackColor = System.Drawing.Color.OliveDrab;
            btnDownloadSong.Enabled = false;
            btnDownloadSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDownloadSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDownloadSong.ForeColor = System.Drawing.Color.White;
            btnDownloadSong.Location = new System.Drawing.Point(612, 37);
            btnDownloadSong.Name = "btnDownloadSong";
            btnDownloadSong.Size = new System.Drawing.Size(145, 31);
            btnDownloadSong.TabIndex = 12;
            btnDownloadSong.Text = "Baixar e adicionar";
            btnDownloadSong.UseVisualStyleBackColor = false;
            btnDownloadSong.Click += btnDownloadSong_Click;
            // 
            // btnAddSongFromPC
            // 
            btnAddSongFromPC.BackColor = System.Drawing.Color.OliveDrab;
            btnAddSongFromPC.Enabled = false;
            btnAddSongFromPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddSongFromPC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddSongFromPC.ForeColor = System.Drawing.Color.White;
            btnAddSongFromPC.Location = new System.Drawing.Point(663, 151);
            btnAddSongFromPC.Name = "btnAddSongFromPC";
            btnAddSongFromPC.Size = new System.Drawing.Size(94, 31);
            btnAddSongFromPC.TabIndex = 16;
            btnAddSongFromPC.Text = "Adicionar";
            btnAddSongFromPC.UseVisualStyleBackColor = false;
            btnAddSongFromPC.Click += btnAddSongFromPC_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(12, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 21);
            label5.TabIndex = 15;
            label5.Text = "Caminho:";
            // 
            // txtSongPath
            // 
            txtSongPath.Location = new System.Drawing.Point(93, 157);
            txtSongPath.Name = "txtSongPath";
            txtSongPath.Size = new System.Drawing.Size(564, 23);
            txtSongPath.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(12, 123);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(250, 21);
            label6.TabIndex = 13;
            label6.Text = "Adicionar música (do computador)";
            // 
            // btnPickSong
            // 
            btnPickSong.Enabled = false;
            btnPickSong.Location = new System.Drawing.Point(12, 191);
            btnPickSong.Name = "btnPickSong";
            btnPickSong.Size = new System.Drawing.Size(115, 26);
            btnPickSong.TabIndex = 17;
            btnPickSong.Text = "Escolher arquivo";
            btnPickSong.UseVisualStyleBackColor = true;
            btnPickSong.Click += btnPickSong_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblWaitPath);
            panel1.Controls.Add(lblPCSongAdded);
            panel1.Controls.Add(lblDownloadEnded);
            panel1.Controls.Add(pgbDownloadProgress);
            panel1.Controls.Add(btnPickSong);
            panel1.Controls.Add(btnAddSongFromPC);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSongPath);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtURL);
            panel1.Controls.Add(btnDownloadSong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblPercentDownload);
            panel1.Location = new System.Drawing.Point(17, 194);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(773, 238);
            panel1.TabIndex = 18;
            // 
            // lblWaitPath
            // 
            lblWaitPath.AutoSize = true;
            lblWaitPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblWaitPath.ForeColor = System.Drawing.Color.Red;
            lblWaitPath.Location = new System.Drawing.Point(133, 191);
            lblWaitPath.Name = "lblWaitPath";
            lblWaitPath.Size = new System.Drawing.Size(85, 21);
            lblWaitPath.TabIndex = 25;
            lblWaitPath.Text = "aguarde...";
            lblWaitPath.Visible = false;
            // 
            // lblPCSongAdded
            // 
            lblPCSongAdded.AutoSize = true;
            lblPCSongAdded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPCSongAdded.ForeColor = System.Drawing.Color.ForestGreen;
            lblPCSongAdded.Location = new System.Drawing.Point(696, 191);
            lblPCSongAdded.Name = "lblPCSongAdded";
            lblPCSongAdded.Size = new System.Drawing.Size(61, 15);
            lblPCSongAdded.TabIndex = 20;
            lblPCSongAdded.Text = "Concluído";
            lblPCSongAdded.Visible = false;
            // 
            // lblDownloadEnded
            // 
            lblDownloadEnded.AutoSize = true;
            lblDownloadEnded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDownloadEnded.ForeColor = System.Drawing.Color.ForestGreen;
            lblDownloadEnded.Location = new System.Drawing.Point(696, 94);
            lblDownloadEnded.Name = "lblDownloadEnded";
            lblDownloadEnded.Size = new System.Drawing.Size(61, 15);
            lblDownloadEnded.TabIndex = 19;
            lblDownloadEnded.Text = "Concluído";
            lblDownloadEnded.Visible = false;
            // 
            // pgbDownloadProgress
            // 
            pgbDownloadProgress.Location = new System.Drawing.Point(14, 77);
            pgbDownloadProgress.Name = "pgbDownloadProgress";
            pgbDownloadProgress.Size = new System.Drawing.Size(743, 14);
            pgbDownloadProgress.TabIndex = 18;
            // 
            // lblPercentDownload
            // 
            lblPercentDownload.AutoSize = true;
            lblPercentDownload.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPercentDownload.Location = new System.Drawing.Point(372, 90);
            lblPercentDownload.Name = "lblPercentDownload";
            lblPercentDownload.Size = new System.Drawing.Size(47, 19);
            lblPercentDownload.TabIndex = 10;
            lblPercentDownload.Text = "0.00%";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnChangePos);
            panel2.Controls.Add(lblChangePosSuccess);
            panel2.Controls.Add(numChangeSongPos);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblDownMusicPositionConcluded);
            panel2.Controls.Add(lblUpMusicPositionConcluded);
            panel2.Controls.Add(lblRenameSongCompleted);
            panel2.Controls.Add(btnRenameSong);
            panel2.Controls.Add(btnDownNumSeqSong);
            panel2.Controls.Add(btnUpNumSeqSong);
            panel2.Controls.Add(btnDeleteSong);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtSongName);
            panel2.Location = new System.Drawing.Point(12, 477);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(778, 201);
            panel2.TabIndex = 19;
            // 
            // btnChangePos
            // 
            btnChangePos.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChangePos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangePos.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnChangePos.ForeColor = System.Drawing.Color.ForestGreen;
            btnChangePos.Location = new System.Drawing.Point(192, 76);
            btnChangePos.Name = "btnChangePos";
            btnChangePos.Size = new System.Drawing.Size(31, 30);
            btnChangePos.TabIndex = 33;
            btnChangePos.Text = "✔";
            btnChangePos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnChangePos.UseVisualStyleBackColor = true;
            btnChangePos.Click += ChangePositionValue;
            // 
            // lblChangePosSuccess
            // 
            lblChangePosSuccess.AutoSize = true;
            lblChangePosSuccess.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblChangePosSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            lblChangePosSuccess.Location = new System.Drawing.Point(229, 79);
            lblChangePosSuccess.Name = "lblChangePosSuccess";
            lblChangePosSuccess.Size = new System.Drawing.Size(38, 25);
            lblChangePosSuccess.TabIndex = 32;
            lblChangePosSuccess.Text = "✔";
            lblChangePosSuccess.Visible = false;
            // 
            // numChangeSongPos
            // 
            numChangeSongPos.Font = new System.Drawing.Font("Segoe UI", 12F);
            numChangeSongPos.Location = new System.Drawing.Point(136, 76);
            numChangeSongPos.Name = "numChangeSongPos";
            numChangeSongPos.Size = new System.Drawing.Size(43, 29);
            numChangeSongPos.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            label9.Location = new System.Drawing.Point(17, 79);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(117, 21);
            label9.TabIndex = 30;
            label9.Text = "Alterar posição:";
            // 
            // lblDownMusicPositionConcluded
            // 
            lblDownMusicPositionConcluded.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDownMusicPositionConcluded.AutoSize = true;
            lblDownMusicPositionConcluded.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblDownMusicPositionConcluded.ForeColor = System.Drawing.Color.ForestGreen;
            lblDownMusicPositionConcluded.Location = new System.Drawing.Point(185, 163);
            lblDownMusicPositionConcluded.Name = "lblDownMusicPositionConcluded";
            lblDownMusicPositionConcluded.Size = new System.Drawing.Size(38, 25);
            lblDownMusicPositionConcluded.TabIndex = 29;
            lblDownMusicPositionConcluded.Text = "✔";
            lblDownMusicPositionConcluded.Visible = false;
            // 
            // lblUpMusicPositionConcluded
            // 
            lblUpMusicPositionConcluded.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUpMusicPositionConcluded.AutoSize = true;
            lblUpMusicPositionConcluded.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblUpMusicPositionConcluded.ForeColor = System.Drawing.Color.ForestGreen;
            lblUpMusicPositionConcluded.Location = new System.Drawing.Point(185, 126);
            lblUpMusicPositionConcluded.Name = "lblUpMusicPositionConcluded";
            lblUpMusicPositionConcluded.Size = new System.Drawing.Size(38, 25);
            lblUpMusicPositionConcluded.TabIndex = 28;
            lblUpMusicPositionConcluded.Text = "✔";
            lblUpMusicPositionConcluded.Visible = false;
            // 
            // lblRenameSongCompleted
            // 
            lblRenameSongCompleted.AutoSize = true;
            lblRenameSongCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRenameSongCompleted.ForeColor = System.Drawing.Color.ForestGreen;
            lblRenameSongCompleted.Location = new System.Drawing.Point(701, 1);
            lblRenameSongCompleted.Name = "lblRenameSongCompleted";
            lblRenameSongCompleted.Size = new System.Drawing.Size(61, 15);
            lblRenameSongCompleted.TabIndex = 21;
            lblRenameSongCompleted.Text = "Concluído";
            lblRenameSongCompleted.Visible = false;
            // 
            // btnRenameSong
            // 
            btnRenameSong.BackColor = System.Drawing.Color.OliveDrab;
            btnRenameSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRenameSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRenameSong.ForeColor = System.Drawing.Color.White;
            btnRenameSong.Location = new System.Drawing.Point(668, 19);
            btnRenameSong.Name = "btnRenameSong";
            btnRenameSong.Size = new System.Drawing.Size(94, 31);
            btnRenameSong.TabIndex = 26;
            btnRenameSong.Text = "Renomear";
            btnRenameSong.UseVisualStyleBackColor = false;
            btnRenameSong.Click += btnRenameSong_Click;
            // 
            // btnDownNumSeqSong
            // 
            btnDownNumSeqSong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnDownNumSeqSong.BackColor = System.Drawing.Color.DarkCyan;
            btnDownNumSeqSong.Enabled = false;
            btnDownNumSeqSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDownNumSeqSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDownNumSeqSong.ForeColor = System.Drawing.Color.White;
            btnDownNumSeqSong.Location = new System.Drawing.Point(19, 160);
            btnDownNumSeqSong.Name = "btnDownNumSeqSong";
            btnDownNumSeqSong.Size = new System.Drawing.Size(160, 31);
            btnDownNumSeqSong.TabIndex = 25;
            btnDownNumSeqSong.Text = "Descer Posição 🔽";
            btnDownNumSeqSong.UseVisualStyleBackColor = false;
            btnDownNumSeqSong.Click += btnDownNumSeqSong_Click;
            // 
            // btnUpNumSeqSong
            // 
            btnUpNumSeqSong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnUpNumSeqSong.BackColor = System.Drawing.Color.DarkCyan;
            btnUpNumSeqSong.Enabled = false;
            btnUpNumSeqSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpNumSeqSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpNumSeqSong.ForeColor = System.Drawing.Color.White;
            btnUpNumSeqSong.Location = new System.Drawing.Point(18, 123);
            btnUpNumSeqSong.Name = "btnUpNumSeqSong";
            btnUpNumSeqSong.Size = new System.Drawing.Size(161, 31);
            btnUpNumSeqSong.TabIndex = 24;
            btnUpNumSeqSong.Text = "Subir Posição 🔼";
            btnUpNumSeqSong.UseVisualStyleBackColor = false;
            btnUpNumSeqSong.Click += btnUpNumSeqSong_Click;
            // 
            // btnDeleteSong
            // 
            btnDeleteSong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteSong.BackColor = System.Drawing.Color.Red;
            btnDeleteSong.Enabled = false;
            btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteSong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteSong.ForeColor = System.Drawing.Color.White;
            btnDeleteSong.Location = new System.Drawing.Point(647, 150);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new System.Drawing.Size(115, 41);
            btnDeleteSong.TabIndex = 21;
            btnDeleteSong.Text = "APAGAR ✖";
            btnDeleteSong.UseVisualStyleBackColor = false;
            btnDeleteSong.Click += btnDeleteSong_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            label8.Location = new System.Drawing.Point(18, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(62, 21);
            label8.TabIndex = 21;
            label8.Text = "Música:";
            // 
            // txtSongName
            // 
            txtSongName.Location = new System.Drawing.Point(80, 25);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new System.Drawing.Size(582, 23);
            txtSongName.TabIndex = 21;
            txtSongName.TextChanged += txtSongName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(337, 453);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(159, 21);
            label7.TabIndex = 20;
            label7.Text = "Música selecionada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label10.Location = new System.Drawing.Point(346, 170);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(126, 21);
            label10.TabIndex = 21;
            label10.Text = "Adicionar nova";
            // 
            // cbbPlaylists
            // 
            cbbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbPlaylists.Enabled = false;
            cbbPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cbbPlaylists.FormattingEnabled = true;
            cbbPlaylists.Items.AddRange(new object[] { "Selecione" });
            cbbPlaylists.Location = new System.Drawing.Point(85, 95);
            cbbPlaylists.Name = "cbbPlaylists";
            cbbPlaylists.Size = new System.Drawing.Size(705, 25);
            cbbPlaylists.TabIndex = 22;
            cbbPlaylists.SelectedIndexChanged += cbbPlaylists_SelectedIndexChanged;
            // 
            // lblPlayListName
            // 
            lblPlayListName.AutoSize = true;
            lblPlayListName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblPlayListName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblPlayListName.Location = new System.Drawing.Point(806, 21);
            lblPlayListName.Name = "lblPlayListName";
            lblPlayListName.Size = new System.Drawing.Size(76, 27);
            lblPlayListName.TabIndex = 23;
            lblPlayListName.Text = "Playlist";
            // 
            // lblRenameFineshed
            // 
            lblRenameFineshed.AutoSize = true;
            lblRenameFineshed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRenameFineshed.ForeColor = System.Drawing.Color.ForestGreen;
            lblRenameFineshed.Location = new System.Drawing.Point(18, 152);
            lblRenameFineshed.Name = "lblRenameFineshed";
            lblRenameFineshed.Size = new System.Drawing.Size(61, 15);
            lblRenameFineshed.TabIndex = 20;
            lblRenameFineshed.Text = "Concluído";
            lblRenameFineshed.Visible = false;
            // 
            // lblChangeColorFineshed
            // 
            lblChangeColorFineshed.AutoSize = true;
            lblChangeColorFineshed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblChangeColorFineshed.ForeColor = System.Drawing.Color.ForestGreen;
            lblChangeColorFineshed.Location = new System.Drawing.Point(99, 152);
            lblChangeColorFineshed.Name = "lblChangeColorFineshed";
            lblChangeColorFineshed.Size = new System.Drawing.Size(61, 15);
            lblChangeColorFineshed.TabIndex = 24;
            lblChangeColorFineshed.Text = "Concluído";
            lblChangeColorFineshed.Visible = false;
            // 
            // clbCatalogue
            // 
            clbCatalogue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            clbCatalogue.FormattingEnabled = true;
            clbCatalogue.Location = new System.Drawing.Point(1301, 85);
            clbCatalogue.Name = "clbCatalogue";
            clbCatalogue.Size = new System.Drawing.Size(351, 580);
            clbCatalogue.TabIndex = 25;
            clbCatalogue.ItemCheck += clbCatalogue_ItemCheck;
            clbCatalogue.SelectedIndexChanged += clbCatalogue_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 50F);
            label11.Location = new System.Drawing.Point(1190, 312);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(105, 89);
            label11.TabIndex = 26;
            label11.Text = "⬅";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 50F);
            label12.Location = new System.Drawing.Point(1190, 115);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(105, 89);
            label12.TabIndex = 27;
            label12.Text = "⬅";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 50F);
            label13.Location = new System.Drawing.Point(1190, 514);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(105, 89);
            label13.TabIndex = 28;
            label13.Text = "⬅";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label14.Location = new System.Drawing.Point(1301, 24);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(94, 27);
            label14.TabIndex = 29;
            label14.Text = "Catálogo";
            // 
            // btnAttSongFromCatalogue
            // 
            btnAttSongFromCatalogue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAttSongFromCatalogue.BackColor = System.Drawing.Color.OliveDrab;
            btnAttSongFromCatalogue.Enabled = false;
            btnAttSongFromCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAttSongFromCatalogue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAttSongFromCatalogue.ForeColor = System.Drawing.Color.White;
            btnAttSongFromCatalogue.Location = new System.Drawing.Point(1301, 670);
            btnAttSongFromCatalogue.Name = "btnAttSongFromCatalogue";
            btnAttSongFromCatalogue.Size = new System.Drawing.Size(351, 31);
            btnAttSongFromCatalogue.TabIndex = 30;
            btnAttSongFromCatalogue.Text = "Adicionar/Remover Selecionadas";
            btnAttSongFromCatalogue.UseVisualStyleBackColor = false;
            btnAttSongFromCatalogue.Click += btnAttSongFromCatalogue_Click;
            // 
            // txtFindInCatalogue
            // 
            txtFindInCatalogue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFindInCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtFindInCatalogue.Location = new System.Drawing.Point(1301, 54);
            txtFindInCatalogue.Name = "txtFindInCatalogue";
            txtFindInCatalogue.PlaceholderText = "Buscar....🔍";
            txtFindInCatalogue.Size = new System.Drawing.Size(351, 29);
            txtFindInCatalogue.TabIndex = 26;
            txtFindInCatalogue.TextChanged += txtFindInCatalogue_TextChanged;
            // 
            // lblAttSongsCatalogueCompleted
            // 
            lblAttSongsCatalogueCompleted.AutoSize = true;
            lblAttSongsCatalogueCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAttSongsCatalogueCompleted.ForeColor = System.Drawing.Color.ForestGreen;
            lblAttSongsCatalogueCompleted.Location = new System.Drawing.Point(1234, 656);
            lblAttSongsCatalogueCompleted.Name = "lblAttSongsCatalogueCompleted";
            lblAttSongsCatalogueCompleted.Size = new System.Drawing.Size(61, 15);
            lblAttSongsCatalogueCompleted.TabIndex = 30;
            lblAttSongsCatalogueCompleted.Text = "Concluído";
            lblAttSongsCatalogueCompleted.Visible = false;
            // 
            // btnSortPlaylist
            // 
            btnSortPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSortPlaylist.BackColor = System.Drawing.Color.OliveDrab;
            btnSortPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSortPlaylist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSortPlaylist.ForeColor = System.Drawing.Color.White;
            btnSortPlaylist.Location = new System.Drawing.Point(806, 668);
            btnSortPlaylist.Name = "btnSortPlaylist";
            btnSortPlaylist.Size = new System.Drawing.Size(378, 31);
            btnSortPlaylist.TabIndex = 33;
            btnSortPlaylist.Text = "Ordenar por Ordem Alfabética";
            btnSortPlaylist.UseVisualStyleBackColor = false;
            btnSortPlaylist.Click += btnSortPlaylist_Click;
            // 
            // lblSortCompleted
            // 
            lblSortCompleted.AutoSize = true;
            lblSortCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSortCompleted.ForeColor = System.Drawing.Color.ForestGreen;
            lblSortCompleted.Location = new System.Drawing.Point(1190, 677);
            lblSortCompleted.Name = "lblSortCompleted";
            lblSortCompleted.Size = new System.Drawing.Size(61, 15);
            lblSortCompleted.TabIndex = 34;
            lblSortCompleted.Text = "Concluído";
            lblSortCompleted.Visible = false;
            // 
            // PlayListEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1660, 705);
            Controls.Add(lblSortCompleted);
            Controls.Add(btnSortPlaylist);
            Controls.Add(lblAttSongsCatalogueCompleted);
            Controls.Add(txtFindInCatalogue);
            Controls.Add(btnAttSongFromCatalogue);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(clbCatalogue);
            Controls.Add(lblChangeColorFineshed);
            Controls.Add(lblRenameFineshed);
            Controls.Add(lblPlayListName);
            Controls.Add(cbbPlaylists);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lsbSongs);
            Controls.Add(btnRenamePlaylist);
            Controls.Add(lblLoading);
            Controls.Add(lblTitle);
            Controls.Add(btnChangePlColor);
            Controls.Add(menuStrip1);
            Controls.Add(btnDeletePlaylist);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(1676, 744);
            Name = "PlayListEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AppMultiTool";
            FormClosed += PlayListEditor_FormClosed;
            Shown += PlayListEditor_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numChangeSongPos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenamePlaylist;
        private System.Windows.Forms.Button btnChangePlColor;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ListBox lsbSongs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnDownloadSong;
        private System.Windows.Forms.Button btnAddSongFromPC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPickSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbPlaylists;
        private System.Windows.Forms.Button btnUpNumSeqSong;
        private System.Windows.Forms.Button btnRenameSong;
        private System.Windows.Forms.Button btnDownNumSeqSong;
        private System.Windows.Forms.ProgressBar pgbDownloadProgress;
        private System.Windows.Forms.Label lblPlayListName;
        private System.Windows.Forms.Label lblDownloadEnded;
        private System.Windows.Forms.Label lblRenameFineshed;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Label lblChangeColorFineshed;
        private System.Windows.Forms.Label lblPCSongAdded;
        private System.Windows.Forms.Label lblRenameSongCompleted;
        private System.Windows.Forms.Label lblWaitPath;
        private System.Windows.Forms.Label lblUpMusicPositionConcluded;
        private System.Windows.Forms.Label lblDownMusicPositionConcluded;
        private System.Windows.Forms.CheckedListBox clbCatalogue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAttSongFromCatalogue;
        private System.Windows.Forms.TextBox txtFindInCatalogue;
        private System.Windows.Forms.Label lblAttSongsCatalogueCompleted;
        private System.Windows.Forms.Label lblChangePosSuccess;
        private System.Windows.Forms.NumericUpDown numChangeSongPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSortPlaylist;
        private System.Windows.Forms.Label lblSortCompleted;
        private System.Windows.Forms.Label lblPercentDownload;
        private System.Windows.Forms.Button btnChangePos;
    }
}