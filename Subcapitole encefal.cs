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
    public partial class Subcapitole_encefal : Form
    {
        public Subcapitole_encefal()
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
            loadform(new Trunchiul_cerebral());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Cerebelul());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Diencefalul());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Emisferele_cerebrale());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Fiziologia_encefalului());
        }
        private void Subcapitole_encefal_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
