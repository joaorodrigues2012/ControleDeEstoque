using BLL;
using DAL;
using Modelo;
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
    public partial class frmPagamentoCompra : Form
    {
        public int pcoCod = 0;
        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaCompra f = new frmConsultaCompra();
                f.ShowDialog();
                if (f.codigo != 0)
                    btPagar.Enabled = false;
                {
                    //leitura de todos os dados do formulario de compra
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bll = new BLLCompra(cx);
                    ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                    //preencher tela
                    txtCodigo.Text = modelo.ComCod.ToString();
                    // txtNFIscal.Text = modelo.ComNFiscal.ToString();
                    dtData.Value = modelo.ComData;
                    txtfronecedor.Text = modelo.ForCod.ToString();
                    //para escrever nome do fornecedor na tela
                    BLLFornecedor bllf = new BLLFornecedor(cx);
                    ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);

                    txtfronecedor.Text = modelof.ForNome.ToString();
                    txtValor.Text = modelo.ComTotal.ToString();
                    //montando o cabeçalho dos itens da compra
                    BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                    dgvParcelas.DataSource = bllp.Localizar(modelo.ComCod);
                    dgvParcelas.Columns[0].HeaderText = "Parcela ";
                    dgvParcelas.Columns[0].Width = 150;
                    dgvParcelas.Columns[1].HeaderText = "Valor da parcela";
                    dgvParcelas.Columns[1].Width = 250;
                    dgvParcelas.Columns[2].HeaderText = "Pago em ";
                    dgvParcelas.Columns[2].Width = 350;
                    dgvParcelas.Columns[3].HeaderText = "Vencimento";
                    dgvParcelas.Columns[3].Width = 250;
                    dgvParcelas.Columns[4].Visible = false;
                    //dgvParcelas.Columns[3].Width = 150;
                }
            }
            catch {  }
            
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btPagar.Enabled = false;
            btnCancelPag.Enabled = false;
            this.pcoCod = 0;
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btPagar.Enabled = true;
                btnCancelPag.Enabled = true;
                this.pcoCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasAPagar bllp = new BLLContasAPagar(cx);
            int comCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpPagto.Value;
            bllp.EfetuaPagamentoCompra(comCod, this.pcoCod, data);
            BLLContasAPagar bll2p = new BLLContasAPagar(cx);
            dgvParcelas.DataSource = bllp.Localizar(comCod);
            dgvParcelas.Columns[0].HeaderText = "Parcela ";
            dgvParcelas.Columns[0].Width = 150;
            dgvParcelas.Columns[1].HeaderText = "Valor da parcela";
            dgvParcelas.Columns[1].Width = 250;
            dgvParcelas.Columns[2].HeaderText = "Pago em ";
            dgvParcelas.Columns[2].Width = 350;
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            dgvParcelas.Columns[3].Width = 250;
            dgvParcelas.Columns[4].Visible = false;
            //dgvParcelas.Columns[3].Width = 150;
            btPagar.Enabled = false;
            btnCancelPag.Enabled = false;
        }

        private void btnCancelPag_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
