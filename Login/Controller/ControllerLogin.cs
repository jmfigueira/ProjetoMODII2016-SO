using System.Collections.Generic;
using UsersAndGroups.Controller;
using UsersAndGroups.Model;

namespace Login.Controller
{
    public class ControllerLogin
    {
        #region Publics Methods
        /// <summary>
        /// Valida se o usuário existe
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool ValidUser(string name, string pass)
        {
            List<User> list = new GeneralController { }.GetAllUsers();
            if (list != null)
            {
                foreach (User user in list)
                {
                    if (name == user.Name && pass == user.Senha)
                        return true;
                }
            }
            return false;
        }
        #endregion
    }
}
