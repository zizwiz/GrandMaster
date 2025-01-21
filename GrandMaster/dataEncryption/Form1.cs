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

            ClientSize = new Size(picbx_Original.Image.Width, (picbx_Original.Image.Height + 160));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_get_original_pixel_colour_Click(object sender, EventArgs e)
        {
            ImageUtilities.DecodePixelColour(picbx_Original, new Point(-1, -1), txtbx_x_coord, txtbx_y_coord,
                lbl_original_pixel_value, lbl_original_alpha, lbl_original_red,
                lbl_original_green, lbl_original_blue, txtbx_original_pixel, txtbx_original_red, 
                txtbx_original_green, txtbx_original_blue);
        }




        private void picbx_Original_MouseUp(object sender, MouseEventArgs e)
        {
            ImageUtilities.DecodePixelColour(picbx_Original, new Point(-1, -1), txtbx_x_coord, txtbx_y_coord,
                lbl_original_pixel_value, lbl_original_alpha, lbl_original_red,
                lbl_original_green, lbl_original_blue, txtbx_original_pixel, txtbx_original_red,
                txtbx_original_green, txtbx_original_blue);

           // To Do all below

            Point myLocation = e.Location;

            // Load the image
            Bitmap bitmap = new Bitmap(picbx_Original.Image);

            // Specify the coordinates of the pixel
            int x = myLocation.X; // X-coordinate
            int y = myLocation.Y; // Y-coordinate

            txtbx_x_coord.Text = x.ToString();
            txtbx_y_coord.Text = y.ToString();

            // Get the color of the pixel
            Color pixelColor = bitmap.GetPixel(x, y);

            var abc = BitConverter.GetBytes(pixelColor.R | (1 << 0))[0]; //convert byte to binary, change lsb, convert back to byte

            txtbx_red_flip_bit8.BackColor = Color.FromArgb(255, abc,
                255, 255);

            txtbx_red_flip_bit8.Text = DataConversion.ByteToBinary(abc);

            var combined_abc = BitConverter.GetBytes(abc | (1 << 1))[0]; // bit 0 and 1

            abc = BitConverter.GetBytes(pixelColor.R | (1 << 1))[0]; //convert byte to binary, change lsb, convert back to byte

            txtbx_red_flip_bit7.BackColor = Color.FromArgb(255, abc,
                255, 255);

            txtbx_red_flip_bit7.Text = DataConversion.ByteToBinary(abc);
            
            txtbx_red_flip_bit7_8.BackColor = Color.FromArgb(255, combined_abc,
                255, 255);
            txtbx_red_flip_bit7_8.Text = DataConversion.ByteToBinary(combined_abc);


           

            GC.Collect(); //Clear memory to prevent leaks
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





            //picbx_result.Image =
            //  ImageUtilities.EncodeColourIntoBitmap((Bitmap)picbx_result.Image, myColour, 
            //      int.Parse(txtbx_x_coord.Text), int.Parse(txtbx_y_coord.Text));



        }
    }
}
