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
    /// Логика взаимодействия для Minus.xaml
    /// </summary>
    public partial class Minus : Window
    {
        public Minus()
        {
            InitializeComponent();
        }

        private void OperateMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string konevsky = "";
                string man = MinMin.Text;
                using (StreamReader sr = new StreamReader("Logins.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        if ((line.Contains($"{App.Namep}" + " J4MM3D " + $"{App.Passp}")) && (line != String.Empty))
                        {
                            konevsky = Convert.ToString(line.Split('|').GetValue(1));
                            sr.Close();
                            break;
                        }
                    }
                }
                if (Convert.ToDouble(man) < 0)
                {
                    MessageBox.Show("Лучше воспользуйтесь вводом!");
                    MinMin.Text = null;
                }
                else if (Convert.ToDouble(man) == 0)
                {
                    MessageBox.Show("зачем");
                    MinMin.Text = null;
                }
                else if (Convert.ToDouble(konevsky)>=Convert.ToDouble(man))
                {
                    double dummy = Math.Round(Convert.ToDouble(man), 2);
                    App.MinusMoney = Convert.ToString(Math.Round(dummy, 2));
                    string str = File.ReadAllText("Logins.txt");
                    str = str.Replace($"|{EntryPoint.realbalance}|{EntryPoint.realbuffer}", $"|{Convert.ToDouble(EntryPoint.realbalance) - Convert.ToDouble(App.MinusMoney)}|{EntryPoint.realbuffer}");
                    File.WriteAllText("Logins.txt", str);
                    double balance = 0;
                    string buffer = "";
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
                    EntryPoint.realbalance = Convert.ToString(balance);
                    Updater updater = new Updater();
                    updater.MyNumber = balance;
                    MessageBox.Show("Готово!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("У вас нет столько денег!");
                    MinMin.Text = null;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число!");
                MinMin.Text = null;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Login.EntryPoint entryPoint = new Login.EntryPoint();
            entryPoint.Show();
        }
    }
}
