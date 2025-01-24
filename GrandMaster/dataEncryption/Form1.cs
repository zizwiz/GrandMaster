using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Text;
using CenteredMessagebox;
using dataEncryption.Utils;

namespace dataEncryption
{
    public partial class Form1 : Form
    {
        Coordinates coordinates = new Coordinates();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put version number into top bar

            //Load the image into the picturebox so we can use it
            picbx_result.Image = picbx_Original.Image = Properties.Resources._0000;

            //make box to fit picture.
            picbx_Original.Size = picbx_result.Size = new Size(picbx_Original.Image.Width, picbx_Original.Image.Height);

            //ClientSize = new Size(picbx_Original.Image.Width, (picbx_Original.Image.Height + 160));

            ClientSize = new Size(picbx_Original.Image.Width, (picbx_Original.Image.Height + 320));

            CenterToScreen();


           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_get_original_pixel_colour_Click(object sender, EventArgs e)
        {
            // Reset the encryption data boxes
            if (!ColourUtilities.ResetEncyptedTextBoxes(txtbx_red_flip_bit8, txtbx_red_flip_bit7,
                    txtbx_red_flip_bit7_8))
            {
                MsgBox.Show("Unable to reset Encryption data boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get the pixel at the location you have added into the coordinates boxes.
            ImageUtilities.DecodePixelColour(picbx_Original, new Point(-1, -1), txtbx_x_coord, txtbx_y_coord,
                lbl_original_pixel_value, lbl_original_alpha, lbl_original_red,
                lbl_original_green, lbl_original_blue, txtbx_original_pixel, txtbx_original_red,
                txtbx_original_green, txtbx_original_blue, chkbx_encode, txtbx_red_flip_bit7, txtbx_red_flip_bit8,
                txtbx_red_flip_bit7_8);
        }




        private void picbx_Original_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset the encryption data boxes
            if (!ColourUtilities.ResetEncyptedTextBoxes(txtbx_red_flip_bit8, txtbx_red_flip_bit7,
                    txtbx_red_flip_bit7_8))
            {
                MsgBox.Show("Unable to reset Encryption data boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Get the pixel at the location the mouse pointer is at when you release the right button.
            ImageUtilities.DecodePixelColour(picbx_Original, e.Location, txtbx_x_coord, txtbx_y_coord,
                lbl_original_pixel_value, lbl_original_alpha, lbl_original_red,
                lbl_original_green, lbl_original_blue, txtbx_original_pixel, txtbx_original_red,
                txtbx_original_green, txtbx_original_blue, chkbx_encode, txtbx_red_flip_bit7, txtbx_red_flip_bit8,
                txtbx_red_flip_bit7_8);
        }


        private void picbx_Original_MouseMove(object sender, MouseEventArgs e)
        {
            Point myLocation = e.Location;

            // Show cordinates in floating window
            coordinates.Show();
            coordinates.lbl_x_coordinate.Text = myLocation.X.ToString();
            coordinates.lbl_y_coordinate.Text = myLocation.Y.ToString();

            coordinates.Location = new Point(myLocation.X, myLocation.Y);

        }

        private void picbx_Original_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Hide();
        }

        private void btn_save_modified_image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Exif Image|*.exif|" +
                                    "Png Image|*.png|Tiff Image| *.tiff";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Save an Image File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image myImage = picbx_result.Image;
                string myFilename = saveFileDialog.FileName;


                string extension = Path.GetExtension(myFilename);

                // switch (extension.ToLower())
                switch (saveFileDialog.FilterIndex.ToString())
                {
                    case "2":
                        myImage.Save(myFilename, ImageFormat.Bmp);
                        break;
                    case "4":
                        myImage.Save(myFilename, ImageFormat.Exif);
                        break;
                    case "3":
                        myImage.Save(myFilename, ImageFormat.Gif);
                        break;
                    case "1":
                        myImage.Save(myFilename, ImageFormat.Jpeg);
                        break;
                    case "5":
                        myImage.Save(myFilename, ImageFormat.Png);
                        break;
                    case "6":
                        myImage.Save(myFilename, ImageFormat.Tiff);
                        break;
                    default:
                        throw new NotSupportedException(
                            "Unknown file extension " + extension);
                }
            }
        }

        private void btn_encode_bitmap_Click(object sender, EventArgs e)
        {
            //if (!ImageUtilities.Encode(picbx_Original, txtbx_red_flip_bit8,
            //        txtbx_red_flip_bit7, txtbx_red_flip_bit7_8, txtbx_x_coord, txtbx_y_coord))
            //{
            //    MsgBox.Show("Unable to Show encoded binary data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //ColourUtilities.WriteDataToUI(pixelColor,  myLbl_original_pixel_value, myLbl_original_alpha,
            //    myLbl_original_red, myLbl_original_green, myLbl_original_blue);

            //ColourUtilities.BackColourTextBox(pixelColor, myTxtbx_original_pixel,
            //    myTxtbx_original_red, myTxtbx_original_green, myTxtbx_original_blue);

            //ColourUtilities.WriteBinaryDataToTextBoxes(pixelColor, myTxtbx_original_red,
            //    myTxtbx_original_green, myTxtbx_original_blue);

            char myChar;
            int charValue;
            string binaryString;

            String myString = txtbx_data_to_encode.Text;

            for (int i = 0; i < myString.Length; i++)
            {
                myChar = Convert.ToChar(myString.Substring(i, 1));
                rchtxtbx_debug.AppendText(myChar + " : ");

                charValue = (int)myChar;
                rchtxtbx_debug.AppendText(charValue.ToString("X") + " : ");

                binaryString = Convert.ToString(myChar, 2).PadLeft(8, '0');
                rchtxtbx_debug.AppendText(binaryString + "\r");

                rchtxtbx_debug.ScrollToCaret();
            }




            //char myChar = Convert.ToChar(myString.Substring(0, 1));

            //int charValue = (int)myChar;
            //string hexValue = charValue.ToString("X");

            //string binaryString = Convert.ToString(myChar, 2).PadLeft(8, '0');


            lbl_encoded_pixel_value.Text = ImageUtilities.Encode(picbx_Original, txtbx_red_flip_bit8,
                txtbx_red_flip_bit7, txtbx_red_flip_bit7_8, txtbx_x_coord, txtbx_y_coord).ToString("X");


            ImageUtilities.DecodePixelColour(picbx_Original, new Point(-1, -1), txtbx_x_coord, txtbx_y_coord,
                lbl_original_pixel_value, lbl_original_alpha, lbl_original_red,
                lbl_original_green, lbl_original_blue, txtbx_original_pixel, txtbx_original_red,
                txtbx_original_green, txtbx_original_blue, chkbx_encode, txtbx_red_flip_bit7, txtbx_red_flip_bit8,
                txtbx_red_flip_bit7_8);
        }

        private void btn_clear_debug_Click(object sender, EventArgs e)
        {
            rchtxtbx_debug.Clear();
        }

        private void btn_generate_random_Click(object sender, EventArgs e)
        {
            rchtxtbx_debug.AppendText(picbx_Original.Size + " : ");
            rchtxtbx_debug.AppendText(NumberUtilities.GenerateRandomNumber(0, picbx_Original.Width) + " : ");
            rchtxtbx_debug.AppendText(NumberUtilities.GenerateRandomNumber(0, picbx_Original.Height) + "\r");
        }
    }
}
