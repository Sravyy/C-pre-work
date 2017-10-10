using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("Wats ur name?");
    string stringInput = Console.ReadLine().ToUpper();
    if(stringInput.StartsWith("S"))
    {
      Console.WriteLine("Your name starts with an S!");
    }
    else
    {
      Console.WriteLine("Your name doesnot start with an S");
    }
  }
}
