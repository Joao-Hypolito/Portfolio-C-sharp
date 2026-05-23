using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBD.Models
{
    public class Professores
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string? CPF { get; set; } 

        public string Email { get; set; } = string.Empty;

        public string Especialidade { get; set; } = string.Empty;

        public string? Telefone { get; set; } 

        public DateTime DataAdmissao { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
