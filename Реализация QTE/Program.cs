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

            switch (s) {
                case 3:
                    Console.WriteLine($@"
         ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :
         : :                 : :                 : :
      ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::
");
                    break;
                case 4:
            Console.WriteLine($@"
         ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :
         : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;
                case 5:
                    
                    Console.WriteLine($@"
         ...                 ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :               : {Qte[4]} :
         : :                 : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;
                case 6:
                    Console.WriteLine($@"
         ...                 ...                 ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :               : {Qte[4]} :               : {Qte[5]} :
         : :                 : :                 : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;

            }





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
                if (userInput.Length < Qte.Length|| !EqualityComparer<char>.Default.Equals(Qte[i], userInput[i]))
                {
                    count++;
                }
            }

            return count;
        }
        /*
         *          ..         
        :  :        
        .. :        
      ..    ..      
      :      :      
     : -.   = :     
   ....:    :....   
   -=: : .. : .-=   
       : :: :       
       : : .:       
       : . :.       
       ::  ::       
       ::  ::       

         * 
         * */


        static void Main(string[] args)
        {
            Console.Write(QTE(10));
            //тест

        }
    }
}
