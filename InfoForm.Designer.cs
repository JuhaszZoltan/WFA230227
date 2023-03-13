namespace WFA230227
{
    partial class InfoForm
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
            gitHubRepoLinkLabel = new LinkLabel();
            uiLabel03 = new Label();
            uiLabel01 = new Label();
            uiLabel02 = new Label();
            SuspendLayout();
            // 
            // gitHubRepoLinkLabel
            // 
            gitHubRepoLinkLabel.AutoSize = true;
            gitHubRepoLinkLabel.BackColor = Color.LightCoral;
            gitHubRepoLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gitHubRepoLinkLabel.Location = new Point(114, 59);
            gitHubRepoLinkLabel.Name = "gitHubRepoLinkLabel";
            gitHubRepoLinkLabel.Size = new Size(358, 21);
            gitHubRepoLinkLabel.TabIndex = 0;
            gitHubRepoLinkLabel.TabStop = true;
            gitHubRepoLinkLabel.Text = "https://github.com/JuhaszZoltan/WFA230227";
            // 
            // uiLabel03
            // 
            uiLabel03.AutoSize = true;
            uiLabel03.BackColor = Color.LightCoral;
            uiLabel03.Location = new Point(25, 59);
            uiLabel03.Name = "uiLabel03";
            uiLabel03.Size = new Size(83, 21);
            uiLabel03.TabIndex = 1;
            uiLabel03.Text = "Forráskód:";
            // 
            // uiLabel01
            // 
            uiLabel01.AutoSize = true;
            uiLabel01.BackColor = Color.LightCoral;
            uiLabel01.Location = new Point(29, 28);
            uiLabel01.Name = "uiLabel01";
            uiLabel01.Size = new Size(79, 21);
            uiLabel01.TabIndex = 1;
            uiLabel01.Text = "Készítette:";
            // 
            // uiLabel02
            // 
            uiLabel02.AutoSize = true;
            uiLabel02.BackColor = Color.LightCoral;
            uiLabel02.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel02.Location = new Point(114, 28);
            uiLabel02.Name = "uiLabel02";
            uiLabel02.Size = new Size(159, 21);
            uiLabel02.TabIndex = 1;
            uiLabel02.Text = "Juhász Zoltán, 2023";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(484, 111);
            Controls.Add(uiLabel02);
            Controls.Add(uiLabel01);
            Controls.Add(uiLabel03);
            Controls.Add(gitHubRepoLinkLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "InfoForm";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel gitHubRepoLinkLabel;
        private Label uiLabel03;
        private Label uiLabel01;
        private Label uiLabel02;
    }
}