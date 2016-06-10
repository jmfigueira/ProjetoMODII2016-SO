using System.Collections.Generic;
using System.Windows.Forms;
using UsersAndGroups.Model;

namespace UsersAndGroups.Controller
{
    public class GeneralController
    {
        #region Atributes
        private static List<Group> _groups;
        private static List<User> _users;
        #endregion

        #region Constructor
        public GeneralController()
        {
            if (_groups == null)
                _groups = new List<Group>();
            if (_users == null)
                _users = new List<User>();
        }
        #endregion

        #region Group
        //Gerenciamento de grupos
        public void InsertNewGroup(TreeView root, string name, bool[] permitions)
        {
            Group newGroup = new Group();

            newGroup.Name = name;
            newGroup.Permit = new Permitions
            {
                CreateArq = permitions[0],
                ReadArq = permitions[1],
                CreateDir = permitions[2],
                ReadDir = permitions[3]
            };

            _groups.Add(newGroup);

            root.SelectedNode.Nodes.Add(name);
            root.ExpandAll();
        }

        //permissões de grupos
        public bool[] GroupPermitions(TreeView root)
        {
            bool[] permitions = null;

            foreach (Group group in _groups)
            {
                if (group.Name == root.SelectedNode.Text)
                {
                    permitions = new bool[]
                    {
                        group.Permit.CreateArq,
                        group.Permit.ReadArq,
                        group.Permit.CreateDir,
                        group.Permit.ReadDir
                    };
                }
            }
            return permitions;
        }

        #endregion

        #region User
        public void InsertNewUser(TreeView root, string name, string email, string group)
        {
            User user = new User();
            bool[] permitions = GroupPermitions(root);
            user.Name = name;
            user.Senha = email;
            user.Group = group;
            user.Permit = new Permitions
                {
                    CreateArq = permitions[0],
                    ReadArq = permitions[1],
                    CreateDir = permitions[2],
                    ReadDir = permitions[3]
                };
            _users.Add(user);

            root.SelectedNode.Nodes.Add(name);
            root.ExpandAll();
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public bool[] PermitionsUser(string name)
        {
            bool[] permitions = null;

            foreach (User user in _users)
            {
                if (user.Name == name)
                {
                    permitions = new bool[]
                    {
                        user.Permit.CreateArq,
                        user.Permit.ReadArq,
                        user.Permit.CreateDir,
                        user.Permit.ReadDir
                    };
                }
            }
            return permitions;
        }

        #endregion

        #region Genereic
        internal void Delete(TreeView root)
        {
            if (root.SelectedNode.Parent.Text != "Principal")
            {
                foreach (User user in _users)
                {
                    if (root.SelectedNode.Text == user.Name && root.SelectedNode.Parent.Text == user.Group)
                    {
                        root.SelectedNode.Remove();
                        _users.Remove(user);
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            else
            {
                foreach (Group group in _groups)
                {
                    if (root.SelectedNode.Text == group.Name)
                    {
                        root.SelectedNode.Remove();
                        _groups.Remove(group);
                        MessageBox.Show("Grupo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
