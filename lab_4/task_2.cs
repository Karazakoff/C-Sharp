using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
      {
        do{
          Console.WriteLine("Enter number");
          int number = Convert.ToInt32(Console.ReadLine());
          if(number != 0){
            Console.WriteLine(10 * number);
          }
          else{
            break;
          }
        }while(true);
      }
    }
  }
