
namespace AppMultiTool.MainForms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lblTitle = new System.Windows.Forms.Label();
            lblPickApp = new System.Windows.Forms.Label();
            btnWppBot = new System.Windows.Forms.Button();
            btnClipboardCopies = new System.Windows.Forms.Button();
            btnVideoConverter = new System.Windows.Forms.Button();
            btnGPTMessenger = new System.Windows.Forms.Button();
            btnVideoAudioDownloader = new System.Windows.Forms.Button();
            btnCPFUsings = new System.Windows.Forms.Button();
            btnConvertText = new System.Windows.Forms.Button();
            btnSSConvert = new System.Windows.Forms.Button();
            btnStartsJobsRoutine = new System.Windows.Forms.Button();
            btnJoyStickController = new System.Windows.Forms.Button();
            btnPlaylistMaker = new System.Windows.Forms.Button();
            btnDateCalculator = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            tsmiConfigs = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCommandLine = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(191, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(215, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Aplicativo Utilitário";
            // 
            // lblPickApp
            // 
            lblPickApp.AutoSize = true;
            lblPickApp.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblPickApp.Location = new System.Drawing.Point(175, 63);
            lblPickApp.Name = "lblPickApp";
            lblPickApp.Size = new System.Drawing.Size(248, 21);
            lblPickApp.TabIndex = 1;
            lblPickApp.Text = "Escolha um das aplicações abaixo: ";
            // 
            // btnWppBot
            // 
            btnWppBot.BackColor = System.Drawing.SystemColors.Control;
            btnWppBot.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnWppBot.Location = new System.Drawing.Point(9, 13);
            btnWppBot.Name = "btnWppBot";
            btnWppBot.Size = new System.Drawing.Size(258, 49);
            btnWppBot.TabIndex = 2;
            btnWppBot.Text = "Whats Bot ";
            btnWppBot.UseVisualStyleBackColor = false;
            btnWppBot.Click += btnWppBot_Click;
            // 
            // btnClipboardCopies
            // 
            btnClipboardCopies.BackColor = System.Drawing.SystemColors.Control;
            btnClipboardCopies.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnClipboardCopies.Location = new System.Drawing.Point(9, 84);
            btnClipboardCopies.Name = "btnClipboardCopies";
            btnClipboardCopies.Size = new System.Drawing.Size(258, 49);
            btnClipboardCopies.TabIndex = 3;
            btnClipboardCopies.Text = "Cópias para área de transferência";
            btnClipboardCopies.UseVisualStyleBackColor = false;
            btnClipboardCopies.Click += btnClipboardCopies_Click;
            // 
            // btnVideoConverter
            // 
            btnVideoConverter.BackColor = System.Drawing.SystemColors.Control;
            btnVideoConverter.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnVideoConverter.Location = new System.Drawing.Point(9, 155);
            btnVideoConverter.Name = "btnVideoConverter";
            btnVideoConverter.Size = new System.Drawing.Size(258, 55);
            btnVideoConverter.TabIndex = 4;
            btnVideoConverter.Text = "Conversor de Arquivos de Mídia";
            btnVideoConverter.UseVisualStyleBackColor = false;
            btnVideoConverter.Click += btnMediaConverter_Click;
            // 
            // btnGPTMessenger
            // 
            btnGPTMessenger.BackColor = System.Drawing.SystemColors.Control;
            btnGPTMessenger.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnGPTMessenger.Location = new System.Drawing.Point(9, 239);
            btnGPTMessenger.Name = "btnGPTMessenger";
            btnGPTMessenger.Size = new System.Drawing.Size(258, 49);
            btnGPTMessenger.TabIndex = 5;
            btnGPTMessenger.Text = "Chat GPT";
            btnGPTMessenger.UseVisualStyleBackColor = false;
            btnGPTMessenger.Click += btnGPTMessenger_click;
            // 
            // btnVideoAudioDownloader
            // 
            btnVideoAudioDownloader.BackColor = System.Drawing.SystemColors.Control;
            btnVideoAudioDownloader.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnVideoAudioDownloader.Location = new System.Drawing.Point(301, 239);
            btnVideoAudioDownloader.Name = "btnVideoAudioDownloader";
            btnVideoAudioDownloader.Size = new System.Drawing.Size(258, 49);
            btnVideoAudioDownloader.TabIndex = 6;
            btnVideoAudioDownloader.Text = "Baixar Vídeo/Áudio da Internet";
            btnVideoAudioDownloader.UseVisualStyleBackColor = false;
            btnVideoAudioDownloader.Click += btnVideoAudioDownloader_Click;
            // 
            // btnCPFUsings
            // 
            btnCPFUsings.BackColor = System.Drawing.SystemColors.Control;
            btnCPFUsings.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnCPFUsings.Location = new System.Drawing.Point(9, 320);
            btnCPFUsings.Name = "btnCPFUsings";
            btnCPFUsings.Size = new System.Drawing.Size(258, 52);
            btnCPFUsings.TabIndex = 7;
            btnCPFUsings.Text = "Gerador e Validador CPF e CNPJ";
            btnCPFUsings.UseVisualStyleBackColor = false;
            btnCPFUsings.Click += btnCPFUsings_Click;
            // 
            // btnConvertText
            // 
            btnConvertText.BackColor = System.Drawing.SystemColors.Control;
            btnConvertText.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnConvertText.Location = new System.Drawing.Point(9, 405);
            btnConvertText.Name = "btnConvertText";
            btnConvertText.Size = new System.Drawing.Size(258, 49);
            btnConvertText.TabIndex = 8;
            btnConvertText.Text = "Conversor de Texto";
            btnConvertText.UseVisualStyleBackColor = false;
            btnConvertText.Click += btnConvertText_Click;
            // 
            // btnSSConvert
            // 
            btnSSConvert.BackColor = System.Drawing.SystemColors.Control;
            btnSSConvert.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnSSConvert.Location = new System.Drawing.Point(301, 84);
            btnSSConvert.Name = "btnSSConvert";
            btnSSConvert.Size = new System.Drawing.Size(258, 49);
            btnSSConvert.TabIndex = 9;
            btnSSConvert.Text = "Planilha Conversora";
            btnSSConvert.UseVisualStyleBackColor = false;
            btnSSConvert.Click += btnSSConvert_Click;
            // 
            // btnStartsJobsRoutine
            // 
            btnStartsJobsRoutine.BackColor = System.Drawing.SystemColors.Control;
            btnStartsJobsRoutine.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnStartsJobsRoutine.Location = new System.Drawing.Point(301, 320);
            btnStartsJobsRoutine.Name = "btnStartsJobsRoutine";
            btnStartsJobsRoutine.Size = new System.Drawing.Size(258, 52);
            btnStartsJobsRoutine.TabIndex = 10;
            btnStartsJobsRoutine.Text = "Rotina";
            btnStartsJobsRoutine.UseVisualStyleBackColor = false;
            btnStartsJobsRoutine.Click += btnStartsJobsRoutine_Click;
            // 
            // btnJoyStickController
            // 
            btnJoyStickController.BackColor = System.Drawing.SystemColors.Control;
            btnJoyStickController.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnJoyStickController.Location = new System.Drawing.Point(301, 155);
            btnJoyStickController.Name = "btnJoyStickController";
            btnJoyStickController.Size = new System.Drawing.Size(258, 55);
            btnJoyStickController.TabIndex = 11;
            btnJoyStickController.Text = "JoyStick Controller";
            btnJoyStickController.UseVisualStyleBackColor = false;
            btnJoyStickController.Click += btnJoyStickController_Click;
            // 
            // btnPlaylistMaker
            // 
            btnPlaylistMaker.BackColor = System.Drawing.SystemColors.Control;
            btnPlaylistMaker.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnPlaylistMaker.Location = new System.Drawing.Point(301, 13);
            btnPlaylistMaker.Name = "btnPlaylistMaker";
            btnPlaylistMaker.Size = new System.Drawing.Size(258, 49);
            btnPlaylistMaker.TabIndex = 12;
            btnPlaylistMaker.Text = "Playlist Maker";
            btnPlaylistMaker.UseVisualStyleBackColor = false;
            btnPlaylistMaker.Click += btnPlaylistMaker_Click;
            // 
            // btnDateCalculator
            // 
            btnDateCalculator.BackColor = System.Drawing.SystemColors.Control;
            btnDateCalculator.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnDateCalculator.Location = new System.Drawing.Point(301, 402);
            btnDateCalculator.Name = "btnDateCalculator";
            btnDateCalculator.Size = new System.Drawing.Size(258, 52);
            btnDateCalculator.TabIndex = 13;
            btnDateCalculator.Text = "Calculador de Datas";
            btnDateCalculator.UseVisualStyleBackColor = false;
            btnDateCalculator.Click += btnDateCalculator_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiOptions });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(595, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiConfigs, tsmiCommandLine });
            tsmiOptions.Name = "tsmiOptions";
            tsmiOptions.Size = new System.Drawing.Size(59, 20);
            tsmiOptions.Text = "Opções";
            // 
            // tsmiConfigs
            // 
            tsmiConfigs.Name = "tsmiConfigs";
            tsmiConfigs.Size = new System.Drawing.Size(180, 22);
            tsmiConfigs.Text = "Configurações";
            tsmiConfigs.Click += tsmiConfigs_Click;
            // 
            // tsmiCommandLine
            // 
            tsmiCommandLine.Name = "tsmiCommandLine";
            tsmiCommandLine.Size = new System.Drawing.Size(180, 22);
            tsmiCommandLine.Text = "Linha de Comando";
            tsmiCommandLine.Click += tsmiCommandLine_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btnDateCalculator);
            panel1.Controls.Add(btnWppBot);
            panel1.Controls.Add(btnPlaylistMaker);
            panel1.Controls.Add(btnClipboardCopies);
            panel1.Controls.Add(btnJoyStickController);
            panel1.Controls.Add(btnVideoConverter);
            panel1.Controls.Add(btnStartsJobsRoutine);
            panel1.Controls.Add(btnGPTMessenger);
            panel1.Controls.Add(btnSSConvert);
            panel1.Controls.Add(btnVideoAudioDownloader);
            panel1.Controls.Add(btnConvertText);
            panel1.Controls.Add(btnCPFUsings);
            panel1.Location = new System.Drawing.Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(572, 468);
            panel1.TabIndex = 15;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(595, 568);
            Controls.Add(panel1);
            Controls.Add(lblPickApp);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new System.Drawing.Size(611, 607);
            MinimumSize = new System.Drawing.Size(611, 607);
            Name = "MainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += MenuInicial_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPickApp;
        private System.Windows.Forms.Button btnWppBot;
        private System.Windows.Forms.Button btnClipboardCopies;
        private System.Windows.Forms.Button btnVideoConverter;
        private System.Windows.Forms.Button btnGPTMessenger;
        private System.Windows.Forms.Button btnVideoAudioDownloader;
        private System.Windows.Forms.Button btnCPFUsings;
        private System.Windows.Forms.Button btnConvertText;
        private System.Windows.Forms.Button btnSSConvert;
        private System.Windows.Forms.Button btnStartsJobsRoutine;
        private System.Windows.Forms.Button btnJoyStickController;
        private System.Windows.Forms.Button btnPlaylistMaker;
        private System.Windows.Forms.Button btnDateCalculator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigs;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommandLine;
    }
}