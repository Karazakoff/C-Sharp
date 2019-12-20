using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] sum = new int[n];
      for(int i = 0; i < n ; i ++){
        if(i % 3 == 2){
          sum[i] = 1;
        }
      }
      for(int i = 0; i < n ; i ++){
        Console.Write(sum[i] + " ");
      }
    }
  }
}
