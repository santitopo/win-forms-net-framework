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
    public partial class SeeAlarmsWindow : Form
    {
        AlarmLogic subSystemAlarm;

        public SeeAlarmsWindow(AlarmLogic s)
        {
            InitializeComponent();
            subSystemAlarm = s;

            RefreshAuthorAlarms();
            try
            {
                grdAlarms.Columns["TimeBack"].HeaderText = "Time (Hours)";
            }
            catch (Exception) { }
        }

        public void RefreshAuthorAlarms()
        {
            grdAlarms.DataSource = subSystemAlarm.GetAuthorAlarms();
        }

        public void RefreshGeneralAlarms()
        {
            grdAlarms.DataSource = subSystemAlarm.GetGeneralAlarms();
        }

        private void btnAuthorAlarm_Click(object sender, EventArgs e)
        {
            grdAuthors.Visible = true;
            lblInfo.Visible = true;
            pictureInfo.Visible = true;
            grdAlarms.Size = new Size(550, 398);
            RefreshAuthorAlarms();
        }

        private void btnGeneralAlarm_Click(object sender, EventArgs e)
        {
            grdAuthors.Visible = false;
            lblInfo.Visible = false;
            pictureInfo.Visible = false;
            grdAlarms.Size = new Size (700, 398);
            RefreshGeneralAlarms();
        }

        private void grdAlarms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdAlarms.CurrentRow != null)
            {
                int i = grdAlarms.CurrentRow.Index;
                AuthorAlarm a = (AuthorAlarm)subSystemAlarm.GetAuthorAlarms()[i];
                grdAuthors.DataSource = a.getAsocciatedAuthors().Select(o => new
                { Usuario = o.Username }).ToList();
            }
        }
    }
}
