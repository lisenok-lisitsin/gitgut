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
    /// Логика взаимодействия для TransferMan.xaml
    /// </summary>
    public partial class TransferMan : Window
    {
        public TransferMan()
        {
            InitializeComponent();
        }

        private void Transfered_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double g1 = Convert.ToDouble(T1.Text), g2 = Convert.ToDouble(T2.Text), g3 = Convert.ToDouble(T3.Text), g4 = Convert.ToDouble(T4.Text);
                App.NewCard = T1.Text + T2.Text + T3.Text + T4.Text;
                if (App.MyCard == App.MakeNewCard(App.NewCard))
                {
                    MessageBox.Show("Себе перевести нельзя!");
                }
                else
                {
                    double money = Convert.ToDouble(Amount.Text);
                    App.TransMoney = Amount.Text;
                    string konevsky = "";
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
                    if (Convert.ToDouble(App.TransMoney) < 0)
                    {
                        MessageBox.Show("Лучше воспользуйтесь вводом!");
                        Amount.Text = null;
                    }
                    else if (Convert.ToDouble(App.TransMoney) == 0)
                    {
                        MessageBox.Show("зачем");
                        Amount.Text = null;
                    }
                    else if (Convert.ToDouble(konevsky) >= Convert.ToDouble(App.TransMoney))
                    {
                        //double mybalance = 0;
                        //string mybuffer = "";
                        //using (StreamReader sr = new StreamReader("Logins.txt"))
                        //{
                        //    while (!sr.EndOfStream)
                        //    {
                        //        var line = sr.ReadLine();

                        //        if ((line.Contains($"|{App.Namep}" + " J4MM3D " + $"{App.Passp}")) && (line != String.Empty))
                        //        {
                        //            mybuffer = Convert.ToString(line.Split('|').GetValue(1));
                        //            sr.Close();
                        //            break;
                        //        }
                        //    }
                        //}
                        //mybalance = Convert.ToDouble(mybuffer);
                        if (App.MakeNewCard(App.NewCard) == null)
                        {
                            MessageBox.Show("Таких карт не существует!");
                            T1.Text = "";
                            T2.Text = "";
                            T3.Text = "";
                            T4.Text = "";
                        }
                        else
                        {
                            double otherbalance = 0;
                            string otherbufffer = "";
                            using (StreamReader sr = new StreamReader("Logins.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    var line = sr.ReadLine();

                                    if ((line.Contains($"|{App.MakeNewCard(App.NewCard)}")) && (line != String.Empty))
                                    {
                                        otherbufffer = Convert.ToString(line.Split('|').GetValue(1));
                                        sr.Close();
                                        break;
                                    }
                                }
                            }
                            otherbalance = Convert.ToDouble(otherbufffer);
                            string str = File.ReadAllText("Logins.txt");
                            str = str.Replace($"|{otherbalance}|{App.MakeNewCard(App.NewCard)}", $"|{Convert.ToDouble(otherbalance) + Convert.ToDouble(App.TransMoney)}|{App.MakeNewCard(App.NewCard)}");
                            File.WriteAllText("Logins.txt", str);
                            str = str.Replace($"|{EntryPoint.realbalance}|{EntryPoint.realbuffer}", $"|{Convert.ToDouble(EntryPoint.realbalance) - Convert.ToDouble(App.TransMoney)}|{EntryPoint.realbuffer}");
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
                    }
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Введите всё цифрами!");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Updater updater = new Updater();
            updater.MyNumber = Convert.ToDouble(EntryPoint.realbalance);
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
        }
    }
}
