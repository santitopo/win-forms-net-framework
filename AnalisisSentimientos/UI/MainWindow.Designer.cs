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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSystemElements = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterElements
            // 
            this.btnRegisterElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterElements.Location = new System.Drawing.Point(0, 170);
            this.btnRegisterElements.Name = "btnRegisterElements";
            this.btnRegisterElements.Size = new System.Drawing.Size(219, 47);
            this.btnRegisterElements.TabIndex = 5;
            this.btnRegisterElements.Text = "Registrar Elementos";
            this.btnRegisterElements.UseVisualStyleBackColor = true;
            this.btnRegisterElements.Click += new System.EventHandler(this.btnRegisterElements_Click_1);
            // 
            // btnCreateAlarm
            // 
            this.btnCreateAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAlarm.Location = new System.Drawing.Point(0, 223);
            this.btnCreateAlarm.Name = "btnCreateAlarm";
            this.btnCreateAlarm.Size = new System.Drawing.Size(219, 51);
            this.btnCreateAlarm.TabIndex = 6;
            this.btnCreateAlarm.Text = "Crear Alarma";
            this.btnCreateAlarm.UseVisualStyleBackColor = true;
            this.btnCreateAlarm.Click += new System.EventHandler(this.btnCreateAlarm_Click_1);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.Location = new System.Drawing.Point(0, 329);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(219, 40);
            this.btnAnalysis.TabIndex = 7;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click_1);
            // 
            // btnSeeAlarms
            // 
            this.btnSeeAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeAlarms.Location = new System.Drawing.Point(0, 280);
            this.btnSeeAlarms.Name = "btnSeeAlarms";
            this.btnSeeAlarms.Size = new System.Drawing.Size(219, 43);
            this.btnSeeAlarms.TabIndex = 8;
            this.btnSeeAlarms.Text = "Ver Alarmas del Sistema";
            this.btnSeeAlarms.UseVisualStyleBackColor = true;
            this.btnSeeAlarms.Click += new System.EventHandler(this.btnSeeAlarms_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnSystemElements);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSeeAlarms);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Controls.Add(this.btnCreateAlarm);
            this.panel1.Controls.Add(this.btnRegisterElements);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 164);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 100);
            this.panel3.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(219, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(665, 461);
            this.MainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSystemElements
            // 
            this.btnSystemElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemElements.Location = new System.Drawing.Point(0, 375);
            this.btnSystemElements.Name = "btnSystemElements";
            this.btnSystemElements.Size = new System.Drawing.Size(219, 40);
            this.btnSystemElements.TabIndex = 10;
            this.btnSystemElements.Text = "Ver Elementos del Sistema";
            this.btnSystemElements.UseVisualStyleBackColor = true;
            this.btnSystemElements.Click += new System.EventHandler(this.btnSystemElements_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSystemElements;
    }
}

