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

        // Display the image converted to sepia tone.
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxes = new TextBox[][]
            {
                new TextBox[] {txt00, txt01, txt02, txt03, txt04},
                new TextBox[] {txt10, txt11, txt12, txt13, txt14},
                new TextBox[] {txt20, txt21, txt22, txt23, txt24},
                new TextBox[] {txt30, txt31, txt32, txt33, txt34},
                new TextBox[] {txt40, txt41, txt42, txt43, txt44},
            };

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        // Color the picture.
        private void ColorPicture()
        {
            if (picOriginal.Image == null) return;

            picToned.Image = AdjustColor(picOriginal.Image);
            mnuFileSaveAs.Enabled = (picToned.Image != null);
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
            float[][] values = new float[][]
            {
                new float[5],
                new float[5],
                new float[5],
                new float[5],
                new float[5],
            };
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
            foreach (TextBox[] txt_array in TextBoxes)
                foreach (TextBox txt in txt_array)
                    txt.Text = "0.0000";
            for (int i = 3; i < 5; i++)
                TextBoxes[i][i].Text = "1.0000";

            ToolStripMenuItem menu_item = sender as ToolStripMenuItem;
            if (menu_item.Tag.ToString().ToLower() == "use bg color")
            {
                Color color = menu_item.BackColor;
                txt00.Text = (color.R / 255f).ToString("f4");
                txt11.Text = (color.G / 255f).ToString("f4");
                txt22.Text = (color.B / 255f).ToString("f4");
                txt33.Text = "1.0000";
                txt44.Text = "1.0000";
            }
            else
            {
                string color_name = menu_item.Text.Replace("&", "").ToLower();
                if (color_name == "identity")
                {
                    for (int i = 0; i < 3; i++)
                        TextBoxes[i][i].Text = "1.0000";
                }
                else if (color_name == "average")
                {
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            TextBoxes[i][j].Text = "0.3333";
                }
                else if (color_name == "monochrome")
                {
                    for (int i = 0; i < 3; i++)
                        TextBoxes[0][i].Text = "0.2990";
                    for (int i = 0; i < 3; i++)
                        TextBoxes[1][i].Text = "0.5870";
                    for (int i = 0; i < 3; i++)
                        TextBoxes[2][i].Text = "0.1140";
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
                    txt20.Text = "0.1680";
                    txt20.Text = "0.1310";
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

        private void MakeIdentity()
        {
            foreach (TextBox[] txt_array in TextBoxes)
                foreach (TextBox txt in txt_array)
                    txt.Text = "0.0000";
            for (int i = 0; i < 5; i++)
                TextBoxes[i][i].Text = "1.0000";
        }

        private void mnuSwapRedGreen_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][0].Text = "0.0000";
            TextBoxes[0][1].Text = "1.0000";
            TextBoxes[1][0].Text = "1.0000";
            TextBoxes[1][1].Text = "0.0000";
            ColorPicture();
        }

        private void mnuSwapRedBlue_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][0].Text = "0.0000";
            TextBoxes[0][2].Text = "1.0000";
            TextBoxes[2][0].Text = "1.0000";
            TextBoxes[2][2].Text = "0.0000";
            ColorPicture();
        }

        private void mnuSwapGreenBlue_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[1][1].Text = "0.0000";
            TextBoxes[1][2].Text = "1.0000";
            TextBoxes[2][1].Text = "1.0000";
            TextBoxes[2][2].Text = "0.0000";
            ColorPicture();
        }

        private void mnuRedToOrange_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][1].Text = "0.6471";
            TextBoxes[1][1].Text = "0.0000";
            ColorPicture();
        }

        private void mnuRedToYellow_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][1].Text = "1.0000";
            TextBoxes[1][1].Text = "0.0000";
            ColorPicture();
        }

        private void mnuRedToFuchsia_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][0].Text = "1.3000";
            TextBoxes[0][2].Text = "1.3000";
            TextBoxes[1][1].Text = "0.5000";
            TextBoxes[2][2].Text = "0.0000";
            ColorPicture();
        }

        private void mnuRedToWhite_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][1].Text = "1.0000";
            TextBoxes[0][2].Text = "1.0000";
            TextBoxes[1][1].Text = "0.0000";
            TextBoxes[2][2].Text = "0.0000";
            ColorPicture();
        }

        private void mnuRedToBlack_Click(object sender, EventArgs e)
        {
            MakeIdentity();
            TextBoxes[0][0].Text = "0.2000";
            TextBoxes[0][1].Text = "0.2000";
            TextBoxes[0][2].Text = "0.2000";
            TextBoxes[1][1].Text = "0.0000";
            TextBoxes[2][2].Text = "0.0000";
            ColorPicture();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt00.Text = "1"; txt01.Text = "0"; txt02.Text = "0"; txt03.Text = "0"; txt04.Text = "0";
            txt10.Text = "0"; txt11.Text = "1"; txt12.Text = "0"; txt13.Text = "0"; txt14.Text = "0";
            txt20.Text = "0"; txt21.Text = "0"; txt22.Text = "1"; txt23.Text = "0"; txt24.Text = "0";
            txt30.Text = "0"; txt31.Text = "0"; txt32.Text = "0"; txt33.Text = "1"; txt34.Text = "0";
            txt40.Text = "0"; txt41.Text = "0"; txt42.Text = "0"; txt43.Text = "0"; txt44.Text = "1";
            ColorPicture();
        }
    }
}
