namespace UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnRegisterElements = new System.Windows.Forms.Button();
            this.btnCreateAlarm = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnSeeAlarms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSystemElements = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterElements
            // 
            this.btnRegisterElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterElements.FlatAppearance.BorderSize = 0;
            this.btnRegisterElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterElements.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterElements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterElements.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterElements.Image")));
            this.btnRegisterElements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterElements.Location = new System.Drawing.Point(12, 106);
            this.btnRegisterElements.Name = "btnRegisterElements";
            this.btnRegisterElements.Size = new System.Drawing.Size(206, 68);
            this.btnRegisterElements.TabIndex = 1;
            this.btnRegisterElements.Text = "          REGISTRAR ELEMENTO";
            this.btnRegisterElements.UseVisualStyleBackColor = true;
            this.btnRegisterElements.Click += new System.EventHandler(this.btnRegisterElements_Click_1);
            // 
            // btnCreateAlarm
            // 
            this.btnCreateAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAlarm.FlatAppearance.BorderSize = 0;
            this.btnCreateAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAlarm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAlarm.Image")));
            this.btnCreateAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAlarm.Location = new System.Drawing.Point(12, 180);
            this.btnCreateAlarm.Name = "btnCreateAlarm";
            this.btnCreateAlarm.Size = new System.Drawing.Size(206, 68);
            this.btnCreateAlarm.TabIndex = 2;
            this.btnCreateAlarm.Text = " CREAR ALARMA";
            this.btnCreateAlarm.UseVisualStyleBackColor = true;
            this.btnCreateAlarm.Click += new System.EventHandler(this.btnCreateAlarm_Click_1);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.FlatAppearance.BorderSize = 0;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalysis.Image")));
            this.btnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalysis.Location = new System.Drawing.Point(12, 328);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(206, 68);
            this.btnAnalysis.TabIndex = 4;
            this.btnAnalysis.Text = "                   ANALYSIS";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click_1);
            // 
            // btnSeeAlarms
            // 
            this.btnSeeAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeAlarms.FlatAppearance.BorderSize = 0;
            this.btnSeeAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAlarms.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAlarms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeAlarms.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeAlarms.Image")));
            this.btnSeeAlarms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAlarms.Location = new System.Drawing.Point(12, 254);
            this.btnSeeAlarms.Name = "btnSeeAlarms";
            this.btnSeeAlarms.Size = new System.Drawing.Size(206, 68);
            this.btnSeeAlarms.TabIndex = 3;
            this.btnSeeAlarms.Text = "             ALARMAS DEL SISTEMA";
            this.btnSeeAlarms.UseVisualStyleBackColor = true;
            this.btnSeeAlarms.Click += new System.EventHandler(this.btnSeeAlarms_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnSystemElements);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSeeAlarms);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Controls.Add(this.btnCreateAlarm);
            this.panel1.Controls.Add(this.btnRegisterElements);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 586);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sidePanel.Location = new System.Drawing.Point(0, 104);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 70);
            this.sidePanel.TabIndex = 6;
            // 
            // btnSystemElements
            // 
            this.btnSystemElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemElements.FlatAppearance.BorderSize = 0;
            this.btnSystemElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemElements.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemElements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystemElements.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemElements.Image")));
            this.btnSystemElements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemElements.Location = new System.Drawing.Point(12, 398);
            this.btnSystemElements.Name = "btnSystemElements";
            this.btnSystemElements.Size = new System.Drawing.Size(206, 68);
            this.btnSystemElements.TabIndex = 5;
            this.btnSystemElements.Text = "                ELEMENTOS DEL SISTEMA";
            this.btnSystemElements.UseVisualStyleBackColor = true;
            this.btnSystemElements.Click += new System.EventHandler(this.btnSystemElements_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 100);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(97, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANALYZER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FEELING";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 71);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnMaximze);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(218, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 97);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(23, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(689, 1);
            this.panel6.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(111, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(542, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Panel Principal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DesktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DesktopPanel.Controls.Add(this.pictureBox1);
            this.DesktopPanel.Controls.Add(this.panel5);
            this.DesktopPanel.Controls.Add(this.panel4);
            this.DesktopPanel.Controls.Add(this.lblDate);
            this.DesktopPanel.Controls.Add(this.lblTime);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(218, 97);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(793, 489);
            this.DesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 244);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(119, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 1);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 465);
            this.panel4.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDate.Location = new System.Drawing.Point(228, 347);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(157, 45);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Navy;
            this.lblTime.Location = new System.Drawing.Point(303, 289);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(186, 58);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "lblTime";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(700, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 22);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximze
            // 
            this.btnMaximze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximze.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximze.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximze.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximze.Image")));
            this.btnMaximze.Location = new System.Drawing.Point(732, 3);
            this.btnMaximze.Name = "btnMaximze";
            this.btnMaximze.Size = new System.Drawing.Size(26, 22);
            this.btnMaximze.TabIndex = 23;
            this.btnMaximze.UseVisualStyleBackColor = false;
            this.btnMaximze.Click += new System.EventHandler(this.btnMaximze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(764, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 22);
            this.btnExit.TabIndex = 24;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.DesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterElements;
        private System.Windows.Forms.Button btnCreateAlarm;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnSeeAlarms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSystemElements;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximze;
        private System.Windows.Forms.Button btnMinimize;
    }
}

