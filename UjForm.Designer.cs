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
            ujSzemelyGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ujSzemelyButton = new Button();
            ujSzemelyFoglalkozasokTextBox = new TextBox();
            uiLabel02 = new Label();
            ujSzemelyNevTextBox = new TextBox();
            uiLabel01 = new Label();
            ujDijGroupBox = new GroupBox();
            evNumericUpDown = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            ujDijazottButton = new Button();
            ujDijazottNevTextBox = new TextBox();
            uiLabel04 = new Label();
            uiLabel03 = new Label();
            ujSzemelyGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ujDijGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)evNumericUpDown).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ujSzemelyGroupBox
            // 
            ujSzemelyGroupBox.BackColor = Color.LightCoral;
            ujSzemelyGroupBox.Controls.Add(tableLayoutPanel1);
            ujSzemelyGroupBox.Controls.Add(ujSzemelyFoglalkozasokTextBox);
            ujSzemelyGroupBox.Controls.Add(uiLabel02);
            ujSzemelyGroupBox.Controls.Add(ujSzemelyNevTextBox);
            ujSzemelyGroupBox.Controls.Add(uiLabel01);
            ujSzemelyGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ujSzemelyGroupBox.Location = new Point(12, 12);
            ujSzemelyGroupBox.Name = "ujSzemelyGroupBox";
            ujSzemelyGroupBox.Size = new Size(360, 202);
            ujSzemelyGroupBox.TabIndex = 0;
            ujSzemelyGroupBox.TabStop = false;
            ujSzemelyGroupBox.Text = "Új személy felvétele";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Controls.Add(ujSzemelyButton, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 147);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(348, 49);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ujSzemelyButton
            // 
            ujSzemelyButton.BackColor = Color.WhiteSmoke;
            ujSzemelyButton.ForeColor = Color.Firebrick;
            ujSzemelyButton.Location = new Point(61, 3);
            ujSzemelyButton.Name = "ujSzemelyButton";
            ujSzemelyButton.Size = new Size(225, 43);
            ujSzemelyButton.TabIndex = 0;
            ujSzemelyButton.Text = "Új személy";
            ujSzemelyButton.UseVisualStyleBackColor = false;
            // 
            // ujSzemelyFoglalkozasokTextBox
            // 
            ujSzemelyFoglalkozasokTextBox.Location = new Point(147, 92);
            ujSzemelyFoglalkozasokTextBox.Name = "ujSzemelyFoglalkozasokTextBox";
            ujSzemelyFoglalkozasokTextBox.Size = new Size(193, 29);
            ujSzemelyFoglalkozasokTextBox.TabIndex = 1;
            // 
            // uiLabel02
            // 
            uiLabel02.AutoSize = true;
            uiLabel02.Location = new Point(17, 95);
            uiLabel02.Name = "uiLabel02";
            uiLabel02.Size = new Size(124, 21);
            uiLabel02.TabIndex = 0;
            uiLabel02.Text = "Foglalkozások:";
            // 
            // ujSzemelyNevTextBox
            // 
            ujSzemelyNevTextBox.Location = new Point(147, 45);
            ujSzemelyNevTextBox.Name = "ujSzemelyNevTextBox";
            ujSzemelyNevTextBox.Size = new Size(193, 29);
            ujSzemelyNevTextBox.TabIndex = 1;
            // 
            // uiLabel01
            // 
            uiLabel01.AutoSize = true;
            uiLabel01.Location = new Point(96, 48);
            uiLabel01.Name = "uiLabel01";
            uiLabel01.Size = new Size(45, 21);
            uiLabel01.TabIndex = 0;
            uiLabel01.Text = "Név:";
            // 
            // ujDijGroupBox
            // 
            ujDijGroupBox.BackColor = Color.LightCoral;
            ujDijGroupBox.Controls.Add(evNumericUpDown);
            ujDijGroupBox.Controls.Add(tableLayoutPanel2);
            ujDijGroupBox.Controls.Add(ujDijazottNevTextBox);
            ujDijGroupBox.Controls.Add(uiLabel04);
            ujDijGroupBox.Controls.Add(uiLabel03);
            ujDijGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ujDijGroupBox.Location = new Point(12, 224);
            ujDijGroupBox.Name = "ujDijGroupBox";
            ujDijGroupBox.Size = new Size(360, 145);
            ujDijGroupBox.TabIndex = 0;
            ujDijGroupBox.TabStop = false;
            ujDijGroupBox.Text = "Új díj kiosztása";
            // 
            // evNumericUpDown
            // 
            evNumericUpDown.Location = new Point(275, 42);
            evNumericUpDown.Margin = new Padding(4);
            evNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            evNumericUpDown.Name = "evNumericUpDown";
            evNumericUpDown.Size = new Size(65, 29);
            evNumericUpDown.TabIndex = 3;
            evNumericUpDown.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.Controls.Add(ujDijazottButton, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 90);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.Size = new Size(348, 49);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ujDijazottButton
            // 
            ujDijazottButton.BackColor = Color.WhiteSmoke;
            ujDijazottButton.ForeColor = Color.Firebrick;
            ujDijazottButton.Location = new Point(61, 3);
            ujDijazottButton.Name = "ujDijazottButton";
            ujDijazottButton.Size = new Size(225, 43);
            ujDijazottButton.TabIndex = 0;
            ujDijazottButton.Text = "Új József Attila díj";
            ujDijazottButton.UseVisualStyleBackColor = false;
            // 
            // ujDijazottNevTextBox
            // 
            ujDijazottNevTextBox.Location = new Point(68, 42);
            ujDijazottNevTextBox.Name = "ujDijazottNevTextBox";
            ujDijazottNevTextBox.Size = new Size(162, 29);
            ujDijazottNevTextBox.TabIndex = 1;
            // 
            // uiLabel04
            // 
            uiLabel04.AutoSize = true;
            uiLabel04.Location = new Point(236, 45);
            uiLabel04.Name = "uiLabel04";
            uiLabel04.Size = new Size(32, 21);
            uiLabel04.TabIndex = 0;
            uiLabel04.Text = "Év:";
            // 
            // uiLabel03
            // 
            uiLabel03.AutoSize = true;
            uiLabel03.Location = new Point(17, 45);
            uiLabel03.Name = "uiLabel03";
            uiLabel03.Size = new Size(45, 21);
            uiLabel03.TabIndex = 0;
            uiLabel03.Text = "Név:";
            // 
            // UjForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(384, 381);
            Controls.Add(ujDijGroupBox);
            Controls.Add(ujSzemelyGroupBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UjForm";
            Text = "Új adatok felvétele";
            ujSzemelyGroupBox.ResumeLayout(false);
            ujSzemelyGroupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ujDijGroupBox.ResumeLayout(false);
            ujDijGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)evNumericUpDown).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ujSzemelyGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ujSzemelyButton;
        private TextBox ujSzemelyFoglalkozasokTextBox;
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