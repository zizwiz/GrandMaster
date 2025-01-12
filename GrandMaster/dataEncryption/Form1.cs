using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

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
            // Load the image
            Bitmap bitmap = new Bitmap(picbx_Original.Image);

            // Specify the coordinates of the pixel
            int x = int.Parse(txtbx_x_coord.Text); // X-coordinate
            int y = int.Parse(txtbx_y_coord.Text); // Y-coordinate

            // Get the color of the pixel
            Color pixelColor = bitmap.GetPixel(x, y);

            // Convert the color to a hex string
            // string hexColor = ColorTranslator.ToHtml(pixelColor);

            string hexColor = pixelColor.R.ToString("X") + " " + pixelColor.G.ToString("X") + " " +
                              pixelColor.B.ToString("X") + " " + pixelColor.A.ToString("X");

            lbl_original_pixel_value.Text = hexColor;

            txtbx_original_pixel.BackColor = Color.FromArgb(pixelColor.A, pixelColor.R,
                pixelColor.G, pixelColor.B);

            txtbx_original_red.BackColor = Color.FromArgb(255, pixelColor.R,
                255, 255);

            txtbx_original_green.BackColor = Color.FromArgb(255, 255,
                pixelColor.G, 255);

            txtbx_original_blue.BackColor = Color.FromArgb(255, 255,
                255, pixelColor.B);
        }


        private void picbx_Original_MouseUp(object sender, MouseEventArgs e)
        {
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

            // Convert the color to a hex string
            // string hexColor = ColorTranslator.ToHtml(pixelColor);

            string hexColor = pixelColor.R.ToString("X") + " " + pixelColor.G.ToString("X") + " " +
                              pixelColor.B.ToString("X") + " " + pixelColor.A.ToString("X");

            lbl_original_pixel_value.Text = hexColor;

            txtbx_original_pixel.BackColor = Color.FromArgb(pixelColor.A, pixelColor.R,
                pixelColor.G, pixelColor.B);

            txtbx_original_red.BackColor = Color.FromArgb(255, pixelColor.R,
                255, 255);
            txtbx_original_red.Text = Convert.ToString(pixelColor.R, 2).PadLeft(8, '0');


            txtbx_original_green.BackColor = Color.FromArgb(255, 255,
                pixelColor.G, 255);
            txtbx_original_green.Text = Convert.ToString(pixelColor.G, 2).PadLeft(8, '0');

            txtbx_original_blue.BackColor = Color.FromArgb(255, 255,
                255, pixelColor.B);
            txtbx_original_blue.Text = Convert.ToString(pixelColor.B, 2).PadLeft(8, '0');
        }


       private void picbx_Original_MouseMove(object sender, MouseEventArgs e)
        {
            Point myLocation = e.Location;

            // Show cordinates in floating window
            coordinates.Show();
            coordinates.lbl_x_coordinate.Text = myLocation.X.ToString();
            coordinates.lbl_y_coordinate.Text = myLocation.Y.ToString();
            
            coordinates.DesktopLocation = new Point(myLocation.X, myLocation.Y);

        }

        private void picbx_Original_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Hide();
        }
    }
}
