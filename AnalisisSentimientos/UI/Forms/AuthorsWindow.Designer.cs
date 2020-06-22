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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.datagridAuthors = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbphraseType = new System.Windows.Forms.ComboBox();
            this.rbtnAverage = new System.Windows.Forms.RadioButton();
            this.rbtnEntities = new System.Windows.Forms.RadioButton();
            this.rbtnRatio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAuthors)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnDeleteAuthor);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 689);
            this.panel1.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Navy;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.Location = new System.Drawing.Point(22, 32);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(64, 62);
            this.btnSort.TabIndex = 25;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.Navy;
            this.btnDeleteAuthor.FlatAppearance.BorderSize = 0;
            this.btnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAuthor.Image")));
            this.btnDeleteAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(916, 284);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(222, 50);
            this.btnDeleteAuthor.TabIndex = 24;
            this.btnDeleteAuthor.Text = "Eliminar Autor";
            this.btnDeleteAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // datagridAuthors
            // 
            this.datagridAuthors.AllowUserToAddRows = false;
            this.datagridAuthors.AllowUserToDeleteRows = false;
            this.datagridAuthors.AllowUserToOrderColumns = true;
            this.datagridAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagridAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAuthors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridAuthors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridAuthors.ColumnHeadersHeight = 25;
            this.datagridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridAuthors.EnableHeadersVisualStyles = false;
            this.datagridAuthors.GridColor = System.Drawing.Color.Navy;
            this.datagridAuthors.Location = new System.Drawing.Point(92, 32);
            this.datagridAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridAuthors.Name = "datagridAuthors";
            this.datagridAuthors.ReadOnly = true;
            this.datagridAuthors.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.datagridAuthors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridAuthors.RowTemplate.Height = 24;
            this.datagridAuthors.Size = new System.Drawing.Size(674, 572);
            this.datagridAuthors.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cmbphraseType);
            this.groupBox2.Controls.Add(this.rbtnAverage);
            this.groupBox2.Controls.Add(this.rbtnEntities);
            this.groupBox2.Controls.Add(this.rbtnRatio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(849, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(339, 232);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar Segun";
            // 
            // cmbphraseType
            // 
            this.cmbphraseType.Enabled = false;
            this.cmbphraseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbphraseType.FormattingEnabled = true;
            this.cmbphraseType.Items.AddRange(new object[] {
            "Positivos",
            "Negativos"});
            this.cmbphraseType.Location = new System.Drawing.Point(51, 85);
            this.cmbphraseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbphraseType.Name = "cmbphraseType";
            this.cmbphraseType.Size = new System.Drawing.Size(252, 37);
            this.cmbphraseType.TabIndex = 5;
            this.cmbphraseType.SelectedValueChanged += new System.EventHandler(this.rbtnRatio_CheckedChanged);
            // 
            // rbtnAverage
            // 
            this.rbtnAverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnAverage.AutoSize = true;
            this.rbtnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAverage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnAverage.Location = new System.Drawing.Point(8, 186);
            this.rbtnAverage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnAverage.Name = "rbtnAverage";
            this.rbtnAverage.Size = new System.Drawing.Size(294, 33);
            this.rbtnAverage.TabIndex = 4;
            this.rbtnAverage.Text = "Promedio Frases Diario";
            this.rbtnAverage.UseVisualStyleBackColor = true;
            this.rbtnAverage.Click += new System.EventHandler(this.rbtnAverage_CheckedChanged);
            // 
            // rbtnEntities
            // 
            this.rbtnEntities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnEntities.AutoSize = true;
            this.rbtnEntities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntities.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnEntities.Location = new System.Drawing.Point(8, 142);
            this.rbtnEntities.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnEntities.Name = "rbtnEntities";
            this.rbtnEntities.Size = new System.Drawing.Size(296, 33);
            this.rbtnEntities.TabIndex = 2;
            this.rbtnEntities.Text = "Entidades Mencionadas";
            this.rbtnEntities.UseVisualStyleBackColor = true;
            this.rbtnEntities.Click += new System.EventHandler(this.rbtnEntitiesChecked);
            // 
            // rbtnRatio
            // 
            this.rbtnRatio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnRatio.AutoSize = true;
            this.rbtnRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRatio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbtnRatio.Location = new System.Drawing.Point(7, 44);
            this.rbtnRatio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnRatio.Name = "rbtnRatio";
            this.rbtnRatio.Size = new System.Drawing.Size(297, 33);
            this.rbtnRatio.TabIndex = 3;
            this.rbtnRatio.Text = "Porcentaje Comentarios";
            this.rbtnRatio.UseVisualStyleBackColor = true;
            this.rbtnRatio.Click += new System.EventHandler(this.rbtnRatio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.datagridAuthors);
            this.panel2.Location = new System.Drawing.Point(23, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 612);
            this.panel2.TabIndex = 26;
            // 
            // AuthorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 689);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorsWindow";
            this.Text = "AuthorsWindow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridAuthors)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnEntities;
        private System.Windows.Forms.RadioButton rbtnRatio;
        private System.Windows.Forms.ComboBox cmbphraseType;
        private System.Windows.Forms.RadioButton rbtnAverage;
        private System.Windows.Forms.DataGridView datagridAuthors;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panel2;
    }
}