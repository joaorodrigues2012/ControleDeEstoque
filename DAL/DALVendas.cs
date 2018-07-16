﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVendas
    {
        private DALConexao conexao;
        public DALVendas(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda(ven_data,ven_nfiscal,ven_total,ven_nparcelas,ven_status,cli_cod,tpa_cod,ven_avista)" +
            "values (@ven_data,@ven_nfiscal,@ven_total,@ven_nparcelas,@ven_status,@cli_cod,@tpa_cod,@ven_avista); select @@IDENTITY;";

            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@ven_data"].Value = modelo.VenData;
            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);

            // conexao.Conectar();
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            // conexao.Desconectar();
        }

        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set ven_data=@ven_data,ven_nfiscal=@ven_nfiscal,ven_total=@ven_total,ven_nparcelas=@ven_nparcelas," +
                "ven_status=@ven_status,cli_cod=@cli_cod,tpa_cod=@tpa_cod,ven_avista=@ven_avista" +
                " where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.VenCod);
            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@ven_data"].Value = modelo.VenData;
            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //  conexao.Desconectar();
        }
        public Boolean CancelarVenda(int codigo)
        {//atuazizando a tabela de venda
            Boolean retorno = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.Iniciatransacao();
            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_status='cancelada' where ven_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                //substituir para o metodo DalItenVenda
                //incrementar o estoque com os itens da venda cancelado
                //localizar os itens da venda
                DataTable tabela = new DataTable();
               
                SqlDataAdapter da = new SqlDataAdapter("Select itv_cod,pro_cod,itv_qtde from itensvenda  where ven_cod =" +
                    codigo.ToString(), conexao.StringConexao);
                da.Fill(tabela);
               // da.Dispose();
                //alterar a qtde do estoque
                ModeloProduto produto;
              //  DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DALProduto dalProduto = new DALProduto(conexao);


                //percorrendo a tabela a preenchendo 
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]),true);
                    produto.ProQtde = produto.ProQtde + Convert.ToDouble(tabela.Rows[i]["itv_qtde"]);
                    dalProduto.Alterar(produto,true);
                }
                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch {
                conexao.CancelarTransacao();
                conexao.Desconectar();
                retorno = false;
            }

            return retorno;
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from venda where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        //implemetar o cancelar venda.

        //localizando pelo codigo do cliente
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            //  SqlDataAdapter da = new SqlDataAdapter("Select * from venpra where for_cod = "+codigo.ToString(), conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_data,v.ven_nfiscal," +
                         "v.ven_nparcelas,c.cli_nome,v.ven_status,v.cli_cod,v.tpa_cod,v.ven_avista,v.ven_total" +
                " from  venda v inner join cliente c on v.cli_cod = c.cli_cod" +
                " where c.cli_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //localizando cliente por nome
        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_data,v.ven_nfiscal," +
                         "v.ven_avista,v.ven_nparcelas,c.cli_nome,v.ven_status,v.cli_cod,v.tpa_cod,v.ven_total" +
                " from  venda v inner join cliente c on v.cli_cod = c.cli_cod" +
                 " where c.cli_nome = like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //lista 
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select v.ven_cod, v.ven_data,v.ven_nfiscal," +
                        "v.ven_nparcelas,c.cli_nome,v.ven_status,v.cli_cod,v.tpa_cod,v.ven_avista,v.ven_total" +
               " from  venda v inner join cliente c on v.cli_cod = c.cli_cod", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorParcelasEmAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select distinct v.ven_cod, v.ven_data,v.ven_nfiscal," +
                        "v.ven_avista,v.ven_nparcelas,c.cli_nome,v.ven_status,v.cli_cod,v.tpa_cod,v.ven_total" +
               " from  venda v inner join cliente c on v.cli_cod = c.cli_cod " +
               "inner join parcelasvenda p on v.ven_cod = p.ven_cod where p.pve_datapagto is NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //localiza as parcelas que ainda não foram pagas
        public int QauantidadeParcelasNaoPagas(int Codigo)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select count(ven_cod) from parcelasvenda where ven_cod = @ven_cod and pve_datapagto is NULL";
            cmd.Parameters.AddWithValue("@ven_cod", Codigo);
            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return qtde;
        }
        //localizando cliente por data
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //criamos um venando
            cmd.CommandText = "Select v.ven_cod, v.ven_data,v.ven_nfiscal," +
                        "v.ven_nparcelas,c.cli_nome,v.ven_status,v.cli_cod,v.tpa_cod,v.ven_avista,v.ven_total" +
               " from  venda v inner join cliente c on v.cli_cod = c.cli_cod" +
              " where v.ven_data BETWEEN @dtinicial and @dtfinal";
            //definição dos parametros deste venando
            cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicial"].Value = dtinicial;

            cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfinal"].Value = dtfinal;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
        //faz uma busca trazendo os dados referente as vendas
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda  where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNFiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNParcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]); ;
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]); ;
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
