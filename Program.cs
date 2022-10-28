using System;

namespace Calculadora
{
    internal class Program
    {
        public static int opcao;
        public static decimal numero1 = 0;
        public static decimal numero2 = 0;
        public static decimal resultado = 0;
        static void Main(string[] args)
        {
            
            bool tentarDnovo = true;
            while (tentarDnovo == true)
            {
                Console.Clear();
                
                Console.WriteLine("Seja Bem-vindo à Calculadora!");
                receberopcao();

                if (opcao == 1)
                {
                    Console.WriteLine("Vamos Somar!");
                    receberdoisnumeros();
                    resultado = Somar(numero1, numero2);

                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Presione qualquer tecla para retornar ao menu!");
                    Console.ReadKey();
                    
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Vamos Subtrair!");
                    receberdoisnumeros();
                    resultado = subtrair(numero1, numero2);

                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Presione qualquer tecla para retornar ao menu!");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Vamos Multiplicar!");
                    receberdoisnumeros();
                    resultado = multiplicar(numero1, numero2);

                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Presione qualquer tecla para retornar ao menu!");
                    Console.ReadKey();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Vamos Dividir!");
                    receberdoisnumeros();
                    resultado = dividir(numero1, numero2);

                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Presione qualquer tecla para retornar ao menu!");
                    Console.ReadKey();
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Até mais!");
                    tentarDnovo = false;
                }
                else
                {
                    Console.WriteLine("Essa opção não existe!!");
                    Console.WriteLine("Presione qualquer tecla para retornar ao menu!");
                    Console.ReadKey();
                }
            }




        }
        public static void receberopcao()
        {
            opcao = 0;

            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 Somar");
            Console.WriteLine("2 Subtrair");
            Console.WriteLine("3 Multiplicar");
            Console.WriteLine("4 Dividir");
            Console.WriteLine("5 sair");
            string escritoNoConsole = Console.ReadLine();

            opcao = Convert.ToInt32(escritoNoConsole);



        }
        public static void receberdoisnumeros()
        {
            numero1 = 0;
            numero2 = 0;

            Console.WriteLine("Digite o primeiro numero:");

            string escritoNoConsole = Console.ReadLine();

            numero1 = Convert.ToDecimal(escritoNoConsole);

            Console.WriteLine("Digite o segundo numero:");


            escritoNoConsole = Console.ReadLine();


            numero2 = Convert.ToInt32(escritoNoConsole);
        }
        public static decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static decimal subtrair(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static decimal dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
