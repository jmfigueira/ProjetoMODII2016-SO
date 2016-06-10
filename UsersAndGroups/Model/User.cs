
namespace UsersAndGroups.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Senha { get; set; }
        public string Group { get; set; }
        public Permitions Permit { get; set; }
    }
}
