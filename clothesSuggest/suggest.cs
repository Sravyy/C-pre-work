using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("whats the current temp. outside (in Celsius)?");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);

    bool cold = givenNumber < 13 && givenNumber == 20;

      if (cold){
      Console.WriteLine("wear jackets! its very cold outside");
      }  else {
      Console.WriteLine("wear thin clothes as its hot outside." );
      }
  }
}
