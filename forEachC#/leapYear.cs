using System;

class GroceryList
{
  static void Main()
  {
    Console.WriteLine("Wats ur yr of birth?");
    string stringNumber = Console.ReadLine();
    int birthYear = int.Parse(stringNumber);

    Console.WriteLine("you were alive during these leap years:");
    for(int year = birthYear; year <= 2017; year++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}
