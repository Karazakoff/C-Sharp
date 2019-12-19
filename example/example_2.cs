using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] sum = new int[n];
      int j = 1;
      for(int i = 0; i < n ; i ++){
        sum[i] = j;
        j ++;
        if (j == 4){
          j = 1;
        }
      }
      for(int i = 0; i < n ; i ++){
        Console.Write(sum[i]);
      }
    }
  }
}
