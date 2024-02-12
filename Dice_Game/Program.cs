using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int rol1 = dice.Next(1, 7);
            int rol2 = dice.Next(1, 7);
            int rol3 = dice.Next(1, 7);

            int total = rol1 + rol2 + rol3;

            Console.WriteLine($"Dice Role: {rol1} + {rol2} + {rol3} = {total} ");

            if (rol1 == rol2 || rol2 == rol3 || rol3 == rol1)
            {
                if ((rol1 == rol2) && (rol2 == rol3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                    Console.WriteLine($"Dice Role: {rol1} + {rol2} + {rol3} = {total} ");

                }
                else
                {
                    Console.WriteLine("Yeeyy, You rolled double! +2 bonus to total");
                    total += 2;
                }
                Console.WriteLine($"yuor total including bonus is  {total} ");

            
             }
                if(total >= 16)
                {
                    Console.WriteLine("yuo win a car");
                }
                else if(total >= 10)
                {
                    Console.WriteLine("You Win a laptop");
                }
                else if(total == 7)
                {
                    Console.WriteLine("You win a trip for you two!");
                }
                else
                {
                    Console.WriteLine("You win a kitten");
                }
           




            Console.ReadLine();
        }
        
    }
}
