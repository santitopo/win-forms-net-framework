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
    public partial class RegistrationWindow : Form
    {
        private Form currentChildForm;
        private FeelingAnalyzer system;
        private Button alarmNotification;
        public RegistrationWindow(FeelingAnalyzer s, Button AlarmsButton)
        {
            InitializeComponent();
            system = s;
            alarmNotification = AlarmsButton;
        }

        private void btnFeeling_Click(object sender, EventArgs e)
        {
            openChildForm(new FeelingRegistrationWindow(system));

        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            openChildForm(new EntityRegistrationWindow(system));

        }

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            openChildForm(new PhraseRegistrationWindow(system,alarmNotification));

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
