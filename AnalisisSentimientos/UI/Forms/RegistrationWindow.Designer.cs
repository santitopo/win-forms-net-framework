namespace UI
{
    partial class RegistrationWindow
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
            this.WrapperPanel = new System.Windows.Forms.Panel();
            this.btnPhrase = new System.Windows.Forms.Button();
            this.btnEntity = new System.Windows.Forms.Button();
            this.btnFeeling = new System.Windows.Forms.Button();
            this.RegistrationPanel = new System.Windows.Forms.Panel();
            this.WrapperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WrapperPanel
            // 
            this.WrapperPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WrapperPanel.Controls.Add(this.btnPhrase);
            this.WrapperPanel.Controls.Add(this.btnEntity);
            this.WrapperPanel.Controls.Add(this.btnFeeling);
            this.WrapperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WrapperPanel.Location = new System.Drawing.Point(0, 0);
            this.WrapperPanel.Name = "WrapperPanel";
            this.WrapperPanel.Size = new System.Drawing.Size(1080, 48);
            this.WrapperPanel.TabIndex = 1;
            // 
            // btnPhrase
            // 
            this.btnPhrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhrase.Location = new System.Drawing.Point(604, 9);
            this.btnPhrase.Name = "btnPhrase";
            this.btnPhrase.Size = new System.Drawing.Size(168, 33);
            this.btnPhrase.TabIndex = 3;
            this.btnPhrase.Text = "Registrar Frase";
            this.btnPhrase.UseVisualStyleBackColor = true;
            this.btnPhrase.Click += new System.EventHandler(this.btnPhrase_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntity.Location = new System.Drawing.Point(402, 9);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(168, 33);
            this.btnEntity.TabIndex = 2;
            this.btnEntity.Text = "Registrar Entidad";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnFeeling
            // 
            this.btnFeeling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeeling.Location = new System.Drawing.Point(202, 9);
            this.btnFeeling.Name = "btnFeeling";
            this.btnFeeling.Size = new System.Drawing.Size(168, 33);
            this.btnFeeling.TabIndex = 1;
            this.btnFeeling.Text = "Registrar Sentimiento";
            this.btnFeeling.UseVisualStyleBackColor = true;
            this.btnFeeling.Click += new System.EventHandler(this.btnFeeling_Click);
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationPanel.Location = new System.Drawing.Point(0, 48);
            this.RegistrationPanel.Name = "RegistrationPanel";
            this.RegistrationPanel.Size = new System.Drawing.Size(1080, 503);
            this.RegistrationPanel.TabIndex = 4;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.RegistrationPanel);
            this.Controls.Add(this.WrapperPanel);
            this.Name = "RegistrationWindow";
            this.Text = "RegistrationWindow";
            this.WrapperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WrapperPanel;
        private System.Windows.Forms.Button btnPhrase;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.Button btnFeeling;
        private System.Windows.Forms.Panel RegistrationPanel;
    }
}