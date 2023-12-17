using System;

namespace ConsoleAppFunctionFofX
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine("calcul");
      for (int i = 0; i < 55; i++)
      {
        var test = Computefunction(i);
        Console.WriteLine($"F de {i} est {test}");
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
