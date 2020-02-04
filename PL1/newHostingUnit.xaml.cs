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
using PL;
using BL;
using Project01_7735_5114_dotNet5780;

namespace PL1
{
    /// <summary>
    /// Interaction logic for newHostingUnit.xaml
    /// </summary>
    public partial class newHostingUnit : Window
    {
        HostingUnit nhu;       
        HostingUnit hu;
        BL.BL_Impl bl;

        public newHostingUnit()
        {

            hu = new HostingUnit();
            nhu = new HostingUnit();
            InitializeComponent();

            foreach (var n in Enum.GetNames(typeof(enum_s.Area)))
                ComboBoxArea.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Type)))
                ComboBoxType.Items.Add(n);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bl.AddHostingUnit(hu);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bl.DeleteHostingUnit(Convert.ToInt32(hostingUnitKey.Text));
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                nhu.HostingUnitKey = Configuration.getGeneralHUK();
                nhu.Adults = int.Parse(adults.Text.ToString());
                nhu.Children = int.Parse(children.Text.ToString());
                nhu.HostingUnitName = NamehostingUnit.Text.ToString();
                nhu.Jacuzzi = CheckBox3.IsChecked.Value;
                nhu.Pool = CheckBox4.IsChecked.Value;
                nhu.Garden = CheckBox10.IsChecked.Value;
                nhu.ChildrensAttractions = CheckBox5.IsChecked.Value;
                nhu.SmokingArea = CheckBox6.IsChecked.Value;
                nhu.Accessible = CheckBox11.IsChecked.Value;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR in one of the fields:\n " + ex.ToString());
            }

            bl.UpdateHostingUnit(nhu);          
        }

        private void ComboBoxArea_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Area n in Enum.GetValues(typeof(enum_s.Area)))
                if (ComboBoxArea.SelectedItem.ToString() == n.ToString())
                {
                    nhu.Area = n;
                    return;
                }
        }

        private void ComboBoxType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(enum_s.Type n in Enum.GetValues(typeof(enum_s.Type)))
                if (ComboBoxType.SelectedItem.ToString() == n.ToString())
            {
                nhu.Type = n;
                return;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                nhu.HostingUnitKey = Configuration.getGeneralHUK();
                nhu.Adults = int.Parse(adults.Text.ToString());
                nhu.Children = int.Parse(children.Text.ToString());
                nhu.HostingUnitName = NamehostingUnit.Text.ToString();
                nhu.Jacuzzi = CheckBox3.IsChecked.Value;
                nhu.Pool = CheckBox4.IsChecked.Value;
                nhu.Garden = CheckBox10.IsChecked.Value;
                nhu.ChildrensAttractions = CheckBox5.IsChecked.Value;
                nhu.SmokingArea = CheckBox6.IsChecked.Value;
                nhu.Accessible = CheckBox11.IsChecked.Value;
            }
            catch(Exception ex)
            {

                MessageBox.Show("ERROR in one of the fields:\n " + ex.ToString());
            }

            bl.AddHostingUnit(nhu);
            this.Close();
        }

        public void Show(BL.BL_Impl bl)
        {

            this.bl = bl;
            this.Show();
        }

        //public void Show(BL_Impl bl)
        //{
        //    this.bl = bl;
        //    choose choose = new choose();
        //    choose.Show();
        //    string caption = "Hosting Unit";
        //    switch (choose.chs)
        //    {

        //        case 1: break;//add
        //        case 2:
        //            chooseHostingUnit("Edit " + caption); //edit
        //            break;
        //        case 3:
        //            chooseHostingUnit("delete " + caption); //delete
        //            break;
        //        default:
        //            break;
        //    }
        //    this.Show();
        //}

        //private void chooseHostingUnit(string caption)
        //{
        //    comboWindow cw = new comboWindow();
        //    cw.Show(DS.DataSource.hostingUnits);
        //    MessageBox.Show(caption)

        //}
    }
}
