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
    /// Interaction logic for WindowOfGames.xaml
    /// </summary>
    public partial class WindowOfGames : Window
    {
        public WindowOfGames()
        {
            InitializeComponent();
        }
        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            string tempSearch = search.Text;
            if (tempSearch == "Search...")
            {
                search.Text = "";
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window PopUp = new PopUpWindow();
            PopUp.Show();
        }

        private void Logo_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = sender as Image;
            image.Opacity = 0.7;
        }

        private void Logo_MouseLeave(object sender, MouseEventArgs e)
        {
            Image image = sender as Image;
            image.Opacity = 1;
        }
    }
}
