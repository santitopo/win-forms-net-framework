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

namespace UI.Forms
{
    public partial class AuthorsWindow : Form
    {
        private AuthorLogic subsystemAuthors;
        public AuthorsWindow(AuthorLogic a)
        {
            InitializeComponent();
            subsystemAuthors = a;
            cmbphraseType.SelectedIndex = 0;
            RefreshAuthors();
            try
            {
                displayWantedColumns();
            }
            catch (Exception) { }
        }

        private void displayWantedColumns()
        {
            for (int i = 0; i < datagridAuthors.Columns.Count; i++)
            {
                datagridAuthors.Columns[i].Visible = false;
            }
            datagridAuthors.Columns["Username"].Visible = true;
            datagridAuthors.Columns["Name"].Visible = true;
            datagridAuthors.Columns["Surname"].Visible = true;
        }
        public void RefreshAuthors()
        {
            datagridAuthors.DataSource = subsystemAuthors.GetAuthors;
        }

       private void rbtnEntitiesChecked(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = false;
            datagridAuthors.DataSource = null;
            datagridAuthors.DataSource = subsystemAuthors.ListByEntityNumberDesc();
            displayWantedColumns();

        }

        private void rbtnAverage_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = false;
            datagridAuthors.DataSource = null;
            datagridAuthors.DataSource = subsystemAuthors.ListByPhraseAverageDesc();
            displayWantedColumns();
        }

        private void rbtnRatio_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = true;
            if (cmbphraseType.SelectedIndex!=-1 && cmbphraseType.SelectedItem.ToString().Equals("Positivos"))
            {
                datagridAuthors.DataSource = null;
                datagridAuthors.DataSource = subsystemAuthors.ListByPositiveRatioDesc();
                displayWantedColumns();
            }
            else
            {
                datagridAuthors.DataSource = null;
                datagridAuthors.DataSource = subsystemAuthors.ListByNegativeRatioDesc();
                displayWantedColumns();
            }
        }
    }
}
