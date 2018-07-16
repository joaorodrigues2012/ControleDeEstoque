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
    public partial class rel_ContasRecebidas : Form
    {
        public rel_ContasRecebidas()
        {
            InitializeComponent();
        }

       


        private void Buscar_Click(object sender, EventArgs e)
        {
            this.listaContasRecebidasTableAdapter.nome(this.bd_tccDataSet.listaContasRecebidas,txtBuscaContaAPagar.Text);
            this.reportViewerContasAReceber.RefreshReport();
        }

        private void rel_ContasARecebidas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.listaContasRecebidas' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bd_tccDataSet.listaContasAReceber' table. You can move, or remove it, as needed.
            //    this.listaContasAReceberTableAdapter.Fill(this.bd_tccDataSet.listaContasAReceber);
            // TODO: This line of code loads data into the 'bd_tccDataSet.listaContasAPagar' table. You can move, or remove it, as needed.
            //   this.listaContasAPagarTableAdapter.Fill(this.bd_tccDataSet.listaContasAPagar);
            // TODO: This line of code loads data into the 'bd_tccDataSet.listaContasAReceber' table. You can move, or remove it, as needed.
            // this.listaContasAReceberTableAdapter.Fill(this.bd_tccDataSet.listaContasAReceber);
            
        }
    }
}
