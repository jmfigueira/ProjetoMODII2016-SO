using NodeFS.Controller;
using System;
using System.Windows.Forms;

namespace NodeFS.View
{
    public partial class NewDirectory : Form
    {
        private FormControl _control;
        private string _userName;

        public NewDirectory(TreeView root, string userName)
        {
            InitializeComponent();
            _control = new FormControl(root, null, this);
            _control.DefineDirectory(textDir);
            _userName = userName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _control.SaveDirectory(checkRead, checkWrite, checkExec, textName.Text, _userName);
        }
    }
}
