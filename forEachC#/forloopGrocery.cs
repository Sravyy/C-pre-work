using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereals"};

    Console.WriteLine("My Grocery List:");
    for (int index = 0; index < myGroceryList.Length; index ++)
    {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}
