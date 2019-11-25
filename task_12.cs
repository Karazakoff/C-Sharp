using System;

namespace std{
   class Program{
    static void Main(string[] args){
      Console.Write("Enter a 1st number: ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter a 2nd number: ");
      int b = Convert.ToInt32(Console.ReadLine());
      if(b == 0){
        Console.WriteLine("You can not give zero to 2nd number!");
      }
      else{
        Console.WriteLine(a % b);
      }
    }
  }
}
