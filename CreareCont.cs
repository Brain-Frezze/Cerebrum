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
    public partial class CreareCont : Form
    {
        public CreareCont()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                Incomplet log = new Incomplet();
                log.Show();
            }
            else if (checkBox2.Checked == false)
            {
                TermANDCond log = new TermANDCond();
                log.Show();
            }
            else if (textBox2.Text != textBox3.Text)
            {
                Parole log = new Parole();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
                log.Show();
            }
            else if (textBox4.Text.IndexOf("@gmail.com") == -1 && textBox4.Text.IndexOf("@email.com") == -1)
            {
                Email log = new Email();
                log.Show();
            }
            else if(checkBox2.Checked)
            {

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb"))
                {
                    con.Open();
                    bool exist = false;
                    using (OleDbCommand cmd = new OleDbCommand("select count(*) from Utilizator where Nume_utilizator = @Nume", con)) 
                    {
                        cmd.Parameters.AddWithValue("Nume_utilizator", textBox1.Text);
                        exist = (int)cmd.ExecuteScalar() > 0;
                    }
                    if (exist == true)
                    {
                        Folosit log = new Folosit();
                        log.Show();
                    }
                    else
                    {
                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Utilizator VALUES (@Nume, @Parola, @Email)", con))
                        {
                        cmd.Parameters.AddWithValue("Nume", textBox1.Text);
                        cmd.Parameters.AddWithValue("Parola",textBox2.Text);
                        cmd.Parameters.AddWithValue("Email", textBox4.Text);
                        cmd.ExecuteNonQuery();
                        }
                        Login log = new Login();
                        this.Hide();
                        log.Show();
                        Creat c = new Creat();
                        c.Show();
                    }
                con.Close();
                }
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Termenii_şi_condiţiile log = new Termenii_şi_condiţiile();
            log.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Comentarii log = new Comentarii();
            log.Show();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void CreareCont_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
