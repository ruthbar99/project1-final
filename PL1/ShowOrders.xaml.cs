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
    /// Interaction logic for ShowOrders.xaml
    /// </summary>
    public partial class ShowOrders : Window
    {
        public ShowOrders()
        {
            InitializeComponent();
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();


            foreach (var item in DS.DataSource.orders)
            {

                listBox1.Items.Add(Convert.ToString(item.OrderKey));
                listBox2.Items.Add(item.Status);
                listBox3.Items.Add(Convert.ToString(item.CreateDate));
                listBox4.Items.Add(Convert.ToString(item.OrderDate));

            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
