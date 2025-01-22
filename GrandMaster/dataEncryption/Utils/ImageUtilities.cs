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
        /// <returns>Bitmap with encoded pixel</returns>
        public static Bitmap EncodeColourIntoBitmap(Bitmap myBitmap, Color myColour, int myPixelX, int myPixelY)
        {
            Bitmap myUpdatedBitmap = new Bitmap(myBitmap.Width, myBitmap.Height);

            myUpdatedBitmap.SetPixel(myPixelX, myPixelY, myColour);

            return myUpdatedBitmap;
        }

        /// <summary>
        /// Sends the pixel at the given co-ordinates to be decoded and written to the UI.
        /// </summary>
        /// <param name="myPictureBox"></param>
        /// <param name="myPoint"></param>
        /// <param name="myTextBoxX"></param>
        /// <param name="myTextBoxY"></param>
        /// <param name="myLbl_original_pixel_value"></param>
        /// <param name="myLbl_original_alpha"></param>
        /// <param name="myLbl_original_red"></param>
        /// <param name="myLbl_original_green"></param>
        /// <param name="myLbl_original_blue"></param>
        /// <param name="myTxtbx_original_pixel"></param>
        /// <param name="myTxtbx_original_red"></param>
        /// <param name="myTxtbx_original_green"></param>
        /// <param name="myTxtbx_original_blue"></param>
        /// <returns>True is successful else False</returns>
        public static bool DecodePixelColour(PictureBox myPictureBox, Point myPoint, TextBox myTextBoxX,
            TextBox myTextBoxY, Label myLbl_original_pixel_value, Label myLbl_original_alpha,
            Label myLbl_original_red, Label myLbl_original_green, Label myLbl_original_blue,
            TextBox myTxtbx_original_pixel, TextBox myTxtbx_original_red, TextBox myTxtbx_original_green, 
            TextBox myTxtbx_original_blue, CheckBox myCheckBox, TextBox myTxtbx_red_flip_bit7, 
            TextBox myTxtbx_red_flip_bit8, TextBox myTxtbx_red_flip_bit7_8)
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
                myTextBoxX.Text = x.ToString(); // Put co-ordinates into textbox
                myTextBoxY.Text = y.ToString(); // Put co-ordinates into textbox
            }


            // Get the color of the pixel
            Color pixelColor = bitmap.GetPixel(x, y);

            string hexColor = ColourUtilities.GetPixelColourString(pixelColor);

            if (!ColourUtilities.WriteDataToUI(pixelColor, myLbl_original_pixel_value, myLbl_original_alpha,
                    myLbl_original_red, myLbl_original_green, myLbl_original_blue))
            {
                MsgBox.Show("Unable to work out the pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ColourUtilities.BackColourTextBox(pixelColor, myTxtbx_original_pixel,
                    myTxtbx_original_red, myTxtbx_original_green, myTxtbx_original_blue))
            {
                MsgBox.Show("Unable to Back Colour Textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ColourUtilities.WriteBinaryDataToTextBoxes(pixelColor, myTxtbx_original_red,
                    myTxtbx_original_green, myTxtbx_original_blue))
            {
                MsgBox.Show("Unable to Write Binary Data to Textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (myCheckBox.Checked)
            {
                if (!Encode(myPictureBox, x, y, myTxtbx_red_flip_bit8, myTxtbx_red_flip_bit7,
                        myTxtbx_red_flip_bit7_8))
                {
                    MsgBox.Show("Unable to Show encoded binary data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            GC.Collect(); //Clear memory to prevent leaks

            return true; //Change this
        }



        public static bool Encode(PictureBox myPictureBox, int myX, int myY, TextBox myTxtbx_red_flip_bit8, 
            TextBox myTxtbx_red_flip_bit7, TextBox myTxtbx_red_flip_bit7_8)
        {
            try
            {
            // Load the image
            Bitmap bitmap = new Bitmap(myPictureBox.Image);

           // Get the color of the pixel
            Color pixelColor = bitmap.GetPixel(myX, myY);

            var abc = BitConverter.GetBytes(pixelColor.R | (1 << 0))[0]; //convert byte to binary, change lsb, convert back to byte

            myTxtbx_red_flip_bit8.BackColor = Color.FromArgb(255, abc,
                255, 255);

            myTxtbx_red_flip_bit8.Text = DataConversion.ByteToBinary(abc);

            var combined_abc = BitConverter.GetBytes(abc | (1 << 1))[0]; // bit 0 and 1

            abc = BitConverter.GetBytes(pixelColor.R | (1 << 1))[0]; //convert byte to binary, change lsb, convert back to byte

            myTxtbx_red_flip_bit7.BackColor = Color.FromArgb(255, abc,
                255, 255);

            myTxtbx_red_flip_bit7.Text = DataConversion.ByteToBinary(abc);

            myTxtbx_red_flip_bit7_8.BackColor = Color.FromArgb(255, combined_abc,
                255, 255);
            myTxtbx_red_flip_bit7_8.Text = DataConversion.ByteToBinary(combined_abc);

            GC.Collect(); //Clear memory to prevent leaks


                //picbx_result.Image =
                //  ImageUtilities.EncodeColourIntoBitmap((Bitmap)picbx_result.Image, myColour, 
                //      int.Parse(txtbx_x_coord.Text), int.Parse(txtbx_y_coord.Text));

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }


    }
}
