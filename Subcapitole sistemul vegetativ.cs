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
    public partial class Subcapitole_sistemul_vegetativ : Form
    {
        public Subcapitole_sistemul_vegetativ()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Neurotransmiţători());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Centrii_SNV());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Căile_SNV());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Plexuri_vegetative());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Fiziologia_SNV());
        }
    }
}
