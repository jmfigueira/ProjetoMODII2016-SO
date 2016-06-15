namespace UsersAndGroups.View
{
    using System;
    using System.Windows.Forms;

    using UsersAndGroups.Controller;

    public partial class NewUser : Form
    {
        private readonly FormControl _control;

        public NewUser(TreeView root)
        {
            this.InitializeComponent();
            this._control = new FormControl(root, this, this);
            this._control.NewUser(
                this.textGroup, 
                this.checkCreateArq, 
                this.checkReadArq, 
                this.checkCreateDir, 
                this.checkReadDir);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._control.SaveUser(this.textName, this.textPass, this.textGroup);
        }
    }
}