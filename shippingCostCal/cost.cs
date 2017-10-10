using System;

class Cost
{
  static void Main()

  {
    Console.WriteLine("What is the weight of the shipment?");
    string stringNumber1 = Console.ReadLine();
    int weight = int.Parse(stringNumber1);

    Console.WriteLine("What is the distance ?");
    string stringNumber2 = Console.ReadLine();
    int distance = int.Parse(stringNumber2);

    Console.WriteLine("What is the price of the shipment?");
    string stringNumber3 = Console.ReadLine();
    int price = int.Parse(stringNumber3);

    int fullCost = (weight/10) + (distance/5) * price;

    string overAllCost = fullCost.ToString();
    Console.WriteLine("your shipping cost is "+ overAllCost +".");
  }
}
