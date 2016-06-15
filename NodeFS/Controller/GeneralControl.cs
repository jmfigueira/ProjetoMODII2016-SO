namespace NodeFS.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using NodeFS.Model;

    using UsersAndGroups.Controller;

    /// <summary>
    ///     The general control.
    /// </summary>
    public class GeneralControl
    {
        private static List<Directory> _directorys;

        private static List<File> _files;

        public GeneralControl()
        {
            if (_files == null) _files = new List<File>();
            if (_directorys == null) _directorys = new List<Directory>();
        }

        // OK
        public void CreateDirectory(TreeView root, string name, bool[] isChecked, string userName)
        {
            try
            {
                this.InsertDirectory(
                    name, 
                    string.Format("{0}\\{1}", root.SelectedNode.FullPath, name), 
                    isChecked, 
                    userName);
                root.SelectedNode.Nodes.Add(name);
                root.ExpandAll();
            }
            catch
            {
                throw new Exception();
            }
        }

        // OK
        public void CreateFile(TreeView root, string nome, string conteudo, bool[] permissoes, string userName)
        {
            try
            {
                var arquivo = new File();

                arquivo.Nome = nome;
                arquivo.Conteudo = conteudo;
                arquivo.Permissoes = new Permitions
                                         {
                                             Leitura = permissoes[0], 
                                             Escrita = permissoes[1], 
                                             Execucao = permissoes[2]
                                         };
                arquivo.CaminhoCompleto = string.Format("{0}\\{1}", root.SelectedNode.FullPath, arquivo.Nome);
                arquivo.Caminho = root.SelectedNode.FullPath.Replace(arquivo.Nome, string.Empty);
                arquivo.User = userName;
                this.InsertFile(root, arquivo);
            }
            catch
            {
                throw new Exception();
            }
        }

        public bool Delete(TreeView root, string userName)
        {
            if (root.SelectedNode.Text.Contains("."))
            {
                foreach (var file in _files)
                {
                    if (root.SelectedNode.Text == file.Nome && root.SelectedNode.FullPath == file.CaminhoCompleto)
                    {
                        if (file.User == userName || file.Permissoes.Escrita.Equals(true))
                        {
                            root.SelectedNode.Remove();
                            _files.Remove(file);
                            MessageBox.Show(
                                "Arquivo excluído com sucesso!", 
                                "Sucesso", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }

                return false;
            }

            foreach (var dir in _directorys)
            {
                if (root.SelectedNode.Text == dir.Nome && root.SelectedNode.FullPath == dir.Caminho)
                {
                    if (dir.User == userName || dir.Permissoes.Escrita.Equals(true))
                    {
                        root.SelectedNode.Remove();
                        _directorys.Remove(dir);
                        MessageBox.Show(
                            "Diretório excluído com sucesso!", 
                            "Sucesso", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        return true;
                    }
                }
            }

            return false;
        }

        // OK
        public void EditFile(TreeView root, string nome, string conteudo, bool[] permissoes)
        {
            try
            {
                var arquivo = new File();

                arquivo.Nome = nome;
                arquivo.Conteudo = conteudo;
                arquivo.Permissoes = new Permitions
                                         {
                                             Leitura = permissoes[0], 
                                             Escrita = permissoes[1], 
                                             Execucao = permissoes[2]
                                         };
                this.UpdateFile(arquivo);
            }
            catch
            {
                throw new Exception();
            }
        }

        // OK
        public File IsEditableFile(TreeNode file, string userContext)
        {
            var fileEx = new File();
            foreach (var fileLocal in _files)
            {
                if (fileLocal.Nome == file.Text && fileLocal.CaminhoCompleto == file.FullPath)
                {
                    if (fileLocal.User == userContext)
                    {
                        fileEx = fileLocal;
                        break;
                    }

                    if (fileLocal.Permissoes.Escrita)
                    {
                        fileEx = fileLocal;
                        break;
                    }
                }
            }

            return fileEx;
        }

        public File ViewFile(TreeView root, string userName)
        {
            foreach (var file in _files)
            {
                if (file.Nome == root.SelectedNode.Text && file.CaminhoCompleto == root.SelectedNode.FullPath)
                {
                    if (file.User == userName) return file;
                    if (file.Permissoes.Escrita.Equals(true))
                    {
                        var user = new GeneralController();
                        var isPermitions = user.PermitionsUser(userName);

                        if (isPermitions[1] && file.Permissoes.Leitura.Equals(true)) return file;
                        if (isPermitions[0]) return file;
                    }
                }
            }

            return null;
        }

        /// <summary>
        ///     The insert directory.
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <param name="fullPath">
        ///     The full path.
        /// </param>
        /// <param name="isChecked">
        ///     The is checked.
        /// </param>
        /// <param name="userName">
        ///     The user name.
        /// </param>
        private void InsertDirectory(string name, string fullPath, bool[] isChecked, string userName)
        {
            var directory = new Directory
                                {
                                    Nome = name, 
                                    Caminho = fullPath, 
                                    Permissoes =
                                        new Permitions
                                            {
                                                Leitura = isChecked[0], 
                                                Escrita = isChecked[1], 
                                                Execucao = isChecked[2]
                                            }, 
                                    User = userName
                                };
            _directorys.Add(directory);
        }

        /// <summary>
        ///     The insert file.
        /// </summary>
        /// <param name="root">
        ///     The root.
        /// </param>
        /// <param name="file">
        ///     The file.
        /// </param>
        private void InsertFile(TreeView root, File file)
        {
            root.SelectedNode.Nodes.Add(file.Nome);
            root.ExpandAll();
            _files.Add(file);
        }

        /// <summary>
        ///     The update file.
        /// </summary>
        /// <param name="file">
        ///     The file.
        /// </param>
        private void UpdateFile(File file)
        {
            foreach (var fl in _files)
            {
                if (fl.Nome == file.Nome)
                {
                    file.Caminho = fl.Caminho;
                    file.CaminhoCompleto = fl.CaminhoCompleto;
                    _files.Remove(fl);
                    break;
                }
            }

            _files.Add(file);
        }
    }
}