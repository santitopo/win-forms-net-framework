namespace UI
{
    partial class FeelingRegistrationWindow
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnNegative = new System.Windows.Forms.RadioButton();
            this.rbtnPositive = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegisterFeeling = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rbtnNegative);
            this.panel1.Controls.Add(this.rbtnPositive);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnRegisterFeeling);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(336, 207);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 1);
            this.panel2.TabIndex = 18;
            // 
            // rbtnNegative
            // 
            this.rbtnNegative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNegative.AutoSize = true;
            this.rbtnNegative.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNegative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnNegative.Location = new System.Drawing.Point(560, 257);
            this.rbtnNegative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNegative.Name = "rbtnNegative";
            this.rbtnNegative.Size = new System.Drawing.Size(145, 34);
            this.rbtnNegative.TabIndex = 2;
            this.rbtnNegative.TabStop = true;
            this.rbtnNegative.Text = "Negativo";
            this.rbtnNegative.UseVisualStyleBackColor = true;
            // 
            // rbtnPositive
            // 
            this.rbtnPositive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnPositive.AutoSize = true;
            this.rbtnPositive.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPositive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnPositive.Location = new System.Drawing.Point(375, 257);
            this.rbtnPositive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPositive.Name = "rbtnPositive";
            this.rbtnPositive.Size = new System.Drawing.Size(125, 34);
            this.rbtnPositive.TabIndex = 1;
            this.rbtnPositive.TabStop = true;
            this.rbtnPositive.Text = "Positivo";
            this.rbtnPositive.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(347, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 30);
            this.txtName.TabIndex = 0;
            // 
            // btnRegisterFeeling
            // 
            this.btnRegisterFeeling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterFeeling.BackColor = System.Drawing.Color.Navy;
            this.btnRegisterFeeling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterFeeling.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFeeling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterFeeling.Location = new System.Drawing.Point(401, 322);
            this.btnRegisterFeeling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterFeeling.Name = "btnRegisterFeeling";
            this.btnRegisterFeeling.Size = new System.Drawing.Size(260, 41);
            this.btnRegisterFeeling.TabIndex = 3;
            this.btnRegisterFeeling.Text = "Registar Sentimiento";
            this.btnRegisterFeeling.UseVisualStyleBackColor = false;
            this.btnRegisterFeeling.Click += new System.EventHandler(this.btnRegisterFeeling_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(341, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(341, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // FeelingRegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FeelingRegistrationWindow";
            this.Text = "FeelingRegistrationWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnNegative;
        private System.Windows.Forms.RadioButton rbtnPositive;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRegisterFeeling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}