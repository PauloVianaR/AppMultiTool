
namespace AppMultiTool.MainForms
{
    partial class TextConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextConverter));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiAutoComma = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            rbtnMin = new System.Windows.Forms.RadioButton();
            rbtnMax = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            chkRemSpecialChar = new System.Windows.Forms.CheckBox();
            rbtnDefault = new System.Windows.Forms.RadioButton();
            brnReset = new System.Windows.Forms.Button();
            brnClean = new System.Windows.Forms.Button();
            chkRemSpecialCharEmpty = new System.Windows.Forms.CheckBox();
            btnSeparateStrings = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            cbbFontSize = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtStringAddBefore = new System.Windows.Forms.TextBox();
            btnRemoveStrings = new System.Windows.Forms.Button();
            txtStringToRemove = new System.Windows.Forms.TextBox();
            btnInvertSeq = new System.Windows.Forms.Button();
            txtStringComparation = new System.Windows.Forms.TextBox();
            ckbConcatResult = new System.Windows.Forms.CheckBox();
            txtText = new System.Windows.Forms.RichTextBox();
            btnCopyText = new System.Windows.Forms.Button();
            lblCopySucess = new System.Windows.Forms.Label();
            txtStringAddAfter = new System.Windows.Forms.TextBox();
            ckbAddSingleQuotes = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            btnSaveTextBase = new System.Windows.Forms.Button();
            btnBackTextBase = new System.Windows.Forms.Button();
            lblTextBaseSaveInfo = new System.Windows.Forms.Label();
            lblAutoCommaInfo = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem, opçõesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1208, 24);
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
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiAutoComma });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tsmiAutoComma
            // 
            tsmiAutoComma.Name = "tsmiAutoComma";
            tsmiAutoComma.Size = new System.Drawing.Size(210, 22);
            tsmiAutoComma.Text = "Ativar Vírgula Automática";
            tsmiAutoComma.Click += tsmiAutoComma_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(12, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(311, 37);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "CONVERSOR DE TEXTO";
            // 
            // rbtnMin
            // 
            rbtnMin.AutoSize = true;
            rbtnMin.Location = new System.Drawing.Point(22, 174);
            rbtnMin.Name = "rbtnMin";
            rbtnMin.Size = new System.Drawing.Size(111, 19);
            rbtnMin.TabIndex = 2;
            rbtnMin.Text = "Tudo Minúsculo";
            rbtnMin.UseVisualStyleBackColor = true;
            rbtnMin.CheckedChanged += SwitchOptionsRadio;
            // 
            // rbtnMax
            // 
            rbtnMax.AutoSize = true;
            rbtnMax.Location = new System.Drawing.Point(22, 208);
            rbtnMax.Name = "rbtnMax";
            rbtnMax.Size = new System.Drawing.Size(110, 19);
            rbtnMax.TabIndex = 3;
            rbtnMax.Text = "Tudo Maiúsculo";
            rbtnMax.UseVisualStyleBackColor = true;
            rbtnMax.CheckedChanged += SwitchOptionsRadio;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(425, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 30);
            label2.TabIndex = 6;
            label2.Text = "TEXTO";
            // 
            // chkRemSpecialChar
            // 
            chkRemSpecialChar.AutoSize = true;
            chkRemSpecialChar.Location = new System.Drawing.Point(22, 246);
            chkRemSpecialChar.Name = "chkRemSpecialChar";
            chkRemSpecialChar.Size = new System.Drawing.Size(243, 19);
            chkRemSpecialChar.TabIndex = 2;
            chkRemSpecialChar.Text = "Substituir caracteres especiais por espaço";
            chkRemSpecialChar.UseVisualStyleBackColor = true;
            chkRemSpecialChar.CheckedChanged += SwitchOptionsCheck;
            // 
            // rbtnDefault
            // 
            rbtnDefault.AutoSize = true;
            rbtnDefault.Checked = true;
            rbtnDefault.Location = new System.Drawing.Point(22, 139);
            rbtnDefault.Name = "rbtnDefault";
            rbtnDefault.Size = new System.Drawing.Size(62, 19);
            rbtnDefault.TabIndex = 1;
            rbtnDefault.TabStop = true;
            rbtnDefault.Text = "Padrão";
            rbtnDefault.UseVisualStyleBackColor = true;
            rbtnDefault.CheckedChanged += SwitchOptionsRadio;
            // 
            // brnReset
            // 
            brnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            brnReset.BackColor = System.Drawing.Color.BurlyWood;
            brnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            brnReset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            brnReset.Location = new System.Drawing.Point(12, 928);
            brnReset.Name = "brnReset";
            brnReset.Size = new System.Drawing.Size(152, 41);
            brnReset.TabIndex = 13;
            brnReset.Text = "RESETAR";
            brnReset.UseVisualStyleBackColor = false;
            brnReset.Click += brnReset_Click;
            // 
            // brnClean
            // 
            brnClean.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            brnClean.BackColor = System.Drawing.Color.IndianRed;
            brnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            brnClean.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            brnClean.Location = new System.Drawing.Point(260, 928);
            brnClean.Name = "brnClean";
            brnClean.Size = new System.Drawing.Size(152, 41);
            brnClean.TabIndex = 14;
            brnClean.Text = "LIMPAR";
            brnClean.UseVisualStyleBackColor = false;
            brnClean.Click += brnClean_Click;
            // 
            // chkRemSpecialCharEmpty
            // 
            chkRemSpecialCharEmpty.AutoSize = true;
            chkRemSpecialCharEmpty.Location = new System.Drawing.Point(22, 281);
            chkRemSpecialCharEmpty.Name = "chkRemSpecialCharEmpty";
            chkRemSpecialCharEmpty.Size = new System.Drawing.Size(233, 19);
            chkRemSpecialCharEmpty.TabIndex = 1;
            chkRemSpecialCharEmpty.Text = "Substituir caracteres especiais por vazio";
            chkRemSpecialCharEmpty.UseVisualStyleBackColor = true;
            chkRemSpecialCharEmpty.CheckedChanged += SwitchOptionsCheck;
            // 
            // btnSeparateStrings
            // 
            btnSeparateStrings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnSeparateStrings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeparateStrings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSeparateStrings.Location = new System.Drawing.Point(3, 161);
            btnSeparateStrings.Name = "btnSeparateStrings";
            btnSeparateStrings.Size = new System.Drawing.Size(390, 39);
            btnSeparateStrings.TabIndex = 16;
            btnSeparateStrings.Text = "Separar por vírgula";
            btnSeparateStrings.UseVisualStyleBackColor = false;
            btnSeparateStrings.Click += SeparateStrings;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(12, 106);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 30);
            label3.TabIndex = 17;
            label3.Text = "Opções";
            // 
            // cbbFontSize
            // 
            cbbFontSize.FormattingEnabled = true;
            cbbFontSize.Items.AddRange(new object[] { "6pt", "7pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "17pt", "18pt", "19pt", "20pt", "21pt", "22pt" });
            cbbFontSize.Location = new System.Drawing.Point(22, 316);
            cbbFontSize.Name = "cbbFontSize";
            cbbFontSize.Size = new System.Drawing.Size(52, 23);
            cbbFontSize.TabIndex = 18;
            cbbFontSize.SelectedIndexChanged += cbbFontSize_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(80, 320);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 19);
            label4.TabIndex = 19;
            label4.Text = "Tamanho da Fonte";
            // 
            // txtStringAddBefore
            // 
            txtStringAddBefore.Location = new System.Drawing.Point(3, 53);
            txtStringAddBefore.Name = "txtStringAddBefore";
            txtStringAddBefore.PlaceholderText = "STRING PARA ADICIONAR ANTES DE CADA SEPARAÇÃO";
            txtStringAddBefore.Size = new System.Drawing.Size(390, 23);
            txtStringAddBefore.TabIndex = 21;
            // 
            // btnRemoveStrings
            // 
            btnRemoveStrings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnRemoveStrings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveStrings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnRemoveStrings.Location = new System.Drawing.Point(20, 586);
            btnRemoveStrings.Name = "btnRemoveStrings";
            btnRemoveStrings.Size = new System.Drawing.Size(180, 64);
            btnRemoveStrings.TabIndex = 22;
            btnRemoveStrings.Text = "Remover string em massa";
            btnRemoveStrings.UseVisualStyleBackColor = false;
            btnRemoveStrings.Click += btnRemoveStrings_Click;
            // 
            // txtStringToRemove
            // 
            txtStringToRemove.Location = new System.Drawing.Point(20, 665);
            txtStringToRemove.Name = "txtStringToRemove";
            txtStringToRemove.PlaceholderText = "STRING PARA REMOVER";
            txtStringToRemove.Size = new System.Drawing.Size(180, 23);
            txtStringToRemove.TabIndex = 23;
            // 
            // btnInvertSeq
            // 
            btnInvertSeq.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnInvertSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInvertSeq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnInvertSeq.Location = new System.Drawing.Point(230, 586);
            btnInvertSeq.Name = "btnInvertSeq";
            btnInvertSeq.Size = new System.Drawing.Size(180, 64);
            btnInvertSeq.TabIndex = 24;
            btnInvertSeq.Text = "Inverter Sequência";
            btnInvertSeq.UseVisualStyleBackColor = false;
            btnInvertSeq.Click += btnInvertSeq_Click;
            // 
            // txtStringComparation
            // 
            txtStringComparation.Location = new System.Drawing.Point(230, 665);
            txtStringComparation.Name = "txtStringComparation";
            txtStringComparation.PlaceholderText = "STRING PARA COMPARAR";
            txtStringComparation.Size = new System.Drawing.Size(180, 23);
            txtStringComparation.TabIndex = 25;
            // 
            // ckbConcatResult
            // 
            ckbConcatResult.AutoSize = true;
            ckbConcatResult.Location = new System.Drawing.Point(3, 111);
            ckbConcatResult.Name = "ckbConcatResult";
            ckbConcatResult.Size = new System.Drawing.Size(147, 19);
            ckbConcatResult.TabIndex = 26;
            ckbConcatResult.Text = "Concatenar Resultado?";
            ckbConcatResult.UseVisualStyleBackColor = true;
            // 
            // txtText
            // 
            txtText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtText.Location = new System.Drawing.Point(425, 66);
            txtText.Name = "txtText";
            txtText.Size = new System.Drawing.Size(771, 903);
            txtText.TabIndex = 27;
            txtText.Text = "";
            txtText.TextChanged += txtText_TextChanged;
            // 
            // btnCopyText
            // 
            btnCopyText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnCopyText.ForeColor = System.Drawing.Color.Green;
            btnCopyText.Location = new System.Drawing.Point(1001, 33);
            btnCopyText.Name = "btnCopyText";
            btnCopyText.Size = new System.Drawing.Size(195, 30);
            btnCopyText.TabIndex = 29;
            btnCopyText.Text = "Copiar Texto CTRL + C";
            btnCopyText.UseVisualStyleBackColor = true;
            btnCopyText.Click += btnCopyText_Click;
            // 
            // lblCopySucess
            // 
            lblCopySucess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCopySucess.AutoSize = true;
            lblCopySucess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCopySucess.ForeColor = System.Drawing.Color.ForestGreen;
            lblCopySucess.Location = new System.Drawing.Point(940, 43);
            lblCopySucess.Name = "lblCopySucess";
            lblCopySucess.Size = new System.Drawing.Size(55, 15);
            lblCopySucess.TabIndex = 30;
            lblCopySucess.Text = "Copiado!";
            lblCopySucess.Visible = false;
            // 
            // txtStringAddAfter
            // 
            txtStringAddAfter.Location = new System.Drawing.Point(3, 82);
            txtStringAddAfter.Name = "txtStringAddAfter";
            txtStringAddAfter.PlaceholderText = "STRING PARA ADICIONAR DEPOIS DE CADA SEPARAÇÃO";
            txtStringAddAfter.Size = new System.Drawing.Size(390, 23);
            txtStringAddAfter.TabIndex = 31;
            // 
            // ckbAddSingleQuotes
            // 
            ckbAddSingleQuotes.AutoSize = true;
            ckbAddSingleQuotes.Location = new System.Drawing.Point(3, 136);
            ckbAddSingleQuotes.Name = "ckbAddSingleQuotes";
            ckbAddSingleQuotes.Size = new System.Drawing.Size(160, 19);
            ckbAddSingleQuotes.TabIndex = 32;
            ckbAddSingleQuotes.Text = "Adicionar Aspas Simples?";
            ckbAddSingleQuotes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtStringAddBefore);
            panel1.Controls.Add(ckbAddSingleQuotes);
            panel1.Controls.Add(btnSeparateStrings);
            panel1.Controls.Add(txtStringAddAfter);
            panel1.Controls.Add(ckbConcatResult);
            panel1.Location = new System.Drawing.Point(16, 361);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(399, 206);
            panel1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(3, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(231, 20);
            label5.TabIndex = 33;
            label5.Text = "Opções para separar por vírgula";
            // 
            // btnSaveTextBase
            // 
            btnSaveTextBase.BackColor = System.Drawing.Color.OliveDrab;
            btnSaveTextBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveTextBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSaveTextBase.Location = new System.Drawing.Point(12, 763);
            btnSaveTextBase.Name = "btnSaveTextBase";
            btnSaveTextBase.Size = new System.Drawing.Size(190, 37);
            btnSaveTextBase.TabIndex = 34;
            btnSaveTextBase.Text = "Salvar texto base";
            btnSaveTextBase.UseVisualStyleBackColor = false;
            btnSaveTextBase.Click += btnSaveTextBase_Click;
            // 
            // btnBackTextBase
            // 
            btnBackTextBase.BackColor = System.Drawing.Color.Firebrick;
            btnBackTextBase.Enabled = false;
            btnBackTextBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackTextBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnBackTextBase.Location = new System.Drawing.Point(12, 806);
            btnBackTextBase.Name = "btnBackTextBase";
            btnBackTextBase.Size = new System.Drawing.Size(190, 37);
            btnBackTextBase.TabIndex = 35;
            btnBackTextBase.Text = "Voltar para texto base";
            btnBackTextBase.UseVisualStyleBackColor = false;
            btnBackTextBase.Click += btnBackTextBase_Click;
            // 
            // lblTextBaseSaveInfo
            // 
            lblTextBaseSaveInfo.AutoSize = true;
            lblTextBaseSaveInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTextBaseSaveInfo.ForeColor = System.Drawing.Color.ForestGreen;
            lblTextBaseSaveInfo.Location = new System.Drawing.Point(210, 776);
            lblTextBaseSaveInfo.Name = "lblTextBaseSaveInfo";
            lblTextBaseSaveInfo.Size = new System.Drawing.Size(41, 15);
            lblTextBaseSaveInfo.TabIndex = 36;
            lblTextBaseSaveInfo.Text = "Salvo!";
            lblTextBaseSaveInfo.Visible = false;
            // 
            // lblAutoCommaInfo
            // 
            lblAutoCommaInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblAutoCommaInfo.AutoSize = true;
            lblAutoCommaInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAutoCommaInfo.ForeColor = System.Drawing.Color.Firebrick;
            lblAutoCommaInfo.Location = new System.Drawing.Point(512, 43);
            lblAutoCommaInfo.Name = "lblAutoCommaInfo";
            lblAutoCommaInfo.Size = new System.Drawing.Size(172, 15);
            lblAutoCommaInfo.TabIndex = 37;
            lblAutoCommaInfo.Text = "[Vírgula automática ATIVADA]";
            lblAutoCommaInfo.Visible = false;
            // 
            // TextConverter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1208, 981);
            Controls.Add(lblAutoCommaInfo);
            Controls.Add(lblTextBaseSaveInfo);
            Controls.Add(btnBackTextBase);
            Controls.Add(btnSaveTextBase);
            Controls.Add(panel1);
            Controls.Add(lblCopySucess);
            Controls.Add(btnCopyText);
            Controls.Add(txtText);
            Controls.Add(txtStringComparation);
            Controls.Add(btnInvertSeq);
            Controls.Add(txtStringToRemove);
            Controls.Add(btnRemoveStrings);
            Controls.Add(label4);
            Controls.Add(cbbFontSize);
            Controls.Add(label3);
            Controls.Add(chkRemSpecialCharEmpty);
            Controls.Add(brnClean);
            Controls.Add(brnReset);
            Controls.Add(rbtnDefault);
            Controls.Add(chkRemSpecialChar);
            Controls.Add(label2);
            Controls.Add(rbtnMax);
            Controls.Add(rbtnMin);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(1224, 1020);
            Name = "TextConverter";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += TextConverter_FormClosed;
            Shown += TextConverter_Shown;
            KeyDown += TextConverter_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbtnMin;
        private System.Windows.Forms.RadioButton rbtnMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRemSpecialChar;
        private System.Windows.Forms.RadioButton rbtnDefault;
        private System.Windows.Forms.Button brnReset;
        private System.Windows.Forms.Button brnClean;
        private System.Windows.Forms.CheckBox chkRemSpecialCharEmpty;
        private System.Windows.Forms.Button btnSeparateStrings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStringAddBefore;
        private System.Windows.Forms.Button btnRemoveStrings;
        private System.Windows.Forms.TextBox txtStringToRemove;
        private System.Windows.Forms.Button btnInvertSeq;
        private System.Windows.Forms.TextBox txtStringComparation;
        private System.Windows.Forms.CheckBox ckbConcatResult;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.Label lblCopySucess;
        private System.Windows.Forms.TextBox txtStringAddAfter;
        private System.Windows.Forms.CheckBox ckbAddSingleQuotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveTextBase;
        private System.Windows.Forms.Button btnBackTextBase;
        private System.Windows.Forms.Label lblTextBaseSaveInfo;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoComma;
        private System.Windows.Forms.Label lblAutoCommaInfo;
    }
}