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
    public partial class AuthorRegistrationWindow : Form
    {
        private AuthorLogic subSystemAuthors;
        public AuthorRegistrationWindow(AuthorLogic subsystemAuthors)
        {
            InitializeComponent();
            subSystemAuthors = subsystemAuthors;
        }

        private void btnRegisterAuthor_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("No pueden haber campos vacíos");
            }
            else if (InvalidDate())
            {
                MessageBox.Show("Fecha inválida, la fecha debe ser igual o anterior al dia actual");
            }
            else
            {
                try
                {
                    Author author = new Author()
                    {
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        BirthDate = dtpDate.Value,
                        Username = txtUserName.Text
                    };
                    subSystemAuthors.AddAuthor(author);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    EmptyFields();
            }

        }

        private bool InvalidDate()
        {
            return dtpDate.Value > DateTime.Now;
        }

        private bool AreEmptyFields()
        {
            return txtName.Text.Equals("") || txtSurname.Text.Equals("") || txtUserName.Text.Equals("");
        }
        private void EmptyFields()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            dtpDate.Value = DateTime.Now;
        }
    }
}
