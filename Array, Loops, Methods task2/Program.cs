using System;

namespace Array__Loops__Methods_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n!=0)
            {
                sum += n % 10;
                n /= 10;

            }
            Console.WriteLine("Sum of the numbers are ");
            Console.WriteLine(sum);
        }
    }
}
