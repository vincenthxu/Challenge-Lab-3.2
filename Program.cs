namespace Challenge_Lab_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                TestInput(args);
            }
            else
            {
                TestInput([ "1q2w3e", "L0r3m.1p5um" ]);
            }
        }

        static int SumDigitsInString(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if (Char.IsAsciiDigit(c))
                {
                    sum += int.Parse($"{c}");
                }
            }
            return sum;
        }

        static void TestInput(string[] input)
        {
            foreach(string s in input)
            {
                Console.WriteLine($"{s} : {SumDigitsInString(s)}");
            }
        }
    }
}