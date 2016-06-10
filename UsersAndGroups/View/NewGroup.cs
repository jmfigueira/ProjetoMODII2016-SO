using System;
using System.Windows.Forms;
using UsersAndGroups.Controller;

namespace UsersAndGroups.View
{
    public partial class NewGroup : Form
    {
        private FormControl _form;

        public NewGroup(TreeView root)
        {
            InitializeComponent();
            _form = new FormControl(root, this, this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _form.SaveGroup(textGroup, checkCreateArq, checkReadArq, checkCreateDir, checkReadDir);
        }
    }
}
