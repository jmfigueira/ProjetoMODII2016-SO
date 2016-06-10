namespace NodeFS.View
{
    partial class NewFile
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
            this.textArq = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textArqName = new System.Windows.Forms.TextBox();
            this.chLeitura = new System.Windows.Forms.CheckBox();
            this.chEscrita = new System.Windows.Forms.CheckBox();
            this.chExecucao = new System.Windows.Forms.CheckBox();
            this.lblPerm = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textArq
            // 
            this.textArq.Location = new System.Drawing.Point(10, 66);
            this.textArq.Multiline = true;
            this.textArq.Name = "textArq";
            this.textArq.Size = new System.Drawing.Size(260, 209);
            this.textArq.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textArqName
            // 
            this.textArqName.Location = new System.Drawing.Point(10, 23);
            this.textArqName.Name = "textArqName";
            this.textArqName.Size = new System.Drawing.Size(260, 20);
            this.textArqName.TabIndex = 2;
            // 
            // chLeitura
            // 
            this.chLeitura.AutoSize = true;
            this.chLeitura.Location = new System.Drawing.Point(12, 294);
            this.chLeitura.Name = "chLeitura";
            this.chLeitura.Size = new System.Drawing.Size(58, 17);
            this.chLeitura.TabIndex = 3;
            this.chLeitura.Text = "Leitura";
            this.chLeitura.UseVisualStyleBackColor = true;
            // 
            // chEscrita
            // 
            this.chEscrita.AutoSize = true;
            this.chEscrita.Location = new System.Drawing.Point(12, 317);
            this.chEscrita.Name = "chEscrita";
            this.chEscrita.Size = new System.Drawing.Size(58, 17);
            this.chEscrita.TabIndex = 4;
            this.chEscrita.Text = "Escrita";
            this.chEscrita.UseVisualStyleBackColor = true;
            // 
            // chExecucao
            // 
            this.chExecucao.AutoSize = true;
            this.chExecucao.Location = new System.Drawing.Point(12, 338);
            this.chExecucao.Name = "chExecucao";
            this.chExecucao.Size = new System.Drawing.Size(74, 17);
            this.chExecucao.TabIndex = 5;
            this.chExecucao.Text = "Execução";
            this.chExecucao.UseVisualStyleBackColor = true;
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.Location = new System.Drawing.Point(7, 278);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(63, 13);
            this.lblPerm.TabIndex = 6;
            this.lblPerm.Text = "Permissões:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 13);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Texto:";
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 367);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPerm);
            this.Controls.Add(this.chExecucao);
            this.Controls.Add(this.chEscrita);
            this.Controls.Add(this.chLeitura);
            this.Controls.Add(this.textArqName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textArq);
            this.MaximizeBox = false;
            this.Name = "NewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textArq;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textArqName;
        private System.Windows.Forms.CheckBox chLeitura;
        private System.Windows.Forms.CheckBox chEscrita;
        private System.Windows.Forms.CheckBox chExecucao;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblText;
    }
}