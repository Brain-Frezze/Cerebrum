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
    public partial class Nerv_oculomotor : Form
    {
        public Nerv_oculomotor()
        {
            InitializeComponent();
        }
        private void nerv_oculomotor_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Nerv_oculomotor_Load(object sender, EventArgs e)
        {

        }

    }
}
