using Domain;
using Logic;
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
        private FeelingLogic subsystem;
        public FeelingRegistrationWindow(FeelingLogic s)
        {
            InitializeComponent();
            subsystem = s;
        }

        private void btnRegisterFeeling_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }
            else
            {
                try
                {
                    Feeling f = new Feeling()
                    {
                        Name = txtName.Text.Trim(),
                        Type = rbtnPositive.Checked ? true : false
                    };
                    subsystem.AddFeeling(f);
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
