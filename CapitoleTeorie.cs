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
            loadform(new Topografie());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Celula_şi_ţesuturi());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Sistem_nervos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Analizatori());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Glande_endocrine());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Mişcarea());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadform(new Digestia_şi_Excreţia());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new Circulaţia());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadform(new Respiraţia());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loadform(new Metabolismul());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            loadform(new Reproducerea());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu log = new MainMenu();
            this.Hide();
            log.Show(); 
        }

        private void panouPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CapitoleTeorie_Load(object sender, EventArgs e)
        {

        }
    }
}
