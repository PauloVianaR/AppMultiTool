
namespace AppMultiTool.MainForms
{
    partial class WppBot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMsg = new System.Windows.Forms.TextBox();
            txtTelefone = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtContato = new System.Windows.Forms.TextBox();
            chkUseTel = new System.Windows.Forms.CheckBox();
            chkUseCont = new System.Windows.Forms.CheckBox();
            btnEnviar = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolLogErros = new System.Windows.Forms.ToolStripMenuItem();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.Location = new System.Drawing.Point(130, 150);
            txtMsg.Name = "txtMsg";
            txtMsg.ReadOnly = true;
            txtMsg.Size = new System.Drawing.Size(607, 23);
            txtMsg.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new System.Drawing.Point(130, 204);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new System.Drawing.Size(607, 23);
            txtTelefone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Mensagem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(305, 70);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 52);
            button1.TabIndex = 4;
            button1.Text = "Link WPP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 264);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Contatos/Grupos";
            // 
            // txtContato
            // 
            txtContato.Location = new System.Drawing.Point(130, 264);
            txtContato.Name = "txtContato";
            txtContato.ReadOnly = true;
            txtContato.Size = new System.Drawing.Size(607, 23);
            txtContato.TabIndex = 6;
            // 
            // chkUseTel
            // 
            chkUseTel.AutoSize = true;
            chkUseTel.Enabled = false;
            chkUseTel.Location = new System.Drawing.Point(130, 325);
            chkUseTel.Name = "chkUseTel";
            chkUseTel.Size = new System.Drawing.Size(101, 19);
            chkUseTel.TabIndex = 7;
            chkUseTel.Text = "Usar Telefone?";
            chkUseTel.UseVisualStyleBackColor = true;
            chkUseTel.CheckedChanged += chkUseTel_CheckedChanged;
            // 
            // chkUseCont
            // 
            chkUseCont.AutoSize = true;
            chkUseCont.Enabled = false;
            chkUseCont.Location = new System.Drawing.Point(305, 325);
            chkUseCont.Name = "chkUseCont";
            chkUseCont.Size = new System.Drawing.Size(148, 19);
            chkUseCont.TabIndex = 8;
            chkUseCont.Text = "Usar Contatos/Grupos?";
            chkUseCont.UseVisualStyleBackColor = true;
            chkUseCont.CheckedChanged += chkUseCont_CheckedChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEnviar.Location = new System.Drawing.Point(305, 366);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new System.Drawing.Size(170, 52);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar!";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Visible = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolLogErros, voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolLogErros
            // 
            toolLogErros.Name = "toolLogErros";
            toolLogErros.Size = new System.Drawing.Size(68, 20);
            toolLogErros.Text = "Log Erros";
            toolLogErros.Click += toolLogErros_Click;
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
            lblTitle.Location = new System.Drawing.Point(338, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(115, 30);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "WhatsBot";
            // 
            // WppBot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnEnviar);
            Controls.Add(chkUseCont);
            Controls.Add(chkUseTel);
            Controls.Add(txtContato);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtMsg);
            Controls.Add(menuStrip1);
            Name = "WppBot";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.CheckBox chkUseTel;
        private System.Windows.Forms.CheckBox chkUseCont;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolLogErros;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}

