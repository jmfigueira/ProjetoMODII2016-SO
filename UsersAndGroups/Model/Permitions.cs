namespace UsersAndGroups.Model
{
    /// <summary>
    ///     The permitions.
    /// </summary>
    public class Permitions
    {
        /// <summary>
        ///     Gets or sets a value indicating whether create arq.
        /// </summary>
        public bool CreateArq { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether create dir.
        /// </summary>
        public bool CreateDir { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether read arq.
        /// </summary>
        public bool ReadArq { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether read dir.
        /// </summary>
        public bool ReadDir { get; set; }
    }
}