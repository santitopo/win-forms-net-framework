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
            this.btnAuthor = new System.Windows.Forms.Button();
            this.WrapperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WrapperPanel
            // 
            this.WrapperPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WrapperPanel.Controls.Add(this.btnAuthor);
            this.WrapperPanel.Controls.Add(this.btnPhrase);
            this.WrapperPanel.Controls.Add(this.btnEntity);
            this.WrapperPanel.Controls.Add(this.btnFeeling);
            this.WrapperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WrapperPanel.Location = new System.Drawing.Point(0, 0);
            this.WrapperPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WrapperPanel.Name = "WrapperPanel";
            this.WrapperPanel.Size = new System.Drawing.Size(1080, 76);
            this.WrapperPanel.TabIndex = 1;
            // 
            // btnPhrase
            // 
            this.btnPhrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhrase.BackColor = System.Drawing.Color.Navy;
            this.btnPhrase.FlatAppearance.BorderSize = 0;
            this.btnPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhrase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhrase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhrase.Location = new System.Drawing.Point(559, 20);
            this.btnPhrase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhrase.Name = "btnPhrase";
            this.btnPhrase.Size = new System.Drawing.Size(205, 33);
            this.btnPhrase.TabIndex = 3;
            this.btnPhrase.Text = "Registrar Frase";
            this.btnPhrase.UseVisualStyleBackColor = false;
            this.btnPhrase.Click += new System.EventHandler(this.btnPhrase_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntity.BackColor = System.Drawing.Color.Navy;
            this.btnEntity.FlatAppearance.BorderSize = 0;
            this.btnEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntity.Location = new System.Drawing.Point(329, 20);
            this.btnEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(205, 33);
            this.btnEntity.TabIndex = 2;
            this.btnEntity.Text = "Registrar Entidad";
            this.btnEntity.UseVisualStyleBackColor = false;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnFeeling
            // 
            this.btnFeeling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeeling.BackColor = System.Drawing.Color.Navy;
            this.btnFeeling.FlatAppearance.BorderSize = 0;
            this.btnFeeling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeling.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFeeling.Location = new System.Drawing.Point(101, 20);
            this.btnFeeling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeeling.Name = "btnFeeling";
            this.btnFeeling.Size = new System.Drawing.Size(205, 33);
            this.btnFeeling.TabIndex = 1;
            this.btnFeeling.Text = "Registrar Sentimiento";
            this.btnFeeling.UseVisualStyleBackColor = false;
            this.btnFeeling.Click += new System.EventHandler(this.btnFeeling_Click);
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistrationPanel.Location = new System.Drawing.Point(0, 76);
            this.RegistrationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationPanel.Name = "RegistrationPanel";
            this.RegistrationPanel.Size = new System.Drawing.Size(1080, 475);
            this.RegistrationPanel.TabIndex = 4;
            // 
            // btnAuthor
            // 
            this.btnAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthor.BackColor = System.Drawing.Color.Navy;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuthor.Location = new System.Drawing.Point(779, 20);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(205, 33);
            this.btnAuthor.TabIndex = 4;
            this.btnAuthor.Text = "Registrar Autor";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.RegistrationPanel);
            this.Controls.Add(this.WrapperPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAuthor;
    }
}