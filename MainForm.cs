using Microsoft.Data.SqlClient;
using WFA230227.Properties;

namespace WFA230227
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += OnMainFormLoad;
            mainDataGridView.CellClick += OnMainDataGridViewCellClick;
            ujToolStripMenuItem.Click += OnUjToolStripMenuItemClick;
            keresesToolStripMenuItem.Click += OnKeresesToolStripMenuItemClick;
            infoToolStripMenuItem.Click += OnInfoToolStripMenuItemClick;
        }

        private void OnInfoToolStripMenuItemClick(object? sender, EventArgs e)
            => new InfoForm().ShowDialog();

        private void OnKeresesToolStripMenuItemClick(object? sender, EventArgs e)
            => new KeresesForm().ShowDialog();

        private void OnUjToolStripMenuItemClick(object? sender, EventArgs e)
        {
            _ = new UjForm().ShowDialog();
            this.Refresh();
        }

        private void OnMainDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e)
            => new ReszletekForm($"{mainDataGridView[1, e.RowIndex].Value}").ShowDialog();

        private void OnMainFormLoad(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT ev, nev " +
                "FROM szemely INNER JOIN kituntetes " +
                "ON szemely.id = szemelyId " +
                "ORDER BY ev DESC, nev ASC;",
                connection: connection)
                .ExecuteReader();

            while (reader.Read())
            {
                int rowIndex = mainDataGridView.Rows.Add(reader[0], reader[1]);
                if (reader.GetInt32(0) % 2 == 0)
                {
                    mainDataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
    }
}