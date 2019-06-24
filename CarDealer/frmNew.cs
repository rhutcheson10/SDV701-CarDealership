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
       sealed public partial class frmNew : CarDealer.frmCarCondition
        {
            public static readonly frmNew Instance =
                new frmNew();

            private frmNew()
            {
                InitializeComponent();
            }

            public static void Run(clsAllVehicles prNew)
            {
                Instance.SetDetails(prNew);
            }

            protected override void updateForm()
            {
                base.updateForm();
                txtFinnance.Text = _Vehicle.Finnance;
                txtWarranty.Text = _Vehicle.Warranty;
                
            }

            protected override void pushData()
            {
                base.pushData();
                _Vehicle.Finnance = txtFinnance.Text;
                _Vehicle.Warranty = txtWarranty.Text;
                
            }

        
    }
    }

