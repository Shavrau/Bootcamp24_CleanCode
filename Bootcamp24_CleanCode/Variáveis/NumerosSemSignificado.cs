using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Variáveis
{
    internal class NumerosSemSignificado
    {
        private int userCount;


        //certo, usando uma constante nomeada para facilitar a compreensão do código.

        const int MAX_USERS = 1000; // Nome claro que explica o propósito da constante.
        if(userCount > MAX_USERS){
        }

        //errado, usando um número mágico sem explicação.
        if (userCount > 1000) {
        }

    }
}
