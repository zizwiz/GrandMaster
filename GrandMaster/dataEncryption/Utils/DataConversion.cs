using System;

namespace dataEncryption.Utils
{
    class DataConversion
    {


        public static string ByteToBinary(Byte myByte)
        {
            return Convert.ToString(myByte, 2).PadLeft(8, '0');
        }

        public static byte ConvertByteArrayToByte(byte[] byteArray)
        {
            //if (byteArray == null || byteArray.Length != 1)
            //{
            //    throw new ArgumentException("The byte array must contain exactly one element.");
            //}
            return byteArray[0];
        }


    }
}
