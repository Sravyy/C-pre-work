using System;

class GroceryList
{
  static void Main()
  {
    Console.WriteLine("Enter a Number");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);

    for (int number = 1; number <= givenNumber; number++)
    {
      if(number % 2 == 0)
      {
        Console.WriteLine("even");
      }
      else
      {
        Console.WriteLine("odd");
      }
    }

  }
}
