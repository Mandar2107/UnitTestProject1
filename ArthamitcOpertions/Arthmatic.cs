using System;

namespace ArithmeticOperations
{
    public static class Arithmetic
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Div(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return x / y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
