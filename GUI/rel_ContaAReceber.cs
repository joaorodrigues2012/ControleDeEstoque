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
    public partial class rel_ContaAReceber : Form
    {
        public rel_ContaAReceber()
        {
            InitializeComponent();
        }

        private void rel_ContasAReceber_Load(object sender, EventArgs e)
        {
            

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.listaContasAReceberTableAdapter.nome(this.bd_tccDataSet.listaContasAReceber,txtBuscaContaAPagar.Text);
            this.reportViewerContasAReceber.RefreshReport();
        }
    }
}
