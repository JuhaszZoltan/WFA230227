using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA230227.Properties;

namespace WFA230227
{
    public partial class KeresesForm : Form
    {
        public KeresesForm()
        {
            InitializeComponent();
            this.Load += OnKeresesResult;
            keresesTextBox.TextChanged += OnKeresesResult;
            keresesDataGridView.CellClick += OnKeresesDataGridViewCellClick;
        }

        private void OnKeresesDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e) =>
            _ = new ReszletekForm($"{keresesDataGridView[1, e.RowIndex].Value}").ShowDialog();

        private void OnKeresesResult(object? sender, EventArgs e)
        {
            keresesDataGridView.Rows.Clear();
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlDataReader reaeder = new SqlCommand(
                cmdText: "SELECT * FROM szemely " +
                $"WHERE nev LIKE '%{keresesTextBox.Text}%';",
                connection: connection)
                .ExecuteReader();
            while (reaeder.Read()) keresesDataGridView.Rows.Add(reaeder[0], reaeder[1]);
        }
    }
}
