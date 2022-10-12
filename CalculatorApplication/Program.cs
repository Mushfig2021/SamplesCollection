using System;

namespace CalculatorApplication
{
    internal class Program
    {
        //https://www.youtube.com/watch?v=BO2C5qAyl4w
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
