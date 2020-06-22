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
        private enum SortType
        {
            ascendent,
            descendent,
        }
        private SortType Sort { get; set; }
        public AuthorsWindow(AuthorLogic a)
        {
            InitializeComponent();
            subsystemAuthors = a;
            Sort = SortType.descendent;
            rbtnRatio.Checked = true;
            cmbphraseType.SelectedIndex = 0;
            Refresh();
        }

        private void Refresh()
        {
            if (rbtnAverage.Checked)
            {
                rbtnAverage_CheckedChanged(null, null);
            }
            else if (rbtnEntities.Checked)
            {
                rbtnEntitiesChecked(null, null);
            }
            else if (rbtnRatio.Checked)
            {
                rbtnRatio_CheckedChanged(null, null);
            }
        }

        private void rbtnEntitiesChecked(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = false;
            var list = subsystemAuthors.Repository.ListByEntityNumber();
            if (Sort == SortType.descendent)
            {
                datagridAuthors.DataSource = list.OrderByDescending(x => x.Mentioned_Entities).ToList();
            }
            else
            {
                datagridAuthors.DataSource = list.OrderBy(x => x.Mentioned_Entities).ToList();
            }
        }

        private void rbtnAverage_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = false;
            var list = subsystemAuthors.Repository.ListByPhraseAverage();

            if (Sort == SortType.descendent)
            {
                datagridAuthors.DataSource = list.OrderByDescending(x => x.Post_average).ToList();
            }
            else
            {
                datagridAuthors.DataSource = list.OrderBy(x => x.Post_average).ToList();
            }
        }

        private void rbtnRatio_CheckedChanged(object sender, EventArgs e)
        {
            cmbphraseType.Enabled = true;
            if (cmbphraseType.SelectedIndex != -1 && cmbphraseType.SelectedItem.ToString().Equals("Positivos"))
            {
                var list = subsystemAuthors.Repository.ListByPositiveRatio();
                if (Sort == SortType.descendent)
                {
                    datagridAuthors.DataSource = list.OrderByDescending(x => x.Positive_Ratio).ToList();
                }
                else
                {
                    datagridAuthors.DataSource = list.OrderBy(x => x.Positive_Ratio).ToList();
                }
            }
            else
            {
                var list = subsystemAuthors.Repository.ListByNegativeRatio();
                if (Sort == SortType.descendent)
                {
                    datagridAuthors.DataSource = list.OrderByDescending(x => x.Negative_Ratio).ToList();
                }
                else
                {
                    datagridAuthors.DataSource = list.OrderBy(x => x.Negative_Ratio).ToList();
                }
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
            Refresh();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Sort = Sort == SortType.descendent ? SortType.ascendent : SortType.descendent;
            Refresh();
        }
    }
}
