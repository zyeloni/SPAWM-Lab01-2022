using System;

namespace SPAWM_Lab01.Helpers;

public class CalculateHelper
{
    public static double Div(double d, double d1)
    {
        if (d1 == 0)
            throw new DivideByZeroException();
                
        return d / d1;
    }

    public static double Mul(double d, double d1)
    {
        return d * d1;
    }

    public static double Sub(double d, double d1)
    {
        return d - d1;
    }

    public static double Sum(double d, double d1)
    {
        return d + d1;
    }
}