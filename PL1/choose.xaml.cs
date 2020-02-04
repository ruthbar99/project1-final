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

namespace PL1
{
    /// <summary>
    /// Interaction logic for choose.xaml
    /// </summary>
    public partial class choose : Window
    {
        public int chs;

        public choose()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            chs = 1;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            chs = 2;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            chs = 3;
        }
    }
}
