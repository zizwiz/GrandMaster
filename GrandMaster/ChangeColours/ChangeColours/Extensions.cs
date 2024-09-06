using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;

namespace ColourChanger
{
    public static class Extensions
    {
        public static Image CopyImage(this Image image)
        {
            return (Image)image.Clone();
        }

        public static Image CopyImage(this Image image, ImageAttributes attributes)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(result))
            {
                Rectangle rect = new Rectangle(
                    0, 0, image.Width, image.Height);
                gr.DrawImage(image, rect,
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            return result;
        }
    }
}
