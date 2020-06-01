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
    public partial class PhraseRegistrationWindow : Form
    {
        private FeelingAnalyzer system;
        private Button alarmNotification;
        public PhraseRegistrationWindow(FeelingAnalyzer s, Button AlarmsButton)
        {
            InitializeComponent();
            system = s;
            alarmNotification = AlarmsButton;
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
                    Content = txtPhrase.Text,
                    Date = dtpDate.Value
                };
                system.AddPhrase(phrase);
                Analysis phraseAnalysis = null; // system.ExecuteAnalysis(phrase);
                system.AddAnalysis(phraseAnalysis);
                verifyAlarmsAndNotify();
                EmptyFields();
            }
            
        }

        private void verifyAlarmsAndNotify()
        {
            int onAlarmsBeforeVerify = countActivatedAlarms(system.GetAlarms);
            system.VerifyAlarms();
            int onAlarmsAfterVerify = countActivatedAlarms(system.GetAlarms);
            if (onAlarmsAfterVerify > onAlarmsBeforeVerify)
            {
                notifyActivatedAlarm();
            }
        }

        private void notifyActivatedAlarm()
        {
            alarmNotification.BackColor = Color.Red;
        }
        private int countActivatedAlarms(Alarm[] alarms)
        {
            int count = 0;
            foreach (Alarm al in alarms){
                if (al.State)
                {
                    count++;
                }
            }
            return count;
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
