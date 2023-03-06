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
    public partial class UjForm : Form
    {
        public UjForm()
        {
            InitializeComponent();
            ujSzemelyButton.Click += OnUjSzemelyButtonClick;
            ujDijazottButton.Click += OnUjDijazottButtonClick;
        }

        private void OnUjDijazottButtonClick(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT id FROM szemely " +
                $"WHERE nev LIKE '{ujDijazottNevTextBox.Text}';",
                connection: connection)
                .ExecuteReader();

            if (reader.Read())
            {
                int dijazottId = reader.GetInt32(0);
                reader.Close();

                reader = new SqlCommand(
                    cmdText: "SELECT MAX(id) FROM kituntetes",
                    connection: connection)
                .ExecuteReader();
                reader.Read();
                int dijId = reader.GetInt32(0) + 1;
                reader.Close();

                SqlDataAdapter adapter = new()
                {
                    InsertCommand = new(
                        cmdText: "INSERT INTO kituntetes VALUES " +
                        $"({dijId}, {dijazottId}, '{evNumericUpDown.Value}');",
                        connection: connection),
                };
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show(
                    caption: "SIKERES MÓDOSÍTÁS!",
                    text: $"{ujDijazottNevTextBox.Text} díja sikeresen rögzítésre került az adatbázisba!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: $"{ujDijazottNevTextBox.Text} nem lehet József Attila Díj jelöltje,\n" +
                    $"mivel a neve még nem szerepel az adatbázisban!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }

        }

        private void OnUjSzemelyButtonClick(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT MAX(id) FROM szemely;",
                connection: connection)
                .ExecuteReader();
            reader.Read();
            int nextId = reader.GetInt32(0) + 1;
            reader.Close();

            string errorMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(ujSzemelyNevTextBox.Text))
                errorMsg += "A 'név' mező kitöltése kötelező!\n";
            if (string.IsNullOrEmpty(ujSzemelyFoglalkozasokTextBox.Text))
                errorMsg += "A 'foglalkozások' mező kitöltése kötelező!\n";

            reader = new SqlCommand(
                cmdText: "SELECT nev FROM szemely " +
                $"WHERE nev LIKE '{ujSzemelyNevTextBox.Text}';",
                connection: connection)
                .ExecuteReader();
            if (reader.Read())
                errorMsg += "Ilyen név már szerepel az adatbázisba!\n";
            reader.Close();

            if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(
                    caption: "HIBA!",
                    text: errorMsg,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            else
            {
                SqlDataAdapter adapter = new()
                {
                    InsertCommand = new(
                        cmdText: "INSERT INTO szemely VALUES " +
                        $"({nextId}, '{ujSzemelyNevTextBox.Text}');",
                        connection: connection),
                };
                adapter.InsertCommand.ExecuteNonQuery();
                var foglalkozasok = ujSzemelyFoglalkozasokTextBox.Text.Split(", ");
                foreach (var f in foglalkozasok)
                {
                    adapter = new()
                    {
                        InsertCommand = new(
                            cmdText:"INSERT INTO foglalkozas VALUES " +
                            $"({nextId}, '{f}')",
                            connection: connection),
                    };
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                MessageBox.Show(
                    caption: "SIKERES MÓDOSÍTÁS!",
                    text: $"{ujSzemelyNevTextBox.Text} hozzáadása az adatbázishoz megtörtént!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);

                ujDijazottNevTextBox.Text = ujSzemelyNevTextBox.Text;
                ujSzemelyNevTextBox.Text = string.Empty;
                ujSzemelyFoglalkozasokTextBox.Text = string.Empty;
                evNumericUpDown.Value = DateTime.Today.Year;
            }

        }
    }
}
