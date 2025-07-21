namespace Challenge_Lab_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                foreach(var arg in args)
                {
                    Console.WriteLine($"{arg} : {SumDigitsInString(arg)}");
                }
            }
            else
            {
                string[] strings = { "1q2w3e", "L0r3m.1p5um" };
                foreach(string s in strings)
                {
                    Console.WriteLine($"{s} : {SumDigitsInString(s)}");
                }
            }
        }

        static int SumDigitsInString(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if (Char.IsAsciiDigit(c))
                    sum++;
            }
            return sum;
        }
    }
}