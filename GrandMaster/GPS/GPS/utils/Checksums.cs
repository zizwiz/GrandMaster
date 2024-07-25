namespace GPS_App.utils
{
    class Checksums
    {
       /// <summary>
       /// Use this to check if the checksum on the string is correct
       /// </summary>
       /// <param name="myData"></param>
       /// <returns>Hex string of the checksum</returns>
        public static string Check_nmea0183_checksum(string myData)
        {
            int crc = 0;
            string ans;
            string myData_crc = myData.Substring(myData.Length - 2, 2);


            // the first $ sign and the last two bytes of original CRC + the * sign
            for (int i = 1; i < myData.Length - 3; i++)
            {
                crc ^= myData[i]; //This will be in decimal
            }

            string CRC = crc.ToString("X");

            if (CRC.Length == 1) CRC = "0" + CRC;

            if (CRC == myData_crc)
            {
                ans = "Checksum = " + myData_crc + " is correct";
            }
            else
            {
                ans = "Checksum = " + myData_crc + " is not correct it should be = " + CRC;
            }

            return ans; 
        }

        /// <summary>
        /// Send in the data including the prefix $ and this will return the complete string including the checksum
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Complete string including the checksum</returns>
        public static string Add_nmea0183_checksum(string myData)
        {
            int crc = 0;

            // the first $ sign and the last two bytes of original CRC + the * sign
            for (int i = 1; i < myData.Length; i++)
            {
                crc ^= myData[i]; //This will be in decimal
            }

            string CRC = crc.ToString("X");

            if (CRC.Length == 1) CRC = "0" + CRC;

            return myData + "*" + CRC; // this will add checksum in hexadecimal
        }
    }
}
