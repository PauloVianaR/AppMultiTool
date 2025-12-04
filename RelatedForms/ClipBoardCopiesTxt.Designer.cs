
namespace AppMultiTool.RelatedForms
{
    partial class ClipBoardCopiesTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipBoardCopiesTxt));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiBackMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            tsmiBackClipBoardCopies = new System.Windows.Forms.ToolStripMenuItem();
            atalhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            btnApplyStrikeout = new System.Windows.Forms.Button();
            btnApplyUnderline = new System.Windows.Forms.Button();
            btnApplyItalic = new System.Windows.Forms.Button();
            btnApplyBold = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            lblStatusInfo = new System.Windows.Forms.Label();
            btnLocateText = new System.Windows.Forms.Button();
            txtLocateText = new System.Windows.Forms.TextBox();
            lblInfoTxtChanged = new System.Windows.Forms.Label();
            lblCopied = new System.Windows.Forms.Label();
            cbbFontSize = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            btnDeleteItem = new System.Windows.Forms.Button();
            btnUpdateItem = new System.Windows.Forms.Button();
            btnInsertItem = new System.Windows.Forms.Button();
            btnCopyToClipboard = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbbListItens = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            txtFolderPath = new System.Windows.Forms.TextBox();
            btnPickFolder = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            txtShowItem = new System.Windows.Forms.RichTextBox();
            label9 = new System.Windows.Forms.Label();
            tbarAutoRoll = new System.Windows.Forms.TrackBar();
            scrollTimer = new System.Windows.Forms.Timer(components);
            btnUploadToGoogleDocs = new System.Windows.Forms.Button();
            btnRenameItem = new System.Windows.Forms.Button();
            lblSearchText = new System.Windows.Forms.Label();
            atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbarAutoRoll).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1050, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiBackMainMenu, tsmiBackClipBoardCopies, atalhosToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tsmiBackMainMenu
            // 
            tsmiBackMainMenu.Name = "tsmiBackMainMenu";
            tsmiBackMainMenu.Size = new System.Drawing.Size(248, 22);
            tsmiBackMainMenu.Text = "Voltar Menu";
            tsmiBackMainMenu.Click += BackToScreen;
            // 
            // tsmiBackClipBoardCopies
            // 
            tsmiBackClipBoardCopies.Name = "tsmiBackClipBoardCopies";
            tsmiBackClipBoardCopies.Size = new System.Drawing.Size(248, 22);
            tsmiBackClipBoardCopies.Text = "Copiar textos do banco de dados";
            tsmiBackClipBoardCopies.Click += BackToScreen;
            // 
            // atalhosToolStripMenuItem
            // 
            atalhosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { visualizarToolStripMenuItem, adicionarToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem });
            atalhosToolStripMenuItem.Name = "atalhosToolStripMenuItem";
            atalhosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            atalhosToolStripMenuItem.Text = "Atalhos";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            visualizarToolStripMenuItem.Text = "Visualizar";
            visualizarToolStripMenuItem.Click += ViewShortCuts;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += AddShortCut;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += RemoveShortCut;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(12, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Copiar itens de arquivos txt";
            // 
            // btnApplyStrikeout
            // 
            btnApplyStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyStrikeout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Strikeout);
            btnApplyStrikeout.Location = new System.Drawing.Point(131, 656);
            btnApplyStrikeout.Name = "btnApplyStrikeout";
            btnApplyStrikeout.Size = new System.Drawing.Size(27, 28);
            btnApplyStrikeout.TabIndex = 45;
            btnApplyStrikeout.Tag = "8";
            btnApplyStrikeout.Text = "C";
            btnApplyStrikeout.UseVisualStyleBackColor = true;
            // 
            // btnApplyUnderline
            // 
            btnApplyUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyUnderline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            btnApplyUnderline.Location = new System.Drawing.Point(93, 656);
            btnApplyUnderline.Name = "btnApplyUnderline";
            btnApplyUnderline.Size = new System.Drawing.Size(27, 28);
            btnApplyUnderline.TabIndex = 44;
            btnApplyUnderline.Tag = "4";
            btnApplyUnderline.Text = "S";
            btnApplyUnderline.UseVisualStyleBackColor = true;
            // 
            // btnApplyItalic
            // 
            btnApplyItalic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyItalic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            btnApplyItalic.Location = new System.Drawing.Point(54, 656);
            btnApplyItalic.Name = "btnApplyItalic";
            btnApplyItalic.Size = new System.Drawing.Size(27, 28);
            btnApplyItalic.TabIndex = 43;
            btnApplyItalic.Tag = "2";
            btnApplyItalic.Text = "I";
            btnApplyItalic.UseVisualStyleBackColor = true;
            // 
            // btnApplyBold
            // 
            btnApplyBold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApplyBold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnApplyBold.Location = new System.Drawing.Point(16, 656);
            btnApplyBold.Name = "btnApplyBold";
            btnApplyBold.Size = new System.Drawing.Size(27, 28);
            btnApplyBold.TabIndex = 42;
            btnApplyBold.Tag = "1";
            btnApplyBold.Text = "B";
            btnApplyBold.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 634);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 19);
            label6.TabIndex = 41;
            label6.Text = "Estilo da Fonte";
            // 
            // lblStatusInfo
            // 
            lblStatusInfo.AutoSize = true;
            lblStatusInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblStatusInfo.ForeColor = System.Drawing.Color.OliveDrab;
            lblStatusInfo.Location = new System.Drawing.Point(550, 221);
            lblStatusInfo.Name = "lblStatusInfo";
            lblStatusInfo.Size = new System.Drawing.Size(48, 21);
            lblStatusInfo.TabIndex = 40;
            lblStatusInfo.Text = "INFO";
            lblStatusInfo.Visible = false;
            // 
            // btnLocateText
            // 
            btnLocateText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLocateText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnLocateText.Enabled = false;
            btnLocateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLocateText.Location = new System.Drawing.Point(956, 161);
            btnLocateText.Name = "btnLocateText";
            btnLocateText.Size = new System.Drawing.Size(78, 23);
            btnLocateText.TabIndex = 39;
            btnLocateText.Text = "Localizar 🔎";
            btnLocateText.UseVisualStyleBackColor = false;
            btnLocateText.Click += btnLocateText_Click;
            // 
            // txtLocateText
            // 
            txtLocateText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLocateText.Location = new System.Drawing.Point(126, 161);
            txtLocateText.Name = "txtLocateText";
            txtLocateText.Size = new System.Drawing.Size(824, 23);
            txtLocateText.TabIndex = 38;
            txtLocateText.TextChanged += txtLocateText_TextChanged;
            // 
            // lblInfoTxtChanged
            // 
            lblInfoTxtChanged.AutoSize = true;
            lblInfoTxtChanged.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblInfoTxtChanged.ForeColor = System.Drawing.Color.Red;
            lblInfoTxtChanged.Location = new System.Drawing.Point(467, 221);
            lblInfoTxtChanged.Name = "lblInfoTxtChanged";
            lblInfoTxtChanged.Size = new System.Drawing.Size(262, 21);
            lblInfoTxtChanged.TabIndex = 37;
            lblInfoTxtChanged.Text = "(TEXTO ALTERADO E NÃO SALVO)";
            lblInfoTxtChanged.Visible = false;
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblCopied.ForeColor = System.Drawing.Color.OliveDrab;
            lblCopied.Location = new System.Drawing.Point(825, 220);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new System.Drawing.Size(87, 21);
            lblCopied.TabIndex = 36;
            lblCopied.Text = "COPIADO!";
            lblCopied.Visible = false;
            // 
            // cbbFontSize
            // 
            cbbFontSize.Enabled = false;
            cbbFontSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            cbbFontSize.FormattingEnabled = true;
            cbbFontSize.Items.AddRange(new object[] { "6pt", "7pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "17pt", "18pt", "19pt", "20pt", "21pt", "22pt" });
            cbbFontSize.Location = new System.Drawing.Point(89, 594);
            cbbFontSize.Name = "cbbFontSize";
            cbbFontSize.Size = new System.Drawing.Size(72, 25);
            cbbFontSize.TabIndex = 35;
            cbbFontSize.SelectedIndexChanged += cbbFontSize_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            label5.Location = new System.Drawing.Point(16, 597);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 19);
            label5.TabIndex = 34;
            label5.Text = "Font Size:";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = System.Drawing.Color.IndianRed;
            btnDeleteItem.Enabled = false;
            btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeleteItem.Location = new System.Drawing.Point(16, 470);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new System.Drawing.Size(116, 31);
            btnDeleteItem.TabIndex = 27;
            btnDeleteItem.Text = "Apagar Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnUpdateItem.Enabled = false;
            btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnUpdateItem.Location = new System.Drawing.Point(15, 313);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new System.Drawing.Size(116, 31);
            btnUpdateItem.TabIndex = 25;
            btnUpdateItem.Text = "Atualizar Item";
            btnUpdateItem.UseVisualStyleBackColor = false;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnInsertItem
            // 
            btnInsertItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnInsertItem.Enabled = false;
            btnInsertItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInsertItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnInsertItem.Location = new System.Drawing.Point(16, 263);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new System.Drawing.Size(116, 31);
            btnInsertItem.TabIndex = 32;
            btnInsertItem.Text = "Inserir Item";
            btnInsertItem.UseVisualStyleBackColor = false;
            btnInsertItem.Click += btnInsertItem_Click;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopyToClipboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCopyToClipboard.Enabled = false;
            btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyToClipboard.Location = new System.Drawing.Point(919, 214);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new System.Drawing.Size(116, 31);
            btnCopyToClipboard.TabIndex = 31;
            btnCopyToClipboard.Text = "Copiar (CTRL+C)";
            btnCopyToClipboard.UseVisualStyleBackColor = false;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(15, 221);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 21);
            label4.TabIndex = 30;
            label4.Text = "Opções";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(197, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 21);
            label3.TabIndex = 29;
            label3.Text = "Texto do Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(12, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 21);
            label2.TabIndex = 28;
            label2.Text = "Escolher item";
            // 
            // cbbListItens
            // 
            cbbListItens.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbbListItens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbListItens.Enabled = false;
            cbbListItens.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbListItens.FormattingEnabled = true;
            cbbListItens.Items.AddRange(new object[] { "Selecione" });
            cbbListItens.Location = new System.Drawing.Point(126, 117);
            cbbListItens.Name = "cbbListItens";
            cbbListItens.Size = new System.Drawing.Size(807, 29);
            cbbListItens.TabIndex = 26;
            cbbListItens.SelectedIndexChanged += cbbListItens_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(15, 82);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 21);
            label7.TabIndex = 46;
            label7.Text = "Pasta raíz";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtFolderPath.Location = new System.Drawing.Point(126, 80);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new System.Drawing.Size(785, 29);
            txtFolderPath.TabIndex = 47;
            // 
            // btnPickFolder
            // 
            btnPickFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPickFolder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnPickFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPickFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnPickFolder.Location = new System.Drawing.Point(917, 80);
            btnPickFolder.Name = "btnPickFolder";
            btnPickFolder.Size = new System.Drawing.Size(118, 29);
            btnPickFolder.TabIndex = 48;
            btnPickFolder.Text = "Escolher pasta";
            btnPickFolder.UseVisualStyleBackColor = false;
            btnPickFolder.Click += btnPickFolder_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(15, 165);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 15);
            label8.TabIndex = 49;
            label8.Text = "Encontrar palavra";
            // 
            // txtShowItem
            // 
            txtShowItem.AcceptsTab = true;
            txtShowItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtShowItem.EnableAutoDragDrop = true;
            txtShowItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtShowItem.Location = new System.Drawing.Point(197, 251);
            txtShowItem.Name = "txtShowItem";
            txtShowItem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            txtShowItem.Size = new System.Drawing.Size(838, 748);
            txtShowItem.TabIndex = 52;
            txtShowItem.Text = "";
            txtShowItem.TextChanged += txtShowItem_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(46, 710);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(96, 19);
            label9.TabIndex = 53;
            label9.Text = "Auto Rolagem";
            // 
            // tbarAutoRoll
            // 
            tbarAutoRoll.Location = new System.Drawing.Point(10, 732);
            tbarAutoRoll.Maximum = 5;
            tbarAutoRoll.Name = "tbarAutoRoll";
            tbarAutoRoll.Size = new System.Drawing.Size(168, 45);
            tbarAutoRoll.TabIndex = 54;
            tbarAutoRoll.TickStyle = System.Windows.Forms.TickStyle.Both;
            tbarAutoRoll.Scroll += tbarAutoRoll_Scroll;
            // 
            // scrollTimer
            // 
            scrollTimer.Interval = 20;
            scrollTimer.Tick += scrollTimer_Tick;
            // 
            // btnUploadToGoogleDocs
            // 
            btnUploadToGoogleDocs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnUploadToGoogleDocs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnUploadToGoogleDocs.Enabled = false;
            btnUploadToGoogleDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUploadToGoogleDocs.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnUploadToGoogleDocs.Location = new System.Drawing.Point(15, 948);
            btnUploadToGoogleDocs.Name = "btnUploadToGoogleDocs";
            btnUploadToGoogleDocs.Size = new System.Drawing.Size(162, 51);
            btnUploadToGoogleDocs.TabIndex = 55;
            btnUploadToGoogleDocs.Text = "Sincronizar arquivo no Google Docs 🔄";
            btnUploadToGoogleDocs.UseVisualStyleBackColor = false;
            btnUploadToGoogleDocs.Click += UploadToGoogleDocs_Click;
            // 
            // btnRenameItem
            // 
            btnRenameItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnRenameItem.Enabled = false;
            btnRenameItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRenameItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnRenameItem.Location = new System.Drawing.Point(16, 365);
            btnRenameItem.Name = "btnRenameItem";
            btnRenameItem.Size = new System.Drawing.Size(116, 31);
            btnRenameItem.TabIndex = 56;
            btnRenameItem.Text = "Renomear Item";
            btnRenameItem.UseVisualStyleBackColor = false;
            btnRenameItem.Click += btnRenameItem_Click;
            // 
            // lblSearchText
            // 
            lblSearchText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            lblSearchText.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblSearchText.Location = new System.Drawing.Point(939, 126);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new System.Drawing.Size(99, 15);
            lblSearchText.TabIndex = 57;
            lblSearchText.Text = "Pesquisar item 🔎";
            lblSearchText.Click += lblSearchText_Click;
            lblSearchText.MouseEnter += lblSearchText_MouseEnter;
            lblSearchText.MouseLeave += lblSearchText_MouseLeave;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            atualizarToolStripMenuItem.Text = "Atualizar";
            atualizarToolStripMenuItem.Click += UpdateShortCut;
            // 
            // ClipBoardCopiesTxt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1050, 1011);
            Controls.Add(lblSearchText);
            Controls.Add(btnRenameItem);
            Controls.Add(btnUploadToGoogleDocs);
            Controls.Add(tbarAutoRoll);
            Controls.Add(label9);
            Controls.Add(txtShowItem);
            Controls.Add(label8);
            Controls.Add(btnPickFolder);
            Controls.Add(txtFolderPath);
            Controls.Add(label7);
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(1066, 1050);
            Name = "ClipBoardCopiesTxt";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += ClipBoardCopiesTxt_FormClosed;
            Shown += ClipBoardCopiesTxt_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbarAutoRoll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnApplyStrikeout;
        private System.Windows.Forms.Button btnApplyUnderline;
        private System.Windows.Forms.Button btnApplyItalic;
        private System.Windows.Forms.Button btnApplyBold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Button btnLocateText;
        private System.Windows.Forms.TextBox txtLocateText;
        private System.Windows.Forms.Label lblInfoTxtChanged;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbListItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtShowItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbarAutoRoll;
        private System.Windows.Forms.Timer scrollTimer;
        private System.Windows.Forms.Button btnUploadToGoogleDocs;
        private System.Windows.Forms.Button btnRenameItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackClipBoardCopies;
        private System.Windows.Forms.ToolStripMenuItem atalhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}