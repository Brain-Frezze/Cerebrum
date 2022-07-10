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
    public partial class CapitoleTeorie : Form
    {
        public CapitoleTeorie()
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
            loadform(new subcapitole_notiuni_generale());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Subcapitole_maduva_spinarii());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Subcapitole_encefal());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Subcapitole_nervi());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Subcapitole_sistemul_vegetativ());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu log = new MainMenu();
            this.Hide();
            log.Show(); 
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Comentarii log = new Comentarii();
            log.Show();
        }

        private void CapitoleTeorie_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
