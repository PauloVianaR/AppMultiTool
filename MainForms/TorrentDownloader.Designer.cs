
namespace AppMultiTool.MainForms
{
    partial class TorrentDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorrentDownloader));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnPickTorrentFile = new System.Windows.Forms.Button();
            lblTorrentFile = new System.Windows.Forms.Label();
            txtSaveFolderPath = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnPickFinalPath = new System.Windows.Forms.Button();
            btnDownload = new System.Windows.Forms.Button();
            btnStopDownload = new System.Windows.Forms.Button();
            pgbDownloadStatus = new System.Windows.Forms.ProgressBar();
            lblProgress = new System.Windows.Forms.Label();
            chbCanVerifyVirusFile = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(291, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(221, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Torrent Downloader";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(12, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "Arquivo Torrent:";
            // 
            // btnPickTorrentFile
            // 
            btnPickTorrentFile.Location = new System.Drawing.Point(12, 116);
            btnPickTorrentFile.Name = "btnPickTorrentFile";
            btnPickTorrentFile.Size = new System.Drawing.Size(121, 26);
            btnPickTorrentFile.TabIndex = 3;
            btnPickTorrentFile.Text = "Escolher Arquivo";
            btnPickTorrentFile.UseVisualStyleBackColor = true;
            btnPickTorrentFile.Click += btnPickTorrentFile_Click;
            // 
            // lblTorrentFile
            // 
            lblTorrentFile.AutoSize = true;
            lblTorrentFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblTorrentFile.Location = new System.Drawing.Point(139, 92);
            lblTorrentFile.Name = "lblTorrentFile";
            lblTorrentFile.Size = new System.Drawing.Size(63, 21);
            lblTorrentFile.TabIndex = 4;
            lblTorrentFile.Text = "arquivo";
            // 
            // txtSaveFolderPath
            // 
            txtSaveFolderPath.Location = new System.Drawing.Point(100, 200);
            txtSaveFolderPath.Name = "txtSaveFolderPath";
            txtSaveFolderPath.PlaceholderText = "caminho que ficará arquivo completo baixado";
            txtSaveFolderPath.Size = new System.Drawing.Size(688, 23);
            txtSaveFolderPath.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Salvar em:";
            // 
            // btnPickFinalPath
            // 
            btnPickFinalPath.Location = new System.Drawing.Point(12, 229);
            btnPickFinalPath.Name = "btnPickFinalPath";
            btnPickFinalPath.Size = new System.Drawing.Size(121, 30);
            btnPickFinalPath.TabIndex = 7;
            btnPickFinalPath.Text = "Escolher Caminho";
            btnPickFinalPath.UseVisualStyleBackColor = true;
            btnPickFinalPath.Click += btnPickFinalPath_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = System.Drawing.Color.Green;
            btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDownload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnDownload.ForeColor = System.Drawing.Color.Black;
            btnDownload.Location = new System.Drawing.Point(12, 296);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new System.Drawing.Size(137, 41);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "BAIXAR";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnStopDownload
            // 
            btnStopDownload.BackColor = System.Drawing.Color.Red;
            btnStopDownload.Enabled = false;
            btnStopDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopDownload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnStopDownload.ForeColor = System.Drawing.Color.Black;
            btnStopDownload.Location = new System.Drawing.Point(651, 296);
            btnStopDownload.Name = "btnStopDownload";
            btnStopDownload.Size = new System.Drawing.Size(137, 41);
            btnStopDownload.TabIndex = 9;
            btnStopDownload.Text = "Interromper";
            btnStopDownload.UseVisualStyleBackColor = false;
            btnStopDownload.Click += btnStopDownload_Click;
            // 
            // pgbDownloadStatus
            // 
            pgbDownloadStatus.Location = new System.Drawing.Point(12, 356);
            pgbDownloadStatus.Name = "pgbDownloadStatus";
            pgbDownloadStatus.Size = new System.Drawing.Size(776, 23);
            pgbDownloadStatus.Step = 1;
            pgbDownloadStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            pgbDownloadStatus.TabIndex = 10;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new System.Drawing.Point(387, 382);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new System.Drawing.Size(23, 15);
            lblProgress.TabIndex = 11;
            lblProgress.Text = "0%";
            // 
            // chbCanVerifyVirusFile
            // 
            chbCanVerifyVirusFile.AutoSize = true;
            chbCanVerifyVirusFile.Checked = true;
            chbCanVerifyVirusFile.CheckState = System.Windows.Forms.CheckState.Checked;
            chbCanVerifyVirusFile.Location = new System.Drawing.Point(12, 148);
            chbCanVerifyVirusFile.Name = "chbCanVerifyVirusFile";
            chbCanVerifyVirusFile.Size = new System.Drawing.Size(236, 19);
            chbCanVerifyVirusFile.TabIndex = 12;
            chbCanVerifyVirusFile.Text = "Verificar a existência de vírus no arquivo";
            chbCanVerifyVirusFile.UseVisualStyleBackColor = true;
            // 
            // TorrentDownloader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 417);
            Controls.Add(chbCanVerifyVirusFile);
            Controls.Add(lblProgress);
            Controls.Add(pgbDownloadStatus);
            Controls.Add(btnStopDownload);
            Controls.Add(btnDownload);
            Controls.Add(btnPickFinalPath);
            Controls.Add(label3);
            Controls.Add(txtSaveFolderPath);
            Controls.Add(lblTorrentFile);
            Controls.Add(btnPickTorrentFile);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TorrentDownloader";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += TorrentDownloader_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPickTorrentFile;
        private System.Windows.Forms.Label lblTorrentFile;
        private System.Windows.Forms.TextBox txtSaveFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPickFinalPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnStopDownload;
        private System.Windows.Forms.ProgressBar pgbDownloadStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.CheckBox chbCanVerifyVirusFile;
    }
}