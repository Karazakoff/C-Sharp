using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
      {
        int i = 15;
        while(i >= 7){
          if(i % 2 == 0){
            Console.Write(i);
          }
          i = i - 1;
        }
      }
    }
  }
