using NodeFS.Controller;
using System;
using System.Windows.Forms;

namespace NodeFS.View
{
    public partial class NewFile : Form
    {
        private FormControl _control;
        private string _userName;

        public NewFile(TreeView root, string nameArq, string txtArq, bool[] lstPerm, bool isEdit, bool isPermit, string userName)
        {
            InitializeComponent();
            _control = new FormControl(root, null, this);
            _userName = userName;
            _control.EditableFile(nameArq, textArqName, textArq, chLeitura, 
                chEscrita, chExecucao, lstPerm, txtArq, btnSave, isEdit, isPermit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _control.CreateOrEditFile(btnSave, textArqName, chLeitura, chEscrita, chExecucao, textArq, _userName);
        }
    }
}
