using System;

namespace std{
   class Program{
    static void Main(string[] args){
      Console.Write("Enter a login: ");
      string login = Console.ReadLine();
      string password = "";
      Console.Write("Enter your password: ");
      do{
        ConsoleKeyInfo key = Console.ReadKey(true);
        if(key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter){
          password += key.KeyChar;
          Console.Write("*");
        }
        else{
          if(key.Key == ConsoleKey.Backspace && password.Length > 0){
            password = password.Substring(0, (password.Length - 1));
            Console.Write("\b \b");
          }
          else if(key.Key == ConsoleKey.Enter){
            break;
          }
        }
      }while (true);
      Console.WriteLine();
      string new_login = "";
      string new_password ="";
      while(login != new_login || password != new_password){
        new_login = "";
        new_password = "";
        Console.Write("Reenter a login: ");
        new_login = Console.ReadLine();
        Console.Write("Reenter a password: ");
        do{
          ConsoleKeyInfo key = Console.ReadKey(true);
          if(key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter){
            new_password += key.KeyChar;
            Console.Write("*");
          }
          else{
            if(key.Key == ConsoleKey.Backspace && new_password.Length > 0){
              new_password = new_password.Substring(0, (new_password.Length - 1));
              Console.Write("\b \b");
            }
            else if(key.Key == ConsoleKey.Enter){
                break;
            }
          }
        }while (true);
        Console.WriteLine();
        if(new_login != login || new_password != password){
            Console.WriteLine("Incorrect username or password.");
        }
      }
      Console.WriteLine("Great! You have registered !");
    }
  }
}
