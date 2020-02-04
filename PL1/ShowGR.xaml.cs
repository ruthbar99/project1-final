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
    /// Interaction logic for ShowGR.xaml
    /// </summary>
    public partial class ShowGR : Window
    {
        public ShowGR()
        {

            //bl.AddHostingUnit(hostingUnit);
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            foreach (var item in DS.DataSource.guestRequests)
            {

                listBox1.Items.Add(Convert.ToString(item.GuestRequestKey));
                listBox2.Items.Add(item.PrivateName);
                listBox3.Items.Add(Convert.ToString(item.FamilyName));
                listBox4.Items.Add(Convert.ToString(item.MailAddress));
                listBox5.Items.Add(Convert.ToString(item.Status));
                listBox6.Items.Add(Convert.ToString(item.Area));
                listBox7.Items.Add(item.Adults);
                listBox8.Items.Add(item.Children);
                listBox9.Items.Add(Convert.ToString(item.Pool));
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
