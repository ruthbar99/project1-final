using Project01_7735_5114_dotNet5780;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for addGuestRequest.xaml
    /// </summary>
    public partial class addGuestRequest : Window
    {
        GuestRequest gr;
        BL.BL_Impl bl;

        public addGuestRequest()
        {
            gr = new GuestRequest();

            InitializeComponent();

            foreach (var n in Enum.GetNames(typeof(enum_s.Status)))
                StatusCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Area)))
                areaCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Type)))
                TypeCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Answer)))
            {
                childrensAttractionsCmb.Items.Add(n);
                poolCmb.Items.Add(n);
                jacuzziCmb.Items.Add(n);
                gardenCmb.Items.Add(n);
                smockingCmb.Items.Add(n);
            }
                
        }

         
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            gr.GuestRequestKey = Configuration.getGeneralGrk();
            
            try
            {
                gr.Accessible = accessible.IsChecked.Value;
                gr.Adults = int.Parse(adult.Text.ToString());
                gr.Children = int.Parse(adult.Text.ToString());
                gr.EntryDate = entry.SelectedDate.Value;
                gr.RegistrationDate = DateTime.Today;
                gr.ReleaseDate = release.SelectedDate.Value;
                gr.FamilyName = family.Text;
                gr.MailAddress = mail.Text;
                gr.PrivateName = privateName.Text;
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR in one of the fields:\n " + ex.ToString());
            }
            

            //you must fil all feilds
            if (privateName.Text !="" && family.Text != "" && mail.Text != "" && adult.Text != "" && children.Text != "" &&  entry.Text != "" && release.Text != "" &&
               jacuzziCmb.SelectedItem != null && poolCmb.SelectedItem != null && gardenCmb.SelectedItem != null
               && StatusCmb.SelectedItem != null && childrensAttractionsCmb.SelectedItem != null && smockingCmb.SelectedItem != null && areaCmb.SelectedItem != null
               && TypeCmb.SelectedItem != null)
                bl.AddGuestRequest(gr); 

            else
                MessageBox.Show("אנא מלא את כל השדות");
            ListBox1.Items.Add(gr.GuestRequestKey);
            MessageBox.Show("אנא שמור מספר דרישה");
            this.Close();
           
        }

        private void StatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Status n in Enum.GetValues(typeof(enum_s.Status)))
                if (StatusCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Status = n;
                    return;
                }
        }

        private void AreaCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Area n in Enum.GetValues(typeof(enum_s.Area)))
                if (areaCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Area = n;
                    return;
                }
        }

        private void TypeCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Type n in Enum.GetValues(typeof(enum_s.Type)))
                if (TypeCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Type = n;
                    return;
                }
        }

        private void PoolCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Answer n in Enum.GetValues(typeof(enum_s.Answer)))
                if (poolCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Pool = n;
                    return;
                }
        }

        private void JacuzziCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Answer n in Enum.GetValues(typeof(enum_s.Answer)))
                if (jacuzziCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Jacuzzi = n;
                    return;
                }
        }

        private void GardenCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Answer n in Enum.GetValues(typeof(enum_s.Answer)))
                if (gardenCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.Garden = n;
                    return;
                }
        }

        private void ChildrensAttractionsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Answer n in Enum.GetValues(typeof(enum_s.Answer)))
                if (childrensAttractionsCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.ChildrensAttractions = n;
                    return;
                }
        }

        private void SmockingCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (enum_s.Answer n in Enum.GetValues(typeof(enum_s.Answer)))
                if (smockingCmb.SelectedItem.ToString() == n.ToString())
                {
                    gr.SmokingArea = n;
                    return;
                }
        }

        public void Show(BL.BL_Impl bl)
        {
            
            this.bl = bl;
            this.Show();
        }

        private void Accessible_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PrivateName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
