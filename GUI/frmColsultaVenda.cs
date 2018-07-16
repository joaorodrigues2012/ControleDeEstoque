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
    public partial class frmColsultaVenda : Form
    {
        public int codigo = 0;
        public frmColsultaVenda()
        {
            InitializeComponent();
        }
        
        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtPInicial.Value;
            DateTime dtfim = dtPFinal.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoDgVenda();
        }
        public void AtualizaCabecalhoDgVenda()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            // dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[1].HeaderText = "Data da venda";
            // dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Nº nota fiscal";
            dgvDados.Columns[3].HeaderText = "Nº parcelas";
            dgvDados.Columns[4].Width = 300;
            dgvDados.Columns[4].HeaderText = "Cliente";
            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[6].HeaderText = "Código do cliente";
            dgvDados.Columns[7].HeaderText = "Código tipo pagamento";
            dgvDados.Columns[8].HeaderText = "A vista ou A prazo";
            dgvDados.Columns[9].Width = 150;
            dgvDados.Columns[9].HeaderText = "Total";
           // dgvDados.Columns[3].Visible = false;
            //dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[7].Visible = false;
        }
        public void AtualizaCabecalhoItensVenda()
        {
            try
            {
                dgvItens.Columns[0].Visible = false;

                dgvItens.Columns[1].Width = 250;
                dgvItens.Columns[1].HeaderText = "Código iten";

                dgvItens.Columns[2].Width = 250;
                dgvItens.Columns[2].HeaderText = "Código produto";

                dgvItens.Columns[3].Width = 350;
                dgvItens.Columns[3].HeaderText = "Nome produto";

                dgvItens.Columns[4].Width = 250;
                dgvItens.Columns[4].HeaderText = "Quantidade";

                dgvItens.Columns[5].Width = 250;
                dgvItens.Columns[5].HeaderText = "Valor";

                //dados da parcela
                dgvParcelas.Columns[0].Width = 250;
                dgvParcelas.Columns[0].HeaderText = "Parcela";

                dgvParcelas.Columns[1].Width = 250;
                dgvParcelas.Columns[1].HeaderText = "Valor";

                dgvParcelas.Columns[2].Width = 250;
                dgvParcelas.Columns[2].HeaderText = "Data pagamento";

                dgvParcelas.Columns[3].Width = 250;
                dgvParcelas.Columns[3].HeaderText = "Data Vencimento";
               
                dgvParcelas.Columns[4].Visible = false;
            }
            catch { }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            pnCliente.Visible = false;
            pnData.Visible = false;
            //limpar o grid
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;
            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabecalhoDgVenda();
            }
            if (rbData.Checked == true)
            {
                pnData.Visible = true;
            }
            if (rbCliente.Checked == true)
            {
                pnCliente.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
               DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
               BLLVenda bllvenda = new BLLVenda(cx);
               dgvDados.DataSource = bllvenda.LocalizarPorParcelasEmAberto();
               this.AtualizaCabecalhoDgVenda();
            }
        }
        private void frmColsultaVenda_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbCliNome.Text = "Nome do cliente:" + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDgVenda();
            }
            else
            {
                txtCliCod.Text = ""; lbCliNome.Text = "Nome do cliente:";
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //armazenando o codigo da venda ao dar dois clic
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);

                this.Close();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //itens da venda
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                //parcelas da venda
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                AtualizaCabecalhoItensVenda();
            }
        }
    }
}
