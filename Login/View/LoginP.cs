using Login.Controller;
using System;
using System.Windows.Forms;

namespace Login.View
{
    public partial class LoginP : Form
    {
        private FormControl _control;

        public LoginP()
        {
            InitializeComponent();
            _control = new FormControl(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _control.Login(textName, textPass, this);
        }
    }
}
