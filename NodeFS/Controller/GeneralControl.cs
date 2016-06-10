using NodeFS.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NodeFS.Controller
{
    public class GeneralControl
    {
        #region Atributes

        private static List<File> _files;
        private static List<Directory> _directorys;

        #endregion

        #region Constructor
        public GeneralControl()
        {
            if (_files == null)
                _files = new List<File>();
            if (_directorys == null)
                _directorys = new List<Directory>();
        }
        #endregion

        #region Directory

        #region Public Methods
        //OK
        public void CreateDirectory(TreeView root, string name, bool[] isChecked, string userName)
        {
            try
            {
                InsertDirectory(name, string.Format("{0}\\{1}", root.SelectedNode.FullPath, name), isChecked, userName);
                root.SelectedNode.Nodes.Add(name);
                root.ExpandAll();
            }
            catch
            {
                throw new Exception();
            }
        }

        #endregion

        #region Private Methods
        //OK
        private void InsertDirectory(string name, string fullPath, bool[] isChecked, string userName)
        {
            Directory directory = new Directory
            {
                Nome = name,
                Caminho = fullPath,
                Permissoes = new Permitions
                {
                    Leitura = isChecked[0],
                    Escrita = isChecked[1],
                    Execucao = isChecked[2]
                },
                User = userName
            };
            _directorys.Add(directory);
        }

        #endregion

        #endregion

        #region File

        #region Public Methods
        //OK
        public void CreateFile(TreeView root, string nome, string conteudo, bool[] permissoes, string userName)
        {
            try
            {
                File arquivo = new File();

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
                InsertFile(root, arquivo);
            }
            catch
            {
                throw new Exception();
            }
        }

        //OK
        public void EditFile(TreeView root, string nome, string conteudo, bool[] permissoes)
        {
            try
            {
                File arquivo = new File();

                arquivo.Nome = nome;
                arquivo.Conteudo = conteudo;
                arquivo.Permissoes = new Permitions
                {
                    Leitura = permissoes[0],
                    Escrita = permissoes[1],
                    Execucao = permissoes[2]
                };
                UpdateFile(arquivo);
            }
            catch
            {
                throw new Exception();
            }
        }

        //OK
        public File IsEditableFile(TreeNode file, string userContext)
        {
            File fileEx = new File();
            foreach (File fileLocal in _files)
            {
                if (fileLocal.Nome == file.Text && fileLocal.CaminhoCompleto == file.FullPath)
                {
                    if (fileLocal.User == userContext)
                    {
                        fileEx = fileLocal;
                        break;
                    }
                    else if (fileLocal.Permissoes.Escrita)
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
            foreach (File file in _files)
            {
                if (file.Nome == root.SelectedNode.Text && file.CaminhoCompleto == root.SelectedNode.FullPath)
                {
                    if (file.User == userName)
                        return file;
                    else if (file.Permissoes.Escrita.Equals(true))
                    {
                        UsersAndGroups.Controller.GeneralController user = new UsersAndGroups.Controller.GeneralController();
                        bool[] isPermitions = user.PermitionsUser(userName);

                        if (isPermitions[1] && file.Permissoes.Leitura.Equals(true))
                            return file;
                        else if (isPermitions[0])
                            return file;
                    }
                }
            }
            return null;
        }

        #endregion

        #region Private Methods
        //OK
        private void UpdateFile(File file)
        {
            foreach (File fl in _files)
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
        //OK
        private void InsertFile(TreeView root, File file)
        {
            root.SelectedNode.Nodes.Add(file.Nome);
            root.ExpandAll();
            _files.Add(file);
        }

        #endregion

        #endregion

        #region Generic

        public bool Delete(TreeView root, string userName)
        {
            if (root.SelectedNode.Text.Contains("."))
            {
                foreach (File file in _files)
                {
                    if (root.SelectedNode.Text == file.Nome && root.SelectedNode.FullPath == file.CaminhoCompleto)
                    {
                        if (file.User == userName || file.Permissoes.Escrita.Equals(true))
                        {
                            root.SelectedNode.Remove();
                            _files.Remove(file);
                            MessageBox.Show("Arquivo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                foreach (Directory dir in _directorys)
                {
                    if (root.SelectedNode.Text == dir.Nome && root.SelectedNode.FullPath == dir.Caminho)
                    {
                        if (dir.User == userName || dir.Permissoes.Escrita.Equals(true))
                        {
                            root.SelectedNode.Remove();
                            _directorys.Remove(dir);
                            MessageBox.Show("Diretório excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        #endregion
    }
}
