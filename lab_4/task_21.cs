using System;

namespace std
{
   class Program
   {
    static void Main(string[] args)
    {
    Console.Write("Enter a 1st number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter a 2nd number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((a > 0 && b > 0) ? 2 : (a > 0 || b > 0) ? 1 : 0);
    }
  }
}
