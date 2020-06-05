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
    public partial class SystemElementsWindow : Form
    {
        PhraseLogic subSystemPhrase;
        EntityLogic subSystemEntity;
        FeelingLogic subSystemFeeling;

        public SystemElementsWindow(PhraseLogic s1, EntityLogic s2, FeelingLogic s3)
        {
            InitializeComponent();
            subSystemPhrase = s1;
            subSystemEntity = s2;
            subSystemFeeling = s3;
            RefreshGrids();
        }

        public void RefreshGrids()
        {
            grdFeelings.DataSource = subSystemFeeling.GetFeelings;
            grdEntities.DataSource = subSystemEntity.GetEntitites;
            grdPhrases.DataSource = subSystemPhrase.GetPhrases;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grdFeelings.SelectedRows)
            {
                Feeling selectedFeeling = row.DataBoundItem as Feeling;
                if (selectedFeeling != null)
                {
                    subSystemFeeling.DeleteFeeling(selectedFeeling);
                }
            }

            foreach (DataGridViewRow row in this.grdEntities.SelectedRows)
            {
                Entity selectedEntity = row.DataBoundItem as Entity;
                if (selectedEntity != null)
                {
                    subSystemEntity.DeleteEntity(selectedEntity);
                }
            }

            RefreshGrids();
        }

    }
}
