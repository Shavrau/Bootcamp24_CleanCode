using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Métodos
{
    internal class SRP
    {
        //certo, metodos com uma unica responsabilidade
        public void CalculateTotal()
        {
            // Apenas calcula o total.
        }

        public void SendEmail()
        {
            // Apenas envia o e-mail.
        }


        //errado
        public void CalculateTotalAndSendEmail()
        {
            // Faz mais de uma coisa, o que reduz a coesão e a clareza do código.
        }

    }
}
