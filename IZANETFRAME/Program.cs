using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZANETFRAME
{
    class Program
    {

        enum Menu { Soma = 1, Substração, Divisão, Multiplicação, Potência, Raiz, Sair }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao IZACALC, selecione uma das opções: ");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");


                Menu opçao = (Menu)int.Parse(Console.ReadLine());

                switch (opçao)
                {

                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Multiplicação:
                        Multiplicação();
                        break;
                    case Menu.Substração:
                        Subtração();
                        break;
                    case Menu.Divisão:
                        Divisão();
                        break;
                    case Menu.Potência:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();

        }
        static void Multiplicação()
        {
            Console.WriteLine("Produto de dois numeros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Subtração()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Divisão()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite a base: ");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)(Math.Pow(basenum, expo));
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raíz Quadrada de um número: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado foi {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
    }
}

    