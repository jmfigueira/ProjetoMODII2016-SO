
namespace NodeFS.Model
{
    public class File
    {
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public string CaminhoCompleto { get; set; }
        public string Caminho { get; set; }
        public string User { get; set; }
        public Permitions Permissoes { get; set; }
    }
}
