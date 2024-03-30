using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("введiть число: ");
        int number = Convert.ToInt32(Console.ReadLine());  
        int summma = 0;
        while (number > 0)
        {
            summma += number % 10;
            number /= 10;
        }
        Console.WriteLine(summma);
    }
}