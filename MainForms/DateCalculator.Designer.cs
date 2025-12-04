
namespace AppMultiTool.MainForms
{
    partial class DateCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateCalculator));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numDayHours = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            numHoursToAdd = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            btnCalcDate = new System.Windows.Forms.Button();
            btnCopyResult = new System.Windows.Forms.Button();
            txtDateResult = new System.Windows.Forms.RichTextBox();
            lblCopiedText = new System.Windows.Forms.Label();
            chkSkipWeekend = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            numShortestHour = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            numLongestHour = new System.Windows.Forms.NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDayHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoursToAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShortestHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLongestHour).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(410, 24);
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
            lblTitle.Location = new System.Drawing.Point(89, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(232, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Calculadora de Datas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(12, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(209, 21);
            label2.TabIndex = 2;
            label2.Text = "Dia considerado com (horas)";
            // 
            // numDayHours
            // 
            numDayHours.Font = new System.Drawing.Font("Segoe UI", 12F);
            numDayHours.Location = new System.Drawing.Point(310, 102);
            numDayHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numDayHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDayHours.Name = "numDayHours";
            numDayHours.Size = new System.Drawing.Size(88, 29);
            numDayHours.TabIndex = 3;
            numDayHours.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 153);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(221, 21);
            label3.TabIndex = 4;
            label3.Text = "Acrescentar horas à data atual:";
            // 
            // numHoursToAdd
            // 
            numHoursToAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            numHoursToAdd.Location = new System.Drawing.Point(310, 151);
            numHoursToAdd.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numHoursToAdd.Name = "numHoursToAdd";
            numHoursToAdd.Size = new System.Drawing.Size(88, 29);
            numHoursToAdd.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(12, 351);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 21);
            label4.TabIndex = 6;
            label4.Text = "Data calculada:";
            // 
            // btnCalcDate
            // 
            btnCalcDate.BackColor = System.Drawing.Color.OliveDrab;
            btnCalcDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalcDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnCalcDate.Location = new System.Drawing.Point(12, 295);
            btnCalcDate.Name = "btnCalcDate";
            btnCalcDate.Size = new System.Drawing.Size(386, 35);
            btnCalcDate.TabIndex = 8;
            btnCalcDate.Text = "Calcular Data";
            btnCalcDate.UseVisualStyleBackColor = false;
            btnCalcDate.Click += btnCalcDate_Click;
            // 
            // btnCopyResult
            // 
            btnCopyResult.BackColor = System.Drawing.Color.Peru;
            btnCopyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnCopyResult.Location = new System.Drawing.Point(292, 461);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new System.Drawing.Size(106, 30);
            btnCopyResult.TabIndex = 9;
            btnCopyResult.Text = "Copiar";
            btnCopyResult.UseVisualStyleBackColor = false;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // txtDateResult
            // 
            txtDateResult.Location = new System.Drawing.Point(12, 375);
            txtDateResult.Name = "txtDateResult";
            txtDateResult.Size = new System.Drawing.Size(386, 69);
            txtDateResult.TabIndex = 10;
            txtDateResult.Text = "";
            // 
            // lblCopiedText
            // 
            lblCopiedText.AutoSize = true;
            lblCopiedText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCopiedText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            lblCopiedText.Location = new System.Drawing.Point(224, 471);
            lblCopiedText.Name = "lblCopiedText";
            lblCopiedText.Size = new System.Drawing.Size(55, 15);
            lblCopiedText.TabIndex = 11;
            lblCopiedText.Text = "Copiado!";
            lblCopiedText.Visible = false;
            // 
            // chkSkipWeekend
            // 
            chkSkipWeekend.AutoSize = true;
            chkSkipWeekend.Checked = true;
            chkSkipWeekend.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSkipWeekend.Location = new System.Drawing.Point(12, 255);
            chkSkipWeekend.Name = "chkSkipWeekend";
            chkSkipWeekend.Size = new System.Drawing.Size(218, 19);
            chkSkipWeekend.TabIndex = 12;
            chkSkipWeekend.Text = "Pular sábado e domingo no cálculo?";
            chkSkipWeekend.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(12, 203);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(222, 21);
            label5.TabIndex = 13;
            label5.Text = "Intervalo de horário permitido:";
            // 
            // numShortestHour
            // 
            numShortestHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            numShortestHour.Location = new System.Drawing.Point(292, 201);
            numShortestHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numShortestHour.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numShortestHour.Name = "numShortestHour";
            numShortestHour.Size = new System.Drawing.Size(40, 29);
            numShortestHour.TabIndex = 14;
            numShortestHour.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(338, 203);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(18, 21);
            label6.TabIndex = 15;
            label6.Text = "à";
            // 
            // numLongestHour
            // 
            numLongestHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            numLongestHour.Location = new System.Drawing.Point(358, 201);
            numLongestHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numLongestHour.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLongestHour.Name = "numLongestHour";
            numLongestHour.Size = new System.Drawing.Size(40, 29);
            numLongestHour.TabIndex = 16;
            numLongestHour.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // DateCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 516);
            Controls.Add(numLongestHour);
            Controls.Add(label6);
            Controls.Add(numShortestHour);
            Controls.Add(label5);
            Controls.Add(chkSkipWeekend);
            Controls.Add(lblCopiedText);
            Controls.Add(txtDateResult);
            Controls.Add(btnCopyResult);
            Controls.Add(btnCalcDate);
            Controls.Add(label4);
            Controls.Add(numHoursToAdd);
            Controls.Add(label3);
            Controls.Add(numDayHours);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "DateCalculator";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += DateCalculator_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDayHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoursToAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShortestHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLongestHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDayHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHoursToAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcDate;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.RichTextBox txtDateResult;
        private System.Windows.Forms.Label lblCopiedText;
        private System.Windows.Forms.CheckBox chkSkipWeekend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numShortestHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLongestHour;
    }
}