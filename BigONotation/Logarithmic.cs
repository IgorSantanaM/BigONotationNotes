using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    // O(logn)
    public class Logarithmic
    {
        private int[] data; // Array of values
        private static Random generator = new Random();

        public Logarithmic(int size)
        {
            data = new int[size]; // Create space for array

            for (int i = 0; i < size; ++i)
                data[i] = generator.Next(10, 100);

            Array.Sort(data); // Sort the array
        }

        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;

            for (int i = low; i <= high; ++i)
                temporary += data[i] + " ";

            return temporary + "\n";
        }

        public int BinarySearch(int searchElement)
        {
            int low = 0; 
            int high = data.Length - 1; 
            int location = -1; 

            while (low <= high && location == -1)
            {
                int middle = (low + high) / 2; // Calculate the middle element

                Console.Write(RemainingElements(low, high));
                for (int i = 0; i < middle; ++i)
                    Console.Write(" ");
                Console.WriteLine("*"); // Indicate current middle

                if (searchElement == data[middle])
                    location = middle; 
                else if (searchElement < data[middle])
                    high = middle - 1; // Eliminate the higher half
                else
                    low = middle + 1; // Eliminate the lower half
            }

            return location; // Return location of search key
        }

        public override string ToString()
        {
            return RemainingElements(0, data.Length - 1);
        }
    }
}
