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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int deadman = 0;

        private void CreateAcc_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameEntAcc.Text;
            string Password = PassEntAcc.Text;
            
            if (NameEntAcc.Text == "" || PassEntAcc.Text == "")
            {
                MessageBox.Show("Вы ошиблись!");
                deadman++;
                if (deadman == 3)
                {
                    MessageBox.Show("Вы - ошибка!");
                    MessageBox.Show("Вы - ошибка!");
                    MessageBox.Show("Вы - ошибка!");
                    MessageBox.Show("Вы - ошибка!");
                }
            }
            bool found = false;
            using (StreamReader sr = new StreamReader("Logins.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if ((line.Contains($"{Name}" + " J4MM3D " + $"{Password}")) && (line != String.Empty))
                    {
                        found = true;
                        sr.Close();
                        break;
                    }
                }
            }

            if (found == true)
            {
                MessageBox.Show("Такое уже существует");
                NameEntAcc.Text = "";
                PassEntAcc.Text = "";
            }
            else if (found == false)
            {
                using (StreamWriter sw = new StreamWriter("Logins.txt", append: true))
                {
                    sw.WriteLine($"{NameEntAcc.Text}" + " J4MM3D " + $"{PassEntAcc.Text}" + "|0,0|" +Themed.GenerateCardNumber());
                    MessageBox.Show("Аккаунт создан!");
                    NameEntAcc.Text = "";
                    PassEntAcc.Text = "";
                    sw.Close();
                }
            }
        }
        private void EntBut_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameEntAcc.Text;
            string Password = PassEntAcc.Text;
            var sr = new StreamReader("Logins.txt");
            if (NameEntAcc.Text == "" || PassEntAcc.Text == "")
            {
                MessageBox.Show("Вы ошиблись!");
                deadman++;
                if (deadman == 3)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        MessageBox.Show("Вы - ошибка!");
                    }
                }
                else if (deadman == 6)
                {
                    this.Close();
                }
            }
            else
            {
                bool boolman = false;
                while (!(sr.EndOfStream))
                {
                    var line = sr.ReadLine();
                    if ((line.Contains($"{Name}" + " J4MM3D " + $"{Password}")) && (line != String.Empty))
                    {
                        MessageBox.Show($"Добро пожаловать, {Name}!");
                        App.Namep = NameEntAcc.Text;
                        App.Passp = PassEntAcc.Text;
                        NameEntAcc.Text = "";
                        PassEntAcc.Text = "";
                        Login.EntryPoint entryPoint = new EntryPoint();
                        entryPoint.Show();
                        this.Hide();
                        boolman = true;
                        sr.Close();
                        break;
                    }
                }
                if (boolman == false)
                {
                    MessageBox.Show("Такого нет. Может создадите аккаунт?");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("Logins.txt"))
            {
                File.Create("Logins.txt");
                MessageBox.Show("Необходим перезапуск.");
                Environment.Exit(0);
            }
            else
            {
                string[] limbs = { "Jerico J4MM3D Eyeless|3735,0|3663/5343/2351/1235", "vindigo J4MM3D Master|123123,0|5422/4264/2452/2351", "boolman J4MM3D 2000|600,0|2352/5235/2362/2645", "deadmans ringer J4MM3D 24976|2499,0|3252/2352/5231/1286", "2ndbeam J4MM3D s0sisochki|-0,78|8800/5553/5356/7878" };
                bool found = false;
                using (StreamReader sr = new StreamReader("Logins.txt"))
                {
                    while (sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (line == null)
                        {
                            found = true;
                            sr.Close();
                            break;
                        }
                    }
                }
                if (found != false)
                {
                    using (StreamWriter sw = new StreamWriter("Logins.txt", append: true))
                    {
                        for (int i = 0; i < limbs.Length; i++)
                        {
                            sw.WriteLine($"{limbs[i]}");
                        }
                        sw.Close();
                    }
                }
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
