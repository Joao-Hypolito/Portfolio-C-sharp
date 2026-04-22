using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Notificacao
{
    public class SMS: Notificacao
    {
        public SMS(string destinarario) : base(destinarario) { }

        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS para Joao: Seu código de ativação é 1234.");
        }
    }
}
