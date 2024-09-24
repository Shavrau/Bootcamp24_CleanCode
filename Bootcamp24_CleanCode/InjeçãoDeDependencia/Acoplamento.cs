using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.InjeçãoDeDependencia
{
    internal class Acoplamento
    {
        //Aqui a classe PaymentService depende diretamente de uma implementação específica (StripePaymentGateway), o que limita a flexibilidade e reutilização do código
        public class PaymentService
        {
            private readonly StripePaymentGateway _paymentGateway;

            public PaymentService()
            {
                _paymentGateway = new StripePaymentGateway();
            }

            public void ProcessPayment()
            {
                _paymentGateway.MakePayment();
            }
        }

        //O PaymentService depende de uma abstração (IPaymentGateway), tornando a classe mais desacoplada. Agora, diferentes implementações de IPaymentGateway podem ser injetadas, promovendo a reutilização e testabilidade do código.
        public class PaymentService
        {
            private readonly IPaymentGateway _paymentGateway;

            public PaymentService(IPaymentGateway paymentGateway)
            {
                _paymentGateway = paymentGateway;
            }

            public void ProcessPayment()
            {
                _paymentGateway.MakePayment();
            }
        }

    }
}
