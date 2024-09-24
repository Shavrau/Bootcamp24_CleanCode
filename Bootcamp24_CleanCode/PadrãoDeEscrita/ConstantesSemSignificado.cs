namespace Bootcamp24_CleanCode.PadrãoDeEscrita
{
    internal class ConstantesSemSignificado
    {
        private int currentUsers;
        public ConstantesSemSignificado()
        {

            //Exemplo de constante sem significado
            if (currentUsers > 1000)
            {
            }

            //Usar uma constante nomeada como MAX_USERS facilita a compreensão do código. Um valor numérico direto (1000) é um "número mágico" que não explica seu propósito sem contexto adicional.
            const int MAX_USERS = 1000;
            if (currentUsers > MAX_USERS)
            {
            }


        }
    }
}
