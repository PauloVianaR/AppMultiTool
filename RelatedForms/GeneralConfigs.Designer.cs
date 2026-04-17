
namespace AppMultiTool.RelatedForms
{
    partial class GeneralConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralConfigs));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            numTimeOut = new System.Windows.Forms.NumericUpDown();
            lblNotSavedInfo = new System.Windows.Forms.Label();
            lblSavedSuccess = new System.Windows.Forms.Label();
            chbUseInactivity = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            cbbYTMethod = new System.Windows.Forms.ComboBox();
            lblFontSizeDefault = new System.Windows.Forms.Label();
            cbbFontSizeDefault = new System.Windows.Forms.ComboBox();
            chbShowRealTime = new System.Windows.Forms.CheckBox();
            chbUseDarkTheme = new System.Windows.Forms.CheckBox();
            chbCloseAfterCheckedDefault = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            cbbWallPaperDefault = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            txtFolderDefaultPath = new System.Windows.Forms.TextBox();
            btnPickFolder = new System.Windows.Forms.Button();
            chbUseSSLogger = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTimeOut).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(186, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 30);
            label1.TabIndex = 0;
            label1.Text = "Configurações Gerais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(12, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(210, 21);
            label2.TabIndex = 1;
            label2.Text = "Tempo inatividade (minutos):";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.ForestGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(229, 578);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(128, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(612, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // numTimeOut
            // 
            numTimeOut.Font = new System.Drawing.Font("Segoe UI", 12F);
            numTimeOut.Location = new System.Drawing.Point(228, 92);
            numTimeOut.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTimeOut.Name = "numTimeOut";
            numTimeOut.Size = new System.Drawing.Size(372, 29);
            numTimeOut.TabIndex = 5;
            numTimeOut.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numTimeOut.ValueChanged += ValueChanged;
            // 
            // lblNotSavedInfo
            // 
            lblNotSavedInfo.AutoSize = true;
            lblNotSavedInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblNotSavedInfo.ForeColor = System.Drawing.Color.Red;
            lblNotSavedInfo.Location = new System.Drawing.Point(228, 54);
            lblNotSavedInfo.Name = "lblNotSavedInfo";
            lblNotSavedInfo.Size = new System.Drawing.Size(149, 19);
            lblNotSavedInfo.TabIndex = 6;
            lblNotSavedInfo.Text = "Alterações não salvas!";
            lblNotSavedInfo.Visible = false;
            // 
            // lblSavedSuccess
            // 
            lblSavedSuccess.AutoSize = true;
            lblSavedSuccess.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblSavedSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            lblSavedSuccess.Location = new System.Drawing.Point(366, 585);
            lblSavedSuccess.Name = "lblSavedSuccess";
            lblSavedSuccess.Size = new System.Drawing.Size(43, 30);
            lblSavedSuccess.TabIndex = 7;
            lblSavedSuccess.Text = "✔";
            lblSavedSuccess.Visible = false;
            // 
            // chbUseInactivity
            // 
            chbUseInactivity.AutoSize = true;
            chbUseInactivity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbUseInactivity.Font = new System.Drawing.Font("Segoe UI", 12F);
            chbUseInactivity.Location = new System.Drawing.Point(12, 133);
            chbUseInactivity.Name = "chbUseInactivity";
            chbUseInactivity.Size = new System.Drawing.Size(180, 25);
            chbUseInactivity.TabIndex = 9;
            chbUseInactivity.Text = "Sair após inatividade?";
            chbUseInactivity.UseVisualStyleBackColor = true;
            chbUseInactivity.CheckedChanged += CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(211, 21);
            label3.TabIndex = 10;
            label3.Text = "Método de downloads do YT:";
            // 
            // cbbYTMethod
            // 
            cbbYTMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbYTMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbYTMethod.FormattingEnabled = true;
            cbbYTMethod.Items.AddRange(new object[] { "YoutubeExplode", "YoutubeDLSharp", "PythonModule" });
            cbbYTMethod.Location = new System.Drawing.Point(229, 174);
            cbbYTMethod.Name = "cbbYTMethod";
            cbbYTMethod.Size = new System.Drawing.Size(371, 29);
            cbbYTMethod.TabIndex = 11;
            cbbYTMethod.SelectedIndexChanged += ValueChanged;
            // 
            // lblFontSizeDefault
            // 
            lblFontSizeDefault.AutoSize = true;
            lblFontSizeDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblFontSizeDefault.Location = new System.Drawing.Point(12, 276);
            lblFontSizeDefault.Name = "lblFontSizeDefault";
            lblFontSizeDefault.Size = new System.Drawing.Size(214, 21);
            lblFontSizeDefault.TabIndex = 12;
            lblFontSizeDefault.Text = "FontSize padrão para textbox:";
            // 
            // cbbFontSizeDefault
            // 
            cbbFontSizeDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbFontSizeDefault.FormattingEnabled = true;
            cbbFontSizeDefault.Items.AddRange(new object[] { "6pt", "7pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "17pt", "18pt", "19pt", "20pt", "21pt", "22pt" });
            cbbFontSizeDefault.Location = new System.Drawing.Point(228, 273);
            cbbFontSizeDefault.Name = "cbbFontSizeDefault";
            cbbFontSizeDefault.Size = new System.Drawing.Size(83, 29);
            cbbFontSizeDefault.TabIndex = 13;
            cbbFontSizeDefault.SelectedIndexChanged += ValueChanged;
            // 
            // chbShowRealTime
            // 
            chbShowRealTime.AutoSize = true;
            chbShowRealTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbShowRealTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            chbShowRealTime.Location = new System.Drawing.Point(12, 364);
            chbShowRealTime.Name = "chbShowRealTime";
            chbShowRealTime.Size = new System.Drawing.Size(205, 25);
            chbShowRealTime.TabIndex = 14;
            chbShowRealTime.Text = "Exibir horário nos títulos?";
            chbShowRealTime.UseVisualStyleBackColor = true;
            chbShowRealTime.CheckedChanged += CheckedChanged;
            // 
            // chbUseDarkTheme
            // 
            chbUseDarkTheme.AutoSize = true;
            chbUseDarkTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbUseDarkTheme.Font = new System.Drawing.Font("Segoe UI", 12F);
            chbUseDarkTheme.Location = new System.Drawing.Point(12, 408);
            chbUseDarkTheme.Name = "chbUseDarkTheme";
            chbUseDarkTheme.Size = new System.Drawing.Size(157, 25);
            chbUseDarkTheme.TabIndex = 15;
            chbUseDarkTheme.Text = "Usar tema escuro?";
            chbUseDarkTheme.UseVisualStyleBackColor = true;
            chbUseDarkTheme.CheckedChanged += CheckedChanged;
            // 
            // chbCloseAfterCheckedDefault
            // 
            chbCloseAfterCheckedDefault.AutoSize = true;
            chbCloseAfterCheckedDefault.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbCloseAfterCheckedDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            chbCloseAfterCheckedDefault.Location = new System.Drawing.Point(12, 321);
            chbCloseAfterCheckedDefault.Name = "chbCloseAfterCheckedDefault";
            chbCloseAfterCheckedDefault.Size = new System.Drawing.Size(447, 25);
            chbCloseAfterCheckedDefault.TabIndex = 16;
            chbCloseAfterCheckedDefault.Text = "Opção \"Fechar Após\" marcada por padrão na tela de Rotinas";
            chbCloseAfterCheckedDefault.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(12, 226);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(135, 21);
            label4.TabIndex = 17;
            label4.Text = "Wallpaper Padrão:";
            // 
            // cbbWallPaperDefault
            // 
            cbbWallPaperDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbWallPaperDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbWallPaperDefault.FormattingEnabled = true;
            cbbWallPaperDefault.Items.AddRange(new object[] { "Nenhum", "YellowHighTech", "Mandala", "BlueCircle" });
            cbbWallPaperDefault.Location = new System.Drawing.Point(228, 223);
            cbbWallPaperDefault.Name = "cbbWallPaperDefault";
            cbbWallPaperDefault.Size = new System.Drawing.Size(372, 29);
            cbbWallPaperDefault.TabIndex = 18;
            cbbWallPaperDefault.SelectedIndexChanged += ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(12, 504);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(273, 21);
            label5.TabIndex = 19;
            label5.Text = "Caminho padrão para salvar arquivos:";
            // 
            // txtFolderDefaultPath
            // 
            txtFolderDefaultPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtFolderDefaultPath.Location = new System.Drawing.Point(291, 503);
            txtFolderDefaultPath.Name = "txtFolderDefaultPath";
            txtFolderDefaultPath.Size = new System.Drawing.Size(309, 29);
            txtFolderDefaultPath.TabIndex = 20;
            // 
            // btnPickFolder
            // 
            btnPickFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPickFolder.Location = new System.Drawing.Point(291, 538);
            btnPickFolder.Name = "btnPickFolder";
            btnPickFolder.Size = new System.Drawing.Size(117, 23);
            btnPickFolder.TabIndex = 21;
            btnPickFolder.Text = "Escolher ficheiro";
            btnPickFolder.UseVisualStyleBackColor = true;
            btnPickFolder.Click += btnPickFolder_Click;
            // 
            // chbUseSSLogger
            // 
            chbUseSSLogger.AutoSize = true;
            chbUseSSLogger.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbUseSSLogger.Font = new System.Drawing.Font("Segoe UI", 12F);
            chbUseSSLogger.Location = new System.Drawing.Point(12, 453);
            chbUseSSLogger.Name = "chbUseSSLogger";
            chbUseSSLogger.Size = new System.Drawing.Size(305, 25);
            chbUseSSLogger.TabIndex = 22;
            chbUseSSLogger.Text = "Salvar registros da planilha conversora?";
            chbUseSSLogger.UseVisualStyleBackColor = true;
            // 
            // GeneralConfigs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 647);
            Controls.Add(chbUseSSLogger);
            Controls.Add(btnPickFolder);
            Controls.Add(txtFolderDefaultPath);
            Controls.Add(label5);
            Controls.Add(cbbWallPaperDefault);
            Controls.Add(label4);
            Controls.Add(chbCloseAfterCheckedDefault);
            Controls.Add(chbUseDarkTheme);
            Controls.Add(chbShowRealTime);
            Controls.Add(cbbFontSizeDefault);
            Controls.Add(lblFontSizeDefault);
            Controls.Add(cbbYTMethod);
            Controls.Add(label3);
            Controls.Add(chbUseInactivity);
            Controls.Add(lblSavedSuccess);
            Controls.Add(lblNotSavedInfo);
            Controls.Add(numTimeOut);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "GeneralConfigs";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            Shown += GeneralConfigs_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTimeOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numTimeOut;
        private System.Windows.Forms.Label lblNotSavedInfo;
        private System.Windows.Forms.Label lblSavedSuccess;
        private System.Windows.Forms.CheckBox chbUseInactivity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbYTMethod;
        private System.Windows.Forms.Label lblFontSizeDefault;
        private System.Windows.Forms.ComboBox cbbFontSizeDefault;
        private System.Windows.Forms.CheckBox chbShowRealTime;
        private System.Windows.Forms.CheckBox chbUseDarkTheme;
        private System.Windows.Forms.CheckBox chbCloseAfterCheckedDefault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbWallPaperDefault;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolderDefaultPath;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.CheckBox chbUseSSLogger;
    }
}