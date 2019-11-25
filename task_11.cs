using System;

namespace std{
   class Program{
    static void Main(string[] args){
      int number_1, number_2, attempt = 0;
      do{
        Console.Write("Enter a login: ");
        number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a password: ");
        number_2 = Convert.ToInt32(Console.ReadLine());
        attempt = attempt + 1;
        if(number_1 == 2019 && number_2 == 12321){
          Console.WriteLine();
          Console.WriteLine("You're correct!");
          break;
        }
        else{
          Console.WriteLine();
          Console.WriteLine($"Sorry, try again. You have {3 - attempt} attempts");
          Console.WriteLine();
        }


      }while(attempt < 3);
    }
  }
}
