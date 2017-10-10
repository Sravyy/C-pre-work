using System;

class Rectangle
{
  public int Length;
  public int Width;

  public bool IsSquare()
  {
    if(Length == Width)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Rectangle myRectangle = new Rectangle();

    Console.WriteLine("Enter the Length: ");
    string stringLength = Console.ReadLine();
    int myLength = int.Parse(stringLength);
    myRectangle.Length = myLength;

    Console.WriteLine("Enter the Width: ");
    string stringWidth = Console.ReadLine();
    int myWidth = int.Parse(stringWidth);
    myRectangle.Width = myWidth;

    if(myRectangle.IsSquare())
    {
      Console.WriteLine("Congratulations! you made a square.");
    }
    else
    {
      Console.WriteLine("Sorry! you didnot make a square.");
    }
  }
}
