namespace HWRand
{
    public static class Program
    {
        public static int Main()
        {
            int count = 10000;
            int seedSize = 30;

            double sum = 0;

            int n1 = 0;
            int n2 = 0;

            for (int i = 0; i < count; ++i)
            {
                var c = RanGen.GenerateRandom(seedSize);
                sum += c;
                Console.WriteLine(c);
                if (c >= 0.5)
                {
                    n1++;
                }
                else
                {
                    n2++;
                }
            }

            Console.WriteLine("\nСреднее значение " + (sum / count).ToString());
            Console.WriteLine("Больше или равно 0.5 " + n1);
            Console.WriteLine("Меньше 0.5 " + n2);
            Console.WriteLine("Разница " + Math.Abs(n1 - n2));

            return 0;
        }
    }
}