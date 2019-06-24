using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ClientSide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgOrder : Page
    {

        protected clsAllVehicles _Vehicle;
        

        public pgOrder()
        {
            this.InitializeComponent();
            
        }


        private void updateForm()

        {

            tbCarID.Text = _Vehicle.CarID.ToString();
            tbModel.Text = _Vehicle.Model;
            tbYear.Text = _Vehicle.Year.ToString();
            tbPurchasePrice.Text = _Vehicle.Price.ToString();


        }

        
        
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
