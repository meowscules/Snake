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
using Snake;

namespace Snake
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SoundPlayer ButtonClick = new SoundPlayer("../../Resources/Button_Click.wav");
        MediaPlayer TitleMusic = new MediaPlayer();

        public Window1()
        {
            InitializeComponent();
            TitleMusic.Open(new Uri("../../Resources/MGS_TitleScreen.wav", UriKind.RelativeOrAbsolute));
            TitleMusic.Play();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick.Play();
            TitleMusic.Stop();
            GameField menu = new GameField();
            menu.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {   
            ButtonClick.Play();
            Close();
        }

		private void Settings_Click(object sender, RoutedEventArgs e)
		{
            ButtonClick.Play();
            Window2 menu = new Window2();
            menu.Show();
            Close();
		}
	}
}
