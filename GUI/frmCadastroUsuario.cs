using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            txtNome.Focus();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtCelular.Mask = "(00)00000,00,00";
            txtTelefone.Mask = "(00)0000,00,00";
            txtNome.Focus();

            txtNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep1.Clear();
            txtCidade.Clear();
            txtSenha.Clear();
            txtEstado.Clear();
            txtNumero.Clear();
            txtLogin.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtLogin.Clear();
            txtEmail.Clear();
            lbSenha.Text = "";

            rbAdministrador.Checked = true;
            txtNome.Focus();


        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome = txtNome.Text;
                modelo.UsuSenha = txtSenha.Text;
                modelo.UsuLogin = txtLogin.Text;
                //modelo.UsuRSocial = txtRsocial.Text;
                modelo.UsuCep = txtCep1.Text;
                modelo.UsuEndereco = txtRua.Text;
                modelo.UsuBairro = txtBairro.Text;
                modelo.UsuFone = txtTelefone.Text;
                modelo.UsuCelular = txtCelular.Text;
                modelo.UsuEmail = txtEmail.Text;
                modelo.UsuEndNumero = txtNumero.Text;
                modelo.UsuCidade = txtCidade.Text;
                modelo.UsuEstado = txtEstado.Text;

                if (rbAdministrador.Checked == true)
                {
                    modelo.UsuTipo = "Administrador";

                }
                else
                {
                    modelo.UsuTipo = "Funcionario";
                }
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar um usuario
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UsuCod.ToString());

                }
                else
                {
                    //alterar um usuario
                    modelo.UsuCod = Convert.ToInt32(txtCodigo.Text);
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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txtCodigo.Text = modelo.UsuCod.ToString();
                if (modelo.UsuTipo == "Administrador")
                {
                    rbAdministrador.Checked = true;
                }
                else
                {
                    rbFuncionario.Checked = true;
                }
                txtNome.Text = modelo.UsuNome;

                txtLogin.Text = modelo.UsuLogin;
                txtSenha.Text = modelo.UsuSenha;
                txtCep1.Text = modelo.UsuCep;
                txtEstado.Text = modelo.UsuEstado;
                txtCidade.Text = modelo.UsuCidade;
                txtRua.Text = modelo.UsuEndereco;
                txtNumero.Text = modelo.UsuEndNumero;
                txtBairro.Text = modelo.UsuBairro;
                txtEmail.Text = modelo.UsuEmail;
                txtTelefone.Text = modelo.UsuFone;
                txtCelular.Text = modelo.UsuCelular;

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
           
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {

            }
            else
            {
                MessageBox.Show("Email Inválido!");
                txtEmail.Clear();
               // txtEmail.Focus();
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

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                r = bll.VerificaLoginDuplicado(txtLogin.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("ja existe um registro com este valor?", "deseja alterar o registro", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUsuario modelo = bll.CarregaModeloUsuario(r);
                        txtCodigo.Text =modelo.UsuCod.ToString();
                        txtNome.Text = modelo.UsuNome;
                        txtSenha.Text = modelo.UsuSenha;
                        txtLogin.Text = modelo.UsuLogin;

                        if (modelo.UsuTipo == "Administrador")
                        {
                            rbAdministrador.Checked = true;
                        }


                        else
                        {
                            if (modelo.UsuTipo == "Funcionario")
                            {
                                rbFuncionario.Checked = true;
                            }
                           
                        }
                        txtCep1.Text = modelo.UsuCep;
                        txtEstado.Text = modelo.UsuEstado;
                        txtCidade.Text = modelo.UsuCidade;
                        txtRua.Text = modelo.UsuEndereco;
                        txtNumero.Text = modelo.UsuEndNumero;
                        txtBairro.Text = modelo.UsuBairro;
                        txtEmail.Text = modelo.UsuEmail;
                        txtTelefone.Text = modelo.UsuFone;
                        txtCelular.Text = modelo.UsuCelular;
                    }
                }

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            this.operacao = "alterar";
            this.alteraBotoes(2);
        }
    }
}
