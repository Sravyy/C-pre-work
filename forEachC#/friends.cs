using System;

class GroceryList
{
  static void Main()
  {
    string[] myFriends = {"megha", "liquid", "veena", "nidhi", "satya"};

    Console.WriteLine("My Friends");
    foreach (string friend in myFriends)
    {
      Console.WriteLine(friend+ " is my friend");
    }
  }
}
