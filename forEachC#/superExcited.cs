using System;

class GroceryList
{
  static void Main()
  {
    string[] superExcitedActivites = {"treking", "reading", "singing", "dancing", "shopping", "outing"};

    Console.WriteLine("My Activities");
    foreach (string activity in superExcitedActivites)
    {
      Console.WriteLine((activity+"!").ToUpper());
    }

  }
}
