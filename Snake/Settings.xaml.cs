using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Globalization;

namespace Snake
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SoundPlayer ButtonClick = new SoundPlayer("../../Resources/Button_Click.wav");

        public Window2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            GameField.language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();

            if (GameField.language != null)
            {
                CultureInfo lang = new CultureInfo(GameField.language);

                if (lang != null)
                {
                    App.Language = lang;
                }

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick.Play();
            Window1 menu = new Window1();
            menu.Show();
            Close();
        }
    }
}
