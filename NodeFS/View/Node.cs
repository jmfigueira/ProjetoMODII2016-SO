using NodeFS.Controller;
using System;
using System.Windows.Forms;

namespace NodeFS.View
{
    public partial class Node : Form
    {
        private FormControl _control;

        public void SetName(string name)
        {
            lblLogin.Text = name;
        }

        public Node(Form form)
        {
            InitializeComponent();
            _control = new FormControl(this.root, form, this);
            //bloquear o diretório para leitura  para outros usuários caso o usuário que criou tenha marcado leitura = false
            //O mesmo aplica-se as outras ideias
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            _control.Directory(lblLogin.Text);
        }

        private void btnArq_Click(object sender, EventArgs e)
        {
            _control.File(lblLogin.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _control.Edit(lblLogin.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _control.Delete(lblLogin.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _control.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _control.View(lblLogin.Text);
        }
    }
}
