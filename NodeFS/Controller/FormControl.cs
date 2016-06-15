namespace NodeFS.Controller
{
    using System.Linq;
    using System.Windows.Forms;

    using NodeFS.View;

    using UsersAndGroups.Controller;

    /// <summary>
    ///     The form control.
    /// </summary>
    public class FormControl
    {
        private readonly GeneralControl _generalController;

        private readonly Form _otherForm;

        private readonly TreeView _root;

        private readonly Form _thisForm;

        private bool _isEdit;

        /// <summary>
        ///     Construtor usado para Criar Início/NewDirectory
        /// </summary>
        /// <param name="root"></param>
        /// <param name="userName"></param>
        public FormControl(TreeView root, Form otherForm, Form thisForm)
        {
            this._generalController = new GeneralControl();
            this._root = root;
            this._otherForm = otherForm;
            this._thisForm = thisForm;
        }

        /// <summary>
        ///     Cria ou edita o arquivo
        /// </summary>
        /// <param name="btnSave"></param>
        /// <param name="textArqName"></param>
        /// <param name="read"></param>
        /// <param name="write"></param>
        /// <param name="exec"></param>
        /// <param name="textArq"></param>
        /// <param name="userName"></param>
        public void CreateOrEditFile(
            Button btnSave, 
            TextBox textArqName, 
            CheckBox read, 
            CheckBox write, 
            CheckBox exec, 
            TextBox textArq, 
            string userName)
        {
            var isValid = true;

            if (btnSave.Text.Equals("Sair")) this._thisForm.Dispose();
            else
            {
                if (
                    this._root.SelectedNode.Nodes.Cast<TreeNode>()
                        .Any(treeNode => treeNode.Text.Equals(textArqName.Text)))
                {
                    MessageBox.Show(
                        "Arquivo com o mesmo nome no diretório selecionado!", 
                        "Erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    isValid = false;
                }

                if (string.IsNullOrEmpty(textArqName.Text))
                {
                    MessageBox.Show(
                        "Insira um nome no arquivo", 
                        "Importante", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                }
                else if (!textArqName.Text.Contains(".txt"))
                {
                    MessageBox.Show("Insira uma extensão válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (isValid)
                {
                    if (this._isEdit)
                    {
                        bool[] isChecked = { read.Checked, write.Checked, exec.Checked };
                        this._generalController.EditFile(this._root, textArqName.Text, textArq.Text, isChecked);

                        MessageBox.Show(
                            "Arquivo editado com sucesso!", 
                            "Informação", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        this._thisForm.Close();
                    }
                    else
                    {
                        bool[] isChecked = { read.Checked, write.Checked, exec.Checked };
                        this._generalController.CreateFile(
                            this._root, 
                            textArqName.Text, 
                            textArq.Text, 
                            isChecked, 
                            userName);

                        MessageBox.Show(
                            "Texto inserido com sucesso!", 
                            "Informação", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        this._thisForm.Close();
                    }
                }
            }
        }

        /// <summary>
        ///     Definições do construtor do diretório
        /// </summary>
        /// <param name="textDir"></param>
        public void DefineDirectory(TextBox textDir)
        {
            if (this._root.SelectedNode.FullPath.Count() > 1)
            {
                var dir = string.Empty;
                for (var i = 1; i < this._root.SelectedNode.FullPath.Length; i++) dir += this._root.SelectedNode.FullPath[i];
                textDir.Text = dir;
            }
            else textDir.Text = this._root.SelectedNode.FullPath;
            textDir.Enabled = false;
        }

        /// <summary>
        ///     Método para deletar um arquivo ou diretório
        /// </summary>
        /// <param name="root"></param>
        /// <param name="userName"></param>
        public void Delete(string userName)
        {
            var permitions = new GeneralController().PermitionsUser(userName);

            if (permitions[0] || permitions[2])
            {
                if (this._root.SelectedNode.Text == @"\")
                    MessageBox.Show(
                        "Não é possível excluir a raiz!", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                else
                {
                    var dialogResult = MessageBox.Show(
                        "Deseja realmente exluir o que foi selecionado?", 
                        "Atenção!", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var isValid = this._generalController.Delete(this._root, userName);
                        if (!isValid)
                            MessageBox.Show(
                                "Você não tem permissão para exluir este arquivo ou diretório!", 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Você para exluir arquivos ou diretórios!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Método para criar um diretório
        /// </summary>
        /// <param name="root"></param>
        /// <param name="userName"></param>
        public void Directory(string userName)
        {
            var permitions = new GeneralController().PermitionsUser(userName);
            if (permitions[2])
            {
                if (this._root.SelectedNode.Text.Contains(".txt"))
                    MessageBox.Show(
                        "Não é possível criar um diretório dentro de um arquivo!", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                else
                {
                    var newDirectory = new NewDirectory(this._root, userName);
                    newDirectory.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Você não tem permissão para criar um diretório!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Método para editar um arquivo
        /// </summary>
        /// <param name="root"></param>
        /// <param name="lblLogin"></param>
        public void Edit(string userName)
        {
            var permitions = new GeneralController().PermitionsUser(userName);
            if (permitions[0])
            {
                if (!this._root.SelectedNode.Text.Contains("."))
                    MessageBox.Show(
                        "Não é possível editar um diretório!", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                else
                {
                    var file = this._generalController.IsEditableFile(this._root.SelectedNode, userName);

                    if (file.Nome != null)
                    {
                        var newFile = new NewFile(
                            this._root, 
                            file.Nome, 
                            file.Conteudo, 
                            new[] { file.Permissoes.Leitura, file.Permissoes.Escrita, file.Permissoes.Execucao }, 
                            true, 
                            false, 
                            userName);
                        newFile.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Não é possível editar este arquivo... o usuário dono publicou!", 
                            "Error", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Você não tem permissão editar um arquivo!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Construtor para a classe NewFile, verifica se o arquivo será editado ou criado
        /// </summary>
        /// <param name="nameArq"></param>
        /// <param name="textArqName"></param>
        /// <param name="textArq"></param>
        /// <param name="read"></param>
        /// <param name="write"></param>
        /// <param name="exec"></param>
        /// <param name="lstPerm"></param>
        /// <param name="textFile"></param>
        /// <param name="btnSave"></param>
        /// <param name="isEdit"></param>
        /// <param name="isPermit"></param>
        public void EditableFile(
            string nameArq, 
            TextBox textArqName, 
            TextBox textArq, 
            CheckBox read, 
            CheckBox write, 
            CheckBox exec, 
            bool[] lstPerm, 
            string textFile, 
            Button btnSave, 
            bool isEdit, 
            bool isPermit)
        {
            if (!string.IsNullOrEmpty(nameArq))
            {
                textArqName.Enabled = false;
                textArqName.Text = nameArq;
                textArq.Text = textFile;
                read.Checked = lstPerm[0];
                write.Checked = lstPerm[1];
                exec.Checked = lstPerm[2];
                this._isEdit = true;
            }

            if (isPermit)
            {
                textArq.Enabled = false;
                textArqName.Enabled = false;
                read.Enabled = false;
                write.Enabled = false;
                exec.Enabled = false;
                btnSave.Text = "Sair";
            }
        }

        /// <summary>
        ///     Método para sair da tela
        /// </summary>
        /// <param name="form"></param>
        /// <param name="nextForm"></param>
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

        /// <summary>
        ///     Método para criar um arquivo
        /// </summary>
        /// <param name="root"></param>
        /// <param name="lblLogin"></param>
        public void File(string userName)
        {
            var permitions = new GeneralController().PermitionsUser(userName);
            if (permitions[0])
            {
                if (this._root.SelectedNode.Text.Contains(".txt"))
                    MessageBox.Show(
                        "Não é possível criar um arquivo dentro de outro arquivo!", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                else
                {
                    var newFile = new NewFile(this._root, null, null, null, false, false, userName);
                    newFile.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Você não tem permissão para criar um arquivo!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Método que salva o diretório e mantém ele na raiz
        /// </summary>
        /// <param name="thisForm"></param>
        /// <param name="root"></param>
        /// <param name="read"></param>
        /// <param name="write"></param>
        /// <param name="exec"></param>
        /// <param name="nameDir"></param>
        public void SaveDirectory(CheckBox read, CheckBox write, CheckBox exec, string nameDir, string userName)
        {
            var isValid = true;

            foreach (TreeNode treeNode in this._root.SelectedNode.Nodes)
            {
                if (treeNode.Text.Equals(nameDir))
                {
                    MessageBox.Show(
                        string.Format("Diretório já existente em {0}!", this._root.SelectedNode.FullPath), 
                        "Erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }

            if (nameDir.Contains(".") || nameDir.Contains("\\"))
            {
                MessageBox.Show(
                    "O nome do diretório contém caracteres inválidos", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(nameDir))
            {
                MessageBox.Show("Selecione um local!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this._root.SelectedNode.Text.Contains(".txt"))
            {
                MessageBox.Show(
                    "Não é possível inserir um diretório num arquivo!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else if (isValid)
            {
                bool[] isChecked = { read.Checked, write.Checked, exec.Checked };
                this._generalController.CreateDirectory(this._root, nameDir, isChecked, userName);
                this._thisForm.Close();
                MessageBox.Show(
                    "Diretório inserido com sucesso!", 
                    "Sucesso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///     Método para visualizar o arquivo
        /// </summary>
        /// <param name="root"></param>
        /// <param name="userName"></param>
        public void View(string userName)
        {
            if (!this._root.SelectedNode.Text.Contains("."))
                MessageBox.Show(
                    "Não é possível visualizar um diretório!", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            else
            {
                var file = this._generalController.ViewFile(this._root, userName);
                if (file == null)
                {
                    MessageBox.Show(
                        "O arquivo foi bloqueado para visualizações pelo autor!", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else
                {
                    var newFile = new NewFile(
                        this._root, 
                        file.Nome, 
                        file.Conteudo, 
                        new[] { file.Permissoes.Leitura, file.Permissoes.Escrita, file.Permissoes.Execucao }, 
                        true, 
                        true, 
                        userName);
                    newFile.ShowDialog();
                }
            }
        }
    }
}