using System;
using System.Collections.Generic;
using System.Globalization;
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
using ClassLibrary1;

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language;
        public MainWindow()
        {
            InitializeComponent();
            language = "ru-RU";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                umnojenie umn = new umnojenie(pole.Text, pole1.Text);
                lababel.Content = umn.fisting();
            }
            catch
            {
                lababel.Content = "Ошибка";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pole.Clear();
            pole1.Clear();
            umnojenie Clear = new umnojenie(pole.Text, pole1.Text);
            lababel.Content = Clear.Clear();
        }

        private void Cb_lang(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();

            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);

                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
    }
}