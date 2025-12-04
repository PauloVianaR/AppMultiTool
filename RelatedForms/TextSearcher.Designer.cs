namespace AppMultiTool.RelatedForms
{
    partial class TextSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSearcher));
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            txtSearchText = new System.Windows.Forms.TextBox();
            lsbItems = new System.Windows.Forms.ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(12, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(222, 30);
            label1.TabIndex = 0;
            label1.Text = "Buscar textos salvos";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(913, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // txtSearchText
            // 
            txtSearchText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearchText.Location = new System.Drawing.Point(12, 57);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.PlaceholderText = "Filtrar...";
            txtSearchText.Size = new System.Drawing.Size(889, 23);
            txtSearchText.TabIndex = 2;
            txtSearchText.TextChanged += txtSearchText_TextChanged;
            // 
            // lsbItems
            // 
            lsbItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lsbItems.Cursor = System.Windows.Forms.Cursors.Hand;
            lsbItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            lsbItems.ForeColor = System.Drawing.SystemColors.HotTrack;
            lsbItems.FormattingEnabled = true;
            lsbItems.ItemHeight = 21;
            lsbItems.Location = new System.Drawing.Point(12, 86);
            lsbItems.Name = "lsbItems";
            lsbItems.Size = new System.Drawing.Size(889, 655);
            lsbItems.TabIndex = 3;
            lsbItems.DoubleClick += lsbItems_DoubleClick;
            // 
            // TextSearcher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(913, 764);
            Controls.Add(lsbItems);
            Controls.Add(txtSearchText);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TextSearcher";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            Load += TextSearcher_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ListBox lsbItems;
    }
}