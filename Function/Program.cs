using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(371));

            Console.WriteLine(Narcissistic(2403));

            Console.WriteLine(Narcissistic(4210818));
        }
        public static bool Narcissistic(int value)
        {
            bool result = false;
            string InStringValue = value.ToString();
            char[] NumbersInChar = InStringValue.ToCharArray();
            string[] NumbersInString = new string[InStringValue.Length];
            int[] NumbersInInt = new int[InStringValue.Length];
            int FinalResult = 0;
            for (int i = 0; i <= InStringValue.Length - 1; i++)
            {
                NumbersInString[i] = NumbersInChar[i].ToString();
                NumbersInInt[i] = Convert.ToInt32(NumbersInString[i]);
                NumbersInInt[i] = (int)Math.Pow(NumbersInInt[i], InStringValue.Length);
                FinalResult += NumbersInInt[i];
            }
            if (FinalResult == value)
                result = true;
            return result;
        }
    }
}
