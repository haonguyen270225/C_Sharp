using System;
namespace LearnTryCatch
{
    public class TryCath
    {
        static double PhepChia(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
