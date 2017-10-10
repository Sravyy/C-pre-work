using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);
    if(givenNumber >= 10 && givenNumber <= 99)
    {
      Console.WriteLine("your number is a 2 digit number");
    }
    else{
      Console.WriteLine("your number is not a 2 digit number" );
    }
  }
}
