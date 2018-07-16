using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.IO;

namespace GUI
{
    public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";
        public frmCadastroProduto()
        {
            InitializeComponent();
            //txtCodBarras.Focus();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            // lbValorPago.Visible = false;
            // lbValorVenda.Visible = false;
            // txtValorPago.Visible = false;
            // txtValorVenda.Visible = false;
            lbQtde.Visible = false;
            txtQtde.Visible = false;
            txtCodBarras.Focus();
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtCodBarras.Clear();
            txtDescricao.Clear();
            txtNome.Clear();
            txtQtde.Text = "0";
            txtValorPago.Text = "0";
            txtValorVenda.Text = "0";
            lbQtde.Visible = false;
            txtQtde.Visible = false;
            this.foto = "";
            pbFoto.Image = null;

        }
        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;//qual fonte de dados desta lista , meu proprio comgobox
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
                cbSubCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSubCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
            cbUnd.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUnd.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        { //não permitir augumas coisas 
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

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
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



        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            txtCodBarras.Focus();

            this.alteraBotoes(2);

            /* lbValorPago.Visible = true;
             lbValorVenda.Visible = true;
             txtValorPago.Visible = true;
             txtValorVenda.Visible = true;
             lbQuantidade.Visible = true;
             txtQtde.Visible = true;
             */
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProCodBarras = txtCodBarras.Text;
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                modelo.UmedCod = Convert.ToInt32(cbUnd.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);

                modelo.CarregaImagem(this.foto);
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                btMovimentarEstoque.Enabled = false;
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cbSubCategoria.Text = "";
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }

        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            btMovimentarEstoque.Enabled = false;
            this.alteraBotoes(1);
            LimpaTela();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                // colocar os dados na tela
                txtCodigo.Text = modelo.CatCod.ToString();
                txtCodigo.Text = modelo.ProCod.ToString();
                txtCodBarras.Text = modelo.ProCodBarras.ToString();
                txtDescricao.Text = modelo.ProDescricao.ToString();
                txtNome.Text = modelo.ProNome.ToString();
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUnd.SelectedValue = modelo.UmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                }

                catch { }

                alteraBotoes(3);
                btMovimentarEstoque.Enabled = true;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAddCat_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //combo dacategoria
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
        }

        private void btAddScat_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
        }

        private void btAddUn_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";
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
        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorPago);

        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorVenda);
        }





        private void btMovimentarEstoque_Click(object sender, EventArgs e)
        {
            //this.operacao = "alterar";
            // this.alteraBotoes(2);
            btAlterar_Click(sender, e);
            /*xtDescricao.Enabled = false;
             txtNome.Enabled = false;
             cbCategoria.Enabled = false;
             cbSubCategoria.Enabled = false;
             cbUnd.Enabled = false;
             btAddCat.Enabled = false;
             btAddScat.Enabled = false;
             btAddUn.Enabled = false;
             */
            lbValorPago.Visible = true;
            lbValorVenda.Visible = true;
            txtValorPago.Visible = true;
            txtValorVenda.Visible = true;

            lbQtde.Visible = true;
            txtQtde.Visible = true;

        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            //nessessario instalar a leitora de codigo de barras 
            if (e.KeyCode == Keys.Enter)
            //codigo lido pela leitora
            {
                string cod_barras = txtCodigo.Text;
            }
        }

        private void txtCodBarras_MouseLeave(object sender, EventArgs e)
        {




        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
           

        }

        private void txtCodBarras_Leave_1(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                r = bll.VerificaCodBarrasDuplicado(txtCodBarras.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("ja existe um registro com este valor?");
                    txtCodBarras.Clear();
                    txtCodBarras.Focus();
                   
                    /*  if (d.ToString() == "Yes")
                      {
                          this.operacao = "alterar";
                          ModeloProduto modelo = new ModeloProduto();
                          modelo.ProCodBarras = txtCodBarras.Text;
                          modelo.ProNome = txtNome.Text;
                          modelo.ProDescricao = txtDescricao.Text;
                          modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                          modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                          modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                          modelo.UmedCod = Convert.ToInt32(cbUnd.SelectedValue);
                          modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                          modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);

                          modelo.CarregaImagem(this.foto);
                          modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                          bll.Alterar(modelo);
                          MessageBox.Show("Cadastro alterado");

                      }
                      */

                }
                else
                {
                    this.operacao = "inserir";
                   // txtCodBarras.Clear();
                   // txtCodBarras.Focus();
                }



            }
        }
    }

}






