using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {

        public frmMovimentacaoCompra()
        {
            InitializeComponent();

            btCancelarFinal.Visible = false;
            btSalvarFinal.Visible = false;
        }
        public double totalCompra = 0;
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            lbFornecedor11.Visible = true;
            lbProduto11.Visible = true;
            ptbVenda.Visible = true;
            this.totalCompra = 0;
            this.alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            txtNFIscal.Focus();
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                //leitura de todos os dados do formulario de compra
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                //preencher tela
                txtComCod.Text = modelo.ComCod.ToString();
                txtNFIscal.Text = modelo.ComNFiscal.ToString();
                dtDataCmpra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                //para escrever nome do fornecedor na tela
                txtForCod_Leave(sender, e);
                cbTPag.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.ComNParcelas.ToString();
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal;//para armazenar o valor total da compra

                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);//carregado os itens
                //jogando na tela os dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    // Double TotalLocal = tabela.Rows[i]["itc_qtde"] * tabela.Rows[i]["itc_valor"];
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itc_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                    String[] it = new string[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);


                }
                alteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();

        }

        private void btAlterar_Click(object sender, EventArgs e)

        {
  
            int codigo = Convert.ToInt32(txtComCod.Text);
            int qtde = Convert.ToInt32(cbNParcelas.Text);
            //conexao
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);

            qtde -= bllc.QauantidadeParcelasNaoPagas(codigo);
            if (qtde == 0)//significa que nçao paguei alguma das parcelas
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossívelalterar o registro. \n O registro esta com parcelas pagas.");
            }

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtComCod.Text);
                    int qtde = Convert.ToInt32(cbNParcelas.Text);
                    //conexao
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);

                    qtde -= bllc.QauantidadeParcelasNaoPagas(codigo);
                    if (qtde == 0)//significa que nçao paguei alguma das parcelas
                    {
                        try
                        {

                            //excluir as parcelas da compra
                            cx.Conectar();
                            cx.Iniciatransacao();
                            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                            bllp.ExcluirTodasAsParcelas(codigo);
                            //excluir os itens da compra

                            BLLItensCompra blli = new BLLItensCompra(cx);
                            blli.ExcluirTodosOsItens(codigo);
                            //excluir uma compra

                            bllc.Excluir(codigo);
                            this.LimpaTela();
                            cx.TerminarTransacao();
                            cx.Desconectar();
                            MessageBox.Show("Registro excluido por completo.");
                            this.alteraBotoes(1);

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelarTransacao();//cancela toda a operação
                            cx.Desconectar();//desconctar do banco de dados
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossível excluir o registro. \n O registro esta com parcelas pagas.");
                    }
                }



            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }

        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))

                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }

            catch (Exception)
            { }
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (totalCompra <= 0)
                {
                    MessageBox.Show("Campo invalido verifique.....");
                    // lbCodBarras.Visible = true;
                    // txtCodBarras.Visible = true;
                    btnMaisFornecedor.Visible = true;
                    lbFornecedor11.Visible = true;
                    lbProduto11.Visible = true;
                    // lbMsg.Visible = true;
                    return;
                }
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCmpra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFIscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTPag.SelectedValue);


                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcelas.Text);
                // Double totalLocal = Convert.ToDouble(txtTotalCompra.Text);
                Double totalLocal = this.totalCompra;
                double valor = totalLocal / parcelas;

                DateTime dt = new DateTime();
                dt = dtDataIni.Value;
                txtTotalFinalParcelas.Text = this.totalCompra.ToString();


                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new string[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                    this.dgvParcelas.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }

                }
                pnFinalizaCompra.Visible = true;
                btAddProd.Visible = false;
                lbItens.Visible = false;
                btAlterar.Visible = false;
                btExcluir.Visible = false;
                btInserir.Visible = false;
                btLocalizar.Visible = false;
                btCancelar.Visible = false;
                btSalvar.Visible = false;
                txtValor.Visible = false;
                btAddProd.Visible = false;

                btnMaisFornecedor.Visible = false;
                lbFornecedor11.Visible = false;
                lbProduto11.Visible = false;
                lbCodBarras.Visible = false;
                txtCodBarras.Visible = false;



                btCancelarFinal.Visible = true;

                btSalvarFinal.Visible = true;

            }
            catch
            {
                MessageBox.Show("Verifique os campos acima se estão prenchidos.....");
            }
           
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;
        }
        public void LimpaTela()
        {
            txtComCod.Clear();
            txtNFIscal.Clear();
            txtForCod.Clear();
            txtProCod.Clear();
            lbProduto11.Text = "-";
            lbFornecedor11.Text = "-";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTPag.SelectedIndex = 0;
            txtCodBarras.Clear();
            ptbVenda.Image = null;

        }
        private void btLFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e);
            }
        }
        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                txtProCod_Leave(sender, e);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodBarras.Text = modelo.ProCodBarras;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    ptbVenda.Image = Image.FromStream(ms);
                }

                catch { }
            }

            /* frmConsultaProduto f = new frmConsultaProduto();
             f.ShowDialog();
             if (f.codigo != 0)
             {
                 txtProCod.Text = f.codigo.ToString();
                 txtProCod_Leave(sender, e);
             }
             */

        }
        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));

                if (modelo.ForCod <= 0)
                {
                    txtForCod.Clear();
                    lbFornecedor11.Text = "informe o código";
                }
                else
                    lbFornecedor11.Text = modelo.ForNome;
            }
            catch
            {
                txtForCod.Clear();
                lbFornecedor11.Text = "informe o código";
            }
        }
        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbProduto11.Text = modelo.ProNome;
                txtQtde.Text = "1";

                if (modelo.ProCod <= 0)
                {
                    txtProCod.Clear();
                    lbProduto11.Text = "informe o código";
                }
                else
                    txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbProduto11.Text = "informe o código";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalCompra = this.totalCompra + TotalLocal;

                  /*  ModeloProduto modelo = new ModeloProduto();
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    DALProduto dal = new DALProduto(cx);
                    modelo.ProCod = Convert.ToInt32(txtProCod.Text);
                    dal.Alterar(modelo);
*/
                    String[] i = new string[] { txtProCod.Text, lbProduto11.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);

                   


                    //limpando os campos da grid para inserir mais dados
                    txtProCod.Clear();
                    lbProduto11.Text = "-";
                    txtQtde.Clear();
                    txtValor.Clear();
                    txtCodBarras.Clear();
                    txtTotalCompra.Text = this.totalCompra.ToString();
                    ptbVenda.Image = null;
                    txtCodBarras.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Informe somente numeros");
            }
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTPag.DataSource = bll.Localizar("");
            cbTPag.DisplayMember = "tpa_nome";
            cbTPag.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //voltando os dados para os campos texbox
            if (e.RowIndex >= 0)//se numero da linhya selecionada for maior ou = a zero
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbProduto11.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;//atualizando o valor da compra
                dgvItens.Rows.RemoveAt(e.RowIndex);//removendo a linha do grid
                this.txtTotalCompra.Text = this.totalCompra.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
            this.LimpaTela();
            pnFinalizaCompra.Visible = false;
            btAddProd.Visible = true;
            btAlterar.Visible = true;
            btExcluir.Visible = true;
            btInserir.Visible = true;
            btLocalizar.Visible = true;
            btCancelar.Visible = true;
            btSalvar.Visible = true;
            txtValor.Visible = true;
            btAddProd.Visible = true;
            btCancelarFinal.Visible = false;
            btSalvarFinal.Visible = false;
            this.alteraBotoes(1);
        }

        private void btSalvarFinal_Click(object sender, EventArgs e)
        {


            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.Iniciatransacao();
            try
            {

                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCmpra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFIscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTPag.SelectedValue);


                //obj para gravar os dados no banco

                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);



                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloCompra);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //gatilho no banco de dados para alterar a quantidade de produtos no banco
                        //Triggers
                    }
                    //inserir itens na tabela de compras
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Cadastro efetuado: Código " + modeloCompra.ComCod.ToString());
                    lbItens.Visible = true;
                    btnMaisFornecedor.Visible = true;
                    lbFornecedor11.Visible = true;
                    lbProduto11.Visible = true;

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCod.Text);
                    bll.Alterar(modeloCompra);
                    //alterar uma compra
                    bitens.ExcluirTodosOsItens(modeloCompra.ComCod);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //gatilho no banco de dados para alterar a quantidade de produtos no banco
                        //Triggers
                    }
                    //inserir itens na tabela de parclas compras
                    bparcelas.ExcluirTodasAsParcelas(modeloCompra.ComCod);
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Alteração efetuado: Código " + modeloCompra.ComCod.ToString());
                    lbItens.Visible = true;
                    btnMaisFornecedor.Visible = true;
                    lbFornecedor11.Visible = true;
                    lbProduto11.Visible = true;

                    // MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                pnFinalizaCompra.Visible = false;
                btAddProd.Visible = true;
                btAlterar.Visible = true;
                btExcluir.Visible = true;
                btInserir.Visible = true;
                btLocalizar.Visible = true;
                btCancelar.Visible = true;
                btSalvar.Visible = true;
                txtValor.Visible = true;
                btAddProd.Visible = true;
                btCancelarFinal.Visible = false;
                btSalvarFinal.Visible = false;

                lbCodBarras.Visible = true;
                txtCodBarras.Visible = true;

                this.alteraBotoes(1);
                //pnBotoes.Visible = true;
                cx.TerminarTransacao();//confirma a altareção no banco de dados
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();//cancela toda a operação
                cx.Desconectar();//desconctar do banco de dados

            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //não permitir augumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez a virgula
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtNFIscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //não permitir augumas coisas 
            if (char.IsLetter(e.KeyChar) || //Letras

                char.IsSymbol(e.KeyChar) || //Símbolos

                char.IsWhiteSpace(e.KeyChar)) //Espaço

                e.Handled = true; //Não permitir

            //só permitir digitar uma vez a virgula
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }



        private void txtTotalCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTotalCompra);
        }



        private void txtTotalFinalParcelas_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTotalFinalParcelas);
        }

        private void btnMaisFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProdutocodBarras(txtCodBarras.Text);
                lbProduto11.Text = modelo.ProNome;
                txtQtde.Text = "1";
                //txtQtde.Focus();

                if (modelo.ProCodBarras.Trim().Length == 0)
                {
                    //  txtProCod.Clear();
                    lbProduto11.Text = "produto não existe";
                    txtCodBarras.Clear();
                    txtQtde.Clear();
                    txtCodBarras.Focus();
                }
                else
                {
                    txtValor.Text = modelo.ProValorVenda.ToString();
                    txtProCod.Text = modelo.ProCod.ToString();
                    try
                    {
                        MemoryStream ms = new MemoryStream(modelo.ProFoto);
                        ptbVenda.Image = Image.FromStream(ms);
                    }

                    catch { }
                    
                   // txtQtde.Focus();
                    btAddProd_Click(sender, e);
                }
            }
            catch
            {
                txtProCod.Clear();
                //  lbProduto.Text = " ";
            }

        }

        private void txtProCod_KeyDown(object sender, KeyEventArgs e)
        {
            btAddProd_Click(sender, e);
        }
    }

}
