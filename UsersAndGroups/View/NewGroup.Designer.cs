namespace UsersAndGroups.View
{
    partial class NewGroup
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
            this.textGroup = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.checkCreateArq = new System.Windows.Forms.CheckBox();
            this.lblPerm = new System.Windows.Forms.Label();
            this.checkReadArq = new System.Windows.Forms.CheckBox();
            this.checkReadDir = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkCreateDir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(53, 12);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(217, 20);
            this.textGroup.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // checkCreateArq
            // 
            this.checkCreateArq.AutoSize = true;
            this.checkCreateArq.Location = new System.Drawing.Point(12, 70);
            this.checkCreateArq.Name = "checkCreateArq";
            this.checkCreateArq.Size = new System.Drawing.Size(121, 17);
            this.checkCreateArq.TabIndex = 2;
            this.checkCreateArq.Text = "Criação de Arquivos";
            this.checkCreateArq.UseVisualStyleBackColor = true;
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.Location = new System.Drawing.Point(9, 54);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(63, 13);
            this.lblPerm.TabIndex = 3;
            this.lblPerm.Text = "Permissões:";
            // 
            // checkReadArq
            // 
            this.checkReadArq.AutoSize = true;
            this.checkReadArq.Location = new System.Drawing.Point(12, 93);
            this.checkReadArq.Name = "checkReadArq";
            this.checkReadArq.Size = new System.Drawing.Size(117, 17);
            this.checkReadArq.TabIndex = 4;
            this.checkReadArq.Text = "Leitura de Arquivos";
            this.checkReadArq.UseVisualStyleBackColor = true;
            // 
            // checkReadDir
            // 
            this.checkReadDir.AutoSize = true;
            this.checkReadDir.Location = new System.Drawing.Point(135, 93);
            this.checkReadDir.Name = "checkReadDir";
            this.checkReadDir.Size = new System.Drawing.Size(120, 17);
            this.checkReadDir.TabIndex = 5;
            this.checkReadDir.Text = "Leitura de Diretórios";
            this.checkReadDir.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkCreateDir
            // 
            this.checkCreateDir.AutoSize = true;
            this.checkCreateDir.Location = new System.Drawing.Point(135, 70);
            this.checkCreateDir.Name = "checkCreateDir";
            this.checkCreateDir.Size = new System.Drawing.Size(124, 17);
            this.checkCreateDir.TabIndex = 7;
            this.checkCreateDir.Text = "Criação de Diretórios";
            this.checkCreateDir.UseVisualStyleBackColor = true;
            // 
            // NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 151);
            this.Controls.Add(this.checkCreateDir);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkReadDir);
            this.Controls.Add(this.checkReadArq);
            this.Controls.Add(this.lblPerm);
            this.Controls.Add(this.checkCreateArq);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textGroup);
            this.MaximizeBox = false;
            this.Name = "NewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkCreateArq;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.CheckBox checkReadArq;
        private System.Windows.Forms.CheckBox checkReadDir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkCreateDir;
    }
}