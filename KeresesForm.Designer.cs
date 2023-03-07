namespace WFA230227
{
    partial class KeresesForm
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
            keresesDataGridView = new DataGridView();
            uiGroupBox = new GroupBox();
            keresesTextBox = new TextBox();
            IdColumn = new DataGridViewTextBoxColumn();
            NevColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)keresesDataGridView).BeginInit();
            uiGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // keresesDataGridView
            // 
            keresesDataGridView.AllowUserToAddRows = false;
            keresesDataGridView.AllowUserToDeleteRows = false;
            keresesDataGridView.AllowUserToResizeColumns = false;
            keresesDataGridView.AllowUserToResizeRows = false;
            keresesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            keresesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            keresesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            keresesDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NevColumn });
            keresesDataGridView.Location = new Point(12, 91);
            keresesDataGridView.Name = "keresesDataGridView";
            keresesDataGridView.RowHeadersVisible = false;
            keresesDataGridView.RowTemplate.Height = 25;
            keresesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            keresesDataGridView.Size = new Size(360, 308);
            keresesDataGridView.TabIndex = 2;
            // 
            // uiGroupBox
            // 
            uiGroupBox.BackColor = Color.LightCoral;
            uiGroupBox.Controls.Add(keresesTextBox);
            uiGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiGroupBox.Location = new Point(12, 12);
            uiGroupBox.Name = "uiGroupBox";
            uiGroupBox.Size = new Size(360, 73);
            uiGroupBox.TabIndex = 3;
            uiGroupBox.TabStop = false;
            uiGroupBox.Text = "keresés díjazottak neve alapján";
            // 
            // keresesTextBox
            // 
            keresesTextBox.Location = new Point(6, 28);
            keresesTextBox.Name = "keresesTextBox";
            keresesTextBox.Size = new Size(348, 29);
            keresesTextBox.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.FillWeight = 2F;
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            // 
            // NevColumn
            // 
            NevColumn.FillWeight = 8F;
            NevColumn.HeaderText = "Személy";
            NevColumn.Name = "NevColumn";
            // 
            // KeresesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(384, 411);
            Controls.Add(uiGroupBox);
            Controls.Add(keresesDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "KeresesForm";
            Text = "Keresés";
            ((System.ComponentModel.ISupportInitialize)keresesDataGridView).EndInit();
            uiGroupBox.ResumeLayout(false);
            uiGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView keresesDataGridView;
        private GroupBox uiGroupBox;
        private TextBox keresesTextBox;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NevColumn;
    }
}