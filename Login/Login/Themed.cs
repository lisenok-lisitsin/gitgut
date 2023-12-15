using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Login
{
    public class Themed
    {
        public static SolidColorBrush BackgroundColor(string color1)
        {
            Color color = (Color)ColorConverter.ConvertFromString(color1);
            SolidColorBrush brush = new SolidColorBrush(color);
            return brush;
        }
        public static string GenerateCardNumber()
        {
            string buffer = "";
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                int j = r.Next(0,10);
                buffer += Convert.ToString(j);
                if (i == 3 || i == 7 || i == 11)
                {
                    buffer += "/";
                }
            }
            return (buffer);
            //double num1 = r.Next(0000,10000);
            //double num2 = r.Next(0000, 10000);
            //double num3 = r.Next(0000, 10000);
            //double num4 = r.Next(0000, 10000);
            //string buffer = $"{num1}" + $"{num2}" + $"{num3}" + $"{num4}";
        }
    }
}
