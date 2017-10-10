using System;

public class PingPong
{
  public static void Main()
  {
    pingPong();
  }
  static void pingPong()
  {
    Console.WriteLine("Enter a Number");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);

    for(int number=0; number <= givenNumber; number++)
    {
      if(number % 3 == 0 && number % 5 == 0)
      {
        Console.WriteLine("PingPong");
      }
      else if(number % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if(number % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
  }
}
