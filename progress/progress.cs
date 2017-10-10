using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("whats your grade (A/B/C/D/E/F)?");
    string grading = Console.ReadLine().ToUpper();

    bool A = grading == "A";
    bool B = grading == "B";
    bool C = grading == "C";
    bool D = grading == "D";

      if (A || B){
      Console.WriteLine("Keep it up!");
      } else if (C || D){
      Console.WriteLine("Can do better!");
      } else {
      Console.WriteLine("Need extra efforts to pass" );
      }
  }
}
