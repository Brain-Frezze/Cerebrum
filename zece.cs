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
    public partial class zece : Form
    {
        public zece()
        {
            InitializeComponent();
        }

        public string brb
        {
            get;
            set;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = brb;
        }
    }
}
