
using System;

namespace AppMultiTool.MainForms
{
    partial class ClipboardCopies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardCopies));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copiarDeArquivosTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            cbbListItens = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnCopyToClipboard = new System.Windows.Forms.Button();
            btnInsertItem = new System.Windows.Forms.Button();
            btnUpdateItem = new System.Windows.Forms.Button();
            btnDeleteItem = new System.Windows.Forms.Button();
            lblLoading = new System.Windows.Forms.Label();
            txtShowItem = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            cbbFontSize = new System.Windows.Forms.ComboBox();
            lblCopied = new System.Windows.Forms.Label();
            lblInfoTxtChanged = new System.Windows.Forms.Label();
            txtLocateText = new System.Windows.Forms.TextBox();
            btnLocateText = new System.Windows.Forms.Button();
            lblStatusInfo = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnApplyBold = new System.Windows.Forms.Button();
            btnApplyItalic = new System.Windows.Forms.Button();
            btnApplyUnderline = new System.Windows.Forms.Button();
            btnApplyStrikeout = new System.Windows.Forms.Button();
            chkCanHighLight = new System.Windows.Forms.CheckBox();
            btnExportTxt = new System.Windows.Forms.Button();
            btnExportPDF = new System.Windows.Forms.Button();
            lblSearchText = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem, copiarDeArquivosTxtToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1036, 24);
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
            // copiarDeArquivosTxtToolStripMenuItem
            // 
            copiarDeArquivosTxtToolStripMenuItem.Name = "copiarDeArquivosTxtToolStripMenuItem";
            copiarDeArquivosTxtToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            copiarDeArquivosTxtToolStripMenuItem.Text = "Copiar de arquivos txt";
            copiarDeArquivosTxtToolStripMenuItem.Click += copiarDeArquivosTxtToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(12, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(433, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Copiar itens para a área de transferência";
            // 
            // cbbListItens
            // 
            cbbListItens.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbbListItens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbListItens.Enabled = false;
            cbbListItens.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbListItens.FormattingEnabled = true;
            cbbListItens.Items.AddRange(new object[] { "Selecione" });
            cbbListItens.Location = new System.Drawing.Point(12, 93);
            cbbListItens.Name = "cbbListItens";
            cbbListItens.Size = new System.Drawing.Size(1019, 29);
            cbbListItens.TabIndex = 2;
            cbbListItens.SelectedIndexChanged += cbbListItens_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(12, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 21);
            label2.TabIndex = 3;
            label2.Text = "Escolher item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(185, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 21);
            label3.TabIndex = 5;
            label3.Text = "Texto do Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(12, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 21);
            label4.TabIndex = 6;
            label4.Text = "Opções";
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopyToClipboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCopyToClipboard.Enabled = false;
            btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyToClipboard.Location = new System.Drawing.Point(915, 180);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new System.Drawing.Size(116, 31);
            btnCopyToClipboard.TabIndex = 7;
            btnCopyToClipboard.Text = "Copiar (CTRL+C)";
            btnCopyToClipboard.UseVisualStyleBackColor = false;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // btnInsertItem
            // 
            btnInsertItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnInsertItem.Enabled = false;
            btnInsertItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInsertItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnInsertItem.Location = new System.Drawing.Point(12, 228);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new System.Drawing.Size(116, 31);
            btnInsertItem.TabIndex = 8;
            btnInsertItem.Text = "Inserir Item";
            btnInsertItem.UseVisualStyleBackColor = false;
            btnInsertItem.Click += btnInsertItem_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnUpdateItem.Enabled = false;
            btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnUpdateItem.Location = new System.Drawing.Point(12, 282);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new System.Drawing.Size(116, 31);
            btnUpdateItem.TabIndex = 1;
            btnUpdateItem.Text = "Atualizar Item";
            btnUpdateItem.UseVisualStyleBackColor = false;
            btnUpdateItem.Click += ActionItem;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = System.Drawing.Color.IndianRed;
            btnDeleteItem.Enabled = false;
            btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeleteItem.Location = new System.Drawing.Point(12, 335);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new System.Drawing.Size(116, 31);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "Apagar Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += ActionItem;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Location = new System.Drawing.Point(912, 31);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(119, 21);
            lblLoading.TabIndex = 11;
            lblLoading.Text = "CARREGANDO";
            // 
            // txtShowItem
            // 
            txtShowItem.AcceptsTab = true;
            txtShowItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtShowItem.EnableAutoDragDrop = true;
            txtShowItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtShowItem.Location = new System.Drawing.Point(185, 217);
            txtShowItem.Name = "txtShowItem";
            txtShowItem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            txtShowItem.Size = new System.Drawing.Size(847, 729);
            txtShowItem.TabIndex = 12;
            txtShowItem.Text = "";
            txtShowItem.TextChanged += txtShowItem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            label5.Location = new System.Drawing.Point(13, 432);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 19);
            label5.TabIndex = 13;
            label5.Text = "Font Size:";
            // 
            // cbbFontSize
            // 
            cbbFontSize.Enabled = false;
            cbbFontSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            cbbFontSize.FormattingEnabled = true;
            cbbFontSize.Items.AddRange(new object[] { "6pt", "7pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "17pt", "18pt", "19pt", "20pt", "21pt", "22pt" });
            cbbFontSize.Location = new System.Drawing.Point(86, 429);
            cbbFontSize.Name = "cbbFontSize";
            cbbFontSize.Size = new System.Drawing.Size(72, 25);
            cbbFontSize.TabIndex = 14;
            cbbFontSize.SelectedIndexChanged += cbbFontSize_SelectedIndexChanged;
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblCopied.ForeColor = System.Drawing.Color.OliveDrab;
            lblCopied.Location = new System.Drawing.Point(821, 186);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new System.Drawing.Size(87, 21);
            lblCopied.TabIndex = 15;
            lblCopied.Text = "COPIADO!";
            lblCopied.Visible = false;
            // 
            // lblInfoTxtChanged
            // 
            lblInfoTxtChanged.AutoSize = true;
            lblInfoTxtChanged.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblInfoTxtChanged.ForeColor = System.Drawing.Color.Red;
            lblInfoTxtChanged.Location = new System.Drawing.Point(465, 190);
            lblInfoTxtChanged.Name = "lblInfoTxtChanged";
            lblInfoTxtChanged.Size = new System.Drawing.Size(262, 21);
            lblInfoTxtChanged.TabIndex = 16;
            lblInfoTxtChanged.Text = "(TEXTO ALTERADO E NÃO SALVO)";
            lblInfoTxtChanged.Visible = false;
            // 
            // txtLocateText
            // 
            txtLocateText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLocateText.Location = new System.Drawing.Point(12, 137);
            txtLocateText.Name = "txtLocateText";
            txtLocateText.Size = new System.Drawing.Size(935, 23);
            txtLocateText.TabIndex = 17;
            // 
            // btnLocateText
            // 
            btnLocateText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLocateText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLocateText.Enabled = false;
            btnLocateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLocateText.Location = new System.Drawing.Point(953, 137);
            btnLocateText.Name = "btnLocateText";
            btnLocateText.Size = new System.Drawing.Size(78, 23);
            btnLocateText.TabIndex = 18;
            btnLocateText.Text = "Localizar 🔎";
            btnLocateText.UseVisualStyleBackColor = false;
            btnLocateText.Click += btnLocateText_Click;
            // 
            // lblStatusInfo
            // 
            lblStatusInfo.AutoSize = true;
            lblStatusInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblStatusInfo.ForeColor = System.Drawing.Color.OliveDrab;
            lblStatusInfo.Location = new System.Drawing.Point(548, 190);
            lblStatusInfo.Name = "lblStatusInfo";
            lblStatusInfo.Size = new System.Drawing.Size(48, 21);
            lblStatusInfo.TabIndex = 19;
            lblStatusInfo.Text = "INFO";
            lblStatusInfo.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(12, 469);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 19);
            label6.TabIndex = 20;
            label6.Text = "Estilo da Fonte";
            // 
            // btnApplyBold
            // 
            btnApplyBold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyBold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnApplyBold.Location = new System.Drawing.Point(13, 491);
            btnApplyBold.Name = "btnApplyBold";
            btnApplyBold.Size = new System.Drawing.Size(27, 28);
            btnApplyBold.TabIndex = 21;
            btnApplyBold.Tag = "1";
            btnApplyBold.Text = "B";
            btnApplyBold.UseVisualStyleBackColor = true;
            btnApplyBold.Click += ChangeFontStyle;
            // 
            // btnApplyItalic
            // 
            btnApplyItalic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyItalic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            btnApplyItalic.Location = new System.Drawing.Point(51, 491);
            btnApplyItalic.Name = "btnApplyItalic";
            btnApplyItalic.Size = new System.Drawing.Size(27, 28);
            btnApplyItalic.TabIndex = 22;
            btnApplyItalic.Tag = "2";
            btnApplyItalic.Text = "I";
            btnApplyItalic.UseVisualStyleBackColor = true;
            btnApplyItalic.Click += ChangeFontStyle;
            // 
            // btnApplyUnderline
            // 
            btnApplyUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyUnderline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            btnApplyUnderline.Location = new System.Drawing.Point(90, 491);
            btnApplyUnderline.Name = "btnApplyUnderline";
            btnApplyUnderline.Size = new System.Drawing.Size(27, 28);
            btnApplyUnderline.TabIndex = 23;
            btnApplyUnderline.Tag = "4";
            btnApplyUnderline.Text = "S";
            btnApplyUnderline.UseVisualStyleBackColor = true;
            btnApplyUnderline.Click += ChangeFontStyle;
            // 
            // btnApplyStrikeout
            // 
            btnApplyStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyStrikeout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Strikeout);
            btnApplyStrikeout.Location = new System.Drawing.Point(128, 491);
            btnApplyStrikeout.Name = "btnApplyStrikeout";
            btnApplyStrikeout.Size = new System.Drawing.Size(27, 28);
            btnApplyStrikeout.TabIndex = 24;
            btnApplyStrikeout.Tag = "8";
            btnApplyStrikeout.Text = "C";
            btnApplyStrikeout.UseVisualStyleBackColor = true;
            btnApplyStrikeout.Click += ChangeFontStyle;
            // 
            // chkCanHighLight
            // 
            chkCanHighLight.AutoSize = true;
            chkCanHighLight.Checked = true;
            chkCanHighLight.CheckState = System.Windows.Forms.CheckState.Checked;
            chkCanHighLight.Location = new System.Drawing.Point(12, 553);
            chkCanHighLight.Name = "chkCanHighLight";
            chkCanHighLight.Size = new System.Drawing.Size(162, 19);
            chkCanHighLight.TabIndex = 25;
            chkCanHighLight.Text = "Destacar palavras de SQL?";
            chkCanHighLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkCanHighLight.UseVisualStyleBackColor = true;
            chkCanHighLight.CheckedChanged += chkCanHighLight_CheckedChanged;
            // 
            // btnExportTxt
            // 
            btnExportTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnExportTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnExportTxt.Enabled = false;
            btnExportTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnExportTxt.Location = new System.Drawing.Point(13, 896);
            btnExportTxt.Name = "btnExportTxt";
            btnExportTxt.Size = new System.Drawing.Size(161, 50);
            btnExportTxt.TabIndex = 26;
            btnExportTxt.Text = "Exportar texto para arquivo TXT ↗";
            btnExportTxt.UseVisualStyleBackColor = false;
            btnExportTxt.Click += btnExportTxt_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnExportPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnExportPDF.Enabled = false;
            btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnExportPDF.Location = new System.Drawing.Point(13, 836);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new System.Drawing.Size(161, 50);
            btnExportPDF.TabIndex = 26;
            btnExportPDF.Text = "Exportar texto para arquivo PDF ↗";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // lblSearchText
            // 
            lblSearchText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            lblSearchText.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblSearchText.Location = new System.Drawing.Point(933, 74);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new System.Drawing.Size(99, 15);
            lblSearchText.TabIndex = 27;
            lblSearchText.Text = "Pesquisar item 🔎";
            lblSearchText.Click += lblSearchText_Click;
            lblSearchText.MouseEnter += lblSearchText_MouseEnter;
            lblSearchText.MouseLeave += lblSearchText_MouseLeave;
            // 
            // ClipboardCopies
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1036, 962);
            Controls.Add(lblSearchText);
            Controls.Add(btnExportTxt);
            Controls.Add(chkCanHighLight);
            Controls.Add(btnApplyStrikeout);
            Controls.Add(btnApplyUnderline);
            Controls.Add(btnApplyItalic);
            Controls.Add(btnApplyBold);
            Controls.Add(label6);
            Controls.Add(lblStatusInfo);
            Controls.Add(btnLocateText);
            Controls.Add(txtLocateText);
            Controls.Add(lblInfoTxtChanged);
            Controls.Add(lblCopied);
            Controls.Add(cbbFontSize);
            Controls.Add(label5);
            Controls.Add(txtShowItem);
            Controls.Add(lblLoading);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnUpdateItem);
            Controls.Add(btnInsertItem);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbbListItens);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Controls.Add(btnExportPDF);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(1052, 1001);
            Name = "ClipboardCopies";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += ClipboardCopies_FormClosed;
            Load += ClipboardCopies_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbbListItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.RichTextBox txtShowItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Label lblInfoTxtChanged;
        private System.Windows.Forms.TextBox txtLocateText;
        private System.Windows.Forms.Button btnLocateText;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApplyBold;
        private System.Windows.Forms.Button btnApplyItalic;
        private System.Windows.Forms.Button btnApplyUnderline;
        private System.Windows.Forms.Button btnApplyStrikeout;
        private System.Windows.Forms.ToolStripMenuItem copiarDeArquivosTxtToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkCanHighLight;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Label lblSearchText;
    }
}