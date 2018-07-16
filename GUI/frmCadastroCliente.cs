using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferramentas;
using Modelo;
using DAL;
using BLL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtCelular.Mask = "(00)00000,00,00";
            txtTelefone.Mask = "(00)0000,00,00";
            txtNome.Focus();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep1.Clear();
            txtCidade.Clear();
            txtCpfCnpj.Clear();
            txtEstado.Clear();
            txtNumero.Clear();
            txtRsocial.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtRgIe.Clear();
            txtEmail.Clear();
            lbCpfCnpj.Text = "";
            
            rbFisica.Checked = true;


        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {



            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                if (modelo.CliTipo == "Física")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtNome.Text = modelo.CliNome;
                txtRsocial.Text = modelo.CliRSocial;
                txtCpfCnpj.Text = modelo.CliCpfCnpj;
                txtRgIe.Text = modelo.CliRgIe;
                txtCep1.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtEmail.Text = modelo.CliEmail;
                txtTelefone.Text = modelo.CliFone;
                txtCelular.Text = modelo.CliCelular;

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
            this.operacao = "alterar";
            this.alteraBotoes(2);
           
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
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

        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                //leitura dos dados
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliCpfCnpj = txtCpfCnpj.Text;
                modelo.CliRgIe = txtRgIe.Text;
                //modelo.CliRSocial = txtRsocial.Text;
                modelo.CliCep = txtCep1.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliFone = txtTelefone.Text;
                modelo.CliCelular = txtCelular.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliRSocial = txtRsocial.Text;
                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física";
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "jurídica";
                }
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            txtNome.Focus();
            
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lbRsocial.Visible = false;
                txtRsocial.Visible = false;
                lbCpfCnpj.Text = "CPF";
                lbRgIe.Text = "RG";
                txtCpfCnpj.Mask = "000,000,000-00";
            }
            else
            {
                lbRsocial.Visible = true;
                txtRsocial.Visible = true;
                lbCpfCnpj.Text = "CNPJ";
                lbRgIe.Text = "IE";
                txtCpfCnpj.Mask = "00,000,000,0000-00";
                if (operacao == "alterar")
                {
                    txtCpfCnpj.Clear();
                    txtRgIe.Clear();
                    txtCpfCnpj.Focus();
                }
            }
        }

        
        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            lbValorInvalidoCPF.Visible = false;
            if (rbFisica.Checked == true)
            {
                if (Validacao.IsCpf(txtCpfCnpj.Text) == false)
                {
                    lbValorInvalidoCPF.Visible = true;
                }
            }
            else
            {
                if (Validacao.IsCnpj(txtCpfCnpj.Text) == false)
                {
                    lbValorInvalidoCPF.Visible = true;
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
              
            }
            else
            {
               MessageBox.Show ("Email Inválido!");
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void txtCep1_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCep1.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtRua.Text = BuscaEndereco.endereco;
            }
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }
        /* public static string MascaraCnpjCpf(string pCnpjCpf)
{
string result = "";
if (pCnpjCpf.Length == 14)
{
result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
}
if (pCnpjCpf.Length == 11)
{
result = pCnpjCpf.Insert(3,".").Insert(7, ".").Insert(11, "-");
}
if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
{
result = pCnpjCpf;
}
return result;
}
private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
{
if (rbFisica.Checked == false)
{
MascaraCnpjCpf(txtCpfCnpj.Text);
}
}*/
    }
}
