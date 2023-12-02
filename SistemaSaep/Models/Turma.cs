using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Turma
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public List<Atividade> Atividades { get; set; }
    }
}
