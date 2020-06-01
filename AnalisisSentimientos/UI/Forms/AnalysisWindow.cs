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
    public partial class AnalysisWindow : Form
    {
        private FeelingAnalyzer system;
        public AnalysisWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
            RefreshAnalysis();
        }

        public void RefreshAnalysis()
        {
            grdAnalysis.DataSource = system.GetAnalysis;
        }
    }
}
