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
    public partial class frmMovimentacaoVendass : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalVenda = 0;
        public double totalTroco = 0;
        public double totalPago = 0;
        public frmMovimentacaoVendass()

        {
            InitializeComponent();
          
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
           
            this.totalVenda = 0;
            this.alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            ptbVenda.Visible = true;
            txtNFIscal.Focus();
            // cbVendaAVista.Checked = false;

        }
        public void LimpaTela()
        {
            txtVenCod.Clear();
            txtCodBarras.Clear();
            txtNFIscal.Clear();
            txtCliCod.Clear();
            txtProCod.Clear();
            lbCliente.Text = "";
            lbProduto.Text = "";
            lbProduto.Text = "-";
            lbCliente.Text = "-";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalVenda.Text = "0,00";
            dgvItens.Rows.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTPag.SelectedIndex = 0;
            cbVendaAVista.Checked = true;
            lbMsg.Visible = false;
            ptbVenda.Image = null;
           

        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            txtNFIscal.Focus();
            this.alteraBotoes(1);
            this.totalVenda = 0;
            lbCodBarras.Visible = true;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmColsultaVenda f = new frmColsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                //leitura de todos os dados do formulario de venda
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                //preencher tela
                txtVenCod.Text = modelo.VenCod.ToString();
                txtNFIscal.Text = modelo.VenNFiscal.ToString();
                dtDataVenda.Value = modelo.VenData;
                txtCliCod.Text = modelo.CliCod.ToString();
                //para escrever nome do cliente na tela
                txtCliCod_Leave(sender, e);
                cbTPag.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.VenNParcelas.ToString();
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                if (modelo.VenAvista == 1)
                    cbVendaAVista.Checked = true;
                else cbVendaAVista.Checked = false;
                this.totalVenda = modelo.VenTotal;//para armazenar o valor total da venda

                //itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                DataTable tabela = bllItens.Localizar(modelo.VenCod);//carregado os itens
                //jogando na tela os dados
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    // Double TotalLocal = tabela.Rows[i]["itc_qtde"] * tabela.Rows[i]["itc_valor"];
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);
                    String[] it = new string[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);


                }
                alteraBotoes(3);
                lbMsg.Visible = false;
                if (modelo.VenStatus != "ativa")
                {
                    lbMsg.Text = "Venda Cancelada";
                    lbMsg.Visible = true;
                    btExcluir.Enabled = false;

                }
            }

            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();

        }

        private void btLFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                txtCliCod_Leave(sender, e);
            }
        }

        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));

                if (modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lbCliente.Text = "cliente não existe";
                    txtCliCod.Focus();
                }
                else
                    lbCliente.Text = modelo.CliNome;
            }

            catch
            {
                txtCliCod.Clear();
               //lbCliente.Text = "código cliente invalido";
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {//após sair do campo verificar se o produto exite
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";

                if (modelo.ProCod <= 0)
                {
                    txtProCod.Clear();
                    
                    lbProduto.Text = "produto não existe";
                    txtProCod.Focus();
                }
                else
                    txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch
            {
                txtProCod.Clear();
                //  lbProduto.Text = " ";
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
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalVenda = this.totalVenda + TotalLocal;
                    String[] i = new string[] { txtProCod.Text, lbProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);
                    //limpando os campos da grid para inserir mais dados
                    txtProCod.Clear();
                    //  lbProduto.Text = "informe o código do produto ou clique em localizar";
                    txtQtde.Clear();
                    txtValor.Clear();
                    txtCodBarras.Clear();
                    lbProduto.Text = "-";
                    //lbCodBarras.Text = "";
                    ptbVenda.Image = null;
                   // txtQtde.Focus()
                    txtTotalVenda.Text = this.totalVenda.ToString();
                    txtCodBarras.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Informe somente numeros");
            }

        }

        private void frmMovimentacaoVendass_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTPag.DataSource = bll.Localizar("");
            cbTPag.DisplayMember = "tpa_nome";
            cbTPag.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
            cbVendaAVista.Checked = true;

        }



        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//se numero da linhya selecionada for maior ou = a zero
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;//atualizando o valor da compra
                dgvItens.Rows.RemoveAt(e.RowIndex);//removendo a linha do grid
                this.txtTotalVenda.Text = this.totalVenda.ToString();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            //validar os dados
            try
            {
                /* if (Convert.ToInt32(txtCliCod.Text) <= 0)
                 {
                     MessageBox.Show("Informe o codigo do cliente");
                     return;
                 }
                 if (Convert.ToInt32(txtProCod.Text) <= 0)
                 {
                     MessageBox.Show("Informe o codigo do produto");
                     return;
                 }
                 if (Convert.ToInt32(txtNFIscal.Text) < 0)
                 {
                     MessageBox.Show("Informe numero da nota fiscal ");
                     return;
                 }
                 */
                txtValorPago.Text = this.totalPago.ToString();
                txtTroco.Text = this.totalTroco.ToString();
                if (totalVenda <= 0)
                {
                    MessageBox.Show("Insira valores validos para  continuar a venda.....");
                    lbCodBarras.Visible = true;
                    txtCodBarras.Visible = true;
                    btnMaisCliente.Visible = true;
                    lbValorTroco.Visible = true;
                    lbVlRecebido.Visible = true;
                    lbMsg.Visible = true;
                    return;
                }
                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcelas.Text);
                // Double totalLocal = Convert.ToDouble(txtTotalCompra.Text);
                Double totalLocal = this.totalVenda;
                double valor = totalLocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtDataIni.Value;
                txtTotalFinalParcelas.Text = this.totalVenda.ToString();


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
                btAlterar.Visible = false;
                btExcluir.Visible = false;
                btInserir.Visible = false;
                btLocalizar.Visible = false;
                btCancelar.Visible = false;
                btSalvar.Visible = false;
                txtValor.Visible = false;
                btAddProd.Visible = false;
                btCancelarFinal.Visible = true;
                btSalvarFinal.Visible = true;
            }
            catch
            {
                MessageBox.Show("Verifique os campos acima se estão prenchidos.....");
            }

            lbCodBarras.Visible = false;
            txtCodBarras.Visible = false;
            btnMaisCliente.Visible = false;
            lbValorTroco.Visible = false;
            lbVlRecebido.Visible = false;
            lbMsg.Visible = false;
        }
        private void btCancelarFinal_Click(object sender, EventArgs e)
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
        private void cbVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendaAVista.Checked == true)//se venda for a vista
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
                txtValorPago.Enabled = true;

            }
            else
            {
                cbNParcelas.Enabled = true;
                txtValorPago.Enabled = false;

            }

        }
        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.Iniciatransacao();
            try
            {
                //leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VenData = dtDataVenda.Value;
                modeloVenda.VenNFiscal = Convert.ToInt32(txtNFIscal.Text);
                modeloVenda.VenNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloVenda.VenStatus = "ativa";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.CliCod = Convert.ToInt32(txtCliCod.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cbTPag.SelectedValue);
                if (cbVendaAVista.Checked == true)
                    modeloVenda.VenAvista = 1;
                else
                    modeloVenda.VenAvista = 0;
                //obj para gravar os dados no banco

                BLLVenda bllVenda = new BLLVenda(cx);

                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                ModeloParcelasVendas mparcelas = new ModeloParcelasVendas();
                BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma venda
                    bllVenda.Incluir(modeloVenda);

                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //gatilho no banco de dados para alterar a quantidade de produtos no banco
                        //Triggers
                    }
                    //inserir itens na tabela de vendass
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bparcelas.Incluir(mparcelas);
                    }

                    MessageBox.Show("Cadastro efetuado: Código " + modeloVenda.VenCod.ToString());
                    lbCodBarras.Visible = true;
                }

                else
                {

                    // alterar uma venda
                    modeloVenda.VenCod = Convert.ToInt32(txtVenCod.Text);
                    bllVenda.Alterar(modeloVenda);
                    //alterar uma venda
                    bitens.ExcluirTodosOsItens(modeloVenda.VenCod);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //gatilho no banco de dados para alterar a quantidade de produtos no banco
                        //Triggers
                    }
                    //inserir itens na tabela de parclas compras
                    bparcelas.ExcluirTodasAsParcelas(modeloVenda.VenCod);
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {

                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);

                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Alteração efetuada: Código " + modeloVenda.VenCod.ToString());

                    // MessageBox.Show("Cadastro alterado");      
                    lbCodBarras.Visible = true;
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
                btnMaisCliente.Visible = true;
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
        private void btExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtVenCod.Text);
                    int qtde = Convert.ToInt32(cbNParcelas.Text);
                    //conexao
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLVenda bllv = new BLLVenda(cx);

                    qtde -= bllv.QauantidadeParcelasNaoPagas(codigo);
                    if (qtde == 0)//significa que nçao paguei alguma das parcelas
                    {
                        try
                        {
                            //excluir as parcelas da compra
                            cx.Conectar();
                            cx.Iniciatransacao();
                            BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                            bllp.ExcluirTodasAsParcelas(codigo);
                            //excluir os itens da compra

                            BLLItensVenda blli = new BLLItensVenda(cx);
                            blli.ExcluirTodosOsItens(codigo);
                            //excluir uma compra

                            bllv.Excluir(codigo);
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

        private void txtTotalFinalParcelas_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTotalFinalParcelas);
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTotalVenda);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtVenCod.Text);
            int qtde = Convert.ToInt32(cbNParcelas.Text);
            //conexao
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllv = new BLLVenda(cx);

            //qtde -= bllc.QauantidadeParcelasNaoPagas(codigo);
            //if (qtde == 0)//significa que nçao paguei alguma das parcelas
            // {
            this.operacao = "alterar";
            this.alteraBotoes(2);
            //  }
            // else {
            // MessageBox.Show("Impossívelalterar o registro. \n O registro esta com parcelas pagas.");
            // }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                double valorPago = 0;
                double valorTroco = 0;
                totalVenda = Convert.ToDouble(this.totalVenda.ToString());
                valorPago = Convert.ToDouble(this.txtValorPago.Text);

                valorTroco = valorPago - totalVenda;


                txtTroco.Text = valorTroco.ToString();
            }
            catch
            {
                MessageBox.Show("Erro ao inseririr valor recebido");
                this.alteraBotoes(3);
            }
        }

        private void btnMaisCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorPago);
        }

        private void txtCliCod_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProCod_KeyPress(object sender, KeyPressEventArgs e)
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



        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProdutocodBarras(txtCodBarras.Text);
                lbProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";
                //txtQtde.Focus();

                if (modelo.ProCodBarras.Trim().Length == 0)
                {
                  //  txtProCod.Clear();
                    lbProduto.Text = "produto não existe";
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
         //   btAddProd_Click(sender, e);
        }

        private void txtCodBarras_MouseEnter(object sender, EventArgs e)
        {
            btAddProd_Click(sender, e);
        }
    }
}
