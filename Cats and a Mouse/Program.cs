using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_and_a_Mouse
{
    class Program
    {
        // Complete the catAndMouse function below.
        /*
         *  cat a , catb , mouse
            1 2 3
            1 3 2
        Cat B
        Mouse C
         * */
        static string catAndMouse(int x, int y, int z)
        {
            string result = (Math.Abs(x - z) < Math.Abs(y - z)) ? "Cat A" : (Math.Abs(x - z) > Math.Abs(y - z)) ? "Cat B" : "Mouse C";

            return result;

        }
        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

         
        }
    }
}
