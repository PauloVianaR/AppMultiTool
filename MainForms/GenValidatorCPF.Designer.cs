
namespace AppMultiTool.MainForms
{
    partial class GenValidatorCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenValidatorCPF));
            label1 = new System.Windows.Forms.Label();
            txtCPFGerated = new System.Windows.Forms.TextBox();
            chbGerarPont = new System.Windows.Forms.CheckBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnGenerate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtCPFVal = new System.Windows.Forms.TextBox();
            btnValidateCPF = new System.Windows.Forms.Button();
            lblValidCPF = new System.Windows.Forms.Label();
            lblInvalidCPF = new System.Windows.Forms.Label();
            btnGenCNPJ = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            txtCNPJGerated = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lblInvalidCNPJ = new System.Windows.Forms.Label();
            lblValidCNPJ = new System.Windows.Forms.Label();
            btnValidateCNPJ = new System.Windows.Forms.Button();
            txtCNPJVal = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(46, 90);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 31);
            label1.TabIndex = 0;
            label1.Text = "GERADOR DE CPF";
            // 
            // txtCPFGerated
            // 
            txtCPFGerated.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            txtCPFGerated.Location = new System.Drawing.Point(23, 179);
            txtCPFGerated.Name = "txtCPFGerated";
            txtCPFGerated.ReadOnly = true;
            txtCPFGerated.Size = new System.Drawing.Size(241, 32);
            txtCPFGerated.TabIndex = 1;
            txtCPFGerated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbGerarPont
            // 
            chbGerarPont.AutoSize = true;
            chbGerarPont.Checked = true;
            chbGerarPont.CheckState = System.Windows.Forms.CheckState.Checked;
            chbGerarPont.Cursor = System.Windows.Forms.Cursors.Hand;
            chbGerarPont.Location = new System.Drawing.Point(23, 137);
            chbGerarPont.Name = "chbGerarPont";
            chbGerarPont.Size = new System.Drawing.Size(146, 19);
            chbGerarPont.TabIndex = 2;
            chbGerarPont.Text = "Gerar com pontuação?";
            chbGerarPont.UseVisualStyleBackColor = true;
            chbGerarPont.CheckedChanged += chbGerarPont_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(670, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = System.Drawing.Color.PaleGreen;
            btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnGenerate.Location = new System.Drawing.Point(23, 231);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(128, 33);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "GERAR";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(38, 313);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(226, 31);
            label2.TabIndex = 5;
            label2.Text = "VALIDADOR DE CPF";
            // 
            // txtCPFVal
            // 
            txtCPFVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            txtCPFVal.Location = new System.Drawing.Point(23, 372);
            txtCPFVal.Name = "txtCPFVal";
            txtCPFVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCPFVal.Size = new System.Drawing.Size(241, 32);
            txtCPFVal.TabIndex = 6;
            txtCPFVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtCPFVal.TextChanged += txtCPFVal_TextChanged;
            txtCPFVal.KeyPress += txtCPFVal_KeyPress;
            // 
            // btnValidateCPF
            // 
            btnValidateCPF.BackColor = System.Drawing.Color.Tan;
            btnValidateCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnValidateCPF.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnValidateCPF.Location = new System.Drawing.Point(23, 429);
            btnValidateCPF.Name = "btnValidateCPF";
            btnValidateCPF.Size = new System.Drawing.Size(128, 33);
            btnValidateCPF.TabIndex = 7;
            btnValidateCPF.Text = "VALIDAR";
            btnValidateCPF.UseVisualStyleBackColor = false;
            btnValidateCPF.Click += btnValidateCPF_Click;
            // 
            // lblValidCPF
            // 
            lblValidCPF.AutoSize = true;
            lblValidCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            lblValidCPF.ForeColor = System.Drawing.Color.DarkOliveGreen;
            lblValidCPF.Location = new System.Drawing.Point(157, 436);
            lblValidCPF.Name = "lblValidCPF";
            lblValidCPF.Size = new System.Drawing.Size(100, 21);
            lblValidCPF.TabIndex = 8;
            lblValidCPF.Text = "CPF VÁLIDO";
            lblValidCPF.Visible = false;
            // 
            // lblInvalidCPF
            // 
            lblInvalidCPF.AutoSize = true;
            lblInvalidCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            lblInvalidCPF.ForeColor = System.Drawing.Color.DarkRed;
            lblInvalidCPF.Location = new System.Drawing.Point(157, 436);
            lblInvalidCPF.Name = "lblInvalidCPF";
            lblInvalidCPF.Size = new System.Drawing.Size(118, 21);
            lblInvalidCPF.TabIndex = 9;
            lblInvalidCPF.Text = "CPF INVÁLIDO";
            lblInvalidCPF.Visible = false;
            // 
            // btnGenCNPJ
            // 
            btnGenCNPJ.BackColor = System.Drawing.Color.PaleGreen;
            btnGenCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenCNPJ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnGenCNPJ.Location = new System.Drawing.Point(374, 231);
            btnGenCNPJ.Name = "btnGenCNPJ";
            btnGenCNPJ.Size = new System.Drawing.Size(128, 33);
            btnGenCNPJ.TabIndex = 13;
            btnGenCNPJ.Text = "GERAR";
            btnGenCNPJ.UseVisualStyleBackColor = false;
            btnGenCNPJ.Click += btnGenCNPJ_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBox1.Location = new System.Drawing.Point(374, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(146, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Gerar com pontuação?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtCNPJGerated
            // 
            txtCNPJGerated.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            txtCNPJGerated.Location = new System.Drawing.Point(374, 179);
            txtCNPJGerated.Name = "txtCNPJGerated";
            txtCNPJGerated.ReadOnly = true;
            txtCNPJGerated.Size = new System.Drawing.Size(262, 32);
            txtCNPJGerated.TabIndex = 11;
            txtCNPJGerated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(397, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(217, 31);
            label3.TabIndex = 10;
            label3.Text = "GERADOR DE CNPJ";
            // 
            // lblInvalidCNPJ
            // 
            lblInvalidCNPJ.AutoSize = true;
            lblInvalidCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            lblInvalidCNPJ.ForeColor = System.Drawing.Color.DarkRed;
            lblInvalidCNPJ.Location = new System.Drawing.Point(507, 436);
            lblInvalidCNPJ.Name = "lblInvalidCNPJ";
            lblInvalidCNPJ.Size = new System.Drawing.Size(129, 21);
            lblInvalidCNPJ.TabIndex = 18;
            lblInvalidCNPJ.Text = "CNPJ INVÁLIDO";
            lblInvalidCNPJ.Visible = false;
            // 
            // lblValidCNPJ
            // 
            lblValidCNPJ.AutoSize = true;
            lblValidCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            lblValidCNPJ.ForeColor = System.Drawing.Color.DarkOliveGreen;
            lblValidCNPJ.Location = new System.Drawing.Point(507, 436);
            lblValidCNPJ.Name = "lblValidCNPJ";
            lblValidCNPJ.Size = new System.Drawing.Size(111, 21);
            lblValidCNPJ.TabIndex = 17;
            lblValidCNPJ.Text = "CNPJ VÁLIDO";
            lblValidCNPJ.Visible = false;
            // 
            // btnValidateCNPJ
            // 
            btnValidateCNPJ.BackColor = System.Drawing.Color.Tan;
            btnValidateCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnValidateCNPJ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnValidateCNPJ.Location = new System.Drawing.Point(373, 429);
            btnValidateCNPJ.Name = "btnValidateCNPJ";
            btnValidateCNPJ.Size = new System.Drawing.Size(128, 33);
            btnValidateCNPJ.TabIndex = 16;
            btnValidateCNPJ.Text = "VALIDAR";
            btnValidateCNPJ.UseVisualStyleBackColor = false;
            btnValidateCNPJ.Click += btnValidateCNPJ_Click;
            // 
            // txtCNPJVal
            // 
            txtCNPJVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            txtCNPJVal.Location = new System.Drawing.Point(373, 372);
            txtCNPJVal.Name = "txtCNPJVal";
            txtCNPJVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCNPJVal.Size = new System.Drawing.Size(263, 32);
            txtCNPJVal.TabIndex = 15;
            txtCNPJVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtCNPJVal.TextChanged += txtCNPJVal_TextChanged;
            txtCNPJVal.KeyPress += txtCNPJVal_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(388, 313);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(240, 31);
            label6.TabIndex = 14;
            label6.Text = "VALIDADOR DE CNPJ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(187, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(267, 31);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "GERADOR DE CPF/CNPJ";
            // 
            // GenValidatorCPF
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(670, 500);
            Controls.Add(lblTitle);
            Controls.Add(lblInvalidCNPJ);
            Controls.Add(lblValidCNPJ);
            Controls.Add(btnValidateCNPJ);
            Controls.Add(txtCNPJVal);
            Controls.Add(label6);
            Controls.Add(btnGenCNPJ);
            Controls.Add(checkBox1);
            Controls.Add(txtCNPJGerated);
            Controls.Add(label3);
            Controls.Add(lblInvalidCPF);
            Controls.Add(lblValidCPF);
            Controls.Add(btnValidateCPF);
            Controls.Add(txtCPFVal);
            Controls.Add(label2);
            Controls.Add(btnGenerate);
            Controls.Add(chbGerarPont);
            Controls.Add(txtCPFGerated);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "GenValidatorCPF";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += GenValidatorCPF_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFGerated;
        private System.Windows.Forms.CheckBox chbGerarPont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPFVal;
        private System.Windows.Forms.Button btnValidateCPF;
        private System.Windows.Forms.Label lblValidCPF;
        private System.Windows.Forms.Label lblInvalidCPF;
        private System.Windows.Forms.Button btnGenCNPJ;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtCNPJGerated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvalidCNPJ;
        private System.Windows.Forms.Label lblValidCNPJ;
        private System.Windows.Forms.Button btnValidateCNPJ;
        private System.Windows.Forms.TextBox txtCNPJVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
    }
}