using System;
using System.Collections.Generic;
using System.Text;

namespace O_Gerenciador_de_Status_de_Guilda
{
    public class Guilda
    {

        private List<Membro> membros = new List<Membro>();

        public void AdicionarMembro(Membro novo)
        {
            if(membros.Count < 5)
            {
                membros.Add(novo);
            }
            else
            {
                Console.WriteLine("Party Cheia!");
            }
        }

        public void TreinarEquipe()
        {
            foreach (var m in membros)
            {
                m.SubirNivel();
            }
        }
        public void ExibirStatus()
        {
            foreach (var c in membros)
            {
                Console.WriteLine($"Nome: {c.Nome} | Nivel: {c.Nivel} | Classe: {c.Classe}");
            }
        }
    }
}