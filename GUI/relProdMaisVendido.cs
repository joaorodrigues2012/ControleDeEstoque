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
    public partial class relProdMaisVendido : Form
    {
        public relProdMaisVendido()
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
                this.itensvendaTableAdapter.frm_data(this.bd_tccDataSet.itensvenda, Convert.ToDateTime(txtDatainni.Text), Convert.ToDateTime(txtdataFinnal.Text));
                this.reportViewerProdMaisVendido.RefreshReport();
            }
        }

        private void relProdMaisVendido_Load(object sender, EventArgs e)
        {
           

        }

    }
}
