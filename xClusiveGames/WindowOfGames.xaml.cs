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

        private void SpidermanLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            SpidermanLogo.Opacity = 0.7;
        }

        private void SpidermanLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            SpidermanLogo.Opacity = 1;
        }

        private void RedDeadLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            RedDeadLogo.Opacity = 0.7;
        }

        private void RedDeadLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            RedDeadLogo.Opacity = 1;
        }

        private void TheLastLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            TheLastLogo.Opacity = 0.7;
        }

        private void TheLastLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            TheLastLogo.Opacity = 1;
        }

        private void ShadowLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowLogo.Opacity = 0.7;
        }

        private void ShadowLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowLogo.Opacity = 1;
        }

        private void UnchartedLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            UnchartedLogo.Opacity = 0.7;
        }

        private void UnchartedLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            UnchartedLogo.Opacity = 1;
        }

        private void HorizonLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            HorizonLogo.Opacity = 0.7;
        }

        private void HorizonLogo_MouseLeave(object sender, MouseEventArgs e)
        {
            HorizonLogo.Opacity = 1;
        }
    }
}
