
namespace AppMultiTool.MainForms
{
    partial class JoyStickController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoyStickController));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraçõesDispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            numSensibility = new System.Windows.Forms.NumericUpDown();
            lblSensibiltyThreshold = new System.Windows.Forms.Label();
            lblUnconnectedMsg = new System.Windows.Forms.Label();
            lsbSites = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cbbLTModo = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            lblConectionStatus = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cbbDeviceType = new System.Windows.Forms.ComboBox();
            lsbPlayedNotes = new System.Windows.Forms.ListBox();
            label8 = new System.Windows.Forms.Label();
            waveTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSensibility).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem, configuraçõesDispositivoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(648, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += VoltarToolStripMenuItem_Click;
            // 
            // configuraçõesDispositivoToolStripMenuItem
            // 
            configuraçõesDispositivoToolStripMenuItem.Name = "configuraçõesDispositivoToolStripMenuItem";
            configuraçõesDispositivoToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            configuraçõesDispositivoToolStripMenuItem.Text = "Configurações Dispositivo";
            configuraçõesDispositivoToolStripMenuItem.Click += ConfigsToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(11, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 21);
            label1.TabIndex = 1;
            label1.Text = "Controle do PC por controlador externo";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(73, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(206, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Joystick Controller";
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.GreenYellow;
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnStart.Location = new System.Drawing.Point(11, 525);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(144, 46);
            btnStart.TabIndex = 3;
            btnStart.Text = "Iniciar Controle";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.DarkRed;
            btnStop.Enabled = false;
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnStop.Location = new System.Drawing.Point(189, 525);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(138, 46);
            btnStop.TabIndex = 4;
            btnStop.Text = "Parar Controle";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // numSensibility
            // 
            numSensibility.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numSensibility.Location = new System.Drawing.Point(123, 217);
            numSensibility.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSensibility.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSensibility.Name = "numSensibility";
            numSensibility.Size = new System.Drawing.Size(204, 23);
            numSensibility.TabIndex = 5;
            numSensibility.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblSensibiltyThreshold
            // 
            lblSensibiltyThreshold.AutoSize = true;
            lblSensibiltyThreshold.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSensibiltyThreshold.Location = new System.Drawing.Point(12, 217);
            lblSensibiltyThreshold.Name = "lblSensibiltyThreshold";
            lblSensibiltyThreshold.Size = new System.Drawing.Size(105, 21);
            lblSensibiltyThreshold.TabIndex = 6;
            lblSensibiltyThreshold.Text = "Sensibilidade:";
            // 
            // lblUnconnectedMsg
            // 
            lblUnconnectedMsg.AutoSize = true;
            lblUnconnectedMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUnconnectedMsg.ForeColor = System.Drawing.Color.Red;
            lblUnconnectedMsg.Location = new System.Drawing.Point(5, 114);
            lblUnconnectedMsg.Name = "lblUnconnectedMsg";
            lblUnconnectedMsg.Size = new System.Drawing.Size(328, 15);
            lblUnconnectedMsg.TabIndex = 7;
            lblUnconnectedMsg.Text = "AVISO: NÃO FOI POSSÍVEL ENCONTRAR UM DISPOSITIVO";
            lblUnconnectedMsg.Visible = false;
            // 
            // lsbSites
            // 
            lsbSites.Font = new System.Drawing.Font("Segoe UI", 12F);
            lsbSites.FormattingEnabled = true;
            lsbSites.ItemHeight = 21;
            lsbSites.Items.AddRange(new object[] { "Google", "Youtube", "Crunchyroll", "Netflix", "Prime Video", "Max", "Disney+" });
            lsbSites.Location = new System.Drawing.Point(12, 315);
            lsbSites.Name = "lsbSites";
            lsbSites.Size = new System.Drawing.Size(315, 193);
            lsbSites.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(11, 287);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 25);
            label4.TabIndex = 9;
            label4.Text = "Sites Botão Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(12, 252);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 21);
            label5.TabIndex = 12;
            label5.Text = "Modo LT:";
            label5.MouseHover += ShowLTModoInfo_MouseHover;
            // 
            // cbbLTModo
            // 
            cbbLTModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbLTModo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            cbbLTModo.FormattingEnabled = true;
            cbbLTModo.Items.AddRange(new object[] { "Controle Volume", "Controle Sensibilidade" });
            cbbLTModo.Location = new System.Drawing.Point(123, 252);
            cbbLTModo.Name = "cbbLTModo";
            cbbLTModo.Size = new System.Drawing.Size(204, 23);
            cbbLTModo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(12, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 21);
            label6.TabIndex = 14;
            label6.Text = "Status:";
            // 
            // lblConectionStatus
            // 
            lblConectionStatus.AutoSize = true;
            lblConectionStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblConectionStatus.ForeColor = System.Drawing.Color.DarkRed;
            lblConectionStatus.Location = new System.Drawing.Point(119, 144);
            lblConectionStatus.Name = "lblConectionStatus";
            lblConectionStatus.Size = new System.Drawing.Size(132, 25);
            lblConectionStatus.TabIndex = 15;
            lblConectionStatus.Text = "Desconectado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            label7.Location = new System.Drawing.Point(12, 181);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 21);
            label7.TabIndex = 16;
            label7.Text = "Controlador:";
            // 
            // cbbDeviceType
            // 
            cbbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            cbbDeviceType.FormattingEnabled = true;
            cbbDeviceType.Items.AddRange(new object[] { "Controle Xbox", "Instrumento musical" });
            cbbDeviceType.Location = new System.Drawing.Point(123, 181);
            cbbDeviceType.Name = "cbbDeviceType";
            cbbDeviceType.Size = new System.Drawing.Size(204, 23);
            cbbDeviceType.TabIndex = 17;
            cbbDeviceType.SelectedIndexChanged += CBBDeviceType_SelectedIndexChanged;
            // 
            // lsbPlayedNotes
            // 
            lsbPlayedNotes.FormattingEnabled = true;
            lsbPlayedNotes.ItemHeight = 15;
            lsbPlayedNotes.Location = new System.Drawing.Point(350, 73);
            lsbPlayedNotes.Name = "lsbPlayedNotes";
            lsbPlayedNotes.Size = new System.Drawing.Size(286, 499);
            lsbPlayedNotes.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(350, 50);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(118, 21);
            label8.TabIndex = 19;
            label8.Text = "Notas tocadas";
            // 
            // waveTimer
            // 
            waveTimer.Tick += WaveTimer_Tick;
            // 
            // JoyStickController
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(648, 591);
            Controls.Add(label8);
            Controls.Add(lsbPlayedNotes);
            Controls.Add(cbbDeviceType);
            Controls.Add(label7);
            Controls.Add(lblConectionStatus);
            Controls.Add(label6);
            Controls.Add(cbbLTModo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lsbSites);
            Controls.Add(lblUnconnectedMsg);
            Controls.Add(lblSensibiltyThreshold);
            Controls.Add(numSensibility);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new System.Drawing.Size(664, 630);
            MinimumSize = new System.Drawing.Size(355, 630);
            Name = "JoyStickController";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosing += JoyStickController_FormClosing;
            FormClosed += JoyStickController_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSensibility).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown numSensibility;
        private System.Windows.Forms.Label lblSensibiltyThreshold;
        private System.Windows.Forms.Label lblUnconnectedMsg;
        private System.Windows.Forms.ListBox lsbSites;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLTModo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblConectionStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbDeviceType;
        private System.Windows.Forms.ListBox lsbPlayedNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDispositivoToolStripMenuItem;
        private System.Windows.Forms.Timer waveTimer;
    }
}