namespace UsersAndGroups.Model
{
    /// <summary>
    ///     The user.
    /// </summary>
    public class User
    {
        /// <summary>
        ///     Gets or sets the group.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the permit.
        /// </summary>
        public Permitions Permit { get; set; }

        /// <summary>
        ///     Gets or sets the senha.
        /// </summary>
        public string Senha { get; set; }
    }
}