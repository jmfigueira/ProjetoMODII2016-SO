namespace Login.View
{
    using System;
    using System.Windows.Forms;

    using Login.Controller;

    public partial class LoginP : Form
    {
        private readonly FormControl _control;

        public LoginP()
        {
            this.InitializeComponent();
            this._control = new FormControl(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this._control.Login(this.textName, this.textPass, this);
        }
    }
}