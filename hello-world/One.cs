using System;

class ToOne
{
  static void Main()
  {
    Console.WriteLine("Enter two numbers and i will add them for you");
    string enterNumber1 = Console.ReadLine();

    int yourNumber1 = int.Parse(enterNumber1);

    string enterNumber2 = Console.ReadLine();

    int yourNumber2 = int.Parse(enterNumber2);
    int addNumber = yourNumber1 + yourNumber2;

    string resultNumber = addNumber.ToString();
    Console.WriteLine("Here is the Magic: "+ resultNumber);
  }

}
