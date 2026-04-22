using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Autor
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Autor(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
