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


namespace Cerebrum
{
    public partial class Comentarii : Form
    {

        public Comentarii()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            /* MailMessage mm = new MailMessage("company.cerebrum@gmail.com");
             mm.Subject = textBox1.Text;
             mm.Body = richTextBox1.Text;
             SmtpClient smtp = new SmtpClient();
             smtp.Host = "smtp.gmail.com";
             smtp.Port = 587;
             System.Net.NetworkCredential nc = new NetworkCredential("company.cerebrum@gmail.com", "Sebi&Ivan");
             smtp.Credentials = nc;
             smtp.EnableSsl = true;
             smtp.UseDefaultCredentials = false;
             smtp.Send(mm); 
             MessageBox.Show("E-mailul tău a fost trimis! Îţi mulţumim! "); */
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
             proc.StartInfo.FileName ="mailto:comapany.cerebrum@gmail.com?subject="+ (textBox1.Text) + "&body="+ (richTextBox1.Text);
            proc.Start();
             proc.Start();
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
