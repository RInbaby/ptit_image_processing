using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class IncreasePicture
    {
        public static bool increaseBrightness(Bitmap picture, int value)
        {
            // Vòng lặp
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    // Lấy giá trị
                    Color color = picture.GetPixel(i, j);
                    // Tính
                    int red = color.R + value < 255 ? color.R + value : 255;
                    int green = color.G + value < 255 ? color.G + value : 255;
                    int blue = color.B + value < 255 ? color.B + value : 255;
                    // Thiết lập lại
                    picture.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            return true;
        }
    }
}
