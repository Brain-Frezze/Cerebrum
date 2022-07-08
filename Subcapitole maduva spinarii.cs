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
    public partial class Subcapitole_maduva_spinarii : Form
    {
        public Subcapitole_maduva_spinarii()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            loadform(new Asezare__rapoarte());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Aspectul_exterior());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Meningele());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Structura_maduva());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Fiziologia_maduvei_spinarii());
        }
    }
}
