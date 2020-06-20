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
            RefreshDefault();
        }

        private void RefreshDefault()
        {
            rbtnRatio.Checked = true;
            cmbphraseType.SelectedIndex = 0;
            datagridAuthors.DataSource = subsystemAuthors.Repository.ListByPositiveRatioDesc();
        }

       private void rbtnEntitiesChecked(object sender, EventArgs e)
       {
            cmbphraseType.Enabled = false;
            datagridAuthors.DataSource = subsystemAuthors.Repository.ListByEntityNumberDesc();
       }

        private void rbtnAverage_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = false;
            datagridAuthors.DataSource = subsystemAuthors.Repository.ListByPhraseAverageDesc();
        }

        private void rbtnRatio_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = true;
            if (cmbphraseType.SelectedIndex!=-1 && cmbphraseType.SelectedItem.ToString().Equals("Positivos"))
            {
                datagridAuthors.DataSource = subsystemAuthors.Repository.ListByPositiveRatioDesc();
            }
            else
            {
                datagridAuthors.DataSource = subsystemAuthors.Repository.ListByNegativeRatioDesc();
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (datagridAuthors.CurrentRow != null)
            {
                int i = datagridAuthors.CurrentRow.Index;
                string username = datagridAuthors.Rows[i].Cells[0].Value.ToString();
                subsystemAuthors.DeleteAuthorByUsername(username);
            }
            RefreshDefault();
        }

    }
}
