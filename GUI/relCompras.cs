using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class relCompras : Form
    {
        public relCompras()
        {
            InitializeComponent();
        }

        private void relCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.rel_Compra' table. You can move, or remove it, as needed.
            //this.rel_CompraTableAdapter.frm_data(this.bd_tccDataSet.rel_Compra);
            // TODO: This line of code loads data into the 'bd_tccDataSet.produto' table. You can move, or remove it, as needed.
            //  this.produtoTableAdapter.Fill(this.bd_tccDataSet.produto);
            // TODO: This line of code loads data into the 'bd_tccDataSet.compra' table. You can move, or remove it, as needed.
            // this.compraTableAdapter.Fill(this.bd_tccDataSet.compra);
            // TODO: This line of code loads data into the 'bd_tccDataSet.produto' table. You can move, or remove it, as needed.
            //this.produtoTableAdapter.Fill(this.bd_tccDataSet.produto);
            // TODO: This line of code loads data into the 'bd_tccDataSet.compra' table. You can move, or remove it, as needed.
            //this.compraTableAdapter.Fill(this.bd_tccDataSet.compra);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txtDatainni.Text == string.Empty || txtdataFinnal.Text == string.Empty)
            {
                MessageBox.Show("informe as datas", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.rel_CompraTableAdapter.frm_data(this.bd_tccDataSet.rel_Compra, Convert.ToDateTime(txtDatainni.Text), Convert.ToDateTime(txtdataFinnal.Text));
            this.reportViewerCompra.RefreshReport();
            }
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdataFinnal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDatainni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewerCompra_Load(object sender, EventArgs e)
        {

        }

        private void dtPFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void compraBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
