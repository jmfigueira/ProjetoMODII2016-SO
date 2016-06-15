namespace NodeFS.View
{
    using System;
    using System.Windows.Forms;

    using NodeFS.Controller;

    public partial class NewFile : Form
    {
        private readonly FormControl _control;

        private readonly string _userName;

        public NewFile(
            TreeView root, 
            string nameArq, 
            string txtArq, 
            bool[] lstPerm, 
            bool isEdit, 
            bool isPermit, 
            string userName)
        {
            this.InitializeComponent();
            this._control = new FormControl(root, null, this);
            this._userName = userName;
            this._control.EditableFile(
                nameArq, 
                this.textArqName, 
                this.textArq, 
                this.chLeitura, 
                this.chEscrita, 
                this.chExecucao, 
                lstPerm, 
                txtArq, 
                this.btnSave, 
                isEdit, 
                isPermit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._control.CreateOrEditFile(
                this.btnSave, 
                this.textArqName, 
                this.chLeitura, 
                this.chEscrita, 
                this.chExecucao, 
                this.textArq, 
                this._userName);
        }
    }
}