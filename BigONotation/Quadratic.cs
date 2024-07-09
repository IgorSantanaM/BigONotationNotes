using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    public class Quadratic
    {
        public void log(int[] nums)
        {
            //Quadratic 
            //O(n^3)

            foreach (int first in nums)//O(n)
            {
                foreach (int second in nums)//O(n)
                    foreach (int third in nums)
                    Console.WriteLine(first + " ," + second + " ," + third);
            }
        }
    }
}
