using System;

namespace ConsoleAppFunctionFofX
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine("Computing");
      for (int i = 0; i < 55; i++)
      {
        var result = Computefunction(i);
        Console.WriteLine($"Function for {i} gives: {result}");
      }

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    private static int Computefunction(int number)
    {
      return (((number * 2) + 6) / 2) - number;
    }
  }
}
