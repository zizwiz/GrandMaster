using System;
using System.Drawing;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace ColourChanger
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private TextBox[][] TextBoxes;
        private bool flag = false;

        /// These are only used for explaining
        private int RedX; private int RedY;
        private int GreenX; private int GreenY;
        private int BlueX; private int BlueY;
        private int BlackX; private int BlackY;
        private int WhiteX; private int WhiteY;

        // Display the image converted to sepia tone.
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxes = new TextBox[][]
            {
                //             Red,   Green, Blue,  Opacity,  Not Used
                new TextBox[] {txt00, txt01, txt02, txt03, txt04}, // Red scaling factor
                new TextBox[] {txt10, txt11, txt12, txt13, txt14}, // Green scaling factor
                new TextBox[] {txt20, txt21, txt22, txt23, txt24}, // Blue scaling factor
                new TextBox[] {txt30, txt31, txt32, txt33, txt34}, // Alpha (Opacity) scaling factor
                new TextBox[] {txt40, txt41, txt42, txt43, txt44}, // Translations
            };

            ResetToOriginal();


            // This column of the matrix does nothing as it is not used.
            // We make it invisible and this prevents confusion.
            txt04.Visible = txt14.Visible = txt24.Visible = txt34.Visible = txt44.Visible = false;

            txtbx_red.BackColor = Color.FromArgb(255, 255, 0, 0);
            txtbx_green.BackColor = Color.FromArgb(255, 0, 255, 0);
            txtbx_blue.BackColor = Color.FromArgb(255, 0, 0, 255);
            txtbx_black.BackColor = Color.FromArgb(255, 0, 0, 0);
            txtbx_white.BackColor = Color.FromArgb(255, 255, 255, 255);


            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        // Color the picture.
        private void ColorPicture()
        {
            if (picOriginal.Image == null) return;

            picToned.Image = AdjustColor(picOriginal.Image);
            mnuFileSaveAs.Enabled = (picToned.Image != null);

            Color RedPixelBeforeColor = new Bitmap(picOriginal.Image).GetPixel(RedX, RedY);
            lbl_R_before.Text = RedPixelBeforeColor.ToString();

            Color GreenPixelBeforeColor = new Bitmap(picOriginal.Image).GetPixel(GreenX, GreenY);
            lbl_G_before.Text = GreenPixelBeforeColor.ToString();

            Color BluePixelBeforeColor = new Bitmap(picOriginal.Image).GetPixel(BlueX, BlueY);
            lbl_B_before.Text = BluePixelBeforeColor.ToString();

            Color BlackPixelBeforeColor = new Bitmap(picOriginal.Image).GetPixel(BlackX, BlackY);
            lbl_K_before.Text = BlackPixelBeforeColor.ToString();

            Color WhitePixelBeforeColor = new Bitmap(picOriginal.Image).GetPixel(WhiteX, WhiteY);
            lbl_W_before.Text = WhitePixelBeforeColor.ToString();

            Color RedPixelAfterColor = new Bitmap(picToned.Image).GetPixel(RedX, RedY);
            lbl_R_after.Text = RedPixelAfterColor.ToString();

            Color GreenPixelAfterColor = new Bitmap(picToned.Image).GetPixel(GreenX, GreenY);
            lbl_G_after.Text = GreenPixelAfterColor.ToString();

            Color BluePixelAfterColor = new Bitmap(picToned.Image).GetPixel(BlueX, BlueY);
            lbl_B_after.Text = BluePixelAfterColor.ToString();

            Color BlackPixelAfterColor = new Bitmap(picToned.Image).GetPixel(BlackX, BlackY);
            lbl_K_after.Text = BlackPixelAfterColor.ToString();

            Color WhitePixelAfterColor = new Bitmap(picToned.Image).GetPixel(WhiteX, WhiteY);
            lbl_W_after.Text = WhitePixelAfterColor.ToString();

            GC.Collect(); // Used to clean up and return used memory.
        }

        // Return the matrix entered by the user.
        private ColorMatrix GetColorMatrix()
        {
            float[][] values = GetMatrix();
            if (values == null) return null;
            return new ColorMatrix(values);
        }

        private float[][] GetMatrix()
        {
            float[][] values = { new float[5], new float[5], new float[5], new float[5], new float[5], };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    float value;
                    if (!float.TryParse(TextBoxes[i][j].Text, out value))
                    {
                        MessageBox.Show("Invalid entry");
                        TextBoxes[i][j].Focus();
                        return null;
                    }

                    values[i][j] = value;
                }
            }

            return values;
        }

        // Display this matrix in the text boxes.
        private void SaveMatrix(float[][] values)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    TextBoxes[i][j].Text = values[i][j].ToString("f4");
                }
            }
        }

        // Adjust the image's colors.
        private Image AdjustColor(Image image)
        {
            // Make the ColorMatrix.
            ColorMatrix cm = GetColorMatrix();
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Make the result image.
            return image.CopyImage(attributes);
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                picOriginal.Image = LoadBitmapUnlocked(ofdPicture.FileName);

                string myFileName = Path.GetFileNameWithoutExtension(ofdPicture.FileName);

                lbl_R_before.Visible = lbl_G_before.Visible = lbl_B_before.Visible = lbl_K_before.Visible =
                    lbl_W_before.Visible = lbl_R_after.Visible = lbl_G_after.Visible = lbl_B_after.Visible =
                        lbl_K_after.Visible = lbl_W_after.Visible = txtbx_red.Visible = txtbx_black.Visible =
                            txtbx_blue.Visible = txtbx_green.Visible = txtbx_white.Visible = lbl_pixel_colour.Visible =
                                true;

                // We only use this to tell us where the pixels are we are looking at during the explanation
                // If using the app as a user then yo do not need this info so make them invisible.
                if (myFileName == "100blocks_input")
                {
                    RedX = 50; RedY = 50;
                    GreenX = 150; GreenY = 50;
                    BlueX = 250; BlueY = 50;
                    BlackX = 350; BlackY = 50;
                    WhiteX = 450; WhiteY = 50;

                }
                else if (myFileName == "colourcast_input")
                {
                    RedX = 960; RedY = 139;
                    GreenX = 625; GreenY = 280;
                    BlueX = 610; BlueY = 460;
                    BlackX = 600; BlackY = 139;
                    WhiteX = 260; WhiteY = 139;
                }
                else if (myFileName == "rgb_input")
                {
                    RedX = 0; RedY = 0;
                    GreenX = 1; GreenY = 0;
                    BlueX = 2; BlueY = 0;
                    BlackX = 3; BlackY = 0;
                    WhiteX = 4; WhiteY = 0;
                }
                else
                {
                    lbl_R_before.Visible = lbl_G_before.Visible = lbl_B_before.Visible = lbl_K_before.Visible =
                        lbl_W_before.Visible = lbl_R_after.Visible = lbl_G_after.Visible = lbl_B_after.Visible =
                            lbl_K_after.Visible = lbl_W_after.Visible = txtbx_red.Visible = txtbx_black.Visible =
                                txtbx_blue.Visible = txtbx_green.Visible = txtbx_white.Visible = lbl_pixel_colour.Visible = 
                                    false;
                }
                
                ColorPicture();
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (sfdPicture.ShowDialog() == DialogResult.OK)
            {
                SaveImage(picToned.Image, sfdPicture.FileName);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuPresets_Click(object sender, EventArgs e)
        {
            //foreach (TextBox[] txt_array in TextBoxes)
            //{
            //    foreach (TextBox txt in txt_array)
            //    {
            //        txt.Text = "0";
            //        for (int i = 3; i < 5; i++)
            //        {
            //            TextBoxes[i][i].Text = "1";
            //        }
            //    }
            //}
            ResetToOriginal();

            ToolStripMenuItem menu_item = sender as ToolStripMenuItem;

            if (menu_item.Tag.ToString().ToLower() == "use bg color")
            {
                Color color = menu_item.BackColor;
                txt00.Text = (color.R / 255f).ToString("f4");
                txt11.Text = (color.G / 255f).ToString("f4");
                txt22.Text = (color.B / 255f).ToString("f4");
                txt33.Text = "1";
                txt44.Text = "1";
            }
            else
            {
                string color_name = menu_item.Text.Replace("&", "").ToLower();

                if (color_name == "identity")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        TextBoxes[i][i].Text = "1";
                    }
                }
                else if (color_name == "average")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            TextBoxes[i][j].Text = "0.3333";
                        }
                    }
                }
                else if (color_name == "monochrome")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        TextBoxes[0][i].Text = "0.2990";
                        TextBoxes[1][i].Text = "0.5870";
                        TextBoxes[2][i].Text = "0.1140";
                    }
                }
                else if (color_name == "sepia")
                {
                    txt00.Text = "0.3930";
                    txt01.Text = "0.3490";
                    txt02.Text = "0.2720";
                    txt10.Text = "0.7690";
                    txt11.Text = "0.6860";
                    txt12.Text = "0.5340";
                    txt20.Text = "0.1890";
                    txt21.Text = "0.1680";
                    txt22.Text = "0.1310";
                }
                else
                {
                    MessageBox.Show("Unknown preset");
                    return;
                }
            }

            ColorPicture();
        }

        // Save the file with the appropriate format.
        public void SaveImage(Image image, string filename)
        {
            string extension = Path.GetExtension(filename);
            switch (extension.ToLower())
            {
                case ".bmp":
                    image.Save(filename, ImageFormat.Bmp);
                    break;
                case ".exif":
                    image.Save(filename, ImageFormat.Exif);
                    break;
                case ".gif":
                    image.Save(filename, ImageFormat.Gif);
                    break;
                case ".jpg":
                case ".jpeg":
                    image.Save(filename, ImageFormat.Jpeg);
                    break;
                case ".png":
                    image.Save(filename, ImageFormat.Png);
                    break;
                case ".tif":
                case ".tiff":
                    image.Save(filename, ImageFormat.Tiff);
                    break;
                default:
                    throw new NotSupportedException(
                        "Unknown file extension " + extension);
            }
        }

        // Load a bitmap without locking it.
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

        private void btnColorize_Click(object sender, EventArgs e)
        {
            ColorPicture();
        }

        private void btnBrighter_Click(object sender, EventArgs e)
        {
            float[][] values = GetMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Math.Abs(values[i][j]) < 0.01f) continue;
                    values[i][j] += 0.1f;
                }
            }

            SaveMatrix(values);
            ColorPicture();
        }

        private void btnDarker_Click(object sender, EventArgs e)
        {
            float[][] values = GetMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Math.Abs(values[i][j]) < 0.01f) continue;
                    values[i][j] -= 0.1f;
                    if (values[i][j] < 0f) values[i][j] = 0f;
                }
            }

            SaveMatrix(values);
            ColorPicture();
        }

        private void ResetToOriginal()
        {
            foreach (TextBox[] txt_array in TextBoxes)
            {
                foreach (TextBox txt in txt_array)
                {
                    txt.Text = "0";
                    for (int i = 0; i < 5; i++)
                    {
                        TextBoxes[i][i].Text = "1";
                    }
                }
            }
        }

        private void mnuSwapRedGreen_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][0].Text = TextBoxes[1][1].Text = "0";
            TextBoxes[0][1].Text = TextBoxes[1][0].Text = "1";
            ColorPicture();
        }

        private void mnuSwapRedBlue_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][0].Text = TextBoxes[2][2].Text = "0";
            TextBoxes[0][2].Text = TextBoxes[2][0].Text = "1";
            ColorPicture();
        }

        private void mnuSwapGreenBlue_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[1][1].Text = TextBoxes[2][2].Text = "0";
            TextBoxes[1][2].Text = TextBoxes[2][1].Text = "1";
            ColorPicture();
        }

        private void mnuRedToOrange_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][1].Text = "0.6471";
            TextBoxes[1][1].Text = "0";
            ColorPicture();
        }

        private void mnuRedToYellow_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][1].Text = "1";
            TextBoxes[1][1].Text = "0";
            ColorPicture();
        }

        private void mnuRedToFuchsia_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][0].Text = "1.3";
            TextBoxes[0][2].Text = "1.3";
            TextBoxes[1][1].Text = "0.5";
            TextBoxes[2][2].Text = "0";
            ColorPicture();
        }

        private void mnuRedToWhite_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][1].Text = TextBoxes[0][2].Text = "1";
            TextBoxes[1][1].Text = TextBoxes[2][2].Text = "0";
            ColorPicture();
        }

        private void mnuRedToBlack_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            TextBoxes[0][0].Text = TextBoxes[0][1].Text = TextBoxes[0][2].Text = "0.2";
            TextBoxes[1][1].Text = TextBoxes[2][2].Text = "0";
            ColorPicture();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetToOriginal();
            ColorPicture();
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            TextBox senderTextBox = sender as TextBox;

            // red = R*00 + G*10 + B*20 + A*30 + 40

            //These boxes show the effect you have on the colour.
            // Colours here are ARGB

            // Red = 255 255 0 0
            //if (flag)
            //{
            //    var abc = txt44.Text;



            //    lbl_before.Text = "255";
            //    lbl_after.Text = ((255 * float.Parse(txt00.Text)) + (255 * float.Parse(txt10.Text)) +
            //                      (255 * float.Parse(txt20.Text)) + (255 * float.Parse(txt30.Text)) +
            //                      (0 * float.Parse(txt30.Text))).ToString();

            //    txtbx_red.BackColor = Color.FromArgb(255, 255, 0, 0);


            //    // Blue
            //    txtbx_blue.BackColor = Color.FromArgb(255, 0, 0, 255);



            //    // Green
            //    txtbx_green.BackColor = Color.FromArgb(255, 0, 128, 0);

            //}




            ////float val = 0;
            //bool res = float.TryParse(senderTextBox.Text, out float val);
            //if (res && val >= -1 && val <= 1)
            //{
            //    // OK
            //}
            //else
            //{
            //   // MessageBox.Show("Please input float between -1 to 1 only.");
            //   // return;
            //}
        }
    }
}
