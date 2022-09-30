namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '+':
                    return '+';
                case '-':
                    return '-';
                case '*':
                    return '*';
                case '/':
                    return '/';
            }
            return '+';
        }
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            ValidarOperador(operador);
            if (operador == '+')
                return num1 + num2;
            if (operador == '-')
                return num1 - num2;
            if (operador == '*')
                return num1 * num2;
            if (operador == '/')
                return num1 / num2;

            return 0;
        }
    }
}
