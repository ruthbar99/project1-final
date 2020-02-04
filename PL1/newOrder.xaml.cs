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
using Project01_7735_5114_dotNet5780;

namespace PL1
{
    /// <summary>
    /// Interaction logic for newOrder.xaml
    /// </summary>
    public partial class newOrder : Window
    {
        Order nor;
        Order or;
        BL.BL_Impl bl;

        public newOrder()
        {
            nor = new Order();

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                nor.OrderKey = Configuration.getGeneralOK();
                nor.GuestRequestKey = bl.returngr(int.Parse(GuestRequestKey.Text.ToString()));
                nor.CreateDate = DateTime.Today;
                nor.HostingUnitKey = int.Parse(hostingUnitKey.Text.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR in one of the fields:\n " + ex.ToString());
            }

            if (GuestRequestKey.Text != "" && hostingUnitKey.Text != "")
                bl.AddOrder(nor);
           
           
            else
                MessageBox.Show("אנא תמלא את כל השדות");
        }
       
        public void Show(BL.BL_Impl bl)
        {

            this.bl = bl;
            this.Show();
        }
    }
}
