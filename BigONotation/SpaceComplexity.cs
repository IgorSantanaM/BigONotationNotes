using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    public class SpaceComplexity
    {
        public void greet(String[] Names) 
        {
            //O(n) space

            String[] copy = new String[Names.Length]; //O(n) space

            for (int i = 0; i < Names.Length; i++) // O(1) space
            {
                Console.WriteLine("Hi " + Names[i]);
            }
        }
    }
}
