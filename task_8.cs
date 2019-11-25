using System;

namespace std
{
   class Program
   {
    static void Main(string[] args)
    {
      int i = 1;
      while(i <= 500){
        if(i % 3 == 0 && i % 5 == 0){
          Console.Write($"{i} ");
        }
      i = i + 1;
      }
    }
  }
}
