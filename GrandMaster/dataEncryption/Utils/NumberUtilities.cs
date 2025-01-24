using System;

namespace dataEncryption.Utils
{
    class NumberUtilities
    {
        public static int GenerateRandomNumber(int myMin, int myMax)
        {
            Random random = new Random();

            return random.Next(myMin, myMax + 1); // max + 1 because Next is exclusive of the upper bound
        }








    }
}
