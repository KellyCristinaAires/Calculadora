using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string operação;

            Console.WriteLine("Calculadora Simples\n");

            Console.WriteLine("Soma: +");
            Console.WriteLine("Subtração: -");
            Console.WriteLine("Multiplicação: *");
            Console.WriteLine("Divisão: /");
            Console.WriteLine("Potencia: P");
            Console.WriteLine("Raiz Quadrada: R\n");

            Console.WriteLine("Escolha uma das operações que deseja efeutar: ");
            operação = Console.ReadLine().ToUpper();

            if (operação == "+")
            {
                Soma();
            }

            if (operação == "-")
            {
                Subtracao();
            }

            if (operação == "*")
            {
                Multiplicacao();
            }

            if (operação == "/")
            {
                Divisao();
            }

            if (operação == "P")
            {
                Potencia();
            }

            if (operação == "R")
            {
                RaizQuadrada();
            }

            static void Soma()
            {
                double valor1, valor2, result;

                Console.Write("Digite o 1ºValor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor: ");
                valor2 = double.Parse(Console.ReadLine());

                result = valor1 + valor2;
                Console.WriteLine("O resultado da sua soma é = {0}", result);

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            
            static void Subtracao()
            {
                double valor1, valor2, result;

                Console.Write("Digite o 1ºValor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor: ");
                valor2 = double.Parse(Console.ReadLine());

                result = valor1 - valor2;
                Console.WriteLine("O resultado da sua soma é = {0}", result);

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }

            static void Multiplicacao()
            {
                double valor1, valor2, result;

                Console.Write("Digite o 1ºValor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor: ");
                valor2 = double.Parse(Console.ReadLine());

                result = valor1 * valor2;
                Console.WriteLine("O resultado da sua soma é = {0}", result);

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }

            static void Divisao()
            {
                double valor1, valor2, result;

                Console.Write("Digite o 1ºValor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor: ");
                valor2 = double.Parse(Console.ReadLine());

                if (valor2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir por zero");
                    throw new DivideByZeroException();
                    
                }

                result = valor1 / valor2;
                Console.WriteLine("O resultado da sua soma é = {0}", result);

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }

            static void Potencia()
            {
                double valor1, valor2, result;

                Console.Write("Digite o 1ºValor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2ºValor: ");
                valor2 = double.Parse(Console.ReadLine());

                result = valor1 * valor2 / 100;
                Console.WriteLine("O resultado da sua soma é = {0}", result);

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }

            static void RaizQuadrada()
            {
                double raiz, result;

                Console.Write("Digite o Valor de Raiz Quadrada: ");
                raiz = double.Parse(Console.ReadLine());

                result = Math.Sqrt(raiz);
                Console.WriteLine("O resultado da sua soma é = {0}", Math.Round(result,2));

                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
        }
    }
}