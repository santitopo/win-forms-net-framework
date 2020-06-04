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
    public partial class CreateAlarmWindow : Form
    {
        public const int HOURSOFDAY = 24;
        FeelingAnalyzer system;
        public CreateAlarmWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            system = s;
            LoadComponents();
        }

        private void btnRegisterAlarm_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("Debe seleccionar una Entidad");
            }
            else
            {
                try
                {
                    Alarm alarm = new Alarm()
                    {
                        Entity = new Entity((string)cbxEntity.SelectedItem),
                        PostNumber = Decimal.ToInt32(postNum.Value),
                        State = false,
                        TimeBack = GetTimeBack(),
                        Counter = 0,
                        Type = GetAlarmType(),
                    };

                  system.AddAlarm(alarm);
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                EmptyFields();
            }
        }

        private bool AreEmptyFields()
        {
            return cbxEntity.SelectedIndex==-1;
        }

        private int GetTimeBack()
        {
            if (radioButtonDays.Checked)
            {
                return Decimal.ToInt32(timeNum.Value) * HOURSOFDAY;
            }
            else
            {
                return Decimal.ToInt32(timeNum.Value);
            }

        }

        private bool GetAlarmType()
        {
            if (radioButtonPos.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void EmptyFields()
        {
            cbxEntity.SelectedIndex = -1;
            postNum.Value = 1;
            timeNum.Value = 1;
        }

        private void LoadComponents()
        {
            Entity[] entities = system.GetEntitites;
           foreach (Entity e in entities)
            {
                cbxEntity.Items.Add(e.Name);
            }
        }
            private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
