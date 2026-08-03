using System;
using System.Collections.Generic;
using System.Text;

namespace WarpERP___Black_Legion_Troop_Management.Models
{
    public class Marine
    {
        public string Nome {get; set;}
        public string LegiaoOrigem {get; set;}
        public ChaosGod Devocao {get; set;}
        public int QtdMutacoes {get; set;}
        public int CraniosColetados {get; set;}

        public Marine(string nome, string legiaoOrigem, ChaosGod devocao, int qtdMutacoes, int craniosColetados)
        {
        Nome = nome;
        LegiaoOrigem = legiaoOrigem;
        Devocao = devocao;
        QtdMutacoes = qtdMutacoes;
        CraniosColetados = craniosColetados;
        }

        public void ExibirFicha()
        {
            Console.WriteLine($"[HERAQUI] Nome: {Nome} | Legião: {LegiaoOrigem} | Deus: {Devocao} | Mutações: {QtdMutacoes} | Crânios: {CraniosColetados}");
        }
    }
}
