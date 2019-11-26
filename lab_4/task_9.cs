using System;

namespace std{
   class Program{

// it's first method

    static void Main(string[] args){
      Console.Write("Enter a number: ");
      string word_1 = Console.ReadLine();
      Console.Write("Enter a amount: ");
      int number_1 = Convert.ToInt32(Console.ReadLine());

      for(int i = 0 ; i < number_1; i ++){
        Console.Write(word_1);
      }
      Console.WriteLine();

// It's second method

      Console.Write("Enter a number: ");
      string word_2 = Console.ReadLine();
      Console.Write("Enter a amount: ");
      int number_2 = Convert.ToInt32(Console.ReadLine());
      int j = 0;
      while(j < number_2){
        Console.Write(word_2);
        j = j + 1;
      }
      Console.WriteLine();

// It's Third Method

      Console.Write("Enter a number: ");
      string word_3 = Console.ReadLine();
      Console.Write("Enter a amount: ");
      int number_3 = Convert.ToInt32(Console.ReadLine());
      int k = 0;
      do{
        Console.Write(word_3);
        k = k + 1;
      }while(k < number_3);
    }
  }
}
