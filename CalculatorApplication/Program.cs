using System;

namespace CalculatorApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculatorService.Testoperations();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
