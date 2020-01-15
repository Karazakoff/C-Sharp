using System;

class MainClass {
  public static double f(int x){
    return 3 * x * x - 2 * Math.Pow(x, 1/4.0) + 1;
  }
  public static void Main (string[] args) {
    int x;
    do{
      Console.Write("Please enter the value of x = ");
      x = Convert.ToInt32(Console.ReadLine());
      if(x >= 0){
        Console.WriteLine("x = " + f(x));
      }
      else{
        Console.WriteLine("your value is not valid, try again");
      }
    }while(true);


  }
}
