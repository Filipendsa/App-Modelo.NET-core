using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIo.UI.Site.Models
{
    public class Aluno
    {
        public Aluno()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
