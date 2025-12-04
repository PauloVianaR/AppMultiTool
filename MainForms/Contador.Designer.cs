
namespace AppMultiTool.MainForms
{
    partial class Contador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contador));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtInput1 = new System.Windows.Forms.TextBox();
            txtInput2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnContar = new System.Windows.Forms.Button();
            pgbBarra = new System.Windows.Forms.ProgressBar();
            lblTimeTotal = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            timerMy = new System.Windows.Forms.Timer(components);
            label5 = new System.Windows.Forms.Label();
            lblCurrentValue = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(516, 24);
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
            lblTitle.Location = new System.Drawing.Point(196, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(110, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Contador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(185, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade a contar: ";
            // 
            // txtInput1
            // 
            txtInput1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            txtInput1.Location = new System.Drawing.Point(42, 123);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new System.Drawing.Size(176, 23);
            txtInput1.TabIndex = 3;
            txtInput1.Text = "0";
            txtInput1.TextChanged += txtInput1_TextChanged;
            // 
            // txtInput2
            // 
            txtInput2.Location = new System.Drawing.Point(273, 123);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new System.Drawing.Size(185, 23);
            txtInput2.TabIndex = 4;
            txtInput2.Text = "1000";
            txtInput2.TextChanged += txtInput2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(20, 15);
            label3.TabIndex = 5;
            label3.Text = "de";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(234, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 15);
            label4.TabIndex = 6;
            label4.Text = "até";
            // 
            // btnContar
            // 
            btnContar.BackColor = System.Drawing.Color.DarkGreen;
            btnContar.FlatAppearance.BorderSize = 0;
            btnContar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnContar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            btnContar.ForeColor = System.Drawing.Color.White;
            btnContar.Location = new System.Drawing.Point(289, 188);
            btnContar.Name = "btnContar";
            btnContar.Size = new System.Drawing.Size(151, 41);
            btnContar.TabIndex = 7;
            btnContar.Text = "CONTAR!";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // pgbBarra
            // 
            pgbBarra.Location = new System.Drawing.Point(12, 284);
            pgbBarra.Name = "pgbBarra";
            pgbBarra.Size = new System.Drawing.Size(492, 23);
            pgbBarra.TabIndex = 8;
            pgbBarra.Visible = false;
            // 
            // lblTimeTotal
            // 
            lblTimeTotal.AutoSize = true;
            lblTimeTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTimeTotal.Location = new System.Drawing.Point(12, 404);
            lblTimeTotal.Name = "lblTimeTotal";
            lblTimeTotal.Size = new System.Drawing.Size(146, 30);
            lblTimeTotal.TabIndex = 9;
            lblTimeTotal.Text = "Tempo Total:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTime.Location = new System.Drawing.Point(164, 404);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(0, 30);
            lblTime.TabIndex = 10;
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.Red;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(55, 188);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(151, 41);
            btnReset.TabIndex = 11;
            btnReset.Text = "RESETAR";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // timerMy
            // 
            timerMy.Interval = 1000;
            timerMy.Tick += timerMy_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(12, 352);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(133, 30);
            label5.TabIndex = 12;
            label5.Text = "Valor Atual:";
            // 
            // lblCurrentValue
            // 
            lblCurrentValue.AutoSize = true;
            lblCurrentValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblCurrentValue.Location = new System.Drawing.Point(151, 352);
            lblCurrentValue.Name = "lblCurrentValue";
            lblCurrentValue.Size = new System.Drawing.Size(26, 30);
            lblCurrentValue.TabIndex = 13;
            lblCurrentValue.Text = "0";
            // 
            // Contador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 476);
            Controls.Add(lblCurrentValue);
            Controls.Add(label5);
            Controls.Add(btnReset);
            Controls.Add(lblTime);
            Controls.Add(lblTimeTotal);
            Controls.Add(pgbBarra);
            Controls.Add(btnContar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Contador";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += Contador_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Label lblTimeTotal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timerMy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentValue;
    }
}