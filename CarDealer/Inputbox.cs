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
    public partial class Inputbox: Form
    {
        private string _Answer;

        public Inputbox(string prQuestion)
        {
            InitializeComponent();
            lblQuestion.Text = prQuestion;
            lblError.Text = "";
            txtAnswer.Focus();
            ShowDialog();
        }

        private void btnOK_Click(object prSender, EventArgs prE)
        {
            _Answer = txtAnswer.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object prSender, EventArgs prE)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _Answer; }
    
        }

        private void Inputbox_Load(object sender, EventArgs e)
        {

        }
    }
}
