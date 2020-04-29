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
    public partial class RegistrationWindow : Form
    {
        private Form currentChildForm;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void btnFeeling_Click(object sender, EventArgs e)
        {
            openChildForm(new FeelingRegistrationWindow());

        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            openChildForm(new EntityRegistrationWindow());

        }

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            openChildForm(new PhraseRegistrationWindow());

        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            RegistrationPanel.Controls.Add(childForm);
            RegistrationPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
