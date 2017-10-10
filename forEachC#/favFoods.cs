using System;

class GroceryList
{
  static void Main()
  {
    string[] favFoods = {"cake", "chocolate", "biryani", "icecream", "pizza", "friedrice", "cherries"};

    for(int food = 0; food < favFoods.Length; food++)
    {
      if(food < 4)
      {
        Console.WriteLine(favFoods[food]);
      }
      else if(food == 4)
      {
        Console.WriteLine("I'm full");
      }
    }
  }
}
