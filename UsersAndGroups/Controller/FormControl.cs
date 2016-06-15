namespace UsersAndGroups.Controller
{
    using System.Windows.Forms;

    using UsersAndGroups.View;

    /// <summary>
    ///     The form control.
    /// </summary>
    public class FormControl
    {
        private readonly GeneralController _control;

        private readonly Form _otherForm;

        private readonly TreeView _root;

        private readonly Form _thisForm;

        public FormControl(TreeView root, Form thisForm, Form otherForm)
        {
            this._thisForm = thisForm;
            this._otherForm = otherForm;
            this._root = root;
            this._control = new GeneralController();
        }

        public void Delete()
        {
            var dialogResult = MessageBox.Show(
                "Deseja realmente exluir o que foi selecionado?", 
                "Atenção!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this._control.Delete(this._root);
            }
        }

        public void Exit()
        {
            var dialogResult = MessageBox.Show(
                "Deseja realmente sair?", 
                "Atenção!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this._thisForm.Hide();
                this._otherForm.Show();
            }
        }

        public void Group()
        {
            if (this._root.SelectedNode.Text == "Principal")
            {
                var newGroup = new NewGroup(this._root);
                newGroup.ShowDialog();
            }
            else MessageBox.Show("Não é possível criar subgrupos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Usuado no construtor para criação de um usuário
        /// </summary>
        /// <param name="textGroup"></param>
        /// <param name="checkCreateArq"></param>
        /// <param name="checkReadArq"></param>
        /// <param name="checkCreateDir"></param>
        /// <param name="checkReadDir"></param>
        public void NewUser(
            TextBox textGroup, 
            CheckBox checkCreateArq, 
            CheckBox checkReadArq, 
            CheckBox checkCreateDir, 
            CheckBox checkReadDir)
        {
            var isPermitions = this._control.GroupPermitions(this._root);
            textGroup.Text = this._root.SelectedNode.Text;
            textGroup.Enabled = false;
            checkCreateArq.Checked = isPermitions[0];
            checkCreateArq.Enabled = false;
            checkReadArq.Checked = isPermitions[1];
            checkReadArq.Enabled = false;
            checkCreateDir.Checked = isPermitions[2];
            checkCreateDir.Enabled = false;
            checkReadDir.Checked = isPermitions[3];
            checkReadDir.Enabled = false;
        }

        /// <summary>
        ///     Salva o grupo criado
        /// </summary>
        /// <param name="textGroup"></param>
        /// <param name="checkCreateArq"></param>
        /// <param name="checkReadArq"></param>
        /// <param name="checkCreateDir"></param>
        /// <param name="checkReadDir"></param>
        public void SaveGroup(
            TextBox textGroup, 
            CheckBox checkCreateArq, 
            CheckBox checkReadArq, 
            CheckBox checkCreateDir, 
            CheckBox checkReadDir)
        {
            var isValid = true;
            foreach (TreeNode treeNode in this._root.SelectedNode.Nodes)
            {
                if (treeNode.Text.Equals(textGroup.Text))
                {
                    MessageBox.Show(
                        "Já existe um grupo com o nome escolhido!", 
                        "Erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                bool[] isPermitions =
                    {
                        checkCreateArq.Checked, checkReadArq.Checked, checkCreateDir.Checked, 
                        checkReadDir.Checked
                    };
                this._control.InsertNewGroup(this._root, textGroup.Text, isPermitions);
                this._thisForm.Close();
            }
        }

        /// <summary>
        ///     Salva o usuário
        /// </summary>
        /// <param name="textName"></param>
        /// <param name="textPass"></param>
        /// <param name="textGroup"></param>
        public void SaveUser(TextBox textName, TextBox textPass, TextBox textGroup)
        {
            var isValid = true;
            foreach (TreeNode treeNode in this._root.SelectedNode.Nodes)
            {
                if (treeNode.Text.Equals(textName.Text))
                {
                    MessageBox.Show(
                        "Usuário com o mesmo nome no grupo selecionado!", 
                        "Erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                this._control.InsertNewUser(this._root, textName.Text, textPass.Text, textGroup.Text);
                this._thisForm.Close();
            }
        }

        public void User()
        {
            if (this._root.SelectedNode.Text == "Principal")
                MessageBox.Show(
                    "Não é possível criar um usuário fora de um grupo!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            else if (this._root.SelectedNode.Parent.Text != "Principal")
                MessageBox.Show(
                    "Não é possível criar um usuário dentro de outro usuário!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            else
            {
                var newUser = new NewUser(this._root);
                newUser.ShowDialog();
            }
        }
    }
}