using System.Drawing;

namespace dataEncryption.Utils
{
    class ColourUtilities
    {
        /// <summary>
        /// Send in the Pixel and get a string returned showing the Hex value for Alpha, Red
        /// Green and Blue channels of the pixel.
        /// </summary>
        /// <param name="myPixelColor"></param>
        /// <returns>String showing Hex values of the individual channels</returns>
        public static string GetPixelColourString(Color myPixelColor)
        {
            return myPixelColor.R.ToString("X").PadLeft(2, '0') + " " +
                              myPixelColor.G.ToString("X").PadLeft(2, '0') + " " +
                              myPixelColor.B.ToString("X").PadLeft(2, '0') + " " +
                              myPixelColor.A.ToString("X").PadLeft(2, '0');
            
        }


    }
}
