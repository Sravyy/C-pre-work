using System;
using System.Collections.Generic;

class songsBand
{
  public static Dictionary<string, string> SongsLibrary = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("would you like to add a song to your library?['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine().ToUpper();

    if(answer == "Y")
    {
      AddSongs();
    }
    else
    {
      Console.WriteLine("would you like to lookup for a song to your library?['Y' for yes, 'Enter' for no]");
      string Lookupanswer = Console.ReadLine().ToUpper();

      if(Lookupanswer == "Y")
      {
        LookUpSongs();
      }
      else{
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine().ToUpper();

        if(finishedAnswer == "Y" )
        {
          Console.WriteLine("Goodbye.");
        }
        else
        {
          Main();
        }
      }
    }
  }
  static void AddSongs()
  {
    Console.WriteLine("NEW SONG");
    Console.WriteLine("Enter a new song name");
    string song = Console.ReadLine();
    Console.WriteLine("Enter the band name");
    string band = Console.ReadLine();

    if (SongsLibrary.ContainsKey(song))
    {
      Console.WriteLine("That song is already in your phonebook. The song is " + SongsLibrary[song]);
    }
    else
    {
      SongsLibrary.Add(song, band);
    }
    Main();
  }
  static void LookUpSongs()
  {
    Console.WriteLine("LOOKUP SONGS");
    Console.WriteLine("What song to look up?");
    string songName = Console.ReadLine();

    if(SongsLibrary.ContainsKey(songName))
    {
      string value = SongsLibrary[songName];
      Console.WriteLine(songName+ "\'s band is "+ value);
    }
    else
    {
      Console.WriteLine("This song doesnot exist in your library");
    }
    Main();
  }
}
