using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerebrum
{
    public partial class CapitoleGrile : Form
    {
        public CapitoleGrile()
        {
            InitializeComponent();
        }
      
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Grile_noţiuni_generale());
            //timer.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Grile_sistem_nervos_central());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Grile_sistem_nervos_periferic());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Test_general());
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            MainMenu log = new MainMenu();
            this.Hide();
            log.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            timer.Start();
        }
        int timeleft = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = timeleft - 1;
                
            }
            else
            {
                timer.Stop();
                timeleft = 10;
                
                // button1.PerformClick();
            }
            if(timeleft <= 3 && timeleft%2==1)
            {
                button4.Visible = false;
            }
            else if(timeleft <= 3 && (timeleft%2==0))
                button4.Visible=true;
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Comentarii log = new Comentarii();
            log.Show();
        }
        private void panouButoane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void CapitoleGrile_Load(object sender, EventArgs e)
        {

        }
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
