namespace WFA230227
{
    partial class ReszletekForm
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
            this.nevLabel = new System.Windows.Forms.Label();
            this.uiLabe01 = new System.Windows.Forms.Label();
            this.foglalkozasokLabel = new System.Windows.Forms.Label();
            this.uiLabel02 = new System.Windows.Forms.Label();
            this.evekLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nevLabel
            // 
            this.nevLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nevLabel.Location = new System.Drawing.Point(12, 9);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(360, 64);
            this.nevLabel.TabIndex = 0;
            this.nevLabel.Text = "### nev ###";
            this.nevLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabe01
            // 
            this.uiLabe01.BackColor = System.Drawing.Color.IndianRed;
            this.uiLabe01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uiLabe01.Location = new System.Drawing.Point(12, 73);
            this.uiLabe01.Name = "uiLabe01";
            this.uiLabe01.Size = new System.Drawing.Size(360, 28);
            this.uiLabe01.TabIndex = 0;
            this.uiLabe01.Text = "Fő foglalkozásai:";
            this.uiLabe01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foglalkozasokLabel
            // 
            this.foglalkozasokLabel.BackColor = System.Drawing.Color.IndianRed;
            this.foglalkozasokLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foglalkozasokLabel.Location = new System.Drawing.Point(12, 112);
            this.foglalkozasokLabel.Name = "foglalkozasokLabel";
            this.foglalkozasokLabel.Size = new System.Drawing.Size(360, 140);
            this.foglalkozasokLabel.TabIndex = 0;
            this.foglalkozasokLabel.Text = "[*] ### foglalkozas ###\r\n[*] ### foglalkozas ###\r\n[*] ### foglalkozas ###\r\n";
            // 
            // uiLabel02
            // 
            this.uiLabel02.AutoSize = true;
            this.uiLabel02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uiLabel02.Location = new System.Drawing.Point(12, 271);
            this.uiLabel02.Name = "uiLabel02";
            this.uiLabel02.Size = new System.Drawing.Size(131, 21);
            this.uiLabel02.TabIndex = 0;
            this.uiLabel02.Text = "A díjat elnyerte:";
            this.uiLabel02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evekLabel
            // 
            this.evekLabel.AutoSize = true;
            this.evekLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.evekLabel.Location = new System.Drawing.Point(149, 271);
            this.evekLabel.Name = "evekLabel";
            this.evekLabel.Size = new System.Drawing.Size(104, 21);
            this.evekLabel.TabIndex = 0;
            this.evekLabel.Text = "### evek ###";
            this.evekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReszletekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.foglalkozasokLabel);
            this.Controls.Add(this.uiLabe01);
            this.Controls.Add(this.evekLabel);
            this.Controls.Add(this.uiLabel02);
            this.Controls.Add(this.nevLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReszletekForm";
            this.Text = "Részletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nevLabel;
        private Label uiLabe01;
        private Label foglalkozasokLabel;
        private Label uiLabel02;
        private Label evekLabel;
    }
}