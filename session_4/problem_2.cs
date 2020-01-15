using System;

class MainClass {
  public static double f2(int x, int y){
    if(x >= 5 && y >= 0){
      return (2 * x) / Math.Pow(y,1/2.0);
    }
    else if(x < 5 && y < 0){
      return 3 * y + Math.Log(x - 5);
    }
    else{
      Console.Write("your x or y is not valid");
      return 0;
    }
  }
  public static void Main (string[] args) {
    int x, y;
    do{
      Console.Write("Enter the value of x = ");
      x = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the value of y = ");
      y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(f2(x,y));
    }while(true);

  }
}
