namespace Login.Controller
{
    using System.Linq;

    using UsersAndGroups.Controller;

    public class ControllerLogin
    {
        /// <summary>
        ///     Valida se o usuário existe
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool ValidUser(string name, string pass)
        {
            var list = new GeneralController().GetAllUsers();
            if (list != null) return list.Any(user => name == user.Name && pass == user.Senha);

            return false;
        }
    }
}