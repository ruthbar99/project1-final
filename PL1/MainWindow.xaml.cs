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
using PL1;
using BL;
using Project01_7735_5114_dotNet5780;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.BL_Impl bl;
        

        public MainWindow()
        {
            bl = new BL.BL_Impl();
           
            InitializeComponent();
        }

        public object AddOrder { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addGuestRequest gr = new addGuestRequest();
            gr.Show(bl);
            //gr.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            newHostingUnit hu = new newHostingUnit();

            hu.Show(bl);
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            newOrder or = new newOrder();
            or.Show(bl);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.ShowDialog();
        }
    }
}
