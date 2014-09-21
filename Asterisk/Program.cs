using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk
{
    class Program
    {

        static void Main(string[] args)
        {

            // 1. Deklarera variabler.
            int rows;
            int columns;


            // 2. Skapar for-satser. En som innehåller antal rader och en som innehåller antalet kolumner.
            for (rows = 0; rows < 25; rows++)
            {

            // 3. Switch-sasten kollar vilket case det blir och sätter färg därefter. Var tredje rad gul, var tredje magenta osv...
                switch (rows % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                        
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                
                // 4. If-sasten gör så att varannan rad blir inskjuten. If sasten kan antingen bli 0 eller 1.
                }
                if (rows % 2 == 1)
                {
                    Console.Write(" ");
                }
                // ...den andra for satsen för kolumner. Här ritas asteriskerna ut.
                for (columns = 0; columns < 39; columns++)
                {
                    Console.Write("* ");
                }

               
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
