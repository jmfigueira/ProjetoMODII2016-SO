namespace UsersAndGroups.Controller
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using UsersAndGroups.Model;

    /// <summary>
    ///     The general controller.
    /// </summary>
    public class GeneralController
    {
        private static List<Group> _groups;

        private static List<User> _users;

        /// <summary>
        ///     Construtor
        /// </summary>
        public GeneralController()
        {
            if (_groups == null) _groups = new List<Group>();
            if (_users == null) _users = new List<User>();
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        // permissões de grupos
        public bool[] GroupPermitions(TreeView root)
        {
            bool[] permitions = null;

            foreach (var group in _groups)
            {
                if (group.Name == root.SelectedNode.Text)
                {
                    permitions = new[]
                                     {
                                         group.Permit.CreateArq, group.Permit.ReadArq, group.Permit.CreateDir, 
                                         group.Permit.ReadDir
                                     };
                }
            }

            return permitions;
        }

        // Gerenciamento de grupos
        public void InsertNewGroup(TreeView root, string name, bool[] permitions)
        {
            var newGroup = new Group
                               {
                                   Name = name, 
                                   Permit =
                                       new Permitions
                                           {
                                               CreateArq = permitions[0], 
                                               ReadArq = permitions[1], 
                                               CreateDir = permitions[2], 
                                               ReadDir = permitions[3]
                                           }
                               };

            _groups.Add(newGroup);

            root.SelectedNode.Nodes.Add(name);
            root.ExpandAll();
        }

        public void InsertNewUser(TreeView root, string name, string email, string group)
        {
            var user = new User();
            var permitions = this.GroupPermitions(root);
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

        public bool[] PermitionsUser(string name)
        {
            bool[] permitions = null;

            foreach (var user in _users)
            {
                if (user.Name == name)
                {
                    permitions = new[]
                                     {
                                         user.Permit.CreateArq, user.Permit.ReadArq, user.Permit.CreateDir, 
                                         user.Permit.ReadDir
                                     };
                }
            }

            return permitions;
        }

        internal void Delete(TreeView root)
        {
            if (root.SelectedNode.Parent.Text != "Principal")
            {
                foreach (var user in _users)
                {
                    if (root.SelectedNode.Text == user.Name && root.SelectedNode.Parent.Text == user.Group)
                    {
                        root.SelectedNode.Remove();
                        _users.Remove(user);
                        MessageBox.Show(
                            "Usuário excluído com sucesso!", 
                            "Sucesso", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            else
            {
                foreach (var group in _groups)
                {
                    if (root.SelectedNode.Text == group.Name)
                    {
                        root.SelectedNode.Remove();
                        _groups.Remove(group);
                        MessageBox.Show(
                            "Grupo excluído com sucesso!", 
                            "Sucesso", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }
    }
}