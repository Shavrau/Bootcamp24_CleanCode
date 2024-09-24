using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.InjeçãoDeDependencia
{
    internal class ParaTestes
    {
        //Como a classe OrderService cria diretamente a instância de OrderRepository, é difícil substituir essa dependência por um mock
        public class OrderService
        {
            private readonly OrderRepository _orderRepository;

            public OrderService()
            {
                _orderRepository = new OrderRepository();
            }

            public Order GetOrder(int id)
            {
                return _orderRepository.GetById(id);
            }
        }

        //A dependência IOrderRepository é injetada, o que facilita a substituição por uma implementação mockada durante os testes.
        public class OrderService
        {
            private readonly IOrderRepository _orderRepository;

            public OrderService(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public Order GetOrder(int id)
            {
                return _orderRepository.GetById(id);
            }
        }
        r
    }
}
