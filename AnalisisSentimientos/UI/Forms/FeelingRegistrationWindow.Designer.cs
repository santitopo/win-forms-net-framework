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
            this.rbtnNegative = new System.Windows.Forms.RadioButton();
            this.rbtnPositive = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegisterFeeling = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rbtnNegative);
            this.panel1.Controls.Add(this.rbtnPositive);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnRegisterFeeling);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // rbtnNegative
            // 
            this.rbtnNegative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNegative.AutoSize = true;
            this.rbtnNegative.Location = new System.Drawing.Point(566, 343);
            this.rbtnNegative.Name = "rbtnNegative";
            this.rbtnNegative.Size = new System.Drawing.Size(85, 21);
            this.rbtnNegative.TabIndex = 21;
            this.rbtnNegative.TabStop = true;
            this.rbtnNegative.Text = "Negativo";
            this.rbtnNegative.UseVisualStyleBackColor = true;
            // 
            // rbtnPositive
            // 
            this.rbtnPositive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnPositive.AutoSize = true;
            this.rbtnPositive.Location = new System.Drawing.Point(380, 343);
            this.rbtnPositive.Name = "rbtnPositive";
            this.rbtnPositive.Size = new System.Drawing.Size(78, 21);
            this.rbtnPositive.TabIndex = 20;
            this.rbtnPositive.TabStop = true;
            this.rbtnPositive.Text = "Positivo";
            this.rbtnPositive.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(351, 261);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 22);
            this.txtName.TabIndex = 19;
            // 
            // btnRegisterFeeling
            // 
            this.btnRegisterFeeling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterFeeling.Location = new System.Drawing.Point(402, 392);
            this.btnRegisterFeeling.Name = "btnRegisterFeeling";
            this.btnRegisterFeeling.Size = new System.Drawing.Size(249, 31);
            this.btnRegisterFeeling.TabIndex = 18;
            this.btnRegisterFeeling.Text = "Registar Sentimiento";
            this.btnRegisterFeeling.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "FeelingRegistration";
            // 
            // FeelingRegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label1;
    }
}