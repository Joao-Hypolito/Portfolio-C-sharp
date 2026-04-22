using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Notificacao
{
    public abstract class Notificacao
    {
        public string Destinarario {  get; set; }

        public Notificacao(string destinarario) { Destinarario = destinarario; }

        public abstract void Enviar();
    }
}
