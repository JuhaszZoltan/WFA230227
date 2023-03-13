using Microsoft.Data.SqlClient;
using WFA230227.Properties;

namespace WFA230227
{
    public partial class ReszletekForm : Form
    {
        public string SelectedNev { get; set; }
        public ReszletekForm(string nev = null)
        {
            InitializeComponent();
            SelectedNev = nev;
            this.Load += OnReszletekFormLoad;
        }
        private void OnReszletekFormLoad(object? sender, EventArgs e)
        {
            nevLabel.Text = SelectedNev;

            foglalkozasokLabel.Text = string.Empty;
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();

            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT megnevezes " +
                "FROM szemely INNER JOIN foglalkozas " +
                "ON szemely.id = szemelyId " +
                $"WHERE nev LIKE '{SelectedNev}';",
                connection: connection)
                .ExecuteReader();
            while (reader.Read()) foglalkozasokLabel.Text += $"[*] {reader[0]}\n";
            reader.Close();

            evekLabel.Text = string.Empty;
            reader = new SqlCommand(
                cmdText: "SELECT ev " +
                "FROM szemely INNER JOIN kituntetes " +
                "ON szemely.id = szemelyId " +
                $"WHERE szemely.id = (SELECT id FROM szemely WHERE nev LIKE '{SelectedNev}');",
                connection: connection)
                .ExecuteReader();
            while (reader.Read()) evekLabel.Text += $"{reader[0]}, ";
            if (evekLabel.Text.Length != 0)
                evekLabel.Text = evekLabel.Text.Remove(evekLabel.Text.Length - 2);
            else evekLabel.Text = "----";
        }
    }
}
