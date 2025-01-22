using System;

namespace dataEncryption.Utils
{
    class DataConversion
    {

        /// <summary>
        /// Converts a Byte to its Binary representation
        /// </summary>
        /// <param name="myByte"></param>
        /// <returns>A string representing the binary representation of the data Byte</returns>
        public static string ByteToBinary(Byte myByte)
        {
            return Convert.ToString(myByte, 2).PadLeft(8, '0');
        }

        /// <summary>
        /// Converts Byte Array to a Byte
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns>Byte</returns>
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
