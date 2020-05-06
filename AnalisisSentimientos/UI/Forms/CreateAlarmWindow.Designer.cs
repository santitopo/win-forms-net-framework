namespace UI
{
    partial class CreateAlarmWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegisterAlarm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEntity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPos = new System.Windows.Forms.RadioButton();
            this.postNum = new System.Windows.Forms.NumericUpDown();
            this.timeNum = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.postNum);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxTime);
            this.panel1.Controls.Add(this.btnRegisterAlarm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxEntity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 689);
            this.panel1.TabIndex = 0;
            // 
            // btnRegisterAlarm
            // 
            this.btnRegisterAlarm.Location = new System.Drawing.Point(460, 592);
            this.btnRegisterAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterAlarm.Name = "btnRegisterAlarm";
            this.btnRegisterAlarm.Size = new System.Drawing.Size(230, 50);
            this.btnRegisterAlarm.TabIndex = 8;
            this.btnRegisterAlarm.Text = "Registrar Alarma";
            this.btnRegisterAlarm.UseVisualStyleBackColor = true;
            this.btnRegisterAlarm.Click += new System.EventHandler(this.btnRegisterAlarm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad de Posts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Entidad";
            // 
            // cbxEntity
            // 
            this.cbxEntity.FormattingEnabled = true;
            this.cbxEntity.Location = new System.Drawing.Point(404, 235);
            this.cbxEntity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEntity.Name = "cbxEntity";
            this.cbxEntity.Size = new System.Drawing.Size(356, 28);
            this.cbxEntity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "AlarmRegistration";
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Location = new System.Drawing.Point(207, 31);
            this.radioButtonHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(77, 24);
            this.radioButtonHours.TabIndex = 6;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "Horas";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            this.radioButtonHours.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Checked = true;
            this.radioButtonDays.Location = new System.Drawing.Point(33, 31);
            this.radioButtonDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(66, 24);
            this.radioButtonDays.TabIndex = 5;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Dias";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            this.radioButtonDays.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.timeNum);
            this.groupBoxTime.Controls.Add(this.radioButtonDays);
            this.groupBoxTime.Controls.Add(this.radioButtonHours);
            this.groupBoxTime.Location = new System.Drawing.Point(405, 448);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(355, 119);
            this.groupBoxTime.TabIndex = 26;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Plazo de Tiempo";
            this.groupBoxTime.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButtonPos);
            this.groupBox1.Location = new System.Drawing.Point(405, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Alarma";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 31);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Negativa";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonPos
            // 
            this.radioButtonPos.AutoSize = true;
            this.radioButtonPos.Location = new System.Drawing.Point(207, 31);
            this.radioButtonPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPos.Name = "radioButtonPos";
            this.radioButtonPos.Size = new System.Drawing.Size(88, 24);
            this.radioButtonPos.TabIndex = 3;
            this.radioButtonPos.TabStop = true;
            this.radioButtonPos.Text = "Positiva";
            this.radioButtonPos.UseVisualStyleBackColor = true;
            // 
            // postNum
            // 
            this.postNum.Location = new System.Drawing.Point(423, 399);
            this.postNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.postNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.postNum.Name = "postNum";
            this.postNum.Size = new System.Drawing.Size(331, 26);
            this.postNum.TabIndex = 4;
            this.postNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeNum
            // 
            this.timeNum.Location = new System.Drawing.Point(18, 72);
            this.timeNum.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.timeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeNum.Name = "timeNum";
            this.timeNum.Size = new System.Drawing.Size(331, 26);
            this.timeNum.TabIndex = 27;
            this.timeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateAlarmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 689);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateAlarmWindow";
            this.Text = "CreateAlarmWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegisterAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonPos;
        private System.Windows.Forms.NumericUpDown postNum;
        private System.Windows.Forms.NumericUpDown timeNum;
    }
}