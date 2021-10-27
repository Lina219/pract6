using System;
using System.Collections.Generic;
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

namespace pract5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Man he = new Man("", 0, "", 0);
        Man she = new Man("", 0, "", 0);

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = he.ShowInformation() + "\n\n" + she.ShowInformation();
        }

        private void ChangeParameters_Click(object sender, RoutedEventArgs e)
        {
            if (person1.IsChecked == true)
            {
                FillInformation(he);
            }

            if (person2.IsChecked == true)
            {
                FillInformation(she);
            }
            TextBox.Text = he.ShowInformation() +"\n\n" + she.ShowInformation();
        }

        private void FillInformation(Man somebody)
        {
            if (имя.Text != string.Empty)
            {
                somebody.Name = имя.Text;
            }

            if (пол.SelectedIndex == 0)
            {
                somebody.Sex = "мужской";
            }
            if (пол.SelectedIndex == 1)
            {
                somebody.Sex = "женский";
            }

            if (Int32.TryParse(возраст.Text, out int howOld))
            {
                if (howOld < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательным");
                }
                else
                {
                    somebody.HowOld = howOld;
                }
            }

            if (Int32.TryParse(вес.Text, out int weight))
            {
                if (weight < 0)
                {
                    MessageBox.Show("Вес не может быть отрицательным");
                }
                else
                {
                    somebody.Weight = weight;
                }
            }
        }

        private void выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void справка_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Использовать класс Man (человек), с полями: имя, возраст, пол и вес.\nРазработать операцию для увеличения возраста на 1 год.\nРазработать операции для определения кто тяжелее или легче.");
        }

        private void increment_Click(object sender, RoutedEventArgs e)
        {
            if (person1.IsChecked == true)
            {
                he++;
                возраст.Text = he.HowOld.ToString();
            }
            if (person2.IsChecked == true)
            {
                she++;
                возраст.Text = she.HowOld.ToString();
            }
        }

        private void сравнить_Click(object sender, RoutedEventArgs e)
        {
            if (he > she)
            {
                MessageBox.Show("Вес 1 человека больше, чем вес 2 человека");
            }
            if (he < she)
            {
                MessageBox.Show("Вес 1 человека меньше, чем вес 2 человека");
            }
            if (he.Weight == she.Weight)
            {
                MessageBox.Show("Вес 1 человека равен весу 2 человека");
            }
        }

        private void person1_Checked(object sender, RoutedEventArgs e)
        {
            имя.Text = "";
            возраст.Text = "";
            вес.Text = "";
            пол.SelectedIndex = -1;

        }

        private void person2_Checked(object sender, RoutedEventArgs e)
        {
            имя.Text = "";
            возраст.Text = "";
            вес.Text = "";
            пол.SelectedIndex = -1;
        }
    }
}
