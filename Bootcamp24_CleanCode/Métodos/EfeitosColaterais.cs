using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Métodos
{
    internal class EfeitosColaterais
    {
        //certo, o método não modifica os parâmetros, apenas retorna um novo valor.
        public int CalculateDiscountedPrice(int originalPrice, int discount)
        {
            return originalPrice - discount; // Retorna um novo valor sem modificar os parâmetros.
        }


        //errado, o método modifica o parâmetro original, causando efeitos colaterais.
        public void ApplyDiscount(ref int price, int discount)
        {
            price -= discount; // Modifica o parâmetro diretamente, causando efeitos colaterais.
        }


        //No primeiro exemplo, CalculateDiscountedPrice calcula e retorna um novo valor sem alterar o valor original, enquanto no segundo exemplo, ApplyDiscount modifica o valor do preço diretamente, o que pode levar a comportamentos inesperados em outras partes do código.
    }
}
