using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
      {
        Console.WriteLine("Enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while(i <= 10){
          Console.WriteLine($"{number} * {i} = {number * i}");
          i = i + 1;
        }
      }
    }
  }
