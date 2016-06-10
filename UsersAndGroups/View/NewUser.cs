using System;
using System.Windows.Forms;
using UsersAndGroups.Controller;

namespace UsersAndGroups.View
{
    public partial class NewUser : Form
    {
        private FormControl _control;

        public NewUser(TreeView root)
        {
            InitializeComponent();
            _control = new FormControl(root, this, this);
            _control.NewUser(textGroup, checkCreateArq, checkReadArq, checkCreateDir, checkReadDir);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _control.SaveUser(textName, textPass, textGroup);
        }
    }
}
