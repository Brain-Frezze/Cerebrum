using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cerebrum
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public static string user = "";
        public static string limba;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb"))
            {
                con.Open();
                bool exist1 = false;
                bool exist2 = false;
                using (OleDbCommand cmd = new OleDbCommand("select count(*) from Utilizator where Nume_utilizator = @Nume", con))
                {
                    cmd.Parameters.AddWithValue("Nume_utilizator", textBox1.Text);
                    exist1 = (int)cmd.ExecuteScalar() > 0;
                }
                using (OleDbCommand cmd = new OleDbCommand("select count(*) from Utilizator where parola = @Parola", con))
                {
                    cmd.Parameters.AddWithValue("parola", textBox2.Text);
                    exist2 = (int)cmd.ExecuteScalar() > 0;
                }
                if (exist1 == true && exist2 == true)
                {
                    user = textBox1.Text;
                    MainMenu log = new MainMenu();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    ContInexistent log = new ContInexistent();
                    log.Show();
                }
                con.Close();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreareCont  log = new CreareCont ();
            this.Hide();
            log.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Comentarii log = new Comentarii();
            log.Show();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ParolaUitata log = new ParolaUitata();
            log.Show();
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            limba = "en";
            InitializeComponent();
        }
        private void românăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");
            this.Controls.Clear();
            limba = "ro";
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
