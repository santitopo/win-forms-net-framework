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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRegisterElements_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl registration = new RegistrationWindow();
            MainPanel.Controls.Add(registration);
        }

        private void btnCreateAlarm_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl createAlarm = new CreateAlarmWindow();
            MainPanel.Controls.Add(createAlarm);
        }

        private void btnSeeAlarms_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl seeAlarms = new SeeAlarmsWindow();
            MainPanel.Controls.Add(seeAlarms);
        }

        private void btnAnalysis_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl analysis = new AnalysisWindow();
            MainPanel.Controls.Add(analysis);
        }

        private void btnSystemElements_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControl systemElements = new SystemElementsWindow();
            MainPanel.Controls.Add(systemElements);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
