using System;

namespace std{
   class Program{
    static void Main(string[] args){
      Console.Write("Enter a 1st number: ");
      int number_1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter a 2nd number: ");
      int number_2 = Convert.ToInt32(Console.ReadLine());
// first method
      Console.WriteLine("First method");
      for(int i = number_1 ; i <= number_2; i ++){
        Console.Write(i + " ");
      }
      Console.WriteLine();
// Second method
      Console.WriteLine("Second moethod");
      int k = number_1;
      while(k <= number_2){
        Console.Write(k + " ");
        k += 1;
      }
      Console.WriteLine();
// Third method
      Console.WriteLine("Third method:");
      do{
        Console.Write(number_1 + " ");
        number_1 = number_1 + 1;
      }while(number_1 <= number_2);
    }
  }
}
