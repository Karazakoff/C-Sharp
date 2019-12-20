using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
    {
      int first, second;
      first = Convert.ToInt32(Console.ReadLine());
      second = Convert.ToInt32(Console.ReadLine());
      int[,] tab = new int[first,second];
      for(int i = 0; i < first ; i ++){
        for(int j = 0 ; j < second ; j ++){
          if(i == j){
            tab[i,j] = 1;
          }
          if(i + j == first - 1){
            tab[i,j] = 1;

          }
        }
      }
      for(int i = 0; i < first ; i ++){
        for(int j = 0 ; j < second ; j ++){
          Console.Write(tab[i,j] + " ");
        }
        Console.WriteLine();
      }

    }
  }
}
