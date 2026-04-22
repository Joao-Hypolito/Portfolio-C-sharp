using System;
using System.Collections.Generic;
using System.Text;

namespace Post
{
    public class Usuario
    {
        public string Nome {  get; set; }
        public Usuario(string nome) { Nome = nome; }
    }

    public class Comentario
    {
        public string Texto { get; set; }
        public Comentario(string texto) { Texto = texto; }
    }
}
