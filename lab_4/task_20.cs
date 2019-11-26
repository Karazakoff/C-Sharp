
using System;

namespace std
{
   class Program
   {

    static bool isprime(int number){
      int i = 0;
      for(i = 2 ; i <= Math.Sqrt(number) ; i ++){
        if(number % i == 0){
          return false;
        }
      }
      return true;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number for check is it prime: ");
      int number = Convert.ToInt32(Console.ReadLine());
      if(isprime(number) == true){
          Console.WriteLine("Yes it\'s");
      }
      else{
        Console.WriteLine("No it isn\'t");
      }

    }
  }
}
