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
    public partial class Subcapitole_nervi : Form
    {
        public Subcapitole_nervi()
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
            loadform(new Căile_ascendente());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Căile_descendente());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Nervii_spinali());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Nervii_cranieni());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Localizări_corticale());
        }
    }
}
