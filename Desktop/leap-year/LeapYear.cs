using System;

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("What year were you born in?");
    string stringBirthYear = Console.ReadLine();
    int birthYear = int.Parse(stringBirthYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = birthYear; year <= 2020; year ++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}