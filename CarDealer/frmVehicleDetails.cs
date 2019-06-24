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
    public partial class frmVehicleDetails : Form
    {
        private clsVehicleBrands _Vehicle;
        private char _CarType;

        private static readonly frmVehicleDetails _Instance =
            new frmVehicleDetails();

        private static Dictionary<string, frmVehicleDetails> _VehicleDetailsList =
            new Dictionary<string, frmVehicleDetails>();

        public frmVehicleDetails()
        {
            InitializeComponent();
            
        }

        public static frmVehicleDetails Instance => _Instance;

        private void frmVehicleDetails_Load(object sender, EventArgs e)
        {

        }

        public static void Run(string prVehicleName)
        {
            frmVehicleDetails lcVehicleDetails;
            if ((string.IsNullOrEmpty(prVehicleName) || !_VehicleDetailsList.TryGetValue(prVehicleName, out lcVehicleDetails)))
            {
                lcVehicleDetails = new frmVehicleDetails();
                if (string.IsNullOrEmpty(prVehicleName))
                    lcVehicleDetails.SetDetails(new clsVehicleBrands());
                else
                {
                    _VehicleDetailsList.Add(prVehicleName, lcVehicleDetails);
                    lcVehicleDetails.refreshFormFromDB(prVehicleName);
                }
            }
            else
            {
                lcVehicleDetails.Show();
                lcVehicleDetails.Activate();
            }
        }

        private async void refreshFormFromDB(string prVehicleName)
        {
            SetDetails(await ServiceClient.GetCarAsync(prVehicleName));
        }
            

        private void updateForm()
        {
            txtBrand.Text = _Vehicle.Name;
            txtSlogan.Text = _Vehicle.Slogan;

        }

        private void updateDisplay()
        {
            txtBrand.Enabled = txtBrand.Text == "";
            txtSlogan.Enabled = txtSlogan.Text == "";
            lstVehicleDetails.DataSource = null;
            if (_Vehicle.VehicleList != null)
                lstVehicleDetails.DataSource = _Vehicle.VehicleList;

        }

        public void SetDetails(clsVehicleBrands prVehicle)
        {
            _Vehicle = prVehicle;
            updateForm();
            updateDisplay();
            Show();
        }
        private void pushData()
        {
            _Vehicle.Name = txtBrand.Text;
            _Vehicle.Slogan = txtSlogan.Text;

        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new Inputbox(clsAllVehicles.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
                {
                    clsAllVehicles lcVehicle = clsAllVehicles.CarType(lcReply[0]);
                    if (lcVehicle != null) // valid artwork created?
                    {
                        frmCarCondition.DispatchWorkForm(lcVehicle);
                        lcVehicle.Name = _Vehicle.Name;
                        lcVehicle.Type = lcReply[0];
                        refreshFormFromDB(_Vehicle.Name);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
                    
                    
             Hide();
            

        }


        private void changeCarType(string prDescription)
        {
            switch (prDescription.ToLower())
            {
                case "New":
                    _CarType = 'n';
                    break;
                case "Secondhand":
                    _CarType = 's';
                    break;
                
            }
        }

        private void lstVehicleDetails_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstVehicleDetails.SelectedIndex;
            try
            {
                
                frmCarCondition.DispatchWorkForm(lstVehicleDetails.SelectedValue as clsAllVehicles);
                updateDisplay();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry no work selected #" + Convert.ToString(lcIndex));
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Are you sure?", "Deleting Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    MessageBox.Show(await ServiceClient.DeleteVehicleAsync(lstVehicleDetails.SelectedItem as clsAllVehicles));
                refreshFormFromDB(_Vehicle.Name);
            }
            catch(Exception)
            {
                MessageBox.Show("There is Nothing to delete");
            }
            
           

        }
    }
    }

        
    

