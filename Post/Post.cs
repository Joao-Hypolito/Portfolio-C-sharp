using System;
using System.Collections.Generic;
using System.Text;

namespace Post
{
    public class Post
    {
        public string Conteudo { get; set; }
        public Usuario Autor {  get; set; }
        public List<Comentario>Comentarios { get; set; }  = new List<Comentario>(); 
        
        public Post(string conteudo, Usuario autor)
        {
            Conteudo = conteudo;
            Autor = autor;
        }

        public void AdicionarComentario(string texto)
        {
            Comentarios.Add(new Comentario(texto));
        }
    }
}
