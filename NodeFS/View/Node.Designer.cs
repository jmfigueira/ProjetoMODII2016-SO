namespace NodeFS.View
{
    partial class Node
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("\\");
            this.root = new System.Windows.Forms.TreeView();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnArq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(12, 49);
            this.root.Name = "root";
            treeNode1.Name = "\\";
            treeNode1.Text = "\\";
            this.root.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.root.Size = new System.Drawing.Size(380, 237);
            this.root.TabIndex = 0;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(398, 51);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(67, 23);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "Diretório";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnArq
            // 
            this.btnArq.Location = new System.Drawing.Point(398, 80);
            this.btnArq.Name = "btnArq";
            this.btnArq.Size = new System.Drawing.Size(67, 22);
            this.btnArq.TabIndex = 3;
            this.btnArq.Text = "Arquivo";
            this.btnArq.UseVisualStyleBackColor = true;
            this.btnArq.Click += new System.EventHandler(this.btnArq_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Logado com:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(87, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 10;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(398, 137);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(67, 23);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 294);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArq);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.root);
            this.MaximizeBox = false;
            this.Name = "Node";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView root;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnArq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnView;
    }
}

