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
            int numeroAleatori = 0;
            bool jugar = true;
            int nRondes = 0; int nGuanyades = 0;
            int inputUsuari;

            Console.WriteLine("WELCOME TO THE S.P.S GAME!\n");

            while (jugar)
            {
                inputUsuari = opcioUsuari();
                numeroAleatori = rnd.Next(0, 3);
                comprovarQuiGuanya(inputUsuari, numeroAleatori);
                nRondes += 1;

                if (resultats[inputUsuari, numeroAleatori] == "Guanyes")
                {
                    nGuanyades += 1;
                }

                Console.WriteLine("Número de rondes: {0}\t Rondes guanyades: {1}", nRondes, nGuanyades);
                jugar = continuarJugant();
            }

            //Console.WriteLine("\t" + comprovarQuiGuanya(opcioUsuari(), numeroAleatori));
            //continuarJugant();
            //Console.ReadLine();
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

            if (num > 0 && num <= opcions.Length)
            {
                return num - 1;
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

        private static bool continuarJugant()
        {
            Console.WriteLine("\nVols continuar jugant (SI/NO)?");
            string eleccio = Console.ReadLine().ToUpper();
 
            if (eleccio == "SI")
            {
                return true;
            }
            if (eleccio == "NO")
            {
                return false;
            }
            else
            {
                return continuarJugant();
            }
        }   
    }
}
