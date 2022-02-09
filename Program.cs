using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisiCurt1
{
    class Program
    {

        private static string[] opcions = new string[] { "PEDRA", "PAPER", "TISORA" };
        private static string[,] resultats = new string[,]
        {
             {"Empat", "Perds", "Guanyes"},
             { "Guanyes", "Empat", "Perds" },
             { "Perds", "Guanyes", "Empat" }
        };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroAleatori = rnd.Next(0, 4);

            Console.WriteLine("\t" + comprovarQuiGuanya(opcioUsuari(), numeroAleatori));
            Console.ReadLine();
        }

        private static int opcioUsuari()
        {
            string input;

            Console.WriteLine("Selecciona una opció (1, 2 o 3):");

            for (int i = 0; i < opcions.Length; i++)
            {
                Console.WriteLine(i + 1 + "->" + opcions[i]);
            }

            input = Console.ReadLine();
            int num = 0;
            Int32.TryParse(input, out num);

            if (num > 0 && num <= 3)
            {
                return num -= 1;
            }

            else
            {
                return opcioUsuari();
            }
        }

        private static string comprovarQuiGuanya(int num1, int num2)
        {
            Console.WriteLine("\tUsuari: " + opcions[num1]);
            Console.WriteLine("\tOrdinador: " + opcions[num2]);
            return resultats[num1, num2];
        }
    }
}
