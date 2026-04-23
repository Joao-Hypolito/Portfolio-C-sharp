using System;
using System.Collections.Generic;
using System.Text;

namespace Escaneamento_Terrorcon
{
    public abstract class Veiculo
    {

        public abstract void VerificarCombustivel();
        public abstract void VerificarAno();
        public abstract void VerificarNota();
        public abstract void MedidaFinal();


    }
}