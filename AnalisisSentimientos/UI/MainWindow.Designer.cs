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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSystemElements = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximze = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.desktopPanel.SuspendLayout();
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
            this.btnRegisterElements.Location = new System.Drawing.Point(16, 130);
            this.btnRegisterElements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterElements.Name = "btnRegisterElements";
            this.btnRegisterElements.Size = new System.Drawing.Size(275, 84);
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
            this.btnCreateAlarm.Location = new System.Drawing.Point(16, 222);
            this.btnCreateAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAlarm.Name = "btnCreateAlarm";
            this.btnCreateAlarm.Size = new System.Drawing.Size(275, 84);
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
            this.btnAnalysis.Location = new System.Drawing.Point(16, 404);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(275, 84);
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
            this.btnSeeAlarms.Location = new System.Drawing.Point(16, 313);
            this.btnSeeAlarms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeeAlarms.Name = "btnSeeAlarms";
            this.btnSeeAlarms.Size = new System.Drawing.Size(275, 84);
            this.btnSeeAlarms.TabIndex = 3;
            this.btnSeeAlarms.Text = "             ALARMAS DEL SISTEMA";
            this.btnSeeAlarms.UseVisualStyleBackColor = true;
            this.btnSeeAlarms.Click += new System.EventHandler(this.btnSeeAlarms_Click_1);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Navy;
            this.menuPanel.Controls.Add(this.sidePanel);
            this.menuPanel.Controls.Add(this.btnSystemElements);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Controls.Add(this.btnSeeAlarms);
            this.menuPanel.Controls.Add(this.btnAnalysis);
            this.menuPanel.Controls.Add(this.btnCreateAlarm);
            this.menuPanel.Controls.Add(this.btnRegisterElements);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(291, 721);
            this.menuPanel.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sidePanel.Location = new System.Drawing.Point(0, 128);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 86);
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
            this.btnSystemElements.Location = new System.Drawing.Point(16, 490);
            this.btnSystemElements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSystemElements.Name = "btnSystemElements";
            this.btnSystemElements.Size = new System.Drawing.Size(275, 84);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 123);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANALYZER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FEELING";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 87);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titlePanel.Controls.Add(this.btnExit);
            this.titlePanel.Controls.Add(this.btnMaximze);
            this.titlePanel.Controls.Add(this.btnMinimize);
            this.titlePanel.Controls.Add(this.panel6);
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(291, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1057, 119);
            this.titlePanel.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1019, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 27);
            this.btnExit.TabIndex = 24;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximze
            // 
            this.btnMaximze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximze.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximze.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximze.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximze.Image")));
            this.btnMaximze.Location = new System.Drawing.Point(976, 4);
            this.btnMaximze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximze.Name = "btnMaximze";
            this.btnMaximze.Size = new System.Drawing.Size(35, 27);
            this.btnMaximze.TabIndex = 23;
            this.btnMaximze.UseVisualStyleBackColor = false;
            this.btnMaximze.Click += new System.EventHandler(this.btnMaximze_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(933, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 27);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(31, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(919, 1);
            this.panel6.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(148, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(723, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MENU PRINCIPAL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.desktopPanel.Controls.Add(this.pictureBox1);
            this.desktopPanel.Controls.Add(this.panel5);
            this.desktopPanel.Controls.Add(this.panel4);
            this.desktopPanel.Controls.Add(this.lblDate);
            this.desktopPanel.Controls.Add(this.lblTime);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(291, 119);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1057, 602);
            this.desktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 300);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(159, 330);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 1);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(0, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 572);
            this.panel4.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDate.Location = new System.Drawing.Point(304, 427);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(195, 58);
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
            this.lblTime.Location = new System.Drawing.Point(404, 356);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(235, 74);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "lblTime";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterElements;
        private System.Windows.Forms.Button btnCreateAlarm;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnSeeAlarms;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel desktopPanel;
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
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximze;
        private System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.PictureBox pictureBox2;
    }
}

