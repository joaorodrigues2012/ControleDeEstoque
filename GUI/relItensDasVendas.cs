﻿using BLL;
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
    public partial class relItensDasVendas : Form
    {
        public int codigo = 0;
        public relItensDasVendas()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_tccDataSet.relItensVenda' table. You can move, or remove it, as needed.
           // this.relItensVendaTableAdapter.cod(this.bd_tccDataSet.relItensVenda);
            // TODO: This line of code loads data into the 'bd_tccDataSet.relItensVenda' table. You can move, or remove it, as needed.
            //this.relItensVendaTableAdapter.cod(this.bd_tccDataSet.relItensVenda);
            // TODO: This line of code loads data into the 'bd_tccDataSet.itenscompra' table. You can move, or remove it, as needed.

            rbGeral_CheckedChanged(sender, e);
        }
        public void ExecutaColsulta(int op)
        {
            //si op = 1 consulta todas as compras
            //si op = 2 por fornecedor
            //si op = 3 data da compra
            //si op = 4 parcelas em aberto

        }
        public void AtualizaCabecalhoDgCompra()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            // dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[1].HeaderText = "Data da Venda";

            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[2].HeaderText = "Nº nota fiscal";

            dgvDados.Columns[3].HeaderText = "Nº parcelas";

            dgvDados.Columns[4].Width = 400;
            dgvDados.Columns[4].HeaderText = "Cliente";

            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[6].HeaderText = "Código do cliente";
            dgvDados.Columns[7].HeaderText = "Código tipo pagamento";

            dgvDados.Columns[8].Width = 150;
            dgvDados.Columns[8].HeaderText = "Total";

            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
        }
        public void AtualizaCabecalhoItensCompra()
        {
            /*
            try
            {
                dgvItens.Columns[0].Visible = false;

                dgvItens.Columns[1].Width = 250;
                dgvItens.Columns[1].HeaderText = "Código iten";

                dgvItens.Columns[2].Width = 250;
                dgvItens.Columns[2].HeaderText = "Código produto";

                dgvItens.Columns[3].Width = 350;
                dgvItens.Columns[3].HeaderText = "Descrição do produto";

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
            */
        }
        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbForNome.Text = "Nome do Cliente:" + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDgCompra();
            }
            else
            {
                txtForCod.Text = ""; lbForNome.Text = "Nome do Cliente:";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            pnFornecedor.Visible = false;
            pnData.Visible = false;
            //limpar o grid
            dgvDados.DataSource = null;
          //  dgvItens.DataSource = null;
          //  dgvParcelas.DataSource = null;
            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabecalhoDgCompra();


            }
            if (rbData.Checked == true)
            {
                pnData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                pnFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarPorParcelasEmAberto();
                this.AtualizaCabecalhoDgCompra();
            }

        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtPInicial.Value;
            DateTime dtfim = dtPFinal.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoDgCompra();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.relItensVendaTableAdapter.cod(this.bd_tccDataSet.relItensVenda, Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                this.reportViewerCompra.RefreshReport();


                if (e.RowIndex >= 0)
                {
                    //itens da venda
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLItensVenda bllItens = new BLLItensVenda(cx);
                 //   dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                    //parcelas da venda
                    BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
                  //  dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                    AtualizaCabecalhoItensCompra();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
