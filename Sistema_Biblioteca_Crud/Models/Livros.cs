﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca_Crud.Models
{
public class Livros
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public string? ISBN { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public int Quantidade { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
