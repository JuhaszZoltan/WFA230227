using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230227
{
    public partial class UjForm : Form
    {
        public UjForm()
        {
            InitializeComponent();
            ujSzemelyButton.Click += OnUjSzemelyButtonClick;
        }

        private void OnUjSzemelyButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
