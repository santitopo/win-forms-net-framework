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
    public partial class CreateAlarmWindow : Form
    {
        FeelingAnalyzer system;
        public CreateAlarmWindow(FeelingAnalyzer s)
        {
            InitializeComponent();
            //LoadComponents();
            system = s;
        }

        private void btnRegisterAlarm_Click(object sender, EventArgs e)
        {

        }

        private void LoadComponents()
        {
            Entity[] entities = system.GetEntitites;
            foreach (Entity e in entities)
            {
                cbxEntity.Items.Add(e.Name);
            }
        }
    }
}
