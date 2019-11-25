using System;

namespace std{
   class Program{
    static void Main(string[] args){
      int number, total = 0, amount = 0, max = -999999, min = 999999;
      do{
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        total = total + number;
        amount = amount + 1;
        if(number > max){
          max = number;
        }
        if(number < min){
          min = number;
        }
        Console.WriteLine($"Total = {total} Amount = {amount} Average = {total / amount} Maximum = {max} Minimum = {min}");
      }while(number != 0);
      Console.WriteLine("Bye!");
    }
  }
}
