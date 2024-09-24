using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Bootcamp24_CleanCode.InjeçãoDeDependencia
{
    internal class CicloDeVida
    {
        //Errado, O ciclo de vida da instância Session é gerenciado diretamente pela classe SessionService
        public class SessionService
        {
            private readonly Session _session;

            public SessionService()
            {
                _session = new Session();
            }

            public void StartSession()
            {
                _session.Open();
            }
        }

        //Certo, Agora a responsabilidade de gerenciar o ciclo de vida da dependência Session foi transferida para o container de injeção de dependência,

        public class SessionService
        {
            private readonly Session _session;

            public SessionService(Session session)
            {
                _session = session;
            }

            public void StartSession()
            {
                _session.Open();
            }
        }


    }
}
