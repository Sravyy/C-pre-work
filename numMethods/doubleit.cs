using System;

class numMethod
{
  static void Main()
  {
    Console.WriteLine("Give me any number and will turn it into 1 for you");
    Console.WriteLine("whats your number?");
    string stringNumber = Console.ReadLine();

    int intNumber = int.Parse(stringNumber);
    int toOne = intNumber / intNumber ;

    string output = toOne.ToString();
    Console.WriteLine("Here it is : "+output);
  }
}
