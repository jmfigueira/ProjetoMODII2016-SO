namespace UsersAndGroups.View
{
    partial class Start
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Principal");
            this.root = new System.Windows.Forms.TreeView();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(12, 12);
            this.root.Name = "root";
            treeNode1.Name = "Root";
            treeNode1.Text = "Principal";
            this.root.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.root.Size = new System.Drawing.Size(351, 252);
            this.root.TabIndex = 0;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(369, 12);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(81, 23);
            this.btnGroup.TabIndex = 2;
            this.btnGroup.Text = "Novo Grupo";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(369, 41);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(81, 23);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Novo Usuário";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(369, 99);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos e Usuários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView root;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDelete;
    }
}

