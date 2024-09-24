using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24_CleanCode.Métodos
{
    internal class NumeroDeParametros
    {
        //certo, poucos parametros facilitam a leitura e manutenção do código
        public void CreateUser(User user)
        {
            // Cria um novo usuário com um objeto que contém todas as informações necessárias.
        }

        //errado, muitos parametros dificultam a leitura e manutenção do código
        public void CreateUser(string name, string email, string phone, string address, string city, string state, string country)
        {
            // Cria um novo usuário com muitos parâmetros, o que dificulta a leitura e manutenção do código.
        }


        // O primeiro exemplo utiliza um único objeto User, tornando o método mais legível e fácil de usar. No segundo exemplo, muitos parâmetros tornam o método confuso e propenso a erros, especialmente se a ordem dos parâmetros for esquecida.
    }
}
