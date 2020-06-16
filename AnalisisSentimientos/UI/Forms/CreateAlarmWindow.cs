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
    public partial class CreateAlarmWindow : Form
    {
        public const int HOURSOFDAY = 24;
        AlarmLogic subSystemAlarm;
        EntityLogic subSystemEntity;


        public CreateAlarmWindow(AlarmLogic subsystemAlarm, EntityLogic subsystemEntity)
        {
            InitializeComponent();
            subSystemAlarm = subsystemAlarm;
            subSystemEntity = subsystemEntity;
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
                    Alarm alarm;
                    if (radioButtonGeneral.Checked)
                    {
                        alarm = new GeneralAlarm()
                        {
                            Entity = new Entity((string)cbxEntity.SelectedItem),
                            PostNumber = Decimal.ToInt32(postNum.Value),
                            State = false,
                            TimeBack = GetTimeBack(),
                            Counter = 0,
                            Type = GetAlarmType(),
                        };

                        subSystemAlarm.AddGeneralAlarm((GeneralAlarm)alarm);
                    }
                    else
                    {
                        alarm = new AuthorAlarm()
                        {
                            PostNumber = Decimal.ToInt32(postNum.Value),
                            State = false,
                            TimeBack = GetTimeBack(),
                            Type = GetAlarmType(),
                        };

                        subSystemAlarm.AddAuthorAlarm((AuthorAlarm)alarm);
                    }

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
            return radioButtonGeneral.Checked && cbxEntity.SelectedIndex==-1;
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
            Entity[] entities = subSystemEntity.GetEntitites;
            foreach (Entity e in entities)
            {
                cbxEntity.Items.Add(e.Name);
            }
        }

        private void radioButtonGeneral_CheckedChanged(object sender, EventArgs e)
        {
            lblEntity.Visible = true;
            cbxEntity.Visible = true;
        }

        private void radioButtonAuthors_CheckedChanged(object sender, EventArgs e)
        {
            lblEntity.Visible = false;
            cbxEntity.Visible = false;
        }
    }
}
