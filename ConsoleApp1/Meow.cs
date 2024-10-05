


using System;
namespace ConsoleApp1
{
  class Meow
  {
    static void Main(string[] args)
    {

      string catFace = @"
    /\_____/\
   /  o   o  \
  ( ==  ^  == )
   )         (
  (           )
 ( (  )   (  ) )
(__(__)___(__)__)";

      Console.WriteLine("Do you like cats?");
      Console.WriteLine("Choose an option from the following list:");
      Console.WriteLine("yes");
      Console.WriteLine("no");
      Console.WriteLine();

      switch (Console.ReadLine())
      {
        case "yes":
          Console.WriteLine("MEOW");
          Console.WriteLine();
          Console.WriteLine(catFace);
          break;
        case "no":
          Console.WriteLine("Sorry this is not an option.");
          break;

      }
    }
  }

}
