using System;

namespace std{
  class Solution{
      static void Main(string[] args){
        int number;
        do{
          number = Convert.ToInt32(Console.ReadLine());
          int[,] tab = new int[number, number];
          if(number % 2 == 0){
            Console.WriteLine("Your number is even, you should write odd number!");
          }
          else{
            int mid = (number - 1) / 2;
            for(int i = 0 ; i < number ; i ++){
                tab[i,mid] = 1;
                tab[mid,i] = 1;
            }
            for(int i = 0 ; i < number; i ++){
              for(int j = 0 ; j < number; j ++){
                Console.Write(tab[i,j] + " ");
              }
              Console.WriteLine();
            }

          }
        }while(number != 0 && number != 1);
        Console.WriteLine("Finished, run code again");
      }
  }
}
