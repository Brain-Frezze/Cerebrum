using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cerebrum
{
    public partial class Resetare_parola : Form
    {
        public Resetare_parola()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb"))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Utilizator VALUES (@Nume, @Parola, @Email)", con))
                {
                    cmd.Parameters.AddWithValue("Nume", "");
                    cmd.Parameters.AddWithValue("Parola", textBox1.Text);
                    cmd.Parameters.AddWithValue("Email", "");
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
