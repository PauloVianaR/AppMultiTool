
namespace AppMultiTool.MainForms
{
    partial class VideoAudioDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoAudioDownloader));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtURL = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtExitPath = new System.Windows.Forms.TextBox();
            btnChooseExitPath = new System.Windows.Forms.Button();
            fbdExitPathPicker = new System.Windows.Forms.FolderBrowserDialog();
            btnDownloadInit = new System.Windows.Forms.Button();
            cbbSelectDownloadType = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            pgbDownloadProgress = new System.Windows.Forms.ProgressBar();
            lblProgress = new System.Windows.Forms.Label();
            lblCompleted = new System.Windows.Forms.Label();
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
            lblTitle.Location = new System.Drawing.Point(267, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(272, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Baixar vídeos da internet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(12, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Location = new System.Drawing.Point(60, 85);
            txtURL.Name = "txtURL";
            txtURL.Size = new System.Drawing.Size(728, 23);
            txtURL.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 21);
            label3.TabIndex = 4;
            label3.Text = "Caminho de saída:";
            // 
            // txtExitPath
            // 
            txtExitPath.Location = new System.Drawing.Point(155, 157);
            txtExitPath.Name = "txtExitPath";
            txtExitPath.PlaceholderText = "SELECIONE O CAMIINHO";
            txtExitPath.ReadOnly = true;
            txtExitPath.Size = new System.Drawing.Size(633, 23);
            txtExitPath.TabIndex = 5;
            txtExitPath.Text = "D:\\Downloads\\";
            // 
            // btnChooseExitPath
            // 
            btnChooseExitPath.Location = new System.Drawing.Point(12, 182);
            btnChooseExitPath.Name = "btnChooseExitPath";
            btnChooseExitPath.Size = new System.Drawing.Size(127, 28);
            btnChooseExitPath.TabIndex = 6;
            btnChooseExitPath.Text = "Alterar onde salvar";
            btnChooseExitPath.UseVisualStyleBackColor = true;
            btnChooseExitPath.Click += btnChooseExitPath_Click;
            // 
            // btnDownloadInit
            // 
            btnDownloadInit.BackColor = System.Drawing.Color.LimeGreen;
            btnDownloadInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDownloadInit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnDownloadInit.Location = new System.Drawing.Point(338, 294);
            btnDownloadInit.Name = "btnDownloadInit";
            btnDownloadInit.Size = new System.Drawing.Size(127, 43);
            btnDownloadInit.TabIndex = 10;
            btnDownloadInit.Text = "BAIXAR";
            btnDownloadInit.UseVisualStyleBackColor = false;
            btnDownloadInit.Click += btnDownloadInit_Click;
            // 
            // cbbSelectDownloadType
            // 
            cbbSelectDownloadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbSelectDownloadType.FormattingEnabled = true;
            cbbSelectDownloadType.Items.AddRange(new object[] { "[YOUTUBE] Video + Áudio", "[YOUTUBE] Só Áudio", "[INTERNET GERAL] Vídeo + Áudio", "[INTERNET GERAL] Só Áudio" });
            cbbSelectDownloadType.Location = new System.Drawing.Point(119, 119);
            cbbSelectDownloadType.Name = "cbbSelectDownloadType";
            cbbSelectDownloadType.Size = new System.Drawing.Size(669, 23);
            cbbSelectDownloadType.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(12, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 21);
            label4.TabIndex = 12;
            label4.Text = "O que baixar:";
            // 
            // pgbDownloadProgress
            // 
            pgbDownloadProgress.Location = new System.Drawing.Point(12, 227);
            pgbDownloadProgress.Name = "pgbDownloadProgress";
            pgbDownloadProgress.Size = new System.Drawing.Size(776, 23);
            pgbDownloadProgress.TabIndex = 13;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblProgress.Location = new System.Drawing.Point(375, 253);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new System.Drawing.Size(53, 21);
            lblProgress.TabIndex = 14;
            lblProgress.Text = "0.00%";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblCompleted.ForeColor = System.Drawing.Color.Green;
            lblCompleted.Location = new System.Drawing.Point(471, 306);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new System.Drawing.Size(104, 21);
            lblCompleted.TabIndex = 15;
            lblCompleted.Text = "CONCLUÍDO";
            lblCompleted.Visible = false;
            // 
            // VideoAudioDownloader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 354);
            Controls.Add(lblCompleted);
            Controls.Add(lblProgress);
            Controls.Add(pgbDownloadProgress);
            Controls.Add(label4);
            Controls.Add(cbbSelectDownloadType);
            Controls.Add(btnDownloadInit);
            Controls.Add(btnChooseExitPath);
            Controls.Add(txtExitPath);
            Controls.Add(label3);
            Controls.Add(txtURL);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "VideoAudioDownloader";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += YoutubeVideoDownloader_FormClosed;
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
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExitPath;
        private System.Windows.Forms.Button btnChooseExitPath;
        private System.Windows.Forms.FolderBrowserDialog fbdExitPathPicker;
        private System.Windows.Forms.Button btnDownloadInit;
        private System.Windows.Forms.ComboBox cbbSelectDownloadType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgbDownloadProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblCompleted;
    }
}