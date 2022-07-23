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
    public partial class Grile_noţiuni_generale : Form
    {
        public Grile_noţiuni_generale()
        {
            InitializeComponent();
            timer1.Start();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaDateRezultate.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void checkedListBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int answer = 4;
            
            int index = checkedListBox16.SelectedIndex;
            int count = checkedListBox16.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox16.SetItemChecked(i, false);
                }
            }
           
        }
        private void checkedListBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 0;
            
            int index = checkedListBox15.SelectedIndex;
            int count = checkedListBox15.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox15.SetItemChecked(i, false);
                }
            }
            
        }

        private void checkedListBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 1;
            
            int index = checkedListBox14.SelectedIndex;
            int count = checkedListBox14.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox14.SetItemChecked(i, false);
                }
            }
            
        }
        private void checkedListBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 3;
            
            int index = checkedListBox13.SelectedIndex;
            int count = checkedListBox13.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox13.SetItemChecked(i, false);
                }
            }
            
        }
        private void checkedListBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 2;
            
            int index = checkedListBox12.SelectedIndex;
            int count = checkedListBox12.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox12.SetItemChecked(i, false);
                }
            }
            
        }
        private void checkedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 3;
            
            int index = checkedListBox11.SelectedIndex;
            int count = checkedListBox11.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox11.SetItemChecked(i, false);
                }
            }
            
        }
        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 0;
            
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
        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 4;
            
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
        private void checkedListBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 4;
            
            int index = checkedListBox17.SelectedIndex;
            int count = checkedListBox17.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox17.SetItemChecked(i, false);
                }
            }
            
        }
        private void checkedListBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int answer = 4;
            
            int index = checkedListBox18.SelectedIndex;
            int count = checkedListBox18.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox18.SetItemChecked(i, false);
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            CapitoleGrile.nr++;
            Rezultate form = new Rezultate(); // formul daca am luat intre 0 si 4
            cinci_sapte nou = new cinci_sapte(); // formul daca am luat intre 5 si 7 
            opt_noua again = new opt_noua(); // formul daca am luat intre 8 si 9
            zece last = new zece();
            int punctaj = 0;
            if (checkedListBox16.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox16.BackColor = Color.LightGreen;
                checkedListBox16.ClearSelected();
            }
            else
            {
                checkedListBox16.BackColor = Color.Red;
                checkedListBox16.SelectedIndex = 4; //cu acesta comanda aratam care era raspunsul corect
            }
            if (checkedListBox15.SelectedIndex == 0)
            {
                punctaj += 10;
                checkedListBox15.BackColor = Color.LightGreen;
                checkedListBox15.ClearSelected();
            }
            else
            {
                checkedListBox15.BackColor = Color.Red;
                checkedListBox15.SelectedIndex = 0;
            }
            if (checkedListBox14.SelectedIndex == 1)
            {
                punctaj += 10;
                checkedListBox14.BackColor = Color.LightGreen;
                checkedListBox14.ClearSelected();
            }
            else
            {
                checkedListBox14.BackColor = Color.Red;
                checkedListBox14.SelectedIndex = 1;

            }
            if (checkedListBox13.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox13.BackColor = Color.LightGreen;
                checkedListBox13.ClearSelected();
            }
            else
            {
                checkedListBox13.BackColor = Color.Red;
                checkedListBox13.SelectedIndex = 3;

            }
            if (checkedListBox12.SelectedIndex == 2)
            {
                punctaj += 10;
                checkedListBox12.BackColor = Color.LightGreen;
                checkedListBox12.ClearSelected();
            }
            else
            {
                checkedListBox12.BackColor = Color.Red;
                checkedListBox12.SelectedIndex = 2;

            }
            if (checkedListBox11.SelectedIndex == 3)
            {
                punctaj += 10;
                checkedListBox11.BackColor = Color.LightGreen;
                checkedListBox11.ClearSelected();
            }
            else
            {
                checkedListBox11.BackColor = Color.Red;
                checkedListBox11.SelectedIndex = 3;
            }
            if (checkedListBox10.SelectedIndex == 0)
            {
                punctaj += 10;
                checkedListBox10.BackColor = Color.LightGreen;
                checkedListBox10.ClearSelected();
            }
            else
            {
                checkedListBox10.BackColor = Color.Red;
                checkedListBox10.SelectedIndex = 0;
            }
            if (checkedListBox9.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox9.BackColor = Color.LightGreen;
                checkedListBox9.ClearSelected();
            }
            else
            {
                checkedListBox9.BackColor = Color.Red;
                checkedListBox9.SelectedIndex = 4;

            }
            if (checkedListBox17.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox17.BackColor = Color.LightGreen;
                checkedListBox17.ClearSelected();
            }
            else
            {
                checkedListBox17.BackColor = Color.Red;
                checkedListBox17.SelectedIndex = 4;
            }
            if (checkedListBox18.SelectedIndex == 4)
            {
                punctaj += 10;
                checkedListBox18.BackColor = Color.LightGreen;
                checkedListBox18.ClearSelected();
            }
            else
            {
                checkedListBox18.BackColor = Color.Red;
                checkedListBox18.SelectedIndex = 4;
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
                    cmd.Parameters.AddWithValue("Parola", "Noțiuni generale"); // testul dat
                    cmd.Parameters.AddWithValue("Email", snr); // punctaj
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

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
