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
    public partial class rel_Clieentes : Form
    {
        public rel_Clieentes()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.bd_tccDataSet.cliente,txtBuscaCliente.Text);
            this.reportViewerCliente.RefreshReport();

        }

        private void rel_Clieentes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.cliente' table. You can move, or remove it, as needed.
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewerCliente_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtPFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void compraBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void vendaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void relatorio_vendas_clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
