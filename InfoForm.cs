using System.Diagnostics;

namespace WFA230227
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            gitHubRepoLinkLabel.LinkClicked += OnGitHubRepoLinkLabelLinkClicked;
        }

        private void OnGitHubRepoLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                new ProcessStartInfo()
                {
                    FileName = gitHubRepoLinkLabel.Text,
                    UseShellExecute = true,
                });
        }
    }
}
