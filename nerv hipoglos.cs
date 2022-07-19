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
    public partial class nerv_hipoglos : Form
    {
        public nerv_hipoglos()
        {
            InitializeComponent();
        }
        private void nerv_hipoglos_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
