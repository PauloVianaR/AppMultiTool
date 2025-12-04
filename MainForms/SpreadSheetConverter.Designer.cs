
namespace AppMultiTool.MainForms
{
    partial class SpreadSheetConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadSheetConverter));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            btnPickFolder = new System.Windows.Forms.Button();
            lblSelectWS = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnConvert = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtCellFormat = new System.Windows.Forms.TextBox();
            lblShowFormats = new System.Windows.Forms.Label();
            chkVerifyHeader = new System.Windows.Forms.CheckBox();
            chkGetSheetName = new System.Windows.Forms.CheckBox();
            txtWorkSheetName = new System.Windows.Forms.TextBox();
            lblShowCommandExemple = new System.Windows.Forms.Label();
            txtCommand = new System.Windows.Forms.RichTextBox();
            btnResetNoValues = new System.Windows.Forms.Button();
            chkHighLightSQL = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            cbbFontSize = new System.Windows.Forms.ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            lblTitle.Location = new System.Drawing.Point(223, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(440, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Conversão de Planilha em Comandos SQL";
            // 
            // btnPickFolder
            // 
            btnPickFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPickFolder.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPickFolder.Location = new System.Drawing.Point(12, 129);
            btnPickFolder.Name = "btnPickFolder";
            btnPickFolder.Size = new System.Drawing.Size(136, 30);
            btnPickFolder.TabIndex = 2;
            btnPickFolder.Text = "Escolher arquivo";
            btnPickFolder.UseVisualStyleBackColor = true;
            btnPickFolder.Click += btnPickFolder_Click;
            // 
            // lblSelectWS
            // 
            lblSelectWS.AutoEllipsis = true;
            lblSelectWS.AutoSize = true;
            lblSelectWS.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSelectWS.Location = new System.Drawing.Point(12, 105);
            lblSelectWS.Name = "lblSelectWS";
            lblSelectWS.Size = new System.Drawing.Size(141, 21);
            lblSelectWS.TabIndex = 4;
            lblSelectWS.Text = "Selecionar Planilha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(374, 21);
            label3.TabIndex = 5;
            label3.Text = "Formato Comando (separar células da planilha por |)";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = System.Drawing.Color.LawnGreen;
            btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConvert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            btnConvert.Location = new System.Drawing.Point(338, 713);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(180, 51);
            btnConvert.TabIndex = 7;
            btnConvert.Text = "Converter";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(12, 479);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 21);
            label4.TabIndex = 9;
            label4.Text = "Formatar Células";
            // 
            // txtCellFormat
            // 
            txtCellFormat.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtCellFormat.Location = new System.Drawing.Point(12, 503);
            txtCellFormat.Multiline = true;
            txtCellFormat.Name = "txtCellFormat";
            txtCellFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtCellFormat.Size = new System.Drawing.Size(860, 88);
            txtCellFormat.TabIndex = 10;
            // 
            // lblShowFormats
            // 
            lblShowFormats.AutoSize = true;
            lblShowFormats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            lblShowFormats.Location = new System.Drawing.Point(146, 484);
            lblShowFormats.Name = "lblShowFormats";
            lblShowFormats.Size = new System.Drawing.Size(332, 15);
            lblShowFormats.TabIndex = 11;
            lblShowFormats.Text = "(clique aqui para ver as formatações possíveis com exemplos)";
            lblShowFormats.Click += lblShowFormats_Click;
            // 
            // chkVerifyHeader
            // 
            chkVerifyHeader.AutoSize = true;
            chkVerifyHeader.Checked = true;
            chkVerifyHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            chkVerifyHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            chkVerifyHeader.Location = new System.Drawing.Point(12, 613);
            chkVerifyHeader.Name = "chkVerifyHeader";
            chkVerifyHeader.Size = new System.Drawing.Size(173, 23);
            chkVerifyHeader.TabIndex = 12;
            chkVerifyHeader.Text = "Planilha tem cabeçalho?";
            chkVerifyHeader.UseVisualStyleBackColor = true;
            chkVerifyHeader.CheckedChanged += chkVerifyHeader_CheckedChanged;
            // 
            // chkGetSheetName
            // 
            chkGetSheetName.AutoSize = true;
            chkGetSheetName.Font = new System.Drawing.Font("Segoe UI", 10F);
            chkGetSheetName.Location = new System.Drawing.Point(12, 651);
            chkGetSheetName.Name = "chkGetSheetName";
            chkGetSheetName.Size = new System.Drawing.Size(320, 23);
            chkGetSheetName.TabIndex = 13;
            chkGetSheetName.Text = "Especificar nome da planilha dentro do arquivo?";
            chkGetSheetName.UseVisualStyleBackColor = true;
            chkGetSheetName.CheckedChanged += chkGetSheetName_CheckedChanged;
            // 
            // txtWorkSheetName
            // 
            txtWorkSheetName.Location = new System.Drawing.Point(338, 651);
            txtWorkSheetName.Name = "txtWorkSheetName";
            txtWorkSheetName.Size = new System.Drawing.Size(534, 23);
            txtWorkSheetName.TabIndex = 14;
            txtWorkSheetName.Visible = false;
            txtWorkSheetName.TextChanged += txtWorkSheetName_TextChanged;
            // 
            // lblShowCommandExemple
            // 
            lblShowCommandExemple.AutoSize = true;
            lblShowCommandExemple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            lblShowCommandExemple.Location = new System.Drawing.Point(383, 175);
            lblShowCommandExemple.Name = "lblShowCommandExemple";
            lblShowCommandExemple.Size = new System.Drawing.Size(172, 15);
            lblShowCommandExemple.TabIndex = 15;
            lblShowCommandExemple.Text = "(clique aqui para ver exemplos)";
            lblShowCommandExemple.Click += lblShowCommandExemple_Click;
            // 
            // txtCommand
            // 
            txtCommand.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtCommand.Location = new System.Drawing.Point(12, 202);
            txtCommand.Name = "txtCommand";
            txtCommand.Size = new System.Drawing.Size(860, 227);
            txtCommand.TabIndex = 16;
            txtCommand.Text = "";
            txtCommand.TextChanged += txtCommand_TextChanged;
            // 
            // btnResetNoValues
            // 
            btnResetNoValues.BackColor = System.Drawing.Color.Red;
            btnResetNoValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetNoValues.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnResetNoValues.Location = new System.Drawing.Point(752, 126);
            btnResetNoValues.Name = "btnResetNoValues";
            btnResetNoValues.Size = new System.Drawing.Size(120, 33);
            btnResetNoValues.TabIndex = 17;
            btnResetNoValues.Text = "RESETAR";
            btnResetNoValues.UseVisualStyleBackColor = false;
            btnResetNoValues.Click += btnResetNoValues_Click;
            // 
            // chkHighLightSQL
            // 
            chkHighLightSQL.AutoSize = true;
            chkHighLightSQL.Checked = true;
            chkHighLightSQL.CheckState = System.Windows.Forms.CheckState.Checked;
            chkHighLightSQL.Font = new System.Drawing.Font("Segoe UI", 10F);
            chkHighLightSQL.Location = new System.Drawing.Point(12, 437);
            chkHighLightSQL.Name = "chkHighLightSQL";
            chkHighLightSQL.Size = new System.Drawing.Size(190, 23);
            chkHighLightSQL.TabIndex = 18;
            chkHighLightSQL.Text = "Destacar palavras do SQL?";
            chkHighLightSQL.UseVisualStyleBackColor = true;
            chkHighLightSQL.CheckedChanged += chkHighLightSQL_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            label2.Location = new System.Drawing.Point(12, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 19;
            label2.Text = "FontSize";
            // 
            // cbbFontSize
            // 
            cbbFontSize.Font = new System.Drawing.Font("Segoe UI", 11F);
            cbbFontSize.FormattingEnabled = true;
            cbbFontSize.Items.AddRange(new object[] { "6pt", "7pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "17pt", "18pt", "19pt", "20pt", "21pt", "22pt" });
            cbbFontSize.Location = new System.Drawing.Point(79, 61);
            cbbFontSize.Name = "cbbFontSize";
            cbbFontSize.Size = new System.Drawing.Size(61, 28);
            cbbFontSize.TabIndex = 20;
            cbbFontSize.SelectedIndexChanged += cbbFontSize_SelectedIndexChanged;
            // 
            // SpreadSheetConverter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 783);
            Controls.Add(cbbFontSize);
            Controls.Add(label2);
            Controls.Add(chkHighLightSQL);
            Controls.Add(btnResetNoValues);
            Controls.Add(txtCommand);
            Controls.Add(lblShowCommandExemple);
            Controls.Add(txtWorkSheetName);
            Controls.Add(chkGetSheetName);
            Controls.Add(chkVerifyHeader);
            Controls.Add(lblShowFormats);
            Controls.Add(txtCellFormat);
            Controls.Add(label4);
            Controls.Add(btnConvert);
            Controls.Add(label3);
            Controls.Add(lblSelectWS);
            Controls.Add(btnPickFolder);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "SpreadSheetConverter";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += SpreadSheetConverter_FormClosed;
            Shown += SpreadSheetConverter_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.Label lblSelectWS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCellFormat;
        private System.Windows.Forms.Label lblShowFormats;
        private System.Windows.Forms.CheckBox chkVerifyHeader;
        private System.Windows.Forms.CheckBox chkGetSheetName;
        private System.Windows.Forms.TextBox txtWorkSheetName;
        private System.Windows.Forms.Label lblShowCommandExemple;
        private System.Windows.Forms.RichTextBox txtCommand;
        private System.Windows.Forms.Button btnResetNoValues;
        private System.Windows.Forms.CheckBox chkHighLightSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbFontSize;
    }
}