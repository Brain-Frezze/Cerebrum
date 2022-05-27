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
    public partial class Test_general : Form
    {
        private int nr = 0;
        public Test_general()
        {
            InitializeComponent();
        }

        private void checkedListBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox16_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int answer = 3;
            bool ok = false;
            int index = checkedListBox16.SelectedIndex;
            int count = checkedListBox16.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox16.SetItemChecked(i, false);
                }
            }
            if ((index == answer) && ok == false)
            {
                ok = true;
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 0;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 3;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 1;
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
                nr += 10;
            }
            else
                if (index != answer && ok == true)
            {
                nr -= 10;
                ok = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(nr.ToString(), "Punctajul obţinut:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}