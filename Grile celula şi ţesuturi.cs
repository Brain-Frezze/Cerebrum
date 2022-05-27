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
    public partial class Grile_celula_şi_ţesuturi : Form
    {
        public Grile_celula_şi_ţesuturi()
        {
            InitializeComponent();

        }
        internal int nr = 0;
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
            bool ok = false;
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox2.SelectedIndex;
            int count = checkedListBox2.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }


        private void checkedListBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int answer = 3;
            bool ok = false;
            int index = checkedListBox3.SelectedIndex;
            int count = checkedListBox3.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox3.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 3;
            bool ok = false;
            int index = checkedListBox4.SelectedIndex;
            int count = checkedListBox4.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox4.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox5.SelectedIndex;
            int count = checkedListBox5.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox5.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 1;
            bool ok = false;
            int index = checkedListBox6.SelectedIndex;
            int count = checkedListBox6.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox6.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox7.SelectedIndex;
            int count = checkedListBox7.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox7.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
            bool ok = false;
            int index = checkedListBox8.SelectedIndex;
            int count = checkedListBox8.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox8.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox9.SelectedIndex;
            int count = checkedListBox9.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox9.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
            bool ok = false;
            int index = checkedListBox10.SelectedIndex;
            int count = checkedListBox10.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox10.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr+=10;
            }
            else
                if (index != answer && ok == true)
            {
                nr-=10;
                ok = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nr.ToString(),"Punctajul obţinut:",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Grile_celula_şi_ţesuturi_Load(object sender, EventArgs e)
        {

        }
    }
}
