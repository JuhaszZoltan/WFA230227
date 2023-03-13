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

            try
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
                else throw new Exception(
                    $"{ujDijazottNevTextBox.Text} nem lehet József Attila Díj jelöltje,\n" +
                    $"mivel a neve még nem szerepel az adatbázisban!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: ex.Message,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);

            }
        }

        private void OnUjSzemelyButtonClick(object? sender, EventArgs e)
        {
            try
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

                if (string.IsNullOrWhiteSpace(ujSzemelyNevTextBox.Text))
                    throw new Exception("A 'név' mező kitöltése kötelező!");
                if (string.IsNullOrEmpty(ujSzemelyFoglalkozasokTextBox.Text))
                    throw new Exception("A 'foglalkozások' mező kitöltése kötelező!");

                reader = new SqlCommand(
                    cmdText: "SELECT nev FROM szemely " +
                    $"WHERE nev LIKE '{ujSzemelyNevTextBox.Text}';",
                    connection: connection)
                    .ExecuteReader();
                if (reader.Read()) throw new Exception("Ilyen név már szerepel az adatbázisba!");
                reader.Close();
                
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
                            cmdText: "INSERT INTO foglalkozas VALUES " +
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: ex.Message,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            finally
            {
                ujDijazottNevTextBox.Text = ujSzemelyNevTextBox.Text;
                ujSzemelyNevTextBox.Text = string.Empty;
                ujSzemelyFoglalkozasokTextBox.Text = string.Empty;
                evNumericUpDown.Value = DateTime.Today.Year;
            }
        }
    }
}
