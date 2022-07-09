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
    public partial class Teorie : Form
    {
        public Teorie()
        {
            InitializeComponent();
        }

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapitoleTeorie log = new CapitoleTeorie();
            this.Hide();
            log.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
