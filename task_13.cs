using System;

namespace std{
   class Program{
    static void Main(string[] args){
      int i = 2;
      do{
        Console.WriteLine();
        Console.WriteLine($"{i} * 1 = {i * 1}");
        Console.WriteLine($"{i} * 2 = {i * 2}");
        Console.WriteLine($"{i} * 3 = {i * 3}");
        Console.WriteLine($"{i} * 4 = {i * 4}");
        Console.WriteLine($"{i} * 5 = {i * 5}");
        Console.WriteLine($"{i} * 6 = {i * 6}");
        Console.WriteLine($"{i} * 7 = {i * 7}");
        Console.WriteLine($"{i} * 8 = {i * 8}");
        Console.WriteLine($"{i} * 9 = {i * 9}");
        Console.WriteLine();
        i = i + 1;
      }while(i <= 6);
    }
  }
}
