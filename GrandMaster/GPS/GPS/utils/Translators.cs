using System;

namespace GPS_App.utils
{
    class Translators
    {

        public static string ConvertASCIItoDec(string myData)
        {
            string GPSData = "";

            foreach (var character in myData)
            {
                GPSData += Convert.ToUInt16(character);
            }

            GPSData += "1310";
            return GPSData;
        }

       
    }







}

