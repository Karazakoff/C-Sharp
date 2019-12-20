using System;

namespace std{
  class Solution{
      static void Main(string[] args){
        int number;
        do{
          number = Convert.ToInt32(Console.ReadLine());
          int[,] tab = new int[number, number];
          int counter = 1;
          for(int i = 0 ; i < number ; i ++){
            if(counter == 4){
              counter = 1;
            }
            for(int j = 0 ; j < number ; j ++){
              if(counter == 4){
                counter = 1;
              }
              tab[i,j] = counter;
              counter ++;
            }
          }
          for(int i = 0 ; i < number ; i ++){
            for(int j = 0 ; j < number ; j ++){
              Console.Write(tab[i,j] + " ");
            }
            Console.WriteLine();
          }

        }while(number != 0);

        Console.WriteLine("Finished. run your code again!");
      }
  }
}
