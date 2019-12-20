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
            tab_1[i,j] = rnd.Next(1,5);
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
            tab_2[i,j] = rnd.Next(1,5);
          }
        }
        for(int i = 0 ; i < second ; i ++){
          for(int j = 0 ; j < second ; j ++){
            Console.Write(tab_2[i,j] + " ");
          }
          Console.WriteLine();
        }
        Console.WriteLine("Multiplication of matrixes: ");
        int c = first;
        int[,] tab_3 = new int[c, c];
        int mult;
        for(int i = 0 ; i < c ; i ++){
          for(int j = 0 ; j < c ; j ++){
            mult = 0;
            for(int k = 0 ; k < c ; k ++){
              mult += (tab_1[i,k] * tab_2[k, j]);
            }
            tab_3[i,j] = mult;
          }
        }
        for(int i = 0 ; i < c ; i ++){
          for(int j = 0 ; j < c ; j ++){
            Console.Write(tab_3[i,j] + " ");
          }
          Console.WriteLine();
        }
      }
  }
}
