using System;

namespace std{
  class Solution{
      static void Main(string[] args){

        Random rnd = new Random();

        Console.Write("Write the first size of matrix, it will be filled by random numbers:");
        int first = Convert.ToInt32(Console.ReadLine());
        int[,] tab_1 = new int[first, first];
        
        for(int i = 0 ; i < first ; i ++){
          for(int j = 0 ; j < first ; j ++){
            tab_1[i,j] = rnd.Next(0,10);
          }
        }
        for(int i = 0 ; i < first ; i ++){
          for(int j = 0 ; j < first ; j ++){
            Console.Write(tab_1[i,j] + " ");
          }
          Console.WriteLine();
        
        
        }
        Console.Write("Write the second size of matrix, it will be filled by random numbers:");
        int second = Convert.ToInt32(Console.ReadLine());
        int[,] tab_2 = new int[second, second];
        
        for(int i = 0 ; i < second ; i ++){
          for(int j = 0 ; j < second ; j ++){
            tab_2[i,j] = rnd.Next(0,10);
          }
        }
        for(int i = 0 ; i < second ; i ++){
          for(int j = 0 ; j < second ; j ++){
            Console.Write(tab_2[i,j] + " ");
          }
          Console.WriteLine();
        }


        Console.WriteLine("Sum of matrix below:");

        for(int i = 0 ; i < second ; i ++){
          for(int j = 0 ; j < second ; j ++){
            Console.Write((tab_2[i,j] + tab_1[i,j] + " "));
          }
          Console.WriteLine();
        }


      }
  }
}
