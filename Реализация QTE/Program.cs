using System.Collections.Generic;
using System.Diagnostics;

namespace Реализация_QTE
{

    internal class Program
    {

        static int QTE(int timer)
        {
            char[] all = { 'A', 'S', 'D', 'F', 'G', 'Q', 'W', 'E', 'R' };

            Random rnd = new Random();
            int s = rnd.Next(3, 6); 
            char[] Qte = new char[s];

            for (int i = 0; i < Qte.Length; i++)
            {
                Qte[i] = all[rnd.Next(0, all.Length)];
            }

            Console.Write("Случайные символы:");
            for (int i = 0; i < Qte.Length; i++)
            {
                Console.Write(Qte[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(Qte);

            
            int timeLimit = timer;
            var stopwatch = new Stopwatch();

            Console.Write("Введите буквы через пробел:");

            stopwatch.Start();
            string input = Console.ReadLine();
            stopwatch.Stop();

            if (stopwatch.ElapsedMilliseconds > timeLimit * 1000)
            {
                Console.WriteLine("Время вышло!");
                return Qte.Length; 
            }

            

            string[] AsString = input.Split(' ');

            char[] userInput = new char[AsString.Length];
            for (int i = 0; i < AsString.Length; i++)
            {
                if (char.TryParse(AsString[i].Trim(), out char number))
                {
                    userInput[i] = number;
                }
            }

            Array.Sort(userInput);
            int count = 0;
            for (int i = 0; i < Qte.Length; i++)
            {
                if (!EqualityComparer<char>.Default.Equals(Qte[i], userInput[i]))
                {
                    count++;
                }
            }

            return count;
        }



        static void Main(string[] args)
        {
            Console.Write(QTE(10));
            //тест

        }
    }
}
