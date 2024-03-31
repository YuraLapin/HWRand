namespace HWRand
{
    public static class Program
    {
        public static int Main()
        {
            int count = 10000;
            int seedSize = 30;

            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine(RanGen.GenerateRandom(seedSize));
            }

            return 0;
        }
    }
}