using System;
using System.Threading;

namespace bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] choices = {"tesoura", "papel", "pedra", "spock", "lagarto"};
            Console.Write("Quantidade de tentativas desejadas: ");
	        int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++)
            {
                Thread.Sleep(2000);
                v1 = choices[rnd.Next(0, 4)];
                v2 = choices[rnd.Next(0, 4)];
    		    Console.WriteLine("\nPartida: #{0} - Sheldon: {1} x Raj: {2}", i, v1, v2);
                if ((v1 == "tesoura" && v2 == "papel") || (v1 == "papel" && v2 == "pedra") || (v1 == "pedra" && v2 == "lagarto") ||
                    (v1 == "lagarto" && v2 == "spock") || (v1 == "spock" && v2 == "tesoura") || (v1 == "tesoura" && v2 == "lagarto") ||
                    (v1 == "lagarto" && v2 == "papel") || (v1 == "papel" && v2 == "spock") || (v1 == "spock" && v2 == "pedra") ||
                    (v1 == "pedra" && v2 == "tesoura"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if ( v1 == v2 )
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
