using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace Cerebrum
{
    public partial class ParolaUitata : Form
    {
        string randomCode;
        public static string to;
        public ParolaUitata()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string from, pass;
            
            Random rand = new Random();
            randomCode = (rand.Next(99999)).ToString();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:comapany.cerebrum@gmail.com?subject=" + ("Recuperare Parolă") + "&body=" + (randomCode);
            proc.Start();
            proc.Start();
            /*MailMessage message = new MailMessage();
            to = textBox1.Text;
            from = "company.cerebrum@gmail.com";
            pass = "anAHc1QrFmxVDh7z";
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb"))
            {
                con.Open();
                bool exist = false;
                using (OleDbCommand cmd = new OleDbCommand("select count(*) from Utilizator where Email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("Email", textBox1.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }
                if (exist == true)
                {

                    try
                    {
                        message.Subject = "Recuperarea parolei";
                        message.Body = "Acest cod trebuie introdus în casetă pentru a putea să îți schimbi parola";
                        message.Body = "Codul este " + randomCode;
                        message.From = new MailAddress(from);
                        message.To.Add(new MailAddress(to));

                        SmtpClient smtp = new SmtpClient();  // Smtp Client system
                        smtp.Host = "smtp-relay.sendinblue.com"; // Host == Google (bulangiu că nu lasă surse nesigure)
                        smtp.Port = 587; // Port (don't ask me why is 587)
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true; // ok so this should make it secure, so Google f**k off

                        NetworkCredential nc = new NetworkCredential(from, pass);
                        smtp.Credentials = nc;
                        smtp.Send(message);
                        MessageBox.Show("Email sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("NU am putut găsi unde s-a folosit acest cont");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                con.Close();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == textBox2.Text)
            {
                MessageBox.Show("merge");
            }
            else
                MessageBox.Show("Nu merge");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Comentarii log = new Comentarii();
            log.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParolaUitata_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateConturi.mdb"))
            {
                con.Open();
                bool exist = false;
                using (OleDbCommand cmd = new OleDbCommand("select count(*) from Utilizator where Email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("Email", textBox1.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }
                if (exist == true)
                {
                    button1.Enabled = true;
                }
                else
                {
                    Email log = new Email();
                    log.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == randomCode)
            {
                Resetare_parola log = new Resetare_parola();
                this.Hide();
                log.Show();
            }
            else
            {
                cod log = new cod();
                log.Show();
            }
        }
    }
}
