
using System;

namespace std
{
  class Program
   {
    static void Main(string[] args)
    {
      Console.Write("Put your mark here -> ");
      int number = Convert.ToInt32(Console.ReadLine());
      switch(number){
        case 10 : Console.WriteLine("You mark is Excellent");
            break;
        case 9 : Console.WriteLine("You mark is Excellent");
            break;
        case 8 : Console.WriteLine("You mark is Notable");
            break;
        case 7 : Console.WriteLine("You mark is Notable");
            break;
        case 6 : Console.WriteLine("You mark is Good");
            break;
        case 5 : Console.WriteLine("You mark is Pass");
            break;
        default: Console.WriteLine("You mark is Fail");
          break;
      }
    }
  }
}
