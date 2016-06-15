namespace UsersAndGroups.View
{
    using System;
    using System.Windows.Forms;

    using UsersAndGroups.Controller;

    public partial class NewGroup : Form
    {
        private readonly FormControl _form;

        public NewGroup(TreeView root)
        {
            this.InitializeComponent();
            this._form = new FormControl(root, this, this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._form.SaveGroup(
                this.textGroup, 
                this.checkCreateArq, 
                this.checkReadArq, 
                this.checkCreateDir, 
                this.checkReadDir);
        }
    }
}