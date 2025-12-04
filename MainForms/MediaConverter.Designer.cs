
namespace AppMultiTool.MainForms
{
    partial class MediaConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaConverter));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblFolderName = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            btnGetVideoToConvert = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            cbbFormatPicker = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtExitPath = new System.Windows.Forms.TextBox();
            btnSwitchExitPath = new System.Windows.Forms.Button();
            fbdExitPathPicker = new System.Windows.Forms.FolderBrowserDialog();
            btnConvert = new System.Windows.Forms.Button();
            lblObsFormat = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbbConversionType = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            rdbFinalTime = new System.Windows.Forms.RadioButton();
            rdbDuration = new System.Windows.Forms.RadioButton();
            label8 = new System.Windows.Forms.Label();
            txtFinalTime = new System.Windows.Forms.TextBox();
            txtStartTime = new System.Windows.Forms.TextBox();
            ckbCutAudio = new System.Windows.Forms.CheckBox();
            numDuration = new System.Windows.Forms.NumericUpDown();
            lblDuration = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(592, 24);
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
            // lblFolderName
            // 
            lblFolderName.AutoEllipsis = true;
            lblFolderName.AutoSize = true;
            lblFolderName.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblFolderName.Location = new System.Drawing.Point(19, 74);
            lblFolderName.Name = "lblFolderName";
            lblFolderName.Size = new System.Drawing.Size(226, 25);
            lblFolderName.TabIndex = 1;
            lblFolderName.Text = "Nenhum arquivo escolhido";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(119, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(341, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Conversor de arquivos de mídia";
            // 
            // btnGetVideoToConvert
            // 
            btnGetVideoToConvert.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnGetVideoToConvert.Location = new System.Drawing.Point(22, 102);
            btnGetVideoToConvert.Name = "btnGetVideoToConvert";
            btnGetVideoToConvert.Size = new System.Drawing.Size(124, 28);
            btnGetVideoToConvert.TabIndex = 3;
            btnGetVideoToConvert.Text = "Escolher arquivo";
            btnGetVideoToConvert.UseVisualStyleBackColor = true;
            btnGetVideoToConvert.Click += btnGetVideoToConvert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            label3.Location = new System.Drawing.Point(3, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 25);
            label3.TabIndex = 4;
            label3.Text = "Formato de saída:";
            // 
            // cbbFormatPicker
            // 
            cbbFormatPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbFormatPicker.FormattingEnabled = true;
            cbbFormatPicker.Items.AddRange(new object[] { "Selecione" });
            cbbFormatPicker.Location = new System.Drawing.Point(167, 104);
            cbbFormatPicker.Name = "cbbFormatPicker";
            cbbFormatPicker.Size = new System.Drawing.Size(130, 23);
            cbbFormatPicker.TabIndex = 5;
            cbbFormatPicker.SelectedIndexChanged += PickMediaFormat;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            label4.Location = new System.Drawing.Point(19, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(158, 25);
            label4.TabIndex = 6;
            label4.Text = "Caminho de saída:";
            // 
            // txtExitPath
            // 
            txtExitPath.Location = new System.Drawing.Point(183, 155);
            txtExitPath.Name = "txtExitPath";
            txtExitPath.ReadOnly = true;
            txtExitPath.Size = new System.Drawing.Size(388, 23);
            txtExitPath.TabIndex = 7;
            // 
            // btnSwitchExitPath
            // 
            btnSwitchExitPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSwitchExitPath.Location = new System.Drawing.Point(22, 182);
            btnSwitchExitPath.Name = "btnSwitchExitPath";
            btnSwitchExitPath.Size = new System.Drawing.Size(150, 28);
            btnSwitchExitPath.TabIndex = 8;
            btnSwitchExitPath.Text = "Alterar caminho saída";
            btnSwitchExitPath.UseVisualStyleBackColor = true;
            btnSwitchExitPath.Click += btnSwitchExitPath_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = System.Drawing.Color.Green;
            btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConvert.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnConvert.Location = new System.Drawing.Point(202, 683);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(158, 48);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "CONVERTER";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblObsFormat
            // 
            lblObsFormat.AutoSize = true;
            lblObsFormat.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblObsFormat.ForeColor = System.Drawing.Color.Red;
            lblObsFormat.Location = new System.Drawing.Point(303, 112);
            lblObsFormat.Name = "lblObsFormat";
            lblObsFormat.Size = new System.Drawing.Size(254, 15);
            lblObsFormat.TabIndex = 10;
            lblObsFormat.Text = "* o novo formato deve ser diferente do original";
            lblObsFormat.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            label1.Location = new System.Drawing.Point(3, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 25);
            label1.TabIndex = 12;
            label1.Text = "Tipo de conversão:";
            // 
            // cbbConversionType
            // 
            cbbConversionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbConversionType.FormattingEnabled = true;
            cbbConversionType.Items.AddRange(new object[] { "Selecione", "VIDEO para VIDEO", "VIDEO para AUDIO", "AUDIO para AUDIO" });
            cbbConversionType.Location = new System.Drawing.Point(167, 54);
            cbbConversionType.Name = "cbbConversionType";
            cbbConversionType.Size = new System.Drawing.Size(130, 23);
            cbbConversionType.TabIndex = 13;
            cbbConversionType.SelectedIndexChanged += PickConversionType;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbbConversionType);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblObsFormat);
            panel1.Controls.Add(cbbFormatPicker);
            panel1.Location = new System.Drawing.Point(12, 223);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(568, 155);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Blue;
            label5.Location = new System.Drawing.Point(219, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 25);
            label5.TabIndex = 15;
            label5.Text = "Conversor";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(rdbFinalTime);
            panel2.Controls.Add(rdbDuration);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtFinalTime);
            panel2.Controls.Add(txtStartTime);
            panel2.Controls.Add(ckbCutAudio);
            panel2.Controls.Add(numDuration);
            panel2.Controls.Add(lblDuration);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new System.Drawing.Point(12, 389);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(568, 283);
            panel2.TabIndex = 15;
            // 
            // rdbFinalTime
            // 
            rdbFinalTime.AutoSize = true;
            rdbFinalTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            rdbFinalTime.Location = new System.Drawing.Point(14, 95);
            rdbFinalTime.Name = "rdbFinalTime";
            rdbFinalTime.Size = new System.Drawing.Size(246, 24);
            rdbFinalTime.TabIndex = 28;
            rdbFinalTime.Text = "Tempo final em minutos:segudos";
            rdbFinalTime.UseVisualStyleBackColor = true;
            rdbFinalTime.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rdbDuration
            // 
            rdbDuration.AutoSize = true;
            rdbDuration.Checked = true;
            rdbDuration.Font = new System.Drawing.Font("Segoe UI", 11F);
            rdbDuration.Location = new System.Drawing.Point(14, 74);
            rdbDuration.Name = "rdbDuration";
            rdbDuration.Size = new System.Drawing.Size(175, 24);
            rdbDuration.TabIndex = 27;
            rdbDuration.TabStop = true;
            rdbDuration.Text = "Duração em segundos";
            rdbDuration.UseVisualStyleBackColor = true;
            rdbDuration.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            label8.Location = new System.Drawing.Point(9, 50);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(98, 25);
            label8.TabIndex = 26;
            label8.Text = "Cortar por:";
            // 
            // txtFinalTime
            // 
            txtFinalTime.Font = new System.Drawing.Font("Segoe UI", 13F);
            txtFinalTime.Location = new System.Drawing.Point(162, 178);
            txtFinalTime.Name = "txtFinalTime";
            txtFinalTime.PlaceholderText = "0:00";
            txtFinalTime.Size = new System.Drawing.Size(395, 31);
            txtFinalTime.TabIndex = 25;
            txtFinalTime.Visible = false;
            // 
            // txtStartTime
            // 
            txtStartTime.Font = new System.Drawing.Font("Segoe UI", 13F);
            txtStartTime.Location = new System.Drawing.Point(162, 139);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.PlaceholderText = "0:00";
            txtStartTime.ReadOnly = true;
            txtStartTime.Size = new System.Drawing.Size(395, 31);
            txtStartTime.TabIndex = 22;
            txtStartTime.Text = "0:00";
            // 
            // ckbCutAudio
            // 
            ckbCutAudio.AutoSize = true;
            ckbCutAudio.Font = new System.Drawing.Font("Segoe UI", 13F);
            ckbCutAudio.Location = new System.Drawing.Point(9, 234);
            ckbCutAudio.Name = "ckbCutAudio";
            ckbCutAudio.Size = new System.Drawing.Size(138, 29);
            ckbCutAudio.TabIndex = 21;
            ckbCutAudio.Text = "Cortar áudio?";
            ckbCutAudio.UseVisualStyleBackColor = true;
            ckbCutAudio.CheckedChanged += ckbCutAudio_CheckedChanged;
            // 
            // numDuration
            // 
            numDuration.Font = new System.Drawing.Font("Segoe UI", 13F);
            numDuration.Location = new System.Drawing.Point(162, 179);
            numDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new System.Drawing.Size(395, 31);
            numDuration.TabIndex = 20;
            numDuration.ValueChanged += numDuration_ValueChanged;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblDuration.Location = new System.Drawing.Point(6, 178);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(105, 25);
            lblDuration.TabIndex = 18;
            lblDuration.Text = "Duração (s):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            label7.Location = new System.Drawing.Point(6, 142);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(159, 25);
            label7.TabIndex = 17;
            label7.Text = "Começar em (m:s):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.Blue;
            label6.Location = new System.Drawing.Point(219, 11);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 25);
            label6.TabIndex = 16;
            label6.Text = "Cortador";
            // 
            // MediaConverter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(592, 743);
            Controls.Add(panel2);
            Controls.Add(lblFolderName);
            Controls.Add(panel1);
            Controls.Add(btnGetVideoToConvert);
            Controls.Add(btnConvert);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Controls.Add(txtExitPath);
            Controls.Add(btnSwitchExitPath);
            Controls.Add(label4);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(608, 2000);
            Name = "MediaConverter";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += VideoConverter_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGetVideoToConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbFormatPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExitPath;
        private System.Windows.Forms.Button btnSwitchExitPath;
        private System.Windows.Forms.FolderBrowserDialog fbdExitPathPicker;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblObsFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbConversionType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbCutAudio;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtFinalTime;
        private System.Windows.Forms.RadioButton rdbDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbFinalTime;
    }
}