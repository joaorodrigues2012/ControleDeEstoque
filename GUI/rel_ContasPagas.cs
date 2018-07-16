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
    public partial class rel_ContasPagas : Form
    {
        public rel_ContasPagas()
        {
            InitializeComponent();
        }


        private void Buscar_Click(object sender, EventArgs e)
        {
            this.listaContasPagasTableAdapter.nome(this.bd_tccDataSet.listaContasPagas,txtBuscaContaAPagar.Text);
            this.reportViewerContasAPagar.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rel_ContasPagas_Load(object sender, EventArgs e)
        {

        }
    }
}
