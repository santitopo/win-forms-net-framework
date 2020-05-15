using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FeelingRegistrationWindow : Form
    {
        private FeelingAnalyzer system;
        public FeelingRegistrationWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
        }

        private void btnRegisterFeeling_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }
            else
            {
                //  try & catch??
                Feeling f = new Feeling()
                {
                    Name = txtName.Text,
                    Type = rbtnPositive.Checked ? true : false
                };
                system.AddFeeling(f);
            };
                EmptyFields();
        }

        private bool AreEmptyFields()
        {
            return txtName.Text.Equals("") || 
                     ((!rbtnNegative.Checked) && (!rbtnPositive.Checked));
        }

        private void EmptyFields()
        {
            txtName.Text = "";
            rbtnNegative.Checked = false;
            rbtnPositive.Checked = false;
        }
        
    }
}
