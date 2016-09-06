using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Tool.CropImage
{
    public class ImageCrop
    {
        public byte[] Crop(string resim, int X, int Y, int Width, int Height)
        {
            using (System.Drawing.Image OriginalImage = System.Drawing.Image.FromFile(resim))
            {
                Bitmap bmp = new Bitmap(Width, Height);
                bmp.SetResolution(OriginalImage.HorizontalResolution, OriginalImage.VerticalResolution);
                Graphics graphic = Graphics.FromImage(bmp);
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.DrawImage(OriginalImage, new Rectangle(0, 0, Width, Height), X, Y, Width, Height, GraphicsUnit.Pixel);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, OriginalImage.RawFormat);
                return ms.GetBuffer();
            }
        }

        public byte[] Crop(Stream stream, int X, int Y, int Width, int Height)
        {
            var OriginalImage = Image.FromStream(stream);
            Bitmap bmp = new Bitmap(Width, Height);
            bmp.SetResolution(OriginalImage.HorizontalResolution, OriginalImage.VerticalResolution);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.SmoothingMode = SmoothingMode.AntiAlias;
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.DrawImage(OriginalImage, new Rectangle(0, 0, Width, Height), X, Y, Width, Height, GraphicsUnit.Pixel);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, OriginalImage.RawFormat);
            return ms.GetBuffer();
        }

        public System.Drawing.Image ResizeImage(int maxWidth, int maxHeight, System.Drawing.Image Image)
        {
            int width = Image.Width;
            int height = Image.Height;
            if (width > maxWidth || height > maxHeight)
            {
                //The flips are in here to prevent any embedded image thumbnails -- usually from cameras
                //from displaying as the thumbnail image later, in other words, we want a clean
                //resize, not a grainy one.
                Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipX);
                Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipX);

                float ratio = 0;
                if (width > height)
                {
                    ratio = (float)width / (float)height;
                    width = maxWidth;
                    height = Convert.ToInt32(Math.Round((float)width / ratio));
                }
                else
                {
                    ratio = (float)height / (float)width;
                    height = maxHeight;
                    width = Convert.ToInt32(Math.Round((float)height / ratio));
                }

                //return the resized image
                return Image.GetThumbnailImage(width, height, null, IntPtr.Zero);
            }
            //return the original resized image
            return Image;
        }

        public int uzaklikDuzenle(int gelen, int orjinal, int bolum)
        {
            return orjinal * gelen / bolum;
        }
    }
}
