using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1: Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = txtcodigo.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtnombre.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtprecio.Text;

            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            if(n!=-1)
            {
                label1.Text = (string)dataGridView1.Rows[n].Cells[1].Value;



            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (n!=-1)
            {
                dataGridView1.Rows.RemoveAt(n);

            }
        }
    }
}
