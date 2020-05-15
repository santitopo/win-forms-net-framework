namespace UI
{
    partial class SystemElementsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemElementsWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPhrases = new System.Windows.Forms.DataGridView();
            this.grdEntities = new System.Windows.Forms.DataGridView();
            this.grdFeelings = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhrases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFeelings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdPhrases);
            this.panel1.Controls.Add(this.grdEntities);
            this.panel1.Controls.Add(this.grdFeelings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(56, 498);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar Elemento";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(60, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frases";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(649, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entidades";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(649, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sentimientos";
            // 
            // grdPhrases
            // 
            this.grdPhrases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdPhrases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPhrases.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdPhrases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPhrases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhrases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPhrases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhrases.EnableHeadersVisualStyles = false;
            this.grdPhrases.GridColor = System.Drawing.Color.Navy;
            this.grdPhrases.Location = new System.Drawing.Point(56, 66);
            this.grdPhrases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPhrases.Name = "grdPhrases";
            this.grdPhrases.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.grdPhrases.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPhrases.RowTemplate.Height = 24;
            this.grdPhrases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhrases.Size = new System.Drawing.Size(564, 425);
            this.grdPhrases.TabIndex = 2;
            // 
            // grdEntities
            // 
            this.grdEntities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdEntities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEntities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdEntities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEntities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEntities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntities.EnableHeadersVisualStyles = false;
            this.grdEntities.GridColor = System.Drawing.Color.Navy;
            this.grdEntities.Location = new System.Drawing.Point(655, 66);
            this.grdEntities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdEntities.Name = "grdEntities";
            this.grdEntities.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            this.grdEntities.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdEntities.RowTemplate.Height = 24;
            this.grdEntities.Size = new System.Drawing.Size(371, 194);
            this.grdEntities.TabIndex = 1;
            // 
            // grdFeelings
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFeelings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdFeelings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdFeelings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFeelings.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdFeelings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdFeelings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFeelings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdFeelings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFeelings.EnableHeadersVisualStyles = false;
            this.grdFeelings.GridColor = System.Drawing.Color.Navy;
            this.grdFeelings.Location = new System.Drawing.Point(655, 313);
            this.grdFeelings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdFeelings.Name = "grdFeelings";
            this.grdFeelings.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Navy;
            this.grdFeelings.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdFeelings.RowTemplate.Height = 24;
            this.grdFeelings.Size = new System.Drawing.Size(371, 194);
            this.grdFeelings.TabIndex = 0;
            // 
            // SystemElementsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SystemElementsWindow";
            this.Text = "SystemElementsWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhrases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFeelings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPhrases;
        private System.Windows.Forms.DataGridView grdEntities;
        private System.Windows.Forms.DataGridView grdFeelings;
        private System.Windows.Forms.Button btnDelete;
    }
}