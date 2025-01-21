using System;
using System.Drawing;
using System.Windows.Forms;
using CenteredMessagebox;

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


        public static bool DecodePixelColour(PictureBox myPictureBox, Point myPoint, TextBox myTextBoxX,
            TextBox myTextBoxY, Label myLbl_original_pixel_value, Label myLbl_original_alpha,
            Label myLbl_original_red, Label myLbl_original_green, Label myLbl_original_blue,
            TextBox myTxtbx_original_pixel, TextBox myTxtbx_original_red, TextBox myTxtbx_original_green, 
            TextBox myTxtbx_original_blue)
        {
            int x;
            int y;

            // Load the image
            Bitmap bitmap = new Bitmap(myPictureBox.Image);

            // Specify the coordinates of the pixel

            if ((myPoint.X < 0) || (myPoint.Y < 0))
            {
                x = int.Parse(myTextBoxX.Text); // X-coordinate
                y = int.Parse(myTextBoxY.Text); // Y-coordinate
            }
            else
            {
                x = myPoint.X; // X-coordinate
                y = myPoint.Y; // Y-coordinate
            }


            // Get the color of the pixel
            Color pixelColor = bitmap.GetPixel(x, y);

            string hexColor = ColourUtilities.GetPixelColourString(pixelColor);

            if (!ColourUtilities.WriteDataToUI(pixelColor, myLbl_original_pixel_value, myLbl_original_alpha,
                    myLbl_original_red, myLbl_original_green, myLbl_original_blue))
            {
                MsgBox.Show("Unable to work out the pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ColourUtilities.BackColourTextBox(pixelColor, myTxtbx_original_pixel,
                    myTxtbx_original_red, myTxtbx_original_green, myTxtbx_original_blue))
            {
                MsgBox.Show("Unable to Back Colour Textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ColourUtilities.WriteBinaryDataToTextBoxes(pixelColor, myTxtbx_original_red,
                    myTxtbx_original_green, myTxtbx_original_blue))
            {
                MsgBox.Show("Unable to Write Binary Data to Textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GC.Collect(); //Clear memory to prevent leaks

            return true; //Change this
        }






    }
}
