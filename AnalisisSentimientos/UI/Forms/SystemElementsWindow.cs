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
    public partial class SystemElementsWindow : Form
    {
        FeelingAnalyzer system;
        public SystemElementsWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
            RefreshGrids();
        }

        public void RefreshGrids()
        {
            grdFeelings.DataSource = system.GetFeelings;
            grdEntities.DataSource = system.GetEntitites;
            grdPhrases.DataSource = system.GetPhrases;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grdFeelings.SelectedRows)
            {
                Feeling selectedFeeling = row.DataBoundItem as Feeling;
                if (selectedFeeling != null)
                {
                     system.DeleteFeeling(selectedFeeling);
                }
            }

            foreach (DataGridViewRow row in this.grdEntities.SelectedRows)
            {
                Entity selectedEntity = row.DataBoundItem as Entity;
                if (selectedEntity != null)
                {
                    system.DeleteEntity(selectedEntity);
                }
            }

            RefreshGrids();
        }

    }
}
