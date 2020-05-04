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
            this.btnRegisterElements = new System.Windows.Forms.Button();
            this.btnCreateAlarm = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnSeeAlarms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSystemElements = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterElements
            // 
            this.btnRegisterElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterElements.Location = new System.Drawing.Point(0, 224);
            this.btnRegisterElements.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterElements.Name = "btnRegisterElements";
            this.btnRegisterElements.Size = new System.Drawing.Size(250, 58);
            this.btnRegisterElements.TabIndex = 1;
            this.btnRegisterElements.Text = "Registrar Elementos";
            this.btnRegisterElements.UseVisualStyleBackColor = true;
            this.btnRegisterElements.Click += new System.EventHandler(this.btnRegisterElements_Click_1);
            // 
            // btnCreateAlarm
            // 
            this.btnCreateAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAlarm.Location = new System.Drawing.Point(0, 289);
            this.btnCreateAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAlarm.Name = "btnCreateAlarm";
            this.btnCreateAlarm.Size = new System.Drawing.Size(250, 63);
            this.btnCreateAlarm.TabIndex = 2;
            this.btnCreateAlarm.Text = "Crear Alarma";
            this.btnCreateAlarm.UseVisualStyleBackColor = true;
            this.btnCreateAlarm.Click += new System.EventHandler(this.btnCreateAlarm_Click_1);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.Location = new System.Drawing.Point(0, 420);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(250, 49);
            this.btnAnalysis.TabIndex = 4;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click_1);
            // 
            // btnSeeAlarms
            // 
            this.btnSeeAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeAlarms.Location = new System.Drawing.Point(0, 360);
            this.btnSeeAlarms.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeAlarms.Name = "btnSeeAlarms";
            this.btnSeeAlarms.Size = new System.Drawing.Size(250, 53);
            this.btnSeeAlarms.TabIndex = 3;
            this.btnSeeAlarms.Text = "Ver Alarmas del Sistema";
            this.btnSeeAlarms.UseVisualStyleBackColor = true;
            this.btnSeeAlarms.Click += new System.EventHandler(this.btnSeeAlarms_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnSystemElements);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSeeAlarms);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Controls.Add(this.btnCreateAlarm);
            this.panel1.Controls.Add(this.btnRegisterElements);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 721);
            this.panel1.TabIndex = 0;
            // 
            // btnSystemElements
            // 
            this.btnSystemElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemElements.Location = new System.Drawing.Point(0, 477);
            this.btnSystemElements.Margin = new System.Windows.Forms.Padding(4);
            this.btnSystemElements.Name = "btnSystemElements";
            this.btnSystemElements.Size = new System.Drawing.Size(250, 49);
            this.btnSystemElements.TabIndex = 5;
            this.btnSystemElements.Text = "Ver Elementos del Sistema";
            this.btnSystemElements.UseVisualStyleBackColor = true;
            this.btnSystemElements.Click += new System.EventHandler(this.btnSystemElements_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 123);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1098, 123);
            this.panel3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(52, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(723, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Panel Principal";
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesktopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DesktopPanel.Location = new System.Drawing.Point(250, 123);
            this.DesktopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1098, 598);
            this.DesktopPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
    }
}

