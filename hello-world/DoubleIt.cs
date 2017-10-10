using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a no. and i will double it for you!");
    string stringNumber = Console.ReadLine();

    int yourNumber = int.Parse(stringNumber);
    int yourDoubleNumber = yourNumber * 2;

    string stringResultNumber = yourDoubleNumber.ToString();

    Console.WriteLine("your doubled number is: "+ stringResultNumber);
  }
}
