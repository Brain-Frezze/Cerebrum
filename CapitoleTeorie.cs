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
    public partial class CapitoleTeorie : Form
    {
        public CapitoleTeorie()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Topografie());
            // am schimbat ceva

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Celula_şi_ţesuturi());
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu log = new MainMenu();
            this.Hide();
            log.Show(); 
        }

        private void CapitoleTeorie_Load(object sender, EventArgs e)
        {

        }
    }
}
