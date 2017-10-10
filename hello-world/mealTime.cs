using System;

class mealTime
{
  static void Main()
  {
    AskWhatYouAte("breakfast");
    AskWhatYouAte("lunch");
    AskWhatYouAte("dinner");
  }
  static void AskWhatYouAte (string meal)
  {
    Console.WriteLine("what did you eat for "+ meal +"?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("your had "+ yourMeal + " for "+ meal +"!");
  }
}
