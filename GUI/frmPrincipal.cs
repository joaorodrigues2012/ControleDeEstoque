using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
using Modelo;
using BLL;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public static frmPrincipal mdiobj;

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçaoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }
        public void DesabilitaMenu()
        {
            menuCadastro.Enabled = false;
            menuConsulta.Enabled = false;
            menuRelatorio.Enabled = false;
            menuMovimentacao.Enabled = false;
            menuFerramentas.Enabled = false;
            menuSobre.Enabled = false;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DesabilitaMenu();


            try
            {
                //verifica conexão com banco
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }

            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao conectar com banco \n Acesse as configurações do banco e informe os parametros");

            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }




        }

        private void bekupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbackupBancoDeDados f = new frmbackupBancoDeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre f = new frmSobre();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra f = new frmMovimentacaoCompra();
            f.ShowDialog();
            f.Dispose();

        }

        private void oCmpraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relItensDasCompras f = new relItensDasCompras();
            f.ShowDialog();
            f.Dispose();


        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra f = new frmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();

        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVendass f = new frmMovimentacaoVendass();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColsultaVenda f = new frmColsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCompras f = new relCompras();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebimentoDeVenda f = new frmRecebimentoDeVenda();
            f.ShowDialog();
            f.Dispose();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            modelo.UsuLogin = txtlogin.Text;
            modelo.UsuSenha = txtSenha.Text;
            modelo.UsuTipo = cbTipo.Text;
            int r = 0;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
           
            bll.Autenticar(modelo);
            string usulogado = modelo.UsuTipo;
           // BLLUsuario sbll = new BLLUsuario(cx);
           // cbTipo.DataSource = sbll.LocalizarPorUsuario((int)cbTipo.SelectedValue);
            //cbTipo.DisplayMember = "usu_tipo";
          //  cbTipo.ValueMember = "usu_cod";
            if (modelo.UsuCod == 0)
            {
                MessageBox.Show("Login Invalido: Código ");
                pnLogar.Visible = true;
            }
            else
            {
                MessageBox.Show("Você esta logado como:\n " + usulogado);

                pnLogar.Visible = false;
                if (modelo.UsuTipo == "Administrador")
                {
                    menuCadastro.Enabled = true;
                    menuConsulta.Enabled = true;
                    menuRelatorio.Enabled = true;
                    menuMovimentacao.Enabled = true;
                    menuFerramentas.Enabled = true;
                    menuSobre.Enabled = true;
                    sairToolStripMenuItem.Enabled = true;
                    menuCadUsuarios.Enabled = true;
                    contasAPagarToolStripMenuItem.Enabled = true;
                    contasAReceberToolStripMenuItem.Enabled = true;
                    // comprasToolStripMenuItem.Enabled = false;


                }
                else
                {
                    if (modelo.UsuTipo == "Funcionario")
                    {
                        menuCadastro.Enabled = true;
                        menuConsulta.Enabled = true;
                        menuRelatorio.Enabled = true;
                        contasAPagarToolStripMenuItem.Enabled = false;
                        contasAReceberToolStripMenuItem.Enabled = false;
                        menuMovimentacao.Enabled = true;
                        menuFerramentas.Enabled = false;
                        menuSobre.Enabled = true;
                        menuCadUsuarios.Enabled = false;
                        sairToolStripMenuItem.Enabled = true;
                        comprasToolStripMenuItem.Enabled = true;


                    }
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja realmente sair do SISCOM?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
                this.Close();
            
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relVendas f = new relVendas();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rel_Clieentes f = new rel_Clieentes();
            f.ShowDialog();
            f.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Trocar de ususário?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                pnLogar.Visible = true;
                txtlogin.Clear();
                txtSenha.Clear();
                DesabilitaMenu();
            }
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario sbll = new BLLUsuario(cx);
            cbTipo.DataSource = sbll.LocalizarUs("");
            cbTipo.DisplayMember = "usu_tipo";
            cbTipo.ValueMember = "usu_cod";


            
        }

        

        private void maisVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             relProdMaisVendido f = new relProdMaisVendido();
            f.ShowDialog();
            f.Dispose();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relProdutos f = new relProdutos();
            f.ShowDialog();
            f.Dispose();
        }

        private void itensSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relItensDasCompras f = new relItensDasCompras();
            f.ShowDialog();
            f.Dispose();
        }

        private void itensDaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relItensDasVendas f = new relItensDasVendas();
            f.ShowDialog();
            f.Dispose();
        }

        private void aReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_ContasPagas f = new rel_ContasPagas();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_ContaAPagar f = new rel_ContaAPagar();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_ContasRecebidas f = new rel_ContasRecebidas();
            f.ShowDialog();
            f.Dispose();
        }

        private void aReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rel_ContaAReceber f = new rel_ContaAReceber();
            f.ShowDialog();
            f.Dispose();
        }

        private void listagemDasVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relVendas f = new relVendas();
            f.ShowDialog();
            f.Dispose();
        }

        private void listaDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCompras f = new relCompras();
            f.ShowDialog();
            f.Dispose();
        }

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
