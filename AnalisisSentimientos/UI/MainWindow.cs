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
    public partial class MainWindow : Form
    {
        private Form  currentChildForm;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRegisterElements_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegistrationWindow());
        }

        private void btnCreateAlarm_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CreateAlarmWindow());
        }

        private void btnSeeAlarms_Click_1(object sender, EventArgs e)
        {
            openChildForm(new SeeAlarmsWindow());
        }

        private void btnAnalysis_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AnalysisWindow());
        }

        private void btnSystemElements_Click_1(object sender, EventArgs e)
        {
            openChildForm(new SystemElementsWindow());
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
    }
}
