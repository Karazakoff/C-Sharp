using System;

namespace std
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 46341;
      int[] sum = new int[n];
      for(int i = 0; i < n ; i ++){
        sum[i] = (i + 1) * (i + 1);
      }
      for(int i = 0; i < n ; i ++){
        Console.Write(sum[i] + " ");
      }
    }
  }
}
