
namespace AppMultiTool.MainForms
{
    partial class Routine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Routine));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            btnStartRoutine = new System.Windows.Forms.Button();
            clsbProcess = new System.Windows.Forms.CheckedListBox();
            btnDeleteProcess = new System.Windows.Forms.Button();
            btnRenameProcess = new System.Windows.Forms.Button();
            btnAttArgs = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtArgs = new System.Windows.Forms.TextBox();
            txtProcessPath = new System.Windows.Forms.TextBox();
            btnSelectProcessPath = new System.Windows.Forms.Button();
            btnInsertProcess = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblArgsInfo = new System.Windows.Forms.Label();
            lblLoading = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtProcessName = new System.Windows.Forms.TextBox();
            lblPItemStatus = new System.Windows.Forms.Label();
            chbEmailCopy = new System.Windows.Forms.CheckBox();
            lblEmailCopy = new System.Windows.Forms.Label();
            chbCloseAppAfter = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1181, 24);
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
            lblTitle.Location = new System.Drawing.Point(361, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(439, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Gerenciamento de Rotina de Inicialização";
            // 
            // btnStartRoutine
            // 
            btnStartRoutine.BackColor = System.Drawing.Color.LawnGreen;
            btnStartRoutine.Enabled = false;
            btnStartRoutine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStartRoutine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            btnStartRoutine.Location = new System.Drawing.Point(11, 588);
            btnStartRoutine.Name = "btnStartRoutine";
            btnStartRoutine.Size = new System.Drawing.Size(114, 76);
            btnStartRoutine.TabIndex = 5;
            btnStartRoutine.Text = "Iniciar Rotina";
            btnStartRoutine.UseVisualStyleBackColor = false;
            btnStartRoutine.Click += btnStartRoutine_Click;
            // 
            // clsbProcess
            // 
            clsbProcess.Font = new System.Drawing.Font("Segoe UI", 14F);
            clsbProcess.FormattingEnabled = true;
            clsbProcess.Location = new System.Drawing.Point(138, 202);
            clsbProcess.Name = "clsbProcess";
            clsbProcess.Size = new System.Drawing.Size(401, 490);
            clsbProcess.TabIndex = 6;
            clsbProcess.ItemCheck += clsbProcess_ItemCheck;
            clsbProcess.SelectedIndexChanged += clsbProcess_SelectedIndexChanged;
            // 
            // btnDeleteProcess
            // 
            btnDeleteProcess.Enabled = false;
            btnDeleteProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteProcess.Location = new System.Drawing.Point(11, 430);
            btnDeleteProcess.Name = "btnDeleteProcess";
            btnDeleteProcess.Size = new System.Drawing.Size(114, 33);
            btnDeleteProcess.TabIndex = 7;
            btnDeleteProcess.Text = "Remover";
            btnDeleteProcess.UseVisualStyleBackColor = true;
            btnDeleteProcess.Click += btnDeleteProcess_Click;
            // 
            // btnRenameProcess
            // 
            btnRenameProcess.Enabled = false;
            btnRenameProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRenameProcess.Location = new System.Drawing.Point(11, 309);
            btnRenameProcess.Name = "btnRenameProcess";
            btnRenameProcess.Size = new System.Drawing.Size(114, 33);
            btnRenameProcess.TabIndex = 8;
            btnRenameProcess.Text = "Renomear";
            btnRenameProcess.UseVisualStyleBackColor = true;
            btnRenameProcess.Click += btnRenameProcess_Click;
            // 
            // btnAttArgs
            // 
            btnAttArgs.Enabled = false;
            btnAttArgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAttArgs.Location = new System.Drawing.Point(11, 248);
            btnAttArgs.Name = "btnAttArgs";
            btnAttArgs.Size = new System.Drawing.Size(114, 40);
            btnAttArgs.TabIndex = 9;
            btnAttArgs.Text = "Atualizar";
            btnAttArgs.UseVisualStyleBackColor = true;
            btnAttArgs.Click += btnAttArgs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(27, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 25);
            label2.TabIndex = 10;
            label2.Text = "Opções";
            // 
            // txtArgs
            // 
            txtArgs.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtArgs.Location = new System.Drawing.Point(556, 202);
            txtArgs.Multiline = true;
            txtArgs.Name = "txtArgs";
            txtArgs.PlaceholderText = "(Nenhum Argumento)";
            txtArgs.Size = new System.Drawing.Size(613, 490);
            txtArgs.TabIndex = 11;
            txtArgs.TextChanged += txtArgs_TextChanged;
            // 
            // txtProcessPath
            // 
            txtProcessPath.Location = new System.Drawing.Point(138, 90);
            txtProcessPath.Name = "txtProcessPath";
            txtProcessPath.ReadOnly = true;
            txtProcessPath.Size = new System.Drawing.Size(1031, 23);
            txtProcessPath.TabIndex = 12;
            // 
            // btnSelectProcessPath
            // 
            btnSelectProcessPath.Enabled = false;
            btnSelectProcessPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectProcessPath.Location = new System.Drawing.Point(11, 90);
            btnSelectProcessPath.Name = "btnSelectProcessPath";
            btnSelectProcessPath.Size = new System.Drawing.Size(114, 23);
            btnSelectProcessPath.TabIndex = 13;
            btnSelectProcessPath.Text = "Selecionar";
            btnSelectProcessPath.UseVisualStyleBackColor = true;
            btnSelectProcessPath.Click += btnSelectProcessPath_Click;
            // 
            // btnInsertProcess
            // 
            btnInsertProcess.Enabled = false;
            btnInsertProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInsertProcess.Location = new System.Drawing.Point(11, 369);
            btnInsertProcess.Name = "btnInsertProcess";
            btnInsertProcess.Size = new System.Drawing.Size(114, 36);
            btnInsertProcess.TabIndex = 14;
            btnInsertProcess.Text = "Inserir Novo";
            btnInsertProcess.UseVisualStyleBackColor = true;
            btnInsertProcess.Click += btnInsertProcess_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(293, 174);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 25);
            label3.TabIndex = 15;
            label3.Text = "Processos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(799, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 25);
            label4.TabIndex = 16;
            label4.Text = "Argumentos";
            // 
            // lblArgsInfo
            // 
            lblArgsInfo.AutoSize = true;
            lblArgsInfo.ForeColor = System.Drawing.Color.Red;
            lblArgsInfo.Location = new System.Drawing.Point(556, 182);
            lblArgsInfo.Name = "lblArgsInfo";
            lblArgsInfo.Size = new System.Drawing.Size(229, 15);
            lblArgsInfo.TabIndex = 17;
            lblArgsInfo.Text = "(Argumento modificado e não atualizado)";
            lblArgsInfo.Visible = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLoading.ForeColor = System.Drawing.Color.Red;
            lblLoading.Location = new System.Drawing.Point(521, 54);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(88, 15);
            lblLoading.TabIndex = 18;
            lblLoading.Text = "CARREGANDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(69, 121);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 21);
            label5.TabIndex = 19;
            label5.Text = "Nome:";
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new System.Drawing.Point(138, 119);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.PlaceholderText = "(Nome do Processo)";
            txtProcessName.Size = new System.Drawing.Size(1031, 23);
            txtProcessName.TabIndex = 20;
            // 
            // lblPItemStatus
            // 
            lblPItemStatus.AutoSize = true;
            lblPItemStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblPItemStatus.ForeColor = System.Drawing.Color.DarkGreen;
            lblPItemStatus.Location = new System.Drawing.Point(138, 176);
            lblPItemStatus.Name = "lblPItemStatus";
            lblPItemStatus.Size = new System.Drawing.Size(48, 21);
            lblPItemStatus.TabIndex = 21;
            lblPItemStatus.Text = "INFO";
            lblPItemStatus.Visible = false;
            // 
            // chbEmailCopy
            // 
            chbEmailCopy.AutoSize = true;
            chbEmailCopy.Checked = true;
            chbEmailCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            chbEmailCopy.Location = new System.Drawing.Point(27, 511);
            chbEmailCopy.Name = "chbEmailCopy";
            chbEmailCopy.Size = new System.Drawing.Size(84, 19);
            chbEmailCopy.TabIndex = 22;
            chbEmailCopy.Text = "C/C Email?";
            chbEmailCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbEmailCopy.UseVisualStyleBackColor = true;
            chbEmailCopy.CheckedChanged += chbEmailCopy_CheckedChanged;
            // 
            // lblEmailCopy
            // 
            lblEmailCopy.AutoSize = true;
            lblEmailCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            lblEmailCopy.ForeColor = System.Drawing.Color.ForestGreen;
            lblEmailCopy.Location = new System.Drawing.Point(45, 533);
            lblEmailCopy.Name = "lblEmailCopy";
            lblEmailCopy.Size = new System.Drawing.Size(42, 15);
            lblEmailCopy.TabIndex = 23;
            lblEmailCopy.Text = "Copiar";
            lblEmailCopy.Visible = false;
            lblEmailCopy.Click += lblEmailCopy_Click;
            lblEmailCopy.MouseEnter += lblEmailCopy_MouseEnter;
            lblEmailCopy.MouseLeave += lblEmailCopy_MouseLeave;
            // 
            // chbCloseAppAfter
            // 
            chbCloseAppAfter.AutoSize = true;
            chbCloseAppAfter.Checked = true;
            chbCloseAppAfter.CheckState = System.Windows.Forms.CheckState.Checked;
            chbCloseAppAfter.Location = new System.Drawing.Point(27, 551);
            chbCloseAppAfter.Name = "chbCloseAppAfter";
            chbCloseAppAfter.Size = new System.Drawing.Size(96, 19);
            chbCloseAppAfter.TabIndex = 24;
            chbCloseAppAfter.Text = "Fechar Após?";
            chbCloseAppAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbCloseAppAfter.UseVisualStyleBackColor = true;
            // 
            // Routine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1181, 701);
            Controls.Add(chbCloseAppAfter);
            Controls.Add(lblEmailCopy);
            Controls.Add(chbEmailCopy);
            Controls.Add(lblPItemStatus);
            Controls.Add(txtProcessName);
            Controls.Add(label5);
            Controls.Add(lblLoading);
            Controls.Add(lblArgsInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnInsertProcess);
            Controls.Add(btnSelectProcessPath);
            Controls.Add(txtProcessPath);
            Controls.Add(txtArgs);
            Controls.Add(label2);
            Controls.Add(btnAttArgs);
            Controls.Add(btnRenameProcess);
            Controls.Add(btnDeleteProcess);
            Controls.Add(clsbProcess);
            Controls.Add(btnStartRoutine);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Routine";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Multi-Tool";
            FormClosed += Routine_FormClosed;
            Load += Routine_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartRoutine;
        private System.Windows.Forms.CheckedListBox clsbProcess;
        private System.Windows.Forms.Button btnDeleteProcess;
        private System.Windows.Forms.Button btnRenameProcess;
        private System.Windows.Forms.Button btnAttArgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArgs;
        private System.Windows.Forms.TextBox txtProcessPath;
        private System.Windows.Forms.Button btnSelectProcessPath;
        private System.Windows.Forms.Button btnInsertProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArgsInfo;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblPItemStatus;
        private System.Windows.Forms.CheckBox chbEmailCopy;
        private System.Windows.Forms.Label lblEmailCopy;
        private System.Windows.Forms.CheckBox chbCloseAppAfter;
    }
}