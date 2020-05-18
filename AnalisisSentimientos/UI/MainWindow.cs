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
    public partial class MainWindow : Form
    {
        private Form  currentChildForm;
        private FeelingAnalyzer system;
        public MainWindow()
        {
            InitializeComponent();
            system = new FeelingAnalyzer();
            lblTitle.Text = "MENU PRINCIPAL";
            sidePanel.Hide();
        }
        private void btnRegisterElements_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegistrationWindow(system, btnSeeAlarms));
            sidePanel.Show();
            sidePanel.Height = btnRegisterElements.Height;
            sidePanel.Top = btnRegisterElements.Top;
            lblTitle.Text = "REGISTRAR ELEMENTO";

        }

        private void btnCreateAlarm_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CreateAlarmWindow(system));
            sidePanel.Show();
            sidePanel.Height = btnCreateAlarm.Height;
            sidePanel.Top = btnCreateAlarm.Top;
            lblTitle.Text = "CREAR ALARMA";

        }

        private void btnSeeAlarms_Click_1(object sender, EventArgs e)
        {
            btnSeeAlarms.BackColor = Color.Navy;
            openChildForm(new SeeAlarmsWindow(system));
            sidePanel.Show();
            sidePanel.Height = btnSeeAlarms.Height;
            sidePanel.Top = btnSeeAlarms.Top;
            lblTitle.Text = "ALARMAS DEL SISTEMA";
        }

        private void btnAnalysis_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AnalysisWindow(system));
            sidePanel.Show();
            sidePanel.Height = btnAnalysis.Height;
            sidePanel.Top = btnAnalysis.Top;
            lblTitle.Text = "ANALYSIS";
        }

        private void btnSystemElements_Click_1(object sender, EventArgs e)
        {
            openChildForm(new SystemElementsWindow(system));
            sidePanel.Show();
            sidePanel.Height = btnSystemElements.Height;
            sidePanel.Top = btnSystemElements.Top;
            lblTitle.Text = "ELEMENTOS DEL SISTEMA";
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
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            desktopPanel.Show();
            lblTitle.Text = "MENU PRINCIPAL";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximze_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
