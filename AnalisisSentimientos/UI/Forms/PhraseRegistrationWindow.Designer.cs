namespace UI
{
    partial class PhraseRegistrationWindow
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnRegisterPhrase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.txtPhrase);
            this.panel1.Controls.Add(this.btnRegisterPhrase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(351, 322);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(384, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // txtPhrase
            // 
            this.txtPhrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhrase.Location = new System.Drawing.Point(351, 256);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(384, 22);
            this.txtPhrase.TabIndex = 0;
            // 
            // btnRegisterPhrase
            // 
            this.btnRegisterPhrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterPhrase.Location = new System.Drawing.Point(434, 381);
            this.btnRegisterPhrase.Name = "btnRegisterPhrase";
            this.btnRegisterPhrase.Size = new System.Drawing.Size(249, 31);
            this.btnRegisterPhrase.TabIndex = 2;
            this.btnRegisterPhrase.Text = "Registar Frase";
            this.btnRegisterPhrase.UseVisualStyleBackColor = true;
            this.btnRegisterPhrase.Click += new System.EventHandler(this.btnRegisterPhrase_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Frase";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "PhraseRegistration";
            // 
            // PhraseRegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
            this.Name = "PhraseRegistrationWindow";
            this.Text = "PhraseRegistrationWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Button btnRegisterPhrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}