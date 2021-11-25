using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauExercice1_Cor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables pour compter les temperatures
            int positive = 0, negative = 0;
            // Déclaration du tableau
            int[] temperatures = new int[5];

            // Saisie des temperatures
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Entrez une température  : ");
                temperatures[i] = int.Parse(Console.ReadLine());
                if (temperatures[i] < 0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }

            }
            Console.WriteLine($"Il y a {negative} temperatures négatives.");
            Console.WriteLine($"Il y a {positive} temperatures positives.");
            Console.ReadLine();
        }
    }
}
