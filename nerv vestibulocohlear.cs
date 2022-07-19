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
    public partial class nerv_vestibulocohlear : Form
    {
        public nerv_vestibulocohlear()
        {
            InitializeComponent();
        }
        private void nerv_vestibulocohlear_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
