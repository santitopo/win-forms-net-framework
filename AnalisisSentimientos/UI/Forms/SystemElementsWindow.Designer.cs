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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdPhrases);
            this.panel1.Controls.Add(this.grdEntities);
            this.panel1.Controls.Add(this.grdFeelings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frases";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entidades";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sentimientos";
            // 
            // grdPhrases
            // 
            this.grdPhrases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdPhrases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPhrases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhrases.Location = new System.Drawing.Point(56, 67);
            this.grdPhrases.Name = "grdPhrases";
            this.grdPhrases.RowTemplate.Height = 24;
            this.grdPhrases.Size = new System.Drawing.Size(564, 441);
            this.grdPhrases.TabIndex = 2;
            // 
            // grdEntities
            // 
            this.grdEntities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdEntities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntities.Location = new System.Drawing.Point(655, 67);
            this.grdEntities.Name = "grdEntities";
            this.grdEntities.RowTemplate.Height = 24;
            this.grdEntities.Size = new System.Drawing.Size(370, 195);
            this.grdEntities.TabIndex = 1;
            // 
            // grdFeelings
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFeelings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdFeelings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdFeelings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdFeelings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFeelings.Location = new System.Drawing.Point(655, 313);
            this.grdFeelings.Name = "grdFeelings";
            this.grdFeelings.RowTemplate.Height = 24;
            this.grdFeelings.Size = new System.Drawing.Size(370, 195);
            this.grdFeelings.TabIndex = 0;
            // 
            // SystemElementsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.panel1);
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
    }
}