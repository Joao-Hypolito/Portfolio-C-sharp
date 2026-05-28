﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca_Crud.Models
{
public class Emprestimos
    {
        public int Id { get; set; }

        public int LeitorId { get; set; }

        public int LivroId { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataDevolucao { get; set; }

        public bool Devolvido { get; set; } = false;

        public string NomeLeitor { get; set; } = string.Empty;
        public string TituloLivro { get; set; } = string.Empty;
    }
}
