
namespace AppMultiTool.MainForms
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbbTimeBeforeStarts = new System.Windows.Forms.ComboBox();
            btnStop = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            numIntervalValue = new System.Windows.Forms.NumericUpDown();
            chkFindWordToClick = new System.Windows.Forms.CheckBox();
            txtPhraseToFind = new System.Windows.Forms.TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIntervalValue).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(292, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += BackToMainMenu;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(71, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(139, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Auto Clicker";
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.GreenYellow;
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnStart.Location = new System.Drawing.Point(14, 270);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(99, 35);
            btnStart.TabIndex = 2;
            btnStart.Text = "INICIAR";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += Start_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(187, 15);
            label2.TabIndex = 3;
            label2.Text = "Tempo antes de iniciar(segundos):";
            // 
            // cbbTimeBeforeStarts
            // 
            cbbTimeBeforeStarts.FormattingEnabled = true;
            cbbTimeBeforeStarts.Items.AddRange(new object[] { "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60" });
            cbbTimeBeforeStarts.Location = new System.Drawing.Point(205, 109);
            cbbTimeBeforeStarts.Name = "cbbTimeBeforeStarts";
            cbbTimeBeforeStarts.Size = new System.Drawing.Size(73, 23);
            cbbTimeBeforeStarts.TabIndex = 4;
            cbbTimeBeforeStarts.Text = "5";
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.DarkRed;
            btnStop.Enabled = false;
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnStop.Location = new System.Drawing.Point(181, 270);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(99, 35);
            btnStop.TabIndex = 5;
            btnStop.Text = "PARAR";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += Stop_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 150);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 15);
            label3.TabIndex = 6;
            label3.Text = "Intervalo tempo click(segundos):";
            // 
            // numIntervalValue
            // 
            numIntervalValue.Location = new System.Drawing.Point(205, 150);
            numIntervalValue.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numIntervalValue.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numIntervalValue.Name = "numIntervalValue";
            numIntervalValue.Size = new System.Drawing.Size(73, 23);
            numIntervalValue.TabIndex = 7;
            numIntervalValue.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // chkFindWordToClick
            // 
            chkFindWordToClick.AutoSize = true;
            chkFindWordToClick.Location = new System.Drawing.Point(12, 197);
            chkFindWordToClick.Name = "chkFindWordToClick";
            chkFindWordToClick.Size = new System.Drawing.Size(207, 19);
            chkFindWordToClick.TabIndex = 8;
            chkFindWordToClick.Text = "Clicar em palavra/frase específica?";
            chkFindWordToClick.UseVisualStyleBackColor = true;
            chkFindWordToClick.CheckedChanged += chkFindWordToClick_CheckedChanged;
            // 
            // txtPhraseToFind
            // 
            txtPhraseToFind.Location = new System.Drawing.Point(12, 222);
            txtPhraseToFind.Name = "txtPhraseToFind";
            txtPhraseToFind.PlaceholderText = "PALAVRA/FRASE PRA BUSCAR";
            txtPhraseToFind.Size = new System.Drawing.Size(266, 23);
            txtPhraseToFind.TabIndex = 9;
            txtPhraseToFind.Visible = false;
            // 
            // AutoClicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(292, 323);
            Controls.Add(txtPhraseToFind);
            Controls.Add(chkFindWordToClick);
            Controls.Add(numIntervalValue);
            Controls.Add(label3);
            Controls.Add(btnStop);
            Controls.Add(cbbTimeBeforeStarts);
            Controls.Add(label2);
            Controls.Add(btnStart);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(308, 600);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(308, 314);
            Name = "AutoClicker";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += AutoClicker_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIntervalValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTimeBeforeStarts;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numIntervalValue;
        private System.Windows.Forms.CheckBox chkFindWordToClick;
        private System.Windows.Forms.TextBox txtPhraseToFind;
    }
}