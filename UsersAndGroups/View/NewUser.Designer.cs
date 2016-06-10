namespace UsersAndGroups.View
{
    partial class NewUser
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
            this.textPass = new System.Windows.Forms.TextBox();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkCreateArq = new System.Windows.Forms.CheckBox();
            this.checkReadArq = new System.Windows.Forms.CheckBox();
            this.checkCreateDir = new System.Windows.Forms.CheckBox();
            this.lblPerm = new System.Windows.Forms.Label();
            this.checkReadDir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(57, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(360, 20);
            this.textName.TabIndex = 0;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(57, 67);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(360, 20);
            this.textPass.TabIndex = 1;
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(57, 15);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(360, 20);
            this.textGroup.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 70);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(41, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Senha:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(11, 18);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Grupo:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkCreateArq
            // 
            this.checkCreateArq.AutoSize = true;
            this.checkCreateArq.Location = new System.Drawing.Point(14, 143);
            this.checkCreateArq.Name = "checkCreateArq";
            this.checkCreateArq.Size = new System.Drawing.Size(103, 17);
            this.checkCreateArq.TabIndex = 7;
            this.checkCreateArq.Text = "Criação Aquivos";
            this.checkCreateArq.UseVisualStyleBackColor = true;
            // 
            // checkReadArq
            // 
            this.checkReadArq.AutoSize = true;
            this.checkReadArq.Location = new System.Drawing.Point(14, 166);
            this.checkReadArq.Name = "checkReadArq";
            this.checkReadArq.Size = new System.Drawing.Size(117, 17);
            this.checkReadArq.TabIndex = 8;
            this.checkReadArq.Text = "Leitura de Arquivos";
            this.checkReadArq.UseVisualStyleBackColor = true;
            // 
            // checkCreateDir
            // 
            this.checkCreateDir.AutoSize = true;
            this.checkCreateDir.Location = new System.Drawing.Point(137, 143);
            this.checkCreateDir.Name = "checkCreateDir";
            this.checkCreateDir.Size = new System.Drawing.Size(124, 17);
            this.checkCreateDir.TabIndex = 9;
            this.checkCreateDir.Text = "Criação de Diretórios";
            this.checkCreateDir.UseVisualStyleBackColor = true;
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.Location = new System.Drawing.Point(9, 110);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(63, 13);
            this.lblPerm.TabIndex = 10;
            this.lblPerm.Text = "Permissões:";
            // 
            // checkReadDir
            // 
            this.checkReadDir.AutoSize = true;
            this.checkReadDir.Location = new System.Drawing.Point(137, 166);
            this.checkReadDir.Name = "checkReadDir";
            this.checkReadDir.Size = new System.Drawing.Size(120, 17);
            this.checkReadDir.TabIndex = 11;
            this.checkReadDir.Text = "Leitura de Diretórios";
            this.checkReadDir.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 195);
            this.Controls.Add(this.checkReadDir);
            this.Controls.Add(this.lblPerm);
            this.Controls.Add(this.checkCreateDir);
            this.Controls.Add(this.checkReadArq);
            this.Controls.Add(this.checkCreateArq);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textGroup);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textName);
            this.MaximizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkCreateArq;
        private System.Windows.Forms.CheckBox checkReadArq;
        private System.Windows.Forms.CheckBox checkCreateDir;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.CheckBox checkReadDir;
    }
}