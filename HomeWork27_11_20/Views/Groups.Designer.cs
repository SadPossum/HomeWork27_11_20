
namespace HomeWork27_11_20.Views
{
    partial class Groups
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GroupName,
            this.Year,
            this.SpecialtyId,
            this.SpecialtyCode,
            this.SpecialtyName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Name";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // SpecialtyId
            // 
            this.SpecialtyId.HeaderText = "SpecialtyId";
            this.SpecialtyId.MinimumWidth = 6;
            this.SpecialtyId.Name = "SpecialtyId";
            this.SpecialtyId.Visible = false;
            this.SpecialtyId.Width = 125;
            // 
            // SpecialtyCode
            // 
            this.SpecialtyCode.HeaderText = "Specialty code";
            this.SpecialtyCode.MinimumWidth = 6;
            this.SpecialtyCode.Name = "SpecialtyCode";
            this.SpecialtyCode.Width = 125;
            // 
            // SpecialtyName
            // 
            this.SpecialtyName.HeaderText = "Specialty name";
            this.SpecialtyName.MinimumWidth = 6;
            this.SpecialtyName.Name = "SpecialtyName";
            this.SpecialtyName.Width = 125;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Groups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyName;
    }
}