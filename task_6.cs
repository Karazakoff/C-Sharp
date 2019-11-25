using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
      {
        int sum = 0, number;
        do{
          number = Convert.ToInt32(Console.ReadLine());
          sum = sum + number;
        }while(number != 0);
        
        Console.WriteLine($"Amount is {sum}");
      }
  }
}
