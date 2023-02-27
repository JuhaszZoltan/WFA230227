namespace WFA230227
{
    partial class UjForm
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
            this.ujSzemelyGroupBox = new System.Windows.Forms.GroupBox();
            this.ujDijGroupBox = new System.Windows.Forms.GroupBox();
            this.uiLabel01 = new System.Windows.Forms.Label();
            this.ujSzemelyNevTextBox = new System.Windows.Forms.TextBox();
            this.uiLabel02 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ujSzemelyButton = new System.Windows.Forms.Button();
            this.ujDijazottButton = new System.Windows.Forms.Button();
            this.uiLabel03 = new System.Windows.Forms.Label();
            this.ujDijazottNevTextBox = new System.Windows.Forms.TextBox();
            this.uiLabel04 = new System.Windows.Forms.Label();
            this.evNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ujSzemelyGroupBox.SuspendLayout();
            this.ujDijGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ujSzemelyGroupBox
            // 
            this.ujSzemelyGroupBox.BackColor = System.Drawing.Color.LightCoral;
            this.ujSzemelyGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ujSzemelyGroupBox.Controls.Add(this.textBox2);
            this.ujSzemelyGroupBox.Controls.Add(this.uiLabel02);
            this.ujSzemelyGroupBox.Controls.Add(this.ujSzemelyNevTextBox);
            this.ujSzemelyGroupBox.Controls.Add(this.uiLabel01);
            this.ujSzemelyGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ujSzemelyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ujSzemelyGroupBox.Name = "ujSzemelyGroupBox";
            this.ujSzemelyGroupBox.Size = new System.Drawing.Size(360, 202);
            this.ujSzemelyGroupBox.TabIndex = 0;
            this.ujSzemelyGroupBox.TabStop = false;
            this.ujSzemelyGroupBox.Text = "Új személy felvétele";
            // 
            // ujDijGroupBox
            // 
            this.ujDijGroupBox.BackColor = System.Drawing.Color.LightCoral;
            this.ujDijGroupBox.Controls.Add(this.evNumericUpDown);
            this.ujDijGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.ujDijGroupBox.Controls.Add(this.ujDijazottNevTextBox);
            this.ujDijGroupBox.Controls.Add(this.uiLabel04);
            this.ujDijGroupBox.Controls.Add(this.uiLabel03);
            this.ujDijGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ujDijGroupBox.Location = new System.Drawing.Point(12, 224);
            this.ujDijGroupBox.Name = "ujDijGroupBox";
            this.ujDijGroupBox.Size = new System.Drawing.Size(360, 145);
            this.ujDijGroupBox.TabIndex = 0;
            this.ujDijGroupBox.TabStop = false;
            this.ujDijGroupBox.Text = "Új díj kiosztása";
            // 
            // uiLabel01
            // 
            this.uiLabel01.AutoSize = true;
            this.uiLabel01.Location = new System.Drawing.Point(96, 48);
            this.uiLabel01.Name = "uiLabel01";
            this.uiLabel01.Size = new System.Drawing.Size(45, 21);
            this.uiLabel01.TabIndex = 0;
            this.uiLabel01.Text = "Név:";
            // 
            // ujSzemelyNevTextBox
            // 
            this.ujSzemelyNevTextBox.Location = new System.Drawing.Point(147, 45);
            this.ujSzemelyNevTextBox.Name = "ujSzemelyNevTextBox";
            this.ujSzemelyNevTextBox.Size = new System.Drawing.Size(193, 29);
            this.ujSzemelyNevTextBox.TabIndex = 1;
            // 
            // uiLabel02
            // 
            this.uiLabel02.AutoSize = true;
            this.uiLabel02.Location = new System.Drawing.Point(17, 95);
            this.uiLabel02.Name = "uiLabel02";
            this.uiLabel02.Size = new System.Drawing.Size(124, 21);
            this.uiLabel02.TabIndex = 0;
            this.uiLabel02.Text = "Foglalkozások:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 29);
            this.textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.ujSzemelyButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ujDijazottButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 49);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ujSzemelyButton
            // 
            this.ujSzemelyButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ujSzemelyButton.ForeColor = System.Drawing.Color.Firebrick;
            this.ujSzemelyButton.Location = new System.Drawing.Point(61, 3);
            this.ujSzemelyButton.Name = "ujSzemelyButton";
            this.ujSzemelyButton.Size = new System.Drawing.Size(226, 43);
            this.ujSzemelyButton.TabIndex = 0;
            this.ujSzemelyButton.Text = "Új személy";
            this.ujSzemelyButton.UseVisualStyleBackColor = false;
            // 
            // ujDijazottButton
            // 
            this.ujDijazottButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ujDijazottButton.ForeColor = System.Drawing.Color.Firebrick;
            this.ujDijazottButton.Location = new System.Drawing.Point(61, 3);
            this.ujDijazottButton.Name = "ujDijazottButton";
            this.ujDijazottButton.Size = new System.Drawing.Size(226, 43);
            this.ujDijazottButton.TabIndex = 0;
            this.ujDijazottButton.Text = "Új József Attila díj";
            this.ujDijazottButton.UseVisualStyleBackColor = false;
            // 
            // uiLabel03
            // 
            this.uiLabel03.AutoSize = true;
            this.uiLabel03.Location = new System.Drawing.Point(17, 45);
            this.uiLabel03.Name = "uiLabel03";
            this.uiLabel03.Size = new System.Drawing.Size(45, 21);
            this.uiLabel03.TabIndex = 0;
            this.uiLabel03.Text = "Név:";
            // 
            // ujDijazottNevTextBox
            // 
            this.ujDijazottNevTextBox.Location = new System.Drawing.Point(68, 42);
            this.ujDijazottNevTextBox.Name = "ujDijazottNevTextBox";
            this.ujDijazottNevTextBox.Size = new System.Drawing.Size(162, 29);
            this.ujDijazottNevTextBox.TabIndex = 1;
            // 
            // uiLabel04
            // 
            this.uiLabel04.AutoSize = true;
            this.uiLabel04.Location = new System.Drawing.Point(236, 45);
            this.uiLabel04.Name = "uiLabel04";
            this.uiLabel04.Size = new System.Drawing.Size(32, 21);
            this.uiLabel04.TabIndex = 0;
            this.uiLabel04.Text = "Év:";
            // 
            // evNumericUpDown
            // 
            this.evNumericUpDown.Location = new System.Drawing.Point(275, 42);
            this.evNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.evNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.evNumericUpDown.Name = "evNumericUpDown";
            this.evNumericUpDown.Size = new System.Drawing.Size(65, 29);
            this.evNumericUpDown.TabIndex = 3;
            this.evNumericUpDown.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // UjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.ujDijGroupBox);
            this.Controls.Add(this.ujSzemelyGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UjForm";
            this.Text = "Új adatok felvétele";
            this.ujSzemelyGroupBox.ResumeLayout(false);
            this.ujSzemelyGroupBox.PerformLayout();
            this.ujDijGroupBox.ResumeLayout(false);
            this.ujDijGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ujSzemelyGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ujSzemelyButton;
        private TextBox textBox2;
        private Label uiLabel02;
        private TextBox ujSzemelyNevTextBox;
        private Label uiLabel01;
        private GroupBox ujDijGroupBox;
        private NumericUpDown evNumericUpDown;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ujDijazottButton;
        private TextBox ujDijazottNevTextBox;
        private Label uiLabel04;
        private Label uiLabel03;
    }
}