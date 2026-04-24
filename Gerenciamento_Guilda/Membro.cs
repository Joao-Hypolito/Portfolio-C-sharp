using System;
using System.Collections.Generic;
using System.Text;

namespace O_Gerenciador_de_Status_de_Guilda
{
    public class Membro
    {
        public string Nome {  get; set; }
        public int Nivel { get; set; }
        public  string Classe { get; set; }

        public Membro (string nome, int nivel, string classe)
        {
            Nome = nome;
            Nivel = nivel;
            Classe = classe;
        }

        public void SubirNivel()
        {
            Nivel++;
            Console.WriteLine($"LEVEL UP! Nivel atual: {Nivel}");
        }
    }
}
