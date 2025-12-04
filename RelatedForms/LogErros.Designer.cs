
namespace AppMultiTool.RelatedForms
{
    partial class LogErros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolWpp = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtAnotacoesErros = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWpp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolWpp
            // 
            this.toolWpp.Name = "toolWpp";
            this.toolWpp.Size = new System.Drawing.Size(73, 20);
            this.toolWpp.Text = "Whats Bot";
            this.toolWpp.Click += new System.EventHandler(this.toolWpp_Click);
            // 
            // rtxtAnotacoesErros
            // 
            this.rtxtAnotacoesErros.Location = new System.Drawing.Point(12, 105);
            this.rtxtAnotacoesErros.Name = "rtxtAnotacoesErros";
            this.rtxtAnotacoesErros.ReadOnly = true;
            this.rtxtAnotacoesErros.Size = new System.Drawing.Size(878, 633);
            this.rtxtAnotacoesErros.TabIndex = 1;
            this.rtxtAnotacoesErros.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Erros Recentes";
            // 
            // LogErros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 763);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtAnotacoesErros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogErros";
            this.Text = "Log de Erros";
            this.Load += new System.EventHandler(this.LogErros_Load);
            this.TextChanged += new System.EventHandler(this.LogErros_TextChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolWpp;
        private System.Windows.Forms.RichTextBox rtxtAnotacoesErros;
        private System.Windows.Forms.Label label1;
    }
}