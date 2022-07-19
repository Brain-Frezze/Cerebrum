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
    public partial class Nervii_cranieni : Form
    {
        public Nervii_cranieni()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            nerv_olfactiv log = new nerv_olfactiv();
            log.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nerv_optic log = new nerv_optic();
            log.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Nerv_oculomotor log = new Nerv_oculomotor();
            log.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Nerv_oculomotor log = new Nerv_oculomotor();
            log.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            nerv_trigemen log = new nerv_trigemen();
            log.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Nerv_oculomotor log = new Nerv_oculomotor();
            log.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nerv_facial log = new nerv_facial();
            log.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nerv_vestibulocohlear log = new nerv_vestibulocohlear();
            log.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nerv_glosofaringian log = new nerv_glosofaringian();
            log.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nerv_vag log = new nerv_vag();
            log.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nerv_accesor log = new nerv_accesor();
            log.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nerv_hipoglos log = new nerv_hipoglos();
            log.Show();
        }
    }
}
