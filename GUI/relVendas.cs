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
    public partial class relVendas : Form
    {
        public relVendas()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            if (txtDatainni.Text == string.Empty || txtdataFinnal.Text == string.Empty)
            {
                MessageBox.Show("informe as datas", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.rel_venda_por_clienteTableAdapter.frm_data(this.bd_tccDataSet.rel_venda_por_cliente, Convert.ToDateTime(txtDatainni.Text), Convert.ToDateTime(txtdataFinnal.Text));
                this.reportViewerVenda.RefreshReport();
            }
        }

        private void relVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.rel_venda_por_cliente' table. You can move, or remove it, as needed.
           // this.rel_venda_por_clienteTableAdapter.Fill(this.bd_tccDataSet.rel_venda_por_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //  this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //  this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            //this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relatorio_vendas_cliente' table. You can move, or remove it, as needed.
            // this.relatorio_vendas_clienteTableAdapter.frm_data(this.bd_tccDataSet.relatorio_vendas_cliente);
            // TODO: This line of code loads data into the 'bd_tccDataSet.venda' table. You can move, or remove it, as needed.
            //this.relatorio_vendas_clienteTableAdapter.Fill(this.bd_tccDataSet.relatorio_vendas_cliente);

        }
    }
}
