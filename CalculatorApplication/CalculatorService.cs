using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CalculatorApplication
{
    public class CalculatorService
    {
        private static Calculator _calculator = new Calculator();
        public static void Testoperations()
        {
            TestAddMethodReturnsRightValue();
            TestDivMethodReturnsRightValue();
            TestSubMethodReturnsRightValue();
            TestMullMethodReturnsRightValue();
        }

        public static void TestAddMethodReturnsRightValue()
        {
            try
            {
                if (13 == _calculator.Add(6, 7))    //6 + 7 = 3
                    PrintSuccess("Add correct passed");
                else
                    PrintError("Add process failed");
            }
            catch (Exception ex)
            {
                PrintError(MethodBase.GetCurrentMethod().Name + " failed");
                Console.WriteLine(ex.Message);
            }
        }
        public static void TestDivMethodReturnsRightValue()
        {
            try
            {
                if (3 == _calculator.Div(6, 0)) //6 / 2 = 3
                    PrintSuccess("Div correct passed");
                else
                    PrintError("Div process failed");
            }
            catch (Exception ex)
            {
                PrintError(MethodBase.GetCurrentMethod().Name + " failed");
                Console.WriteLine(ex.Message);
            }
        }
        public static void TestSubMethodReturnsRightValue()
        {
            try
            {
                if (4 == _calculator.Sub(6, 2))   //6 - 2 = 4
                    PrintSuccess("Sub correct passed");
                else
                    PrintError("Sub process failed");
            }
            catch (Exception ex)
            {
                PrintError(MethodBase.GetCurrentMethod().Name + " failed");
                Console.WriteLine(ex.Message);
            }
        }
        public static void TestMullMethodReturnsRightValue()
        {
            try
            {
                if (18 == _calculator.Mul(6, 3))  //6 * 3 = 3
                    PrintSuccess("Mul correct passed");
                else
                    PrintError("Mul process failed");
            }
            catch (Exception ex)
            {
                PrintError(MethodBase.GetCurrentMethod().Name + " failed");
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
