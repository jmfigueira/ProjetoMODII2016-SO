namespace NodeFS.View
{
    using System;
    using System.Windows.Forms;

    using NodeFS.Controller;

    public partial class Node : Form
    {
        private readonly FormControl _control;

        public Node(Form form)
        {
            this.InitializeComponent();
            this._control = new FormControl(this.root, form, this);

            // bloquear o diretório para leitura  para outros usuários caso o usuário que criou tenha marcado leitura = false
            // O mesmo aplica-se as outras ideias
        }

        public void SetName(string name)
        {
            this.lblLogin.Text = name;
        }

        private void btnArq_Click(object sender, EventArgs e)
        {
            this._control.File(this.lblLogin.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._control.Delete(this.lblLogin.Text);
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this._control.Directory(this.lblLogin.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this._control.Edit(this.lblLogin.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this._control.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this._control.View(this.lblLogin.Text);
        }
    }
}