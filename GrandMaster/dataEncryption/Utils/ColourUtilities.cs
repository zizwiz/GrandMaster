using System;
using System.Drawing;
using System.Windows.Forms;

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

        /// <summary>
        /// Write the pixel data to the UI
        /// </summary>
        /// <param name="myPixelColor"></param>
        /// <param name="myLbl_original_pixel_value"></param>
        /// <param name="myLbl_original_alpha"></param>
        /// <param name="myLbl_original_red"></param>
        /// <param name="myLbl_original_green"></param>
        /// <param name="myLbl_original_blue"></param>
        /// <returns>True is successful else False</returns>
        public static bool WriteDataToUI(Color myPixelColor, Label myLbl_original_pixel_value, Label myLbl_original_alpha,
            Label myLbl_original_red, Label myLbl_original_green, Label myLbl_original_blue)
        {
            bool result;
            try
            {
                myLbl_original_pixel_value.Text = GetPixelColourString(myPixelColor);

                myLbl_original_alpha.Text = myPixelColor.A.ToString("X").PadLeft(2, '0');
                myLbl_original_red.Text = myPixelColor.R.ToString("X").PadLeft(2, '0');
                myLbl_original_green.Text = myPixelColor.G.ToString("X").PadLeft(2, '0');
                myLbl_original_blue.Text = myPixelColor.B.ToString("X").PadLeft(2, '0');
                
                result = true;
            }
            catch 
            {
                result = false;
            }

            return result;

        }

        /// <summary>
        /// Colours the channel colour Textboxes to the pixel channel colour
        /// </summary>
        /// <param name="myPixelColor"></param>
        /// <param name="myTxtbx_original_pixel"></param>
        /// <param name="myTxtbx_original_red"></param>
        /// <param name="myTxtbx_original_green"></param>
        /// <param name="myTxtbx_original_blue"></param>
        /// <returns>True is successful else False</returns>
        public static bool BackColourTextBox(Color myPixelColor, TextBox myTxtbx_original_pixel, 
            TextBox myTxtbx_original_red, TextBox myTxtbx_original_green, TextBox myTxtbx_original_blue)
        {
            bool result;
            try
            {
               myTxtbx_original_pixel.BackColor = Color.FromArgb(myPixelColor.A, myPixelColor.R,
                   myPixelColor.G, myPixelColor.B);

                myTxtbx_original_red.BackColor = Color.FromArgb(255, myPixelColor.R,
                    255, 255);
                myTxtbx_original_green.BackColor = Color.FromArgb(255, 255,
                    myPixelColor.G, 255);
                myTxtbx_original_blue.BackColor = Color.FromArgb(255, 255,
                    255, myPixelColor.B);
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;

        }

        /// <summary>
        /// Writes the pixel channel colour to the Channel colour textboxes on the UI as binary data.
        /// </summary>
        /// <param name="myPixelColor"></param>
        /// <param name="myTxtbx_original_red"></param>
        /// <param name="myTxtbx_original_green"></param>
        /// <param name="myTxtbx_original_blue"></param>
        /// <returns>True is successful else False</returns>
        public static bool WriteBinaryDataToTextBoxes(Color myPixelColor, TextBox myTxtbx_original_red, 
            TextBox myTxtbx_original_green, TextBox myTxtbx_original_blue)
        {
            bool result;
            try
            {
                myTxtbx_original_red.Text = DataConversion.ByteToBinary(myPixelColor.R); //show binary value
                myTxtbx_original_green.Text = DataConversion.ByteToBinary(myPixelColor.G);  //show binary value
                myTxtbx_original_blue.Text = DataConversion.ByteToBinary(myPixelColor.B);  //show binary value
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;

        }

        /// <summary>
        /// Resets the encrypted data textboxes.
        /// </summary>
        /// <param name="myTxtbx_red_flip_bit8"></param>
        /// <param name="myTxtbx_red_flip_bit7"></param>
        /// <param name="myTxtbx_red_flip_bit7_8"></param>
        /// <returns>True is successful else False</returns>
        public static bool ResetEncyptedTextBoxes(TextBox myTxtbx_red_flip_bit8, TextBox myTxtbx_red_flip_bit7,
            TextBox myTxtbx_red_flip_bit7_8)
        {
            bool result;
            try
            {
                myTxtbx_red_flip_bit8.BackColor = Color.FromArgb(255, 255, 255, 255);
                myTxtbx_red_flip_bit8.Text = "";
                myTxtbx_red_flip_bit7.BackColor = Color.FromArgb(255, 255, 255, 255);
                myTxtbx_red_flip_bit7.Text = "";
                myTxtbx_red_flip_bit7_8.BackColor = Color.FromArgb(255, 255, 255, 255);
                myTxtbx_red_flip_bit7_8.Text = "";
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;

        }
    }
}
