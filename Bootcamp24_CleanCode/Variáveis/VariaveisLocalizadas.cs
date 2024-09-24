using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bootcamp24_CleanCode.Variáveis
{
    internal class VariaveisLocalizadas
    {
        //Certo
        //Variáveis locais devem ser declaradas no local onde são usadas.
        public void ProcessData()
        {
            for (int i = 0; i < data.Length; i++)
            {
                var item = data[i];
            }
        }

        //Errado
        //Declarar variáveis no início do método pode dificultar a compreensão do código.
        int i;
        for (i = 0; i<data.Length; i++) {
            // Usando uma variável fora do escopo necessário, o que pode levar a confusões.
        }
        // i ainda está acessível aqui, o que pode causar problemas
    }
}
