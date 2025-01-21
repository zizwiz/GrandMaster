using System.Drawing;

namespace dataEncryption.Utils
{
    class ImageUtilities
    {
        /// <summary>
        /// Pass in the bitmap, the coordinates of the pixel to change and the updated colour to use.
        /// </summary>
        /// <param name="myBitmap"></param>
        /// <param name="myColour"></param>
        /// <param name="myPixelX"></param>
        /// <param name="myPixelY"></param>
        /// <returns></returns>
        public static Bitmap EncodeColourIntoBitmap(Bitmap myBitmap, Color myColour, int myPixelX, int myPixelY)
        {
           Bitmap myUpdatedBitmap = new Bitmap(myBitmap.Width, myBitmap.Height);

            myUpdatedBitmap.SetPixel(myPixelX, myPixelY, myColour);
                    
            return myUpdatedBitmap;
        }










    }
}
