using System;

namespace std{
  class Solution{
      static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        int[,] tab = new int[number, number];
        for(int i = 0 ; i < number; i ++){
          tab[i,0] = 1;
          tab[0,i] = 1;
          tab[number - 1, i] = 1;
          tab[i, number - 1] = 1;
        }
        Console.WriteLine();
        for(int i = 0 ; i < number ; i ++){
          for(int j = 0 ; j < number ; j ++){
            Console.Write(tab[i,j] + " ");
          }
          Console.WriteLine();
        }
      }
  }
}
