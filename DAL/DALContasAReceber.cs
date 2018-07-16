using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class DALContasAReceber
    {
        private DALConexao conexao;
        public DALContasAReceber(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DALItensVenda DALItensVenda
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Incluir(ModeloContasAReceber modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelasvenda(pve_cod,ven_cod,pve_datavecto,pve_valor) values (@pve_cod,@ven_cod,@pve_datavecto,@pve_valor);";

            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
            if (modelo.PveDataVecto == null)
            {
                cmd.Parameters["@pve_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVecto;
            }
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //  conexao.Desconectar();
        }
        public void Alterar(ModeloContasAReceber modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelasvenda set pve_valor = @pve_valor,pve_datapagto = @pve_datapagto,pve_datavecto = @pve_datavecto " +
                "where pve_cod = @pve_cod and ven_cod = @ven_cod;";

            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);

            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.PveDataPagto == null)
            {
                cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datapagto"].Value = modelo.PveDataPagto;
            }
            cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVecto;

            // conexao.Conectar();
            cmd.ExecuteNonQuery();
            //  conexao.Desconectar();
        }
        public void Excluir(ModeloContasAReceber modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            // conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodasAsParcelas(int comcod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda where ven_cod = @ven_cod ;";
            cmd.Parameters.AddWithValue("@ven_cod", comcod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelasvenda where ven_cod = " +
                comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloContasAReceber CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            ModeloContasAReceber modelo = new ModeloContasAReceber();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select * from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod";
            cmd.Parameters.AddWithValue("@pve_cod", PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = PveCod;
                modelo.VenCod = VenCod;
                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
        public void EfetuaRecebimentoVenda(int venCod, int pveCod, DateTime dtRecebimento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "update parcelasvenda set pve_datapagto = @pve_datapagto " +
                "where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", pveCod);
            cmd.Parameters.AddWithValue("@ven_cod", venCod);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@pve_datapagto"].Value = dtRecebimento;
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
