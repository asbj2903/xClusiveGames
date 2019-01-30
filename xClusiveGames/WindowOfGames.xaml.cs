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
    }
}
