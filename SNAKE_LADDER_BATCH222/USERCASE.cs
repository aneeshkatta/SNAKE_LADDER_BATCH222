using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE_LADDER_BATCH222
{
    internal class USERCASE
    {
        static void Main()
        {
            int START_POSITION = 0;
            int END_POSITION = 100;
            int dieRoll;
            Console.WriteLine("Welcome to snake and Ladder");
            Console.WriteLine("Player will Start at Zero Position,Player position :{0}", START_POSITION);
            Random random = new Random();
            dieRoll = random.Next(1, 7);
            Console.WriteLine("Number on die is: " + dieRoll);
            Console.WriteLine("Player position:{0}", dieRoll);

        }
    }
}
