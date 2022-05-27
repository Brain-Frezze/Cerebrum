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
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            BaraProgres.Value = startpoint;
            BaraProgres.ForeColor = Color.White;
            if(BaraProgres.Value == 100)
            {
                BaraProgres.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void StartView_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
