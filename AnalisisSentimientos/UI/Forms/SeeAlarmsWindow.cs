using Domain;
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
    public partial class SeeAlarmsWindow : Form
    {
        FeelingAnalyzer system;
        public SeeAlarmsWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
            RefreshAlarms();
            try
            {
                grdAlarms.Columns["TimeBack"].HeaderText = "Time (Hours)";
            }
            catch (Exception) { }
        }

        public void RefreshAlarms()
        {
            grdAlarms.DataSource = system.GetAlarms;
        }
    }
}
