
namespace AppMultiTool.MainForms
{
    partial class GPTMessenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPTMessenger));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            rtxtPrompt = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            rtxtResponse = new System.Windows.Forms.RichTextBox();
            btnSend = new System.Windows.Forms.Button();
            lblCopyResponse = new System.Windows.Forms.Label();
            lblCopyInfo = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            rdbGPT3 = new System.Windows.Forms.RadioButton();
            rdbHuggingFace = new System.Windows.Forms.RadioButton();
            rdbGemini = new System.Windows.Forms.RadioButton();
            rdbGPT4 = new System.Windows.Forms.RadioButton();
            rdbDeepSeek = new System.Windows.Forms.RadioButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(937, 24);
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
            lblTitle.Location = new System.Drawing.Point(338, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(110, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Chat GPT";
            // 
            // rtxtPrompt
            // 
            rtxtPrompt.Font = new System.Drawing.Font("Segoe UI", 12F);
            rtxtPrompt.Location = new System.Drawing.Point(12, 81);
            rtxtPrompt.Name = "rtxtPrompt";
            rtxtPrompt.Size = new System.Drawing.Size(776, 96);
            rtxtPrompt.TabIndex = 2;
            rtxtPrompt.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(13, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 21);
            label2.TabIndex = 3;
            label2.Text = "Prompt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(12, 205);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 21);
            label3.TabIndex = 4;
            label3.Text = "Resposta";
            // 
            // rtxtResponse
            // 
            rtxtResponse.Font = new System.Drawing.Font("Segoe UI", 12F);
            rtxtResponse.Location = new System.Drawing.Point(12, 229);
            rtxtResponse.Name = "rtxtResponse";
            rtxtResponse.ReadOnly = true;
            rtxtResponse.Size = new System.Drawing.Size(776, 575);
            rtxtResponse.TabIndex = 5;
            rtxtResponse.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = System.Drawing.Color.YellowGreen;
            btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSend.Location = new System.Drawing.Point(690, 183);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(98, 28);
            btnSend.TabIndex = 6;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblCopyResponse
            // 
            lblCopyResponse.AutoSize = true;
            lblCopyResponse.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCopyResponse.ForeColor = System.Drawing.Color.DarkRed;
            lblCopyResponse.Location = new System.Drawing.Point(82, 210);
            lblCopyResponse.Name = "lblCopyResponse";
            lblCopyResponse.Size = new System.Drawing.Size(111, 15);
            lblCopyResponse.TabIndex = 7;
            lblCopyResponse.Text = "(Clique para copiar)";
            lblCopyResponse.Click += lblCopyResponse_Click;
            // 
            // lblCopyInfo
            // 
            lblCopyInfo.AutoSize = true;
            lblCopyInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCopyInfo.ForeColor = System.Drawing.Color.OliveDrab;
            lblCopyInfo.Location = new System.Drawing.Point(199, 210);
            lblCopyInfo.Name = "lblCopyInfo";
            lblCopyInfo.Size = new System.Drawing.Size(76, 15);
            lblCopyInfo.TabIndex = 8;
            lblCopyInfo.Text = "COPIADO ✔";
            lblCopyInfo.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(807, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 21);
            label4.TabIndex = 9;
            label4.Text = "API Usada:";
            // 
            // rdbGPT3
            // 
            rdbGPT3.AutoSize = true;
            rdbGPT3.Location = new System.Drawing.Point(807, 115);
            rdbGPT3.Name = "rdbGPT3";
            rdbGPT3.Size = new System.Drawing.Size(98, 19);
            rdbGPT3.TabIndex = 1;
            rdbGPT3.Text = "GPT 3.5 Turbo";
            rdbGPT3.UseVisualStyleBackColor = true;
            // 
            // rdbHuggingFace
            // 
            rdbHuggingFace.AutoSize = true;
            rdbHuggingFace.Location = new System.Drawing.Point(807, 165);
            rdbHuggingFace.Name = "rdbHuggingFace";
            rdbHuggingFace.Size = new System.Drawing.Size(99, 19);
            rdbHuggingFace.TabIndex = 3;
            rdbHuggingFace.Text = "Hugging Face";
            rdbHuggingFace.UseVisualStyleBackColor = true;
            // 
            // rdbGemini
            // 
            rdbGemini.AutoSize = true;
            rdbGemini.Checked = true;
            rdbGemini.Location = new System.Drawing.Point(807, 190);
            rdbGemini.Name = "rdbGemini";
            rdbGemini.Size = new System.Drawing.Size(120, 19);
            rdbGemini.TabIndex = 4;
            rdbGemini.TabStop = true;
            rdbGemini.Text = "Gemini (Vertex AI)";
            rdbGemini.UseVisualStyleBackColor = true;
            // 
            // rdbGPT4
            // 
            rdbGPT4.AutoSize = true;
            rdbGPT4.Location = new System.Drawing.Point(807, 140);
            rdbGPT4.Name = "rdbGPT4";
            rdbGPT4.Size = new System.Drawing.Size(91, 19);
            rdbGPT4.TabIndex = 2;
            rdbGPT4.Text = "GPT 4.0 Mini";
            rdbGPT4.UseVisualStyleBackColor = true;
            // 
            // rdbDeepSeek
            // 
            rdbDeepSeek.AutoSize = true;
            rdbDeepSeek.Location = new System.Drawing.Point(807, 215);
            rdbDeepSeek.Name = "rdbDeepSeek";
            rdbDeepSeek.Size = new System.Drawing.Size(76, 19);
            rdbDeepSeek.TabIndex = 5;
            rdbDeepSeek.TabStop = true;
            rdbDeepSeek.Text = "DeepSeek";
            rdbDeepSeek.UseVisualStyleBackColor = true;
            // 
            // GPTMessenger
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(937, 816);
            Controls.Add(rdbGPT4);
            Controls.Add(rdbGemini);
            Controls.Add(rdbHuggingFace);
            Controls.Add(rdbGPT3);
            Controls.Add(rdbDeepSeek);
            Controls.Add(label4);
            Controls.Add(lblCopyInfo);
            Controls.Add(lblCopyResponse);
            Controls.Add(btnSend);
            Controls.Add(rtxtResponse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rtxtPrompt);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "GPTMessenger";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AppMultiTool";
            FormClosed += GPTMessenger_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtxtPrompt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtResponse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblCopyResponse;
        private System.Windows.Forms.Label lblCopyInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbGPT3;
        private System.Windows.Forms.RadioButton rdbHuggingFace;
        private System.Windows.Forms.RadioButton rdbGemini;
        private System.Windows.Forms.RadioButton rdbGPT4;
        private System.Windows.Forms.RadioButton rdbDeepSeek;
    }
}