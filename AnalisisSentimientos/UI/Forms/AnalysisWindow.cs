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
    public partial class AnalysisWindow : Form
    {
        private AnalysisLogic subSystemAnalysis;
        public AnalysisWindow(AnalysisLogic s)
        {
            InitializeComponent();
            subSystemAnalysis = s;
            RefreshAnalysis();
            displayWantedColumns();
        }

        private void displayWantedColumns()
        {
            grdAnalysis.Columns["AnalysisId"].Visible = false;

        }
        public void RefreshAnalysis()
        {
            grdAnalysis.DataSource = subSystemAnalysis.GetAnalysis;
        }
    }
}
