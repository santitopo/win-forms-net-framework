namespace UI
{
    partial class SeeAlarmsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeAlarmsWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeneralAlarm = new System.Windows.Forms.Button();
            this.btnAuthorAlarm = new System.Windows.Forms.Button();
            this.grdAuthors = new System.Windows.Forms.DataGridView();
            this.grdAlarms = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.pictureInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grdAuthors);
            this.panel1.Controls.Add(this.grdAlarms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Location = new System.Drawing.Point(119, 508);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(510, 21);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Clickee sobre la alarma para obtener los autores asociados";
            // 
            // pictureInfo
            // 
            this.pictureInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureInfo.Image")));
            this.pictureInfo.Location = new System.Drawing.Point(78, 501);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(38, 35);
            this.pictureInfo.TabIndex = 4;
            this.pictureInfo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnGeneralAlarm);
            this.panel2.Controls.Add(this.btnAuthorAlarm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 57);
            this.panel2.TabIndex = 3;
            // 
            // btnGeneralAlarm
            // 
            this.btnGeneralAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeneralAlarm.BackColor = System.Drawing.Color.Navy;
            this.btnGeneralAlarm.FlatAppearance.BorderSize = 0;
            this.btnGeneralAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralAlarm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneralAlarm.Location = new System.Drawing.Point(552, 12);
            this.btnGeneralAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneralAlarm.Name = "btnGeneralAlarm";
            this.btnGeneralAlarm.Size = new System.Drawing.Size(205, 33);
            this.btnGeneralAlarm.TabIndex = 4;
            this.btnGeneralAlarm.Text = "Alarma General";
            this.btnGeneralAlarm.UseVisualStyleBackColor = false;
            this.btnGeneralAlarm.Click += new System.EventHandler(this.btnGeneralAlarm_Click);
            // 
            // btnAuthorAlarm
            // 
            this.btnAuthorAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthorAlarm.BackColor = System.Drawing.Color.Navy;
            this.btnAuthorAlarm.FlatAppearance.BorderSize = 0;
            this.btnAuthorAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorAlarm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuthorAlarm.Location = new System.Drawing.Point(324, 12);
            this.btnAuthorAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuthorAlarm.Name = "btnAuthorAlarm";
            this.btnAuthorAlarm.Size = new System.Drawing.Size(205, 33);
            this.btnAuthorAlarm.TabIndex = 3;
            this.btnAuthorAlarm.Text = "Alarma Autores";
            this.btnAuthorAlarm.UseVisualStyleBackColor = false;
            this.btnAuthorAlarm.Click += new System.EventHandler(this.btnAuthorAlarm_Click);
            // 
            // grdAuthors
            // 
            this.grdAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAuthors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAuthors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAuthors.ColumnHeadersHeight = 25;
            this.grdAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAuthors.EnableHeadersVisualStyles = false;
            this.grdAuthors.GridColor = System.Drawing.Color.Navy;
            this.grdAuthors.Location = new System.Drawing.Point(832, 75);
            this.grdAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAuthors.Name = "grdAuthors";
            this.grdAuthors.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.grdAuthors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAuthors.RowTemplate.Height = 24;
            this.grdAuthors.Size = new System.Drawing.Size(198, 398);
            this.grdAuthors.TabIndex = 2;
            // 
            // grdAlarms
            // 
            this.grdAlarms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAlarms.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdAlarms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAlarms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAlarms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAlarms.ColumnHeadersHeight = 25;
            this.grdAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAlarms.EnableHeadersVisualStyles = false;
            this.grdAlarms.GridColor = System.Drawing.Color.Navy;
            this.grdAlarms.Location = new System.Drawing.Point(45, 75);
            this.grdAlarms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAlarms.Name = "grdAlarms";
            this.grdAlarms.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            this.grdAlarms.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAlarms.RowTemplate.Height = 24;
            this.grdAlarms.Size = new System.Drawing.Size(758, 398);
            this.grdAlarms.TabIndex = 1;
            this.grdAlarms.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdAlarms_CellMouseClick);
            // 
            // SeeAlarmsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeeAlarmsWindow";
            this.Text = "SeeAlarmsWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdAlarms;
        private System.Windows.Forms.DataGridView grdAuthors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeneralAlarm;
        private System.Windows.Forms.Button btnAuthorAlarm;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureInfo;
    }
}