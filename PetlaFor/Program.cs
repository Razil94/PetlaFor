using System.ComponentModel.Design.Serialization;

internal class Program
{

    private static void Main(string[] args)
    {
        
        for (double x = 0; x <= 10; x++)
        {
        
            double y  = Math.Sqrt(Math.Pow(3, 2)) * x;

            Console.WriteLine($"y = {y}");

        }
    }
}