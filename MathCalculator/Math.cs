using System;


namespace MathCalculator
{
    public interface IMath
    {
        public int sum(int a, int b);
        public int sub(int a, int b);
        public int div(int a, int b);
        public int mul(int a, int b);
    }
    public class Math : IMath
    {
        public int sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public int mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int div(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
