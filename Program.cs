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
        private static string[][] resultats = new string[3][]
        {
            new string[] {"Empat", "Perds", "Guanyes"},
            new string[] { "Guanyes", "Empat", "Perds" },
            new string[] { "Perds", "Guanyes", "Empat" }
        };

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
            Random rnd = new Random();
            int numeroAleatori = rnd.Next(0,4);
            num2 = numeroAleatori;

            Console.Write("Usuari: " + num1 + "\n");
            Console.Write("Ordinador: " + num2 + "\n");

            // POSIBILITAT PEDRA---------
            if (num1 == 0 && num2 == 0)
            {
                return resultats[0][1];
            }

            if (num1 == 0 && num2 == 1)
            {
                return resultats[0][1];
            }

            if (num1 == 0 && num2 == 2)
            {
                return resultats[0][2];
            }

            // --------------------------

            // POSIBILITAT PAPER---------
            if (num1 == 1 && num2 == 0)
            {
                return resultats[1][0];
            }

            if (num1 == 1 && num2 == 1)
            {
                return resultats[1][1];
            }

            if (num1 == 1 && num2 == 2)
            {
                return resultats[1][2];
            }
            // --------------------------
            // POSIBILITAT TISORA---------
            if (num1 == 2 && num2 == 0)
            {
                return resultats[2][0];
            }

            if (num1 == 2 && num2 == 1)
            {
                return resultats[2][1];
            }

            if (num1 == 1 && num2 == 2)
            {
                return resultats[2][2];
            }


            return "Tonto";
        }


    }
}
