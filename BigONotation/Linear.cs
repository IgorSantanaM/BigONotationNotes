using System;
public class Main
{
    public void log(int[] numbers, string[]names){
       //O(n) Linear
        for (int i = 0; i < numbers.Length; i++)//O(n)
        {
            Console.WriteLine(numbers[i]); 
        }
       foreach (string name in names) //O(m)
        {
            Console.WriteLine(name);
        }
    }
}