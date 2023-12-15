using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Namep { get; set; }
        public static string Passp { get; set; }
        public static string NewCard { get; set; }

        public static string MakeNewCard(string name)
        {
            try
            {
                string male = "";
                for (int i = 0; i < name.Length; i += 4)
                {
                    male += name.Substring(i, 4) + "/";
                }
                return male.Remove(male.Length - 1);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public static string MyCard { get; set; }
        public static string PlusMoney { get; set; }
        public static string MinusMoney { get; set; }
        public static string TransMoney { get; set; }
        public static bool OpenPlus { get; set; }
    }
}
