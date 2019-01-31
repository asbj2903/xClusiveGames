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
using System.Windows.Shapes;

namespace xClusiveGames
{
    /// <summary>
    /// Interaction logic for PopUpWindow.xaml
    /// </summary>
    public partial class PopUpWindow : Window
    {
        bool Switch = false;
        public PopUpWindow()
        {
            InitializeComponent();
            Trailer.Source = new Uri(@"C:\Users\Victor\Downloads\trailer.wmv");
            PlayButton.Opacity = 0;
            Trailer.Play();
        }

        private void Trailer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Switch == false)
            {
                Trailer.Pause();
                Switch = true;
                
            }
            else
            {
                Trailer.Play();
                Switch = false;
            }
            
        }

        private void Trailer_MouseEnter(object sender, MouseEventArgs e)
        {
            PlayButton.Opacity = 0.5;
        }

        private void Trailer_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Switch == false)
            {
                PlayButton.Opacity = 0;
            }
        }
    }
}
