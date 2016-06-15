namespace NodeFS.View
{
    using System;
    using System.Windows.Forms;

    using NodeFS.Controller;

    public partial class NewDirectory : Form
    {
        private readonly FormControl _control;

        private readonly string _userName;

        public NewDirectory(TreeView root, string userName)
        {
            this.InitializeComponent();
            this._control = new FormControl(root, null, this);
            this._control.DefineDirectory(this.textDir);
            this._userName = userName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this._control.SaveDirectory(
                this.checkRead, 
                this.checkWrite, 
                this.checkExec, 
                this.textName.Text, 
                this._userName);
        }
    }
}