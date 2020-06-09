namespace UI.Forms
{
    partial class AuthorsWindow
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
            this.datagridAuthors = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnEntities = new System.Windows.Forms.RadioButton();
            this.rbtnRatio = new System.Windows.Forms.RadioButton();
            this.rbtnAverage = new System.Windows.Forms.RadioButton();
            this.cmbphraseType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAuthors)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datagridAuthors);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 695);
            this.panel1.TabIndex = 0;
            // 
            // datagridAuthors
            // 
            this.datagridAuthors.AllowUserToAddRows = false;
            this.datagridAuthors.AllowUserToDeleteRows = false;
            this.datagridAuthors.AllowUserToOrderColumns = true;
            this.datagridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAuthors.Location = new System.Drawing.Point(39, 191);
            this.datagridAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridAuthors.Name = "datagridAuthors";
            this.datagridAuthors.ReadOnly = true;
            this.datagridAuthors.RowHeadersWidth = 51;
            this.datagridAuthors.RowTemplate.Height = 24;
            this.datagridAuthors.Size = new System.Drawing.Size(999, 472);
            this.datagridAuthors.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(481, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Listar Segun:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cmbphraseType);
            this.groupBox2.Controls.Add(this.rbtnAverage);
            this.groupBox2.Controls.Add(this.rbtnEntities);
            this.groupBox2.Controls.Add(this.rbtnRatio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1058, 125);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterios";
            // 
            // rbtnEntities
            // 
            this.rbtnEntities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnEntities.AutoSize = true;
            this.rbtnEntities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntities.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnEntities.Location = new System.Drawing.Point(191, 70);
            this.rbtnEntities.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnEntities.Name = "rbtnEntities";
            this.rbtnEntities.Size = new System.Drawing.Size(350, 37);
            this.rbtnEntities.TabIndex = 2;
            this.rbtnEntities.Text = "Entidades Mencionadas";
            this.rbtnEntities.UseVisualStyleBackColor = true;
            this.rbtnEntities.Click += new System.EventHandler(this.rbtnEntitiesChecked);
            // 
            // rbtnRatio
            // 
            this.rbtnRatio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnRatio.AutoSize = true;
            this.rbtnRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRatio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnRatio.Location = new System.Drawing.Point(191, 25);
            this.rbtnRatio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnRatio.Name = "rbtnRatio";
            this.rbtnRatio.Size = new System.Drawing.Size(353, 37);
            this.rbtnRatio.TabIndex = 3;
            this.rbtnRatio.Text = "Porcentaje Comentarios";
            this.rbtnRatio.UseVisualStyleBackColor = true;
            this.rbtnRatio.Click += new System.EventHandler(this.rbtnRatio_CheckedChanged);
            // 
            // rbtnAverage
            // 
            this.rbtnAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnAverage.AutoSize = true;
            this.rbtnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAverage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnAverage.Location = new System.Drawing.Point(561, 70);
            this.rbtnAverage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnAverage.Name = "rbtnAverage";
            this.rbtnAverage.Size = new System.Drawing.Size(348, 37);
            this.rbtnAverage.TabIndex = 4;
            this.rbtnAverage.Text = "Promedio Frases Diario";
            this.rbtnAverage.UseVisualStyleBackColor = true;
            this.rbtnAverage.Click += new System.EventHandler(this.rbtnAverage_CheckedChanged);
            // 
            // cmbphraseType
            // 
            this.cmbphraseType.Enabled = false;
            this.cmbphraseType.FormattingEnabled = true;
            this.cmbphraseType.Items.AddRange(new object[] {
            "Positivos",
            "Negativos"});
            this.cmbphraseType.Location = new System.Drawing.Point(561, 21);
            this.cmbphraseType.Name = "cmbphraseType";
            this.cmbphraseType.Size = new System.Drawing.Size(348, 41);
            this.cmbphraseType.TabIndex = 5;
            this.cmbphraseType.SelectedValueChanged += new System.EventHandler(this.rbtnRatio_CheckedChanged);
            // 
            // AuthorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 691);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorsWindow";
            this.Text = "AuthorsWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAuthors)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnEntities;
        private System.Windows.Forms.RadioButton rbtnRatio;
        private System.Windows.Forms.ComboBox cmbphraseType;
        private System.Windows.Forms.RadioButton rbtnAverage;
    }
}