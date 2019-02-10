using System;
using System.Collections.Generic;

namespace Sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] colorArray = new string[4] { "Red", "Blue", "Green", "Yellow" };

      foreach (string color in colorArray)
      {
        Console.WriteLine(color);
      }

      var gc = new GenericClass<string>(colorArray[0], "Behold my color!");
      Console.WriteLine(gc.Result);
      Console.WriteLine(gc.Message);

      var colorList = new List<string>() { "Red", "Blue", "Green", "Yellow" };

      colorList.Add("Black");
      colorList.Add("White");
      colorList.Add("Grey");

      foreach (string color in colorList)
      {
        Console.WriteLine(color);
      }
    }
  }
}
