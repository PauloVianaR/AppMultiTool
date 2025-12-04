
namespace AppMultiTool.RelatedForms
{
    partial class JoyStickConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoyStickConfigs));
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblDeviceName = new System.Windows.Forms.Label();
            txtDeviceName = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            lblChangesInfo = new System.Windows.Forms.Label();
            lblSucess = new System.Windows.Forms.Label();
            lblSampleRate = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbbSamplesRate = new System.Windows.Forms.ComboBox();
            lblChannelType = new System.Windows.Forms.Label();
            cbbChannelType = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(109, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(314, 30);
            label1.TabIndex = 0;
            label1.Text = "Configurações de Dispositivo";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(571, 24);
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
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDeviceName.Location = new System.Drawing.Point(12, 86);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new System.Drawing.Size(221, 21);
            lblDeviceName.TabIndex = 2;
            lblDeviceName.Text = "Nome do dispositivo de áudio:";
            // 
            // txtDeviceName
            // 
            txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtDeviceName.Location = new System.Drawing.Point(239, 83);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(302, 29);
            txtDeviceName.TabIndex = 3;
            txtDeviceName.TextChanged += ConfigChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.YellowGreen;
            btnSave.Enabled = false;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(208, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(118, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblChangesInfo
            // 
            lblChangesInfo.AutoSize = true;
            lblChangesInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblChangesInfo.ForeColor = System.Drawing.Color.DarkRed;
            lblChangesInfo.Location = new System.Drawing.Point(190, 54);
            lblChangesInfo.Name = "lblChangesInfo";
            lblChangesInfo.Size = new System.Drawing.Size(145, 19);
            lblChangesInfo.TabIndex = 5;
            lblChangesInfo.Text = "(alterações não salvas)";
            lblChangesInfo.Visible = false;
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSucess.ForeColor = System.Drawing.Color.OliveDrab;
            lblSucess.Location = new System.Drawing.Point(332, 247);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new System.Drawing.Size(105, 19);
            lblSucess.TabIndex = 6;
            lblSucess.Text = "Concluído! ✔";
            lblSucess.Visible = false;
            // 
            // lblSampleRate
            // 
            lblSampleRate.AutoSize = true;
            lblSampleRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSampleRate.Location = new System.Drawing.Point(12, 128);
            lblSampleRate.Name = "lblSampleRate";
            lblSampleRate.Size = new System.Drawing.Size(219, 21);
            lblSampleRate.TabIndex = 7;
            lblSampleRate.Text = "Taxa de amostragem de áudio:";
            // 
            // cbbSamplesRate
            // 
            cbbSamplesRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbSamplesRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbSamplesRate.FormattingEnabled = true;
            cbbSamplesRate.Items.AddRange(new object[] { "11025", "16000", "22050", "32000", "44100", "48000" });
            cbbSamplesRate.Location = new System.Drawing.Point(239, 125);
            cbbSamplesRate.Name = "cbbSamplesRate";
            cbbSamplesRate.Size = new System.Drawing.Size(302, 29);
            cbbSamplesRate.TabIndex = 8;
            cbbSamplesRate.SelectedIndexChanged += ConfigChanged;
            // 
            // lblChannelType
            // 
            lblChannelType.AutoSize = true;
            lblChannelType.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblChannelType.Location = new System.Drawing.Point(12, 172);
            lblChannelType.Name = "lblChannelType";
            lblChannelType.Size = new System.Drawing.Size(168, 21);
            lblChannelType.TabIndex = 9;
            lblChannelType.Text = "Tipo de canal de áudio:";
            // 
            // cbbChannelType
            // 
            cbbChannelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbChannelType.Font = new System.Drawing.Font("Segoe UI", 12F);
            cbbChannelType.FormattingEnabled = true;
            cbbChannelType.Items.AddRange(new object[] { "Mono", "Stereo" });
            cbbChannelType.Location = new System.Drawing.Point(239, 169);
            cbbChannelType.Name = "cbbChannelType";
            cbbChannelType.Size = new System.Drawing.Size(302, 29);
            cbbChannelType.TabIndex = 10;
            cbbChannelType.SelectedIndexChanged += ConfigChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(543, 128);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 21);
            label2.TabIndex = 11;
            label2.Text = "Hz";
            // 
            // JoyStickConfigs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(571, 284);
            Controls.Add(label2);
            Controls.Add(cbbChannelType);
            Controls.Add(lblChannelType);
            Controls.Add(cbbSamplesRate);
            Controls.Add(lblSampleRate);
            Controls.Add(lblSucess);
            Controls.Add(lblChangesInfo);
            Controls.Add(btnSave);
            Controls.Add(txtDeviceName);
            Controls.Add(lblDeviceName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "JoyStickConfigs";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AppMultiTool";
            Shown += JoyStickConfigs_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblChangesInfo;
        private System.Windows.Forms.Label lblSucess;
        private System.Windows.Forms.Label lblSampleRate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbSamplesRate;
        private System.Windows.Forms.Label lblChannelType;
        private System.Windows.Forms.ComboBox cbbChannelType;
        private System.Windows.Forms.Label label2;
    }
}