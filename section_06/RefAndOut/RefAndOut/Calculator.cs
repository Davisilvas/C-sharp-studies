namespace RefAndOut
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Ttriple(int x, out int result)
        {
            result = x * 3;
        }
    }
}
