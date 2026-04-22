using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Notificacao
{
    public class Email: Notificacao
    {
        public Email(string email) : base(email) { }

        public override void Enviar()
        {
            Console.WriteLine("Enviando E-mail para Joao: Olá, confira nossas ofertas!");
        }
    }
}
