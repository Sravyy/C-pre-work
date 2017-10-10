using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("Enter your age ?");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);
    if(givenNumber >= 18)
    {
      Console.WriteLine("you are permitted to drink");
    }
    else{
      Console.WriteLine("you are not of drinking age" );
    }
  }
}
