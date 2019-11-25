using System;

namespace std{
   class Program{
    static void Main(string[] args){
      Console.Write("Enter a number: ");
      string number = Console.ReadLine();
      if(Convert.ToInt32(number) < 0){
        Console.WriteLine($"{number.Length - 1} digits");
      }
      else{
        Console.WriteLine($"{number.Length} digits");
      }
    }
  }
}
