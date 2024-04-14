using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");            

            int operacao;

            int.TryParse(Console.ReadLine(), out operacao);

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operacao)
            {
                case 1:
                    {
                        result = Adicao(num1, num2); 
                        break;
                    }

                case 2:
                    {
                        result = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        result = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        result = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Número inválido, digite outro número.");
                    break;
            }

            Console.WriteLine("Resultado é: {0}", result);
        }

        public static int Adicao(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Subtracao(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Divisao(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
