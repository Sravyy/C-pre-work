using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereals"};
    int[] grocerListPrice = {2,3,4,5,6};

    Console.WriteLine("My Grocery List:");
    foreach (string groceryItem in myGroceryList)
    {
      Console.WriteLine(groceryItem);
    }
    int total = 0;
    foreach (int price in grocerListPrice)
    {
      total += price;
    }
    Console.WriteLine("your total for this shopping trip will be $"+ total);
  }
}
