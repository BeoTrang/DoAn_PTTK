using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace dll_captcha
{
    public class tao_capcha
    {
        private static Random random = new Random();
        private static string[] fonts = { "Arial", "Verdana", "Times New Roman", "Comic Sans MS", "Tahoma" };
        public static Bitmap TaoCaptcha(string inputText)
        {
            if (inputText.Length != 6)
                throw new ArgumentException("6 kí tự cơ mà!!!");
            Bitmap anh_background = LoadRandomBackground();
            int width = anh_background.Width;
            int height = anh_background.Height;
            Bitmap Anh_Captcha = new Bitmap(width, height);
            using (Graphics Anh = Graphics.FromImage(Anh_Captcha))
            {
                Anh.DrawImage(anh_background, 0, 0, width, height);
                for (int i = 0; i < inputText.Length; i++)
                {
                    char c = inputText[i];
                    string fontName = fonts[random.Next(fonts.Length)];
                    int fontSize = random.Next(100, 120);
                    Font font = new Font(fontName, fontSize, FontStyle.Bold);
                    Color fontColor = Color.FromArgb(random.Next(50, 200), random.Next(50, 200), random.Next(50, 200));
                    float angle = random.Next(-45, 45);
                    int x = i * (width / inputText.Length) + random.Next(-5, 5);
                    int y = random.Next(10, height / 2);
                    Anh.TranslateTransform(x, y);
                    Anh.RotateTransform(angle);
                    Anh.DrawString(c.ToString(), font, new SolidBrush(fontColor), 0, 0);
                    Anh.ResetTransform();
                }
                AddNoise(Anh, width, height);
            }

            return Anh_Captcha;
        }

        private static Bitmap LoadRandomBackground()
        {
            int backgroundIndex = random.Next(1, 10);
            string resourceName = $"DLL_CAPCHA.Resources.background{backgroundIndex}.jpg";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                return new Bitmap(stream);
            }
        }

        private static void AddNoise(Graphics Anh, int width, int height)
        {
            for (int i = 0; i < 10; i++)
            {
                Pen pen = new Pen(Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)), 1);
                Anh.DrawLine(pen, random.Next(width), random.Next(height), random.Next(width), random.Next(height));
            }

            for (int i = 0; i < 5; i++)
            {
                Pen pen = new Pen(Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)), 1);
                Anh.DrawEllipse(pen, random.Next(width), random.Next(height), random.Next(10, 30), random.Next(10, 30));
            }
        }
    }
}
