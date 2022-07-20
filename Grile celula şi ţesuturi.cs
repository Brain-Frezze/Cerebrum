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
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 4;
            //checkedListBox1.BackColor = Color.LightGreen;

            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // int answer = 2;
            int index = checkedListBox2.SelectedIndex;
            int count = checkedListBox2.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }
        }


        private void checkedListBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // int answer = 3;
            int index = checkedListBox3.SelectedIndex;
            int count = checkedListBox3.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox3.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 3;
            int index = checkedListBox4.SelectedIndex;
            int count = checkedListBox4.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox4.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 2;
            int index = checkedListBox5.SelectedIndex;
            int count = checkedListBox5.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox5.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 1;
            int index = checkedListBox6.SelectedIndex;
            int count = checkedListBox6.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox6.SetItemChecked(i, false);
                }
            }
        }
        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 2;
            int index = checkedListBox7.SelectedIndex;
            int count = checkedListBox7.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox7.SetItemChecked(i, false);
                }
            }
        }
        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 4;
            int index = checkedListBox8.SelectedIndex;
            int count = checkedListBox8.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox8.SetItemChecked(i, false);
                }
            }
        }
        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 2;
            int index = checkedListBox9.SelectedIndex;
            int count = checkedListBox9.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox9.SetItemChecked(i, false);
                }
            }
        }
        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 4;
            int index = checkedListBox10.SelectedIndex;
            int count = checkedListBox10.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox10.SetItemChecked(i, false);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nr.ToString(),"Punctajul obţinut:",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Rezultate form = new Rezultate(); // formul daca am luat intre 0 si 4
            cinci_sapte nou = new cinci_sapte(); // formul daca am luat intre 5 si 7 
            int punctaj = 0;
            if (checkedListBox1.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox1.BackColor = Color.LightGreen;
                checkedListBox1.ClearSelected();
            }
            else
            {
                checkedListBox1.BackColor = Color.DarkRed;
            }
            if (checkedListBox2.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox2.BackColor = Color.LightGreen;
                checkedListBox2.ClearSelected();
            }
            else
            {
                checkedListBox2.BackColor = Color.DarkRed;
            }
            if (checkedListBox3.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox3.BackColor = Color.LightGreen;
                checkedListBox3.ClearSelected();
            }
            else
            {
                checkedListBox3.BackColor = Color.DarkRed;
            }
            if (checkedListBox4.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox4.BackColor = Color.LightGreen;
                checkedListBox4.ClearSelected();
            }
            else
            {
                checkedListBox4.BackColor = Color.DarkRed;
            }
            if (checkedListBox5.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox5.BackColor = Color.LightGreen;
                checkedListBox5.ClearSelected();
            }
            else
            {
                checkedListBox5.BackColor = Color.DarkRed;
            }
            if (checkedListBox6.SelectedIndex == 1)
            {
                punctaj += 10;
                checkedListBox6.BackColor = Color.LightGreen;
                checkedListBox6.ClearSelected();
            }
            if (checkedListBox7.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox7.BackColor = Color.LightGreen;
                checkedListBox7.ClearSelected();
            }
            else
            {
                checkedListBox7.BackColor = Color.DarkRed;
            }
            if (checkedListBox8.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox8.BackColor = Color.LightGreen;
                checkedListBox8.ClearSelected();
            }
            else
            {
                checkedListBox8.BackColor = Color.DarkRed;
            }
            if (checkedListBox9.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox9.BackColor = Color.LightGreen;
                checkedListBox9.ClearSelected();
            }
            else
            {
                checkedListBox9.BackColor = Color.DarkRed;
            }
            if (checkedListBox10.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox10.BackColor = Color.LightGreen;
                checkedListBox10.ClearSelected();
            }
            else
            {
                checkedListBox10.BackColor = Color.DarkRed;
            }

            string snr = Convert.ToString(punctaj);
            if (punctaj < 5)
            {
                form.rez = snr;
                form.ShowDialog();
            }
            else
            {
                if (punctaj > 4 && punctaj < 8)
                {
                    nou.cinci = snr;
                    form.ShowDialog();

                }
                else
            }
            

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
