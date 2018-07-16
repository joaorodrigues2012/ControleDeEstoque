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
    public partial class relProdutos : Form
    {
        public relProdutos()
        {
            InitializeComponent();
        }

        private void relProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.listaProdutoPorNome' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'bd_tccDataSet.compra' table. You can move, or remove it, as needed.
            // this.compraTableAdapter.Fill(this.bd_tccDataSet.compra);
            // TODO: This line of code loads data into the 'bd_tccDataSet.produto' table. You can move, or remove it, as needed.

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.listaProdutoPorNomeTableAdapter.Fill(this.bd_tccDataSet.listaProdutoPorNome,txtBuscaProduto.Text);

            this.reportViewerProduto.RefreshReport();
        }

        
    }
}
