namespace NodeFS.Model
{
    using System.Collections.Generic;

    /// <summary>
    ///     The directory.
    /// </summary>
    public class Directory
    {
        /// <summary>
        ///     Gets or sets the caminho.
        /// </summary>
        public string Caminho { get; set; }

        /// <summary>
        ///     Gets or sets the files.
        /// </summary>
        public List<File> Files { get; set; }

        /// <summary>
        ///     Gets or sets the nome.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        ///     Gets or sets the permissoes.
        /// </summary>
        public Permitions Permissoes { get; set; }

        /// <summary>
        ///     Gets or sets the user.
        /// </summary>
        public string User { get; set; }
    }
}