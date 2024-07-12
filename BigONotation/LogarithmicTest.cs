using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    public class LogarithmicTest
    {
        public static void Main(string[] args)
        {
            int searchInt; 
            int position;  

            Logarithmic searchArray = new Logarithmic(15);
            Console.WriteLine("The sorted array is:");
            Console.WriteLine(searchArray);

            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (searchInt != -1)
            {
                position = searchArray.BinarySearch(searchInt);

                if (position == -1)
                {
                    Console.WriteLine($"The integer {searchInt} was not found.\n");
                }
                else
                {
                    Console.WriteLine($"The integer {searchInt} was found in position {position}.\n");
                }

                Console.Write("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
