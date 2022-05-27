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
    public partial class Funcţia_de_nutriţie : Form
    {
        private int nr = 0;
        public Funcţia_de_nutriţie()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox16_SelectedIndexChanged(object sender, EventArgs e)
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

        private void checkedListBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 1;
            bool ok = false;
            int index = checkedListBox15.SelectedIndex;
            int count = checkedListBox15.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox15.SetItemChecked(i, false);
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

        private void checkedListBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
            bool ok = false;
            int index = checkedListBox14.SelectedIndex;
            int count = checkedListBox14.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox14.SetItemChecked(i, false);
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

        private void checkedListBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox13.SelectedIndex;
            int count = checkedListBox13.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox13.SetItemChecked(i, false);
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

        private void checkedListBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 3;
            bool ok = false;
            int index = checkedListBox12.SelectedIndex;
            int count = checkedListBox12.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox12.SetItemChecked(i, false);
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

        private void checkedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 4;
            bool ok = false;
            int index = checkedListBox11.SelectedIndex;
            int count = checkedListBox11.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox11.SetItemChecked(i, false);
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

        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 3;
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
            int answer = 3;
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

        private void checkedListBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 2;
            bool ok = false;
            int index = checkedListBox17.SelectedIndex;
            int count = checkedListBox17.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox17.SetItemChecked(i, false);
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

        private void checkedListBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer = 1;
            bool ok = false;
            int index = checkedListBox18.SelectedIndex;
            int count = checkedListBox18.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox18.SetItemChecked(i, false);
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nr.ToString(), "Punctajul obţinut:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
