using System;

namespace std{
  class Solution{
      static void Main(string[] args){

          int[,] matris=new int[5,5];
          for(int i=0;i<5;i++)
          {
            for(int j=0;j<5;j++)
            {
              if(i==0 || j==0 || i==4 || j==4)
              matris[i,j]=1;
            }
          }

          for(int i=0;i<5;i++)
          {
            for(int j=0;j<5;j++)
            {
              Console.Write(matris[i,j]+" ");

            }
              Console.WriteLine();
          }
      }
  }
}
