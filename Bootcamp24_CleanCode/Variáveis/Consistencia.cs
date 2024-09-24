using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Variáveis
{
    internal class Consistencia
    {
        //certo, usando camelCase consistentemente, pode ser outro padrão de nomenclatura, mas é importante manter a consistência.
        int totalAmount; 
        float discountAmount;

        //errado, mistura camelCase e snake_case, o que pode causar confusão.
        int totalAmount; // Mistura camelCase e snake_case
        float discount_amount;
    }
}
