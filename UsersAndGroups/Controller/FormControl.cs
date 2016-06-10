using System.Windows.Forms;
using UsersAndGroups.View;

namespace UsersAndGroups.Controller
{
    public class FormControl
    {
        #region Atributes
        private TreeView _root;
        private GeneralController _control;
        private Form _thisForm;
        private Form _otherForm;
        #endregion

        #region Constructor
        public FormControl(TreeView root, Form thisForm, Form otherForm)
        {
            _thisForm = thisForm;
            _otherForm = otherForm;
            _root = root;
            _control = new GeneralController();
        }
        #endregion

        #region Public Methods
        #region NewGroup
        /// <summary>
        /// Salva o grupo criado
        /// </summary>
        /// <param name="textGroup"></param>
        /// <param name="checkCreateArq"></param>
        /// <param name="checkReadArq"></param>
        /// <param name="checkCreateDir"></param>
        /// <param name="checkReadDir"></param>
        public void SaveGroup(TextBox textGroup, CheckBox checkCreateArq, CheckBox checkReadArq, CheckBox checkCreateDir, CheckBox checkReadDir)
        {
            bool isValid = true;
            foreach (TreeNode treeNode in _root.SelectedNode.Nodes)
            {
                if (treeNode.Text.Equals(textGroup.Text))
                {
                    MessageBox.Show("Já existe um grupo com o nome escolhido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                bool[] isPermitions = new bool[] { checkCreateArq.Checked, checkReadArq.Checked, checkCreateDir.Checked, checkReadDir.Checked };
                _control.InsertNewGroup(_root, textGroup.Text, isPermitions);
                _thisForm.Close();
            }
        }
        #endregion

        #region NewUser
        /// <summary>
        /// Usuado no construtor para criação de um usuário
        /// </summary>
        /// <param name="textGroup"></param>
        /// <param name="checkCreateArq"></param>
        /// <param name="checkReadArq"></param>
        /// <param name="checkCreateDir"></param>
        /// <param name="checkReadDir"></param>
        public void NewUser(TextBox textGroup, CheckBox checkCreateArq, CheckBox checkReadArq, CheckBox checkCreateDir, CheckBox checkReadDir)
        {
            bool[] isPermitions = _control.GroupPermitions(_root);
            textGroup.Text = _root.SelectedNode.Text;
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
        /// Salva o usuário
        /// </summary>
        /// <param name="textName"></param>
        /// <param name="textPass"></param>
        /// <param name="textGroup"></param>
        public void SaveUser(TextBox textName, TextBox textPass, TextBox textGroup)
        {
            bool isValid = true;
            foreach (TreeNode treeNode in _root.SelectedNode.Nodes)
            {
                if (treeNode.Text.Equals(textName.Text))
                {
                    MessageBox.Show("Usuário com o mesmo nome no grupo selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                _control.InsertNewUser(_root, textName.Text, textPass.Text, textGroup.Text);
                _thisForm.Close();
            }
        }
        #endregion

        #region Start
        public void User()
        {
            if (_root.SelectedNode.Text == "Principal")
                MessageBox.Show("Não é possível criar um usuário fora de um grupo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_root.SelectedNode.Parent.Text != "Principal")
                MessageBox.Show("Não é possível criar um usuário dentro de outro usuário!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                NewUser newUser = new NewUser(_root);
                newUser.ShowDialog();
            }
        }
        public void Group()
        {
            if (_root.SelectedNode.Text == "Principal")
            {
                NewGroup newGroup = new NewGroup(_root);
                newGroup.ShowDialog();
            }
            else
                MessageBox.Show("Não é possível criar subgrupos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Exit()
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _thisForm.Hide();
                _otherForm.Show();
            }
        }
        public void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente exluir o que foi selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _control.Delete(_root);
            }
        }
        #endregion
        #endregion
    }
}
