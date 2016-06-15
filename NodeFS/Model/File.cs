namespace NodeFS.Model
{
    /// <summary>
    ///     The file.
    /// </summary>
    public class File
    {
        /// <summary>
        ///     Gets or sets the caminho.
        /// </summary>
        public string Caminho { get; set; }

        /// <summary>
        ///     Gets or sets the caminho completo.
        /// </summary>
        public string CaminhoCompleto { get; set; }

        /// <summary>
        ///     Gets or sets the conteudo.
        /// </summary>
        public string Conteudo { get; set; }

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