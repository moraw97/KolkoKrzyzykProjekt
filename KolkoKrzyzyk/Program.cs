using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoKrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3]
            {
                { '1','2','3' },
                { '4','5','6' },
                { '7','8','9' }
        };

            Console.Write("Wpisz imie gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            imieGraczaB = Console.ReadLine();
            bool koniecGry = false;

            while (!koniecGry)
            {
                Console.Clear();
                RysujPlansze(plansza);
                RuchGracza1(plansza);
            }

              
        }

        static void RuchGracza1(char[,] plansza) {

            int xWidth = Convert.ToInt32(Console.ReadLine());
            int xHeight = Convert.ToInt32(Console.ReadLine());

            plansza[xWidth-1, xHeight-1] = 'x';

        }

        static void RysujPlansze(char[,] plansza)
        {
            int height = plansza.GetLength(0);
            int width = plansza.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    Console.Write(" [ " + plansza[i, j] + " ] ");
                }
                Console.WriteLine();
            }

        }
        
    }
}

