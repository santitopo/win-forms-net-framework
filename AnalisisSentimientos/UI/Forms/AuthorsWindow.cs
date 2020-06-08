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
            RefreshAuthors();
            //try
            //{
            //    datagridAuthors.Columns["TimeBack"].HeaderText = "Time (Hours)";
            //}
            //catch (Exception) { }
        }

        public void RefreshAuthors()
        {
            
            datagridAuthors.DataSource = subsystemAuthors.ListByEntityNumberDesc();
        }
    }
}
