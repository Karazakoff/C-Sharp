using System;

namespace std{
   class Program{
    static void Main(string[] args){

// first method
      Console.WriteLine("First method:");
      for(int i = 10; i <= 20; i += 2){
        if(i == 16){
          continue;
        }
        Console.Write(i + " ");
      }
      Console.WriteLine();
// Second method
      Console.WriteLine("Second moethod:");
      for(int i = 10; i <= 20; i ++){
        if(i % 2 != 0 || i == 16){
          continue;
        }
        Console.Write(i + " ");
      }
      Console.WriteLine();
// Third method
      Console.WriteLine("Third method:");
      int k = 10;
      while(true){
        if(k % 2 == 0 && k != 16){
          Console.Write(k + " ");
        }
        else if(k == 21){
          break;
        }
        k = k + 1;
      }
    }
  }
}
