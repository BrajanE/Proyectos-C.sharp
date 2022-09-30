using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            numero = 0;
        }
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }
        public Operando(string strNumero) : this()
        {
            Numero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            double auxNumero;
            bool control = double.TryParse(strNumero, out auxNumero);
            if (control)
            {
                return auxNumero;
            }
            return auxNumero;
        }
        public string Numero
        {
            set
            {
                double auxValor = ValidarOperando(value);
                numero = auxValor;
            }
        }
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (!(binario.Substring(i).Contains('0') || binario.Substring(i).Contains('1')))
                {
                    return false;
                }
            }
            return true;
        }
        public string BinarioDecimal(string binario)
        {
            bool controlBinario = EsBinario(binario);
            if (controlBinario)
            {
                int numero = 0;
                int digito;
                int divisor = 10;
                int numeroBinario = int.Parse(binario);
                for (int i = numeroBinario, j = 0; i > 0; i /= divisor, j++)
                {
                    digito = i % divisor;
                    if (digito != 1 && digito != 0)
                    {
                        return "Valor Invalido";
                    }
                    numero += digito * (int)Math.Pow(2, j);
                }
                return numero.ToString();
            }
            return "Valor Invalido";
        }
        private string DecimalBinario(double numero)
        {
            if (numero != Double.MinValue)
            {
                int auxNum = Math.Abs((int)numero);
                string binario = "";
                if (auxNum > 0)
                {
                    while (auxNum > 0)
                    {
                        binario = auxNum % 2 + binario;
                        auxNum = auxNum / 2;
                    }
                    return binario;
                }
            }
            return "Valor Invalido";
        }
        public string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double auxNum);
            return DecimalBinario(auxNum);
        }
        public static string Conversor(bool tipo, string numero)
        {
            Operando aux = new Operando(numero);
            if (tipo)
            {
                return aux.DecimalBinario(numero);
            }
            else
            {
                return aux.BinarioDecimal(numero);
            }            
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            { return n1.numero / n2.numero; }
            return Double.MinValue;
        }     
    }
}
