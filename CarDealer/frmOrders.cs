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
    public partial class frmOrders : Form
    {
        

        public frmOrders()
        {
            InitializeComponent();
            updateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        public async void updateDisplay()
        {
           
                lstOrders.DataSource = null;
                List<clsAllOrders> lcOrders = await ServiceClient.GetOrderAsync();
                lstOrders.DataSource = lcOrders;

        }

       

    }
}
