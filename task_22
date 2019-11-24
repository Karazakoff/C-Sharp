using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Price: ");
      int price = Convert.ToInt32(Console.ReadLine());
      Console.Write("Paid: ");
      int paid = Convert.ToInt32(Console.ReadLine());
      int sum = paid - price;
      Console.Write($"Your change is {sum}: ");
      while(sum != 0){
        if(sum >= 100){
          Console.Write("100 ");
          sum = sum - 100;
        }
        else if(sum >= 50){
          Console.Write("50 ");
          sum = sum - 50;
        }
        else if(sum >= 20){
          Console.Write("20 ");
          sum = sum - 20;
        }
        else if(sum >= 10){
          Console.Write("10 ");
          sum = sum - 10;
        }
        else if(sum >= 5){
          Console.Write("5 ")
          sum = sum - 5;
        }
        else if(sum >= 2){
          Console.Write("2 ");
          sum = sum - 2;
        }
        else if(sum >= 1){
          Console.Write("1 ");
          sum = sum - 1;
        }
    }
  }
}
