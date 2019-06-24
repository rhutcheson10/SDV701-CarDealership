using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ClientSide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class pgCars : Page
    {
        public pgCars()
        {
            InitializeComponent();
            
        }

        private clsVehicleBrands _Vehicle;
       
        

        public void SetDetails(clsVehicleBrands prBrand)
        {
            _Vehicle = prBrand;
            UpdateForm();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
           
            
               _Vehicle.Name = tbName.Text;
                _Vehicle.Slogan = tbSlogan.Text;


                lstVehicleDetails.ItemsSource = null;
                if (_Vehicle.VehicleList != null)
                    lstVehicleDetails.ItemsSource = _Vehicle.VehicleList;
            
           
        }

        public void UpdateForm()
        {


            tbName.Text = _Vehicle.Name;
            tbSlogan.Text = _Vehicle.Slogan;

      

        }


           

        private async void refreshFormFromDB(string prName)
        {
            SetDetails(await ServiceClient.GetCarAsync(prName));
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcName = e.Parameter.ToString();

                try
                {
                    _Vehicle = await ServiceClient.GetCarAsync(lcName);
                }
                catch (Exception lcEx)
                {
                    tbMessages.Text = lcEx.Message.ToString();
                }

                UpdateForm();
                UpdateDisplay();
            }
            else
                _Vehicle = new clsVehicleBrands();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void LstVehicleDetails_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(pgOrder));
        }


    }
}