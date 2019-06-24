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
    public partial class frmCarCondition : Form
    {

        protected clsAllVehicles _Vehicle;

        public delegate void LoadWorkFormDelegate(clsAllVehicles prVehicle);
        public static Dictionary<char, Delegate> _CarForm = new Dictionary<char, Delegate>
        {
            {'N', new LoadWorkFormDelegate(frmNew.Run)},
            {'S', new LoadWorkFormDelegate(frmSecondhand.Run)}
            
        };
        public static void DispatchWorkForm(clsAllVehicles prVehicle)
        {
            _CarForm[prVehicle.Type].DynamicInvoke(prVehicle);
        }
        public frmCarCondition()
        {
            InitializeComponent();
        }
        protected virtual void updateForm()

        {
            
            txtBrand.Enabled = string.IsNullOrEmpty(_Vehicle.Name);
            txtBrand.Text = _Vehicle.Name;
            txtModel.Text = _Vehicle.Model;
            txtYear.Text = _Vehicle.Year.ToString();
            txtPurchasPrice.Text = _Vehicle.Price.ToString();
            txtCreation.Text = _Vehicle.DateLastModified.ToShortDateString();
            txtStatus.Text = _Vehicle.Status;
           
        }
        public void SetDetails(clsAllVehicles prVehicle)
        {
            _Vehicle = prVehicle;
            updateForm();
            ShowDialog();
        }

        protected virtual void pushData()
        {
            _Vehicle.Name = txtBrand.Text;
            _Vehicle.Model = txtModel.Text;
            _Vehicle.Year = int.Parse(txtYear.Text);
            _Vehicle.Price = decimal.Parse(txtPurchasPrice.Text);
            _Vehicle.DateLastModified = DateTime.Parse(txtCreation.Text);
            _Vehicle.Status = txtStatus.Text;
            
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            
            
                if (IsValid() == true)
                {
                    pushData();

                    if (txtBrand.Enabled)
                        MessageBox.Show(await ServiceClient.InsertVehicleAsync(_Vehicle));
                    else
                        MessageBox.Show(await ServiceClient.UpdateVehicleAsync(_Vehicle));
                    Close();
                }
            
            
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public virtual bool IsValid()
        {
            return true;
        }

    }
}
