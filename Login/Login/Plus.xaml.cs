using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Plus.xaml
    /// </summary>
    public partial class Plus : Window
    {
        public Plus()
        {
            InitializeComponent();
        }

        private void PlusPlus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void OperatePlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string man = PlusPlus.Text;
                double dummy = Math.Round(Convert.ToDouble(man), 2);
                App.PlusMoney = Convert.ToString(Math.Round(dummy, 2));
                string str = File.ReadAllText("Logins.txt");
                str = str.Replace($"|{EntryPoint.realbalance}|{EntryPoint.realbuffer}", $"|{Convert.ToDouble(App.PlusMoney)+Convert.ToDouble(EntryPoint.realbalance)}|{EntryPoint.realbuffer}");
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
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число!");
                PlusPlus.Text = null;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.OpenPlus = true;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.OpenPlus = false;
            Updater updater = new Updater();
            updater.MyNumber = Convert.ToDouble(EntryPoint.realbalance);
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
        }
    }
}
