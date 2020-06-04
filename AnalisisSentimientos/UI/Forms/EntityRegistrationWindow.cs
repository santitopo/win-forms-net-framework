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
    public partial class EntityRegistrationWindow : Form
    {
        EntityLogic subsystem;

        public EntityRegistrationWindow(EntityLogic s)
        {
            InitializeComponent();
            subsystem = s;
        }

        private void btnRegisterEntity_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }
            else
            {
                try
                {
                    Entity entity = new Entity()
                    {
                        Name = txtName.Text
                    };
                    subsystem.AddEntity(entity);
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
            return txtName.Text.Equals("");
        }
        private void EmptyFields()
        {
            txtName.Text = "";
        }
    }
}
