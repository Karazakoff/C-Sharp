using System;

  class Programm{
    public static double function_1(int x){
      return 2*x*x + 2*x + 1;
    }
    public static double function_2(int x, int y){
      return 2*x*(x + 1) / y ;
    }
    public static double function_3(int x, int y){
      if(y >= 0){
        return x * Math.Sqrt(y);
      }
      else{
        return y * x;
      }
    }
    public static int factorial(int x){
      if(x == 0){
        return 1;
      }
      return factorial(x - 1) * x;
    }
    public static void Main(string[] args){
      Console.WriteLine(function_1(9));
      Console.WriteLine(function_2(4 , 3));
      Console.WriteLine(function_3(5, -2));
      Console.WriteLine(factorial(5));
      Console.WriteLine(factorial(0));
    }
  }
