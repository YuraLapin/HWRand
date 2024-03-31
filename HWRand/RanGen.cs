using System.Globalization;

namespace HWRand
{
    internal static class RanGen
    {
        private static List<bool> GenerateSeed(int size)
        {
            var seed = new List<bool>();
            var rand = new Random();

            for (int i = 0; i < size; ++i)
            {
                if (rand.Next(2) == 1)
                {
                    seed.Add(true);
                }
                else
                {
                    seed.Add(false);
                }
            }

            return seed;
        }

        private static int IntPow(int num, int pow)
        {
            int res = 1;

            for (int i = 0; i < pow; ++i)
            {
                res *= num;
            }

            return res;
        }

        public static double GenerateRandom(int seedSize)
        {
            return GenerateRandom(GenerateSeed(seedSize));
        }

        public static double GenerateRandom()
        {
            return GenerateRandom(GenerateSeed(20));
        }

        public static double GenerateRandom(List<bool> seed)
        {
            int iRes = 0;

            for (int i = seed.Count - 1; i >= 0; --i)
            {
                if (seed[i])
                {
                    iRes += 1 * IntPow(2, i);
                }
            }

            double div;

            for (div = 10; div <= iRes; div *= 10.0);

            var dRes = iRes / div;

            return dRes;
        }
    }
}
