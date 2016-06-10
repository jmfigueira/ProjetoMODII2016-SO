using System;
using System.Windows.Forms;
using UsersAndGroups.Controller;

namespace UsersAndGroups.View
{
    public partial class Start : Form
    {
        private FormControl _control;

        public Start(Form login)
        {
            InitializeComponent();
            _control = new FormControl(this.root, this, login);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            _control.User();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            _control.Group();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            _control.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _control.Delete();
        }
    }
}
