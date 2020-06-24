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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthors = new System.Windows.Forms.RadioButton();
            this.postNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPos = new System.Windows.Forms.RadioButton();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.timeNum = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.btnRegisterAlarm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.cbxEntity = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.postNum);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxTime);
            this.panel1.Controls.Add(this.btnRegisterAlarm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblEntity);
            this.panel1.Controls.Add(this.cbxEntity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioButtonGeneral);
            this.groupBox2.Controls.Add(this.radioButtonAuthors);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(61, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(360, 84);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarma";
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonGeneral.AutoSize = true;
            this.radioButtonGeneral.Checked = true;
            this.radioButtonGeneral.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGeneral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radioButtonGeneral.Location = new System.Drawing.Point(28, 36);
            this.radioButtonGeneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(131, 34);
            this.radioButtonGeneral.TabIndex = 2;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            this.radioButtonGeneral.CheckedChanged += new System.EventHandler(this.radioButtonGeneral_CheckedChanged);
            // 
            // radioButtonAuthors
            // 
            this.radioButtonAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAuthors.AutoSize = true;
            this.radioButtonAuthors.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAuthors.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radioButtonAuthors.Location = new System.Drawing.Point(211, 36);
            this.radioButtonAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAuthors.Name = "radioButtonAuthors";
            this.radioButtonAuthors.Size = new System.Drawing.Size(123, 34);
            this.radioButtonAuthors.TabIndex = 3;
            this.radioButtonAuthors.TabStop = true;
            this.radioButtonAuthors.Text = "Autores";
            this.radioButtonAuthors.UseVisualStyleBackColor = true;
            this.radioButtonAuthors.CheckedChanged += new System.EventHandler(this.radioButtonAuthors_CheckedChanged);
            // 
            // postNum
            // 
            this.postNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postNum.Location = new System.Drawing.Point(557, 187);
            this.postNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.postNum.Size = new System.Drawing.Size(356, 37);
            this.postNum.TabIndex = 4;
            this.postNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButtonPos);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(553, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 84);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Alarma";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(28, 36);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 34);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Negativa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonPos
            // 
            this.radioButtonPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonPos.AutoSize = true;
            this.radioButtonPos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radioButtonPos.Location = new System.Drawing.Point(211, 36);
            this.radioButtonPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPos.Name = "radioButtonPos";
            this.radioButtonPos.Size = new System.Drawing.Size(125, 34);
            this.radioButtonPos.TabIndex = 3;
            this.radioButtonPos.TabStop = true;
            this.radioButtonPos.Text = "Positiva";
            this.radioButtonPos.UseVisualStyleBackColor = true;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTime.Controls.Add(this.timeNum);
            this.groupBoxTime.Controls.Add(this.radioButtonDays);
            this.groupBoxTime.Controls.Add(this.radioButtonHours);
            this.groupBoxTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTime.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxTime.Location = new System.Drawing.Point(553, 249);
            this.groupBoxTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTime.Size = new System.Drawing.Size(368, 120);
            this.groupBoxTime.TabIndex = 26;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Plazo de Tiempo";
            // 
            // timeNum
            // 
            this.timeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNum.Location = new System.Drawing.Point(28, 76);
            this.timeNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.timeNum.Size = new System.Drawing.Size(295, 32);
            this.timeNum.TabIndex = 7;
            this.timeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Checked = true;
            this.radioButtonDays.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonDays.Location = new System.Drawing.Point(28, 36);
            this.radioButtonDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(84, 34);
            this.radioButtonDays.TabIndex = 5;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Dias";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonHours.Location = new System.Drawing.Point(194, 36);
            this.radioButtonHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(99, 34);
            this.radioButtonHours.TabIndex = 6;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "Horas";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // btnRegisterAlarm
            // 
            this.btnRegisterAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterAlarm.BackColor = System.Drawing.Color.Navy;
            this.btnRegisterAlarm.FlatAppearance.BorderSize = 0;
            this.btnRegisterAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAlarm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterAlarm.Location = new System.Drawing.Point(131, 245);
            this.btnRegisterAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterAlarm.Name = "btnRegisterAlarm";
            this.btnRegisterAlarm.Size = new System.Drawing.Size(204, 39);
            this.btnRegisterAlarm.TabIndex = 8;
            this.btnRegisterAlarm.Text = "Registrar Alarma";
            this.btnRegisterAlarm.UseVisualStyleBackColor = false;
            this.btnRegisterAlarm.Click += new System.EventHandler(this.btnRegisterAlarm_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(553, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad de Posts";
            // 
            // lblEntity
            // 
            this.lblEntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntity.AutoSize = true;
            this.lblEntity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntity.ForeColor = System.Drawing.Color.Navy;
            this.lblEntity.Location = new System.Drawing.Point(552, 383);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(103, 30);
            this.lblEntity.TabIndex = 14;
            this.lblEntity.Text = "Entidad";
            // 
            // cbxEntity
            // 
            this.cbxEntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxEntity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEntity.FormattingEnabled = true;
            this.cbxEntity.Location = new System.Drawing.Point(555, 417);
            this.cbxEntity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEntity.Name = "cbxEntity";
            this.cbxEntity.Size = new System.Drawing.Size(356, 38);
            this.cbxEntity.TabIndex = 1;
            // 
            // CreateAlarmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateAlarmWindow";
            this.Text = "CreateAlarmWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegisterAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.ComboBox cbxEntity;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonPos;
        private System.Windows.Forms.NumericUpDown postNum;
        private System.Windows.Forms.NumericUpDown timeNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
        private System.Windows.Forms.RadioButton radioButtonAuthors;
    }
}