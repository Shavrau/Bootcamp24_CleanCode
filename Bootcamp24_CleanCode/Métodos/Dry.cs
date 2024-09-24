using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Métodos
{
    internal class Dry
    {


        public decimal CalculateTotalOrder(List<OrderItem> items)
        {
            return items.Sum(item => item.Price * item.Quantity);
        }

        public decimal CalculateTotalInvoice(List<InvoiceItem> items)
        {
            return items.Sum(item => item.Price * item.Quantity);
        }

        // O código acima é um exemplo de duplicação de código. Ambos os métodos CalculateTotalOrder e CalculateTotalInvoice fazem a mesma coisa, mas com tipos diferentes. Isso viola o princípio DRY (Don't Repeat Yourself), que afirma que cada parte do conhecimento deve ter uma representação única e não ambígua no sistema. Para resolver esse problema, podemos criar um método genérico que aceita uma lista de itens e calcula o total da fatura.

        public decimal CalculateTotal(IEnumerable<Item> items)
        {
            return items.Sum(item => item.Price * item.Quantity);
        }
        // Agora, podemos reutilizar o método CalculateTotal para calcular o total de qualquer lista de itens, independentemente do tipo de item. Isso elimina a duplicação de código e torna o código mais limpo e fácil de manter.

    }
}
