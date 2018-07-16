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
    public partial class frmRecebimentoDeVenda : Form
    {
        public int pveCod = 0;
        public frmRecebimentoDeVenda()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmColsultaVenda f = new frmColsultaVenda();
                f.ShowDialog();
                if (f.codigo != 0)
                    btReceber.Enabled = false;
                {
                    //leitura de todos os dados do formulario de compra
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bll = new BLLVenda(cx);
                    ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                    //preencher tela
                    txtCodigo.Text = modelo.VenCod.ToString();
                    // txtNFIscal.Text = modelo.ComNFiscal.ToString();
                    dtData.Value = modelo.VenData;
                    txtcliente.Text = modelo.CliCod.ToString();
                    //para escrever nome do fornecedor na tela
                    BLLCliente bllf = new BLLCliente(cx);
                    ModeloCliente modelof = bllf.CarregaModeloCliente(modelo.CliCod);

                    txtcliente.Text = modelof.CliNome.ToString();
                    txtValor.Text = modelo.VenTotal.ToString();
                    //montando o cabeçalho dos itens da compra
                    BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                    dgvParcelas.DataSource = bllp.Localizar(modelo.VenCod);
                    dgvParcelas.Columns[0].HeaderText = "Parcela ";
                    dgvParcelas.Columns[0].Width = 150;
                    dgvParcelas.Columns[1].HeaderText = "Valor da parcela";
                    dgvParcelas.Columns[1].Width = 250;
                    dgvParcelas.Columns[2].HeaderText = "recebido em ";
                    dgvParcelas.Columns[2].Width = 350;
                    dgvParcelas.Columns[3].HeaderText = "Vencimento";
                    dgvParcelas.Columns[3].Width = 250;
                    dgvParcelas.Columns[4].Visible = false;
                    //dgvParcelas.Columns[3].Width = 150;
                }
            }
            catch { }
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btReceber.Enabled = false;
            btnCancelPag.Enabled = false;
            this.pveCod = 0;
            //verifica se a celula 3  da grid esta vazia não pagou ainda
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btReceber.Enabled = true;
                btnCancelPag.Enabled = true;
                this.pveCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLContasAReceber bllp = new BLLContasAReceber(cx);
            int venCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpReceMento.Value;
            bllp.EfetuaRecebimentoVenda(venCod, this.pveCod, data);
            BLLContasAReceber bll2p = new BLLContasAReceber(cx);
            dgvParcelas.DataSource = bllp.Localizar(venCod);
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
            btReceber.Enabled = false;
            btnCancelPag.Enabled = false;
        }

        private void btnCancelPag_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
