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
            int rows;
            int columns;

            for (rows = 0; rows < 25; rows++)
            {

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
                
                }
                if (rows % 2 == 1)
                {
                    Console.Write(" ");
                }
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
