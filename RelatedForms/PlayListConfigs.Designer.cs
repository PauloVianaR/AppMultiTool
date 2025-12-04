
namespace AppMultiTool.RelatedForms
{
    partial class PlayListConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListConfigs));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numVolConfig = new System.Windows.Forms.NumericUpDown();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblWaitPath = new System.Windows.Forms.Label();
            this.lblWaitConnect = new System.Windows.Forms.Label();
            this.lblSaveCompleted = new System.Windows.Forms.Label();
            this.chbLoopPlaylist = new System.Windows.Forms.CheckBox();
            this.chbRandomizePlaylist = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações PlayList Maker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho do catálogo:";
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(174, 94);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(614, 23);
            this.txtBasePath.TabIndex = 3;
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Location = new System.Drawing.Point(12, 119);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(111, 23);
            this.btnPickFolder.TabIndex = 4;
            this.btnPickFolder.Text = "Escolher caminho";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volume:";
            // 
            // numVolConfig
            // 
            this.numVolConfig.Location = new System.Drawing.Point(80, 153);
            this.numVolConfig.Name = "numVolConfig";
            this.numVolConfig.Size = new System.Drawing.Size(88, 23);
            this.numVolConfig.TabIndex = 6;
            this.numVolConfig.ValueChanged += new System.EventHandler(this.numVolConfig_ValueChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(630, 284);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(158, 41);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Salvar Alterações";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblWaitPath
            // 
            this.lblWaitPath.AutoSize = true;
            this.lblWaitPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaitPath.ForeColor = System.Drawing.Color.Red;
            this.lblWaitPath.Location = new System.Drawing.Point(129, 123);
            this.lblWaitPath.Name = "lblWaitPath";
            this.lblWaitPath.Size = new System.Drawing.Size(77, 19);
            this.lblWaitPath.TabIndex = 8;
            this.lblWaitPath.Text = "aguarde...";
            this.lblWaitPath.Visible = false;
            // 
            // lblWaitConnect
            // 
            this.lblWaitConnect.AutoSize = true;
            this.lblWaitConnect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaitConnect.ForeColor = System.Drawing.Color.Red;
            this.lblWaitConnect.Location = new System.Drawing.Point(537, 30);
            this.lblWaitConnect.Name = "lblWaitConnect";
            this.lblWaitConnect.Size = new System.Drawing.Size(77, 19);
            this.lblWaitConnect.TabIndex = 9;
            this.lblWaitConnect.Text = "aguarde...";
            // 
            // lblSaveCompleted
            // 
            this.lblSaveCompleted.AutoSize = true;
            this.lblSaveCompleted.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaveCompleted.ForeColor = System.Drawing.Color.Green;
            this.lblSaveCompleted.Location = new System.Drawing.Point(548, 296);
            this.lblSaveCompleted.Name = "lblSaveCompleted";
            this.lblSaveCompleted.Size = new System.Drawing.Size(76, 19);
            this.lblSaveCompleted.TabIndex = 10;
            this.lblSaveCompleted.Text = "Concluido";
            this.lblSaveCompleted.Visible = false;
            // 
            // chbLoopPlaylist
            // 
            this.chbLoopPlaylist.AutoSize = true;
            this.chbLoopPlaylist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbLoopPlaylist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbLoopPlaylist.Location = new System.Drawing.Point(12, 194);
            this.chbLoopPlaylist.Name = "chbLoopPlaylist";
            this.chbLoopPlaylist.Size = new System.Drawing.Size(188, 24);
            this.chbLoopPlaylist.TabIndex = 11;
            this.chbLoopPlaylist.Text = "Rodar Playlist em Loop?";
            this.chbLoopPlaylist.UseVisualStyleBackColor = true;
            // 
            // chbRandomizePlaylist
            // 
            this.chbRandomizePlaylist.AutoSize = true;
            this.chbRandomizePlaylist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRandomizePlaylist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbRandomizePlaylist.Location = new System.Drawing.Point(12, 233);
            this.chbRandomizePlaylist.Name = "chbRandomizePlaylist";
            this.chbRandomizePlaylist.Size = new System.Drawing.Size(188, 24);
            this.chbRandomizePlaylist.TabIndex = 12;
            this.chbRandomizePlaylist.Text = "Tocar no aleatório?        ";
            this.chbRandomizePlaylist.UseVisualStyleBackColor = true;
            // 
            // PlayListConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.chbRandomizePlaylist);
            this.Controls.Add(this.chbLoopPlaylist);
            this.Controls.Add(this.lblSaveCompleted);
            this.Controls.Add(this.lblWaitConnect);
            this.Controls.Add(this.lblWaitPath);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.numVolConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPickFolder);
            this.Controls.Add(this.txtBasePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayListConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppMultiTool";
            this.Shown += new System.EventHandler(this.PlayListConfigs_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVolConfig;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblWaitPath;
        private System.Windows.Forms.Label lblWaitConnect;
        private System.Windows.Forms.Label lblSaveCompleted;
        private System.Windows.Forms.CheckBox chbLoopPlaylist;
        private System.Windows.Forms.CheckBox chbRandomizePlaylist;
    }
}