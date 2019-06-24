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
    sealed public partial class frmSecondhand : CarDealer.frmCarCondition
    {
        public static readonly frmSecondhand Instance =
            new frmSecondhand();

        private frmSecondhand()
        {
            InitializeComponent();
        }

        public static void Run(clsAllVehicles prSecondhand)
        {
            Instance.SetDetails(prSecondhand);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtMileage.Text = _Vehicle.Mileage;
            txtRego.Text = _Vehicle.Rego;

        }

        protected override void pushData()
        {
            base.pushData();
            _Vehicle.Mileage = txtMileage.Text;
            _Vehicle.Rego = txtRego.Text;

        }


    }
}
