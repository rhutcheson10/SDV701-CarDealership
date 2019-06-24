using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    sealed public partial class frmVehicleBrand : Form
    {
        private static readonly frmVehicleBrand _Instance =
            new frmVehicleBrand();

        private frmOrders frmOrders;

        public frmVehicleBrand()
        {
            InitializeComponent();
            

        }

        public static frmVehicleBrand Instance => _Instance;

        public async void UpdateDisplay()
        {
            
            
                lstVehicleBrands.DataSource = null;
                lstVehicleBrands.DataSource = await ServiceClient.GetCarBrandsAsync();
           

        }

        private void lstVehicleBrands_DoubleClick(object sender, EventArgs e)
        {
            string lcKey = Convert.ToString(lstVehicleBrands.SelectedItem);
            frmVehicleDetails.Run(lcKey);     
        }


        private void frmVehicleBrand_Load(object sender, EventArgs e)
        {
            UpdateDisplay();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrders = new frmOrders();
            frmOrders.Show();
            
        }
    }

}
