using System.Collections.Generic;

namespace NodeFS.Model
{
    public class Directory
    {
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string User { get; set; }
        public List<File> Files { get; set; }
        public Permitions Permissoes { get; set; }
    }
}
