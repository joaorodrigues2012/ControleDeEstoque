﻿using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt",false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!!!");

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
              

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica conexão com banco
              //  StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
               
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso");

            }

            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao conectar com banco \n Verifique os dados informados");

            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }

        }
    }
}
