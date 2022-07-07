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
    public partial class Rezultate : Form
    {
        public Rezultate()
        {
            InitializeComponent();
        }
        public string rez
        {
            get;
            set;
        }

        private void Rezultate_Load(object sender, EventArgs e)
        {
            label1.Text = rez;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
