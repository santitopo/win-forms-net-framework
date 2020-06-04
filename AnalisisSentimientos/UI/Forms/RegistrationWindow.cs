﻿using Domain;
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
    public partial class RegistrationWindow : Form
    {
        private Form currentChildForm;
        private Button alarmNotification;

        //Subsystems
        private EntityLogic subSystemEntity;
        private FeelingLogic subSystemFeeling;
        private PhraseLogic subSystemPhrase;
        private AlarmLogic subSystemAlarm;
        private AnalysisLogic subSystemAnalysis;

        public RegistrationWindow(EntityLogic subsytemEntity, FeelingLogic subsytemFeeling, PhraseLogic subsystemPhrase, 
                                    AlarmLogic subsystemAlarm, AnalysisLogic subsystemAnalysis,Button AlarmsButton)
        {
            InitializeComponent();
            subSystemEntity = subsytemEntity;
            subSystemFeeling = subsytemFeeling;
            subSystemPhrase = subsystemPhrase;
            subSystemAlarm = subsystemAlarm;
            subSystemAnalysis = subsystemAnalysis;
            alarmNotification = AlarmsButton;
        }

        private void btnFeeling_Click(object sender, EventArgs e)
        {
            openChildForm(new FeelingRegistrationWindow(subSystemFeeling));

        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            openChildForm(new EntityRegistrationWindow(subSystemEntity));

        }

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            openChildForm(new PhraseRegistrationWindow(subSystemPhrase, subSystemAnalysis,
                                                            subSystemAlarm, alarmNotification));

        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            RegistrationPanel.Controls.Add(childForm);
            RegistrationPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
