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
    public partial class Rezultatele_mele : Form
    {
        public Rezultatele_mele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rezultatele_mele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDateRezultateDataSet.Rezultate' table. You can move, or remove it, as needed.
            this.rezultateTableAdapter.Fill(this.bazaDateRezultateDataSet.Rezultate);
            label1.Text = $"Numărul total de teste: {dataGridView1.RowCount}";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void conturiDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
