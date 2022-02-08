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
        private static string[] resultats = new string[]{ "Empatat", "Perds", "Guanyes" };

        static void Main(string[] args)
        {
            // PRUEBA PARA MIRAR SI FUNCIONA opcioUsuari
            /*if (opcioUsuari() > 0 && opcioUsuari() <= 3)
            {
                Console.WriteLine("Opcio correcta");
            }

            else
            {
                Console.WriteLine("Opcio incorrecta");
            }
            */

            opcioUsuari();
            Console.ReadLine();
        }

        private static int opcioUsuari()
        {
            string input;

            Console.WriteLine("Selecciona una opció (1, 2 o 3):");

            for (int i = 0; i < opcions.Length; i++)
            {
                Console.WriteLine(i+ 1 + "->" + opcions[i]); 
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


            }
}
