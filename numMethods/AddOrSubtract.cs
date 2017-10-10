using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("Enter a number ?");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);
    if(givenNumber >= 0)
    {
      int addNumber = givenNumber + 1;
      Console.WriteLine("this is a positive number, adding 1 gives :"+ addNumber );
    }
    else{
      int addNumber = givenNumber - 1;
      Console.WriteLine("this is a Negative number, subtracting 1 gives :"+ addNumber );

    }
  }
}
