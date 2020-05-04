using BusinessLogic;
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
    public partial class PhraseRegistrationWindow : Form
    {
        FeelingAnalyzer system;
        public PhraseRegistrationWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
        }

        private void btnRegisterPhrase_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }else if (InvalidDate())
            {
                MessageBox.Show("Fecha inválida, la fecha debe ser igual o anterior al dia actual");
            }
            else
            {
                //  try & catch??
                Phrase phrase = new Phrase()
                {
                    content = txtPhrase.Text,
                    date = dtpDate.Value.Date
                };
                system.AddPhrase(phrase);

                EmptyFields();
            }
            
        }

        private bool InvalidDate()
        {
            return dtpDate.Value > DateTime.Now;
        }

        private bool AreEmptyFields()
        {
            return txtPhrase.Text.Equals("");
        }
        private void EmptyFields()
        {
            txtPhrase.Text = "";
            dtpDate.Value = DateTime.Now;
        }
    }
}
