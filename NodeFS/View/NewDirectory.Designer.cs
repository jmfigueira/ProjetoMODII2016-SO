namespace NodeFS.View
{
    partial class NewDirectory
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
            this.textName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkRead = new System.Windows.Forms.CheckBox();
            this.checkWrite = new System.Windows.Forms.CheckBox();
            this.checkExec = new System.Windows.Forms.CheckBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.textDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(50, 48);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(308, 20);
            this.textName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(283, 74);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Salvar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // checkRead
            // 
            this.checkRead.AutoSize = true;
            this.checkRead.Location = new System.Drawing.Point(14, 78);
            this.checkRead.Name = "checkRead";
            this.checkRead.Size = new System.Drawing.Size(58, 17);
            this.checkRead.TabIndex = 3;
            this.checkRead.Text = "Leitura";
            this.checkRead.UseVisualStyleBackColor = true;
            // 
            // checkWrite
            // 
            this.checkWrite.AutoSize = true;
            this.checkWrite.Location = new System.Drawing.Point(78, 78);
            this.checkWrite.Name = "checkWrite";
            this.checkWrite.Size = new System.Drawing.Size(58, 17);
            this.checkWrite.TabIndex = 4;
            this.checkWrite.Text = "Escrita";
            this.checkWrite.UseVisualStyleBackColor = true;
            // 
            // checkExec
            // 
            this.checkExec.AutoSize = true;
            this.checkExec.Location = new System.Drawing.Point(142, 78);
            this.checkExec.Name = "checkExec";
            this.checkExec.Size = new System.Drawing.Size(74, 17);
            this.checkExec.TabIndex = 5;
            this.checkExec.Text = "Execução";
            this.checkExec.UseVisualStyleBackColor = true;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(1, 23);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(49, 13);
            this.lblDir.TabIndex = 6;
            this.lblDir.Text = "Diretório:";
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(50, 20);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(308, 20);
            this.textDir.TabIndex = 7;
            // 
            // NewDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 109);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.checkExec);
            this.Controls.Add(this.checkWrite);
            this.Controls.Add(this.checkRead);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textName);
            this.MaximizeBox = false;
            this.Name = "NewDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Diretório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkRead;
        private System.Windows.Forms.CheckBox checkWrite;
        private System.Windows.Forms.CheckBox checkExec;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox textDir;
    }
}