using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для EntryPoint.xaml
    /// </summary>
    public partial class EntryPoint : Window
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        public static string realbuffer = "";
        public static string realbalance = "";
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double balance = 0;
            string buffer = "";
            namesnroses.Content = App.Namep + " " + "XXXXXX";
            using (StreamReader sr = new StreamReader("Logins.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if ((line.Contains($"{App.Namep}" + " J4MM3D " + $"{App.Passp}")) && (line != String.Empty))
                    {
                        buffer = Convert.ToString(line.Split('|').GetValue(1));
                        sr.Close();
                        break;
                    }
                }
            }
            balance = Convert.ToDouble(buffer);
            realbalance = buffer;
            bal.Content = balance;
            BitmapImage mybitmapUni = new BitmapImage();
            switch (App.Namep+ " J4MM3D " + App.Passp)
            {
                case ("vindigo J4MM3D Master"):
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpvindigo.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#9e8bad");
                    break;
                case ("boolman J4MM3D 2000"):
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpbool.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#272763");
                    break;
                case ("Jerico J4MM3D Eyeless"):
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpeyes.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#1f471a");
                    break;
                case ("deadmans ringer J4MM3D 24976"):
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpred.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#992020");
                    break;
                case ("2ndbeam J4MM3D s0sisochki"):
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpbeam.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#ffccff");
                    break;
                default:
                    mybitmapUni.BeginInit();
                    mybitmapUni.UriSource = new Uri("pack://application:,,,/pfpdef.png");
                    mybitmapUni.EndInit();
                    pfp.Source = mybitmapUni;
                    this.Background = Themed.BackgroundColor("#878787");
                    //"#878787";
                    break;
            }
            string cardbuffer = "";
            using (StreamReader sr = new StreamReader("Logins.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if ((line.Contains($"{App.Namep}" + " J4MM3D " + $"{App.Passp}")) && (line != String.Empty))
                    {
                        cardbuffer = Convert.ToString(line.Split('|').GetValue(2));
                        realbuffer = cardbuffer;
                        sr.Close();
                        break;
                    }
                }
            }
            card.Content = cardbuffer;
            App.MyCard = cardbuffer;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Login.MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void giveMoney_Click(object sender, RoutedEventArgs e)
        {
            Login.Plus pl = new Plus();
            pl.ShowDialog();
            this.Hide();
            //string str = File.ReadAllText("Logins.txt");
            //str = str.Replace($"|{realbalance}|{realbuffer}", $"|{App.PlusMoney}|{realbuffer}");
            //File.WriteAllText("Logins.txt", str);
            //double balance = 0;
            //string buffer = "";
            //using (StreamReader sr = new StreamReader("Logins.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        var line = sr.ReadLine();

            //        if ((line.Contains($"{App.Namep}" + " J4MM3D " + $"{App.Passp}")) && (line != String.Empty))
            //        {
            //            buffer = Convert.ToString(line.Split('|').GetValue(1));
            //            sr.Close();
            //            break;
            //        }
            //    }
            //}
            //balance = Convert.ToDouble(buffer);
            //bal.Content = balance;
        }

        private void takeMoney_Click(object sender, RoutedEventArgs e)
        {
            Login.Minus min = new Minus();
            min.ShowDialog();
            this.Hide();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            Login.TransferMan tr = new TransferMan();
            tr.ShowDialog();
            this.Hide();
        }
    }
}
