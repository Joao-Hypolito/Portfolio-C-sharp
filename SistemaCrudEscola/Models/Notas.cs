using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBD.Models
{
    public class Notas
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; }
        public string Disciplina { get; set; }
        public decimal Valor { get; set; }
        public string Periodo { get; set; }
    }
}
