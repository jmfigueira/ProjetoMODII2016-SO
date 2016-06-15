namespace UsersAndGroups.View
{
    using System;
    using System.Windows.Forms;

    using UsersAndGroups.Controller;

    public partial class Start : Form
    {
        private readonly FormControl _control;

        public Start(Form login)
        {
            this.InitializeComponent();
            this._control = new FormControl(this.root, this, login);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._control.Delete();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            this._control.Group();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this._control.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this._control.User();
        }
    }
}