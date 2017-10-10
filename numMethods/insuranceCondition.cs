using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("whats your gender (male/female)?");
    string gender = Console.ReadLine();

    Console.WriteLine("whats your age?");
    string stringNumber = Console.ReadLine();
    int givenNumber = int.Parse(stringNumber);

    bool  male = gender == "male";
    bool young = givenNumber < 26;

    if (young && male){
      Console.WriteLine("your insurance is going to be exprensive, but it could be worse.");
    } else if (young || male){
      Console.WriteLine("your insurance is going to be failry expensive.");
    } else {
      Console.WriteLine("your insurance is going to be exprensive" );
    }
  }
}
