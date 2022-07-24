using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cerebrum
{
    public partial class Grile_sistem_nervos_periferic : Form
    {
        public Grile_sistem_nervos_periferic()
        {
            InitializeComponent();
            timer1.Start();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateRezultate.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 3;
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

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 4;
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
            // int answer = 4;
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
            // int answer = 2;
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
            // int answer = 0;
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
            // int answer = 2;
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
            // int answer = 3;
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
            // int answer = 1;
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
            timer1.Stop();
            CapitoleGrile.nr++;
            CapitoleGrile.ok = true;
            //MessageBox.Show(nr.ToString(),"Punctajul obţinut:",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Rezultate form = new Rezultate(); // formul daca am luat intre 0 si 4
            cinci_sapte nou = new cinci_sapte(); // formul daca am luat intre 5 si 7 
            opt_noua again = new opt_noua(); // formul daca am luat intre 8 si 9
            zece last = new zece();
            int punctaj = 0;
            if (checkedListBox1.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox1.BackColor = Color.LightGreen;
                checkedListBox1.ClearSelected();
            }
            else
            {
                checkedListBox1.BackColor = Color.Red;
                checkedListBox1.SelectedIndex = 3; //cu acesta comanda aratam care era raspunsul corect
            }
            if (checkedListBox2.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox2.BackColor = Color.LightGreen;
                checkedListBox2.ClearSelected();
            }
            else
            {
                checkedListBox2.BackColor = Color.Red;
                checkedListBox2.SelectedIndex = 2;
            }
            if (checkedListBox3.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox3.BackColor = Color.LightGreen;
                checkedListBox3.ClearSelected();
            }
            else
            {
                checkedListBox3.BackColor = Color.Red;
                checkedListBox3.SelectedIndex = 4;

            }
            if (checkedListBox4.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox4.BackColor = Color.LightGreen;
                checkedListBox4.ClearSelected();
            }
            else
            {
                checkedListBox4.BackColor = Color.Red;
                checkedListBox4.SelectedIndex = 4;

            }
            if (checkedListBox5.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox5.BackColor = Color.LightGreen;
                checkedListBox5.ClearSelected();
            }
            else
            {
                checkedListBox5.BackColor = Color.Red;
                checkedListBox5.SelectedIndex = 2;

            }
            if (checkedListBox6.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox6.BackColor = Color.LightGreen;
                checkedListBox6.ClearSelected();
            }
            else
            {
                checkedListBox6.BackColor = Color.Red;
                checkedListBox6.SelectedIndex = 2;
            }
            if (checkedListBox7.SelectedIndex == 0)
            {
                punctaj += 10;
                checkedListBox7.BackColor = Color.LightGreen;
                checkedListBox7.ClearSelected();
            }
            else
            {
                checkedListBox7.BackColor = Color.Red;
                checkedListBox7.SelectedIndex = 0;
            }
            if (checkedListBox8.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox8.BackColor = Color.LightGreen;
                checkedListBox8.ClearSelected();
            }
            else
            {
                checkedListBox8.BackColor = Color.Red;
                checkedListBox8.SelectedIndex = 2;

            }
            if (checkedListBox9.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox9.BackColor = Color.LightGreen;
                checkedListBox9.ClearSelected();
            }
            else
            {
                checkedListBox9.BackColor = Color.Red;
                checkedListBox9.SelectedIndex = 3;
            }
            if (checkedListBox10.SelectedIndex == 1)
            {
                punctaj += 10;
                checkedListBox10.BackColor = Color.LightGreen;
                checkedListBox10.ClearSelected();
            }
            else
            {
                checkedListBox10.BackColor = Color.Red;
                checkedListBox10.SelectedIndex = 1;
            }

            string snr = Convert.ToString(punctaj);
            if (punctaj < 50)
            {
                form.rez = snr;
                form.ShowDialog();
            }
            else
            {
                if (punctaj > 49 && punctaj < 80)
                {
                    nou.cinci = snr;
                    nou.ShowDialog();

                }
                else
                {
                    if (punctaj > 79 && punctaj < 100)
                    {
                        again.opt = snr;
                        again.ShowDialog();
                    }
                    else
                        if (punctaj == 100)
                    {
                        last.brb = snr;
                        last.ShowDialog();
                    }
                }
            }
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateRezultate.mdb"))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Rezultate VALUES (@ID ,@Nume, @Parola, @Email)", con))
                {
                    cmd.Parameters.AddWithValue("ID", CapitoleGrile.nr); // nr de teste
                    cmd.Parameters.AddWithValue("Nume", Login.user); // utilizator
                    cmd.Parameters.AddWithValue("Parola", "Sistem nervos periferic"); // testul dat
                    cmd.Parameters.AddWithValue("Email", snr); // punctaj
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        int time = CapitoleGrile.timeleft;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time = time - 1;

            }
            else
            {
                timer1.Stop();
                button1.PerformClick();

            }
        }
    }
}
