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
    public class DALParcelasCompra
    {
        private DALConexao conexao;
        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DALItensCompra DALItensCompra
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelascompra(pco_cod,com_cod,pco_datavecto,pco_valor) values (@pco_cod,@com_cod,@pco_datavecto,@pco_valor);";

            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pco_datavecto", System.Data.SqlDbType.Date);
            if (modelo.PcoDataVecto == null)
            {
                cmd.Parameters["@pco_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDataVecto;
            }
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            // conexao.Desconectar();
        }
        public void EfetuaPagamentoCompra(int comCod, int pcoCod, DateTime dtPagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "update parcelascompra set pco_datapagto = @pco_datapagto " +
                "where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", pcoCod);
            cmd.Parameters.AddWithValue("@com_cod", comCod);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@pco_datapagto"].Value = dtPagto;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelascompra set pco_valor = @pco_valor,pco_datapagto = @pco_datapagto,pco_datavecto = @pco_datavecto " +
                "where pco_cod = @pco_cod and com_cod = @com_cod;";

            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pco_datavecto", System.Data.SqlDbType.Date);

            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.PcoDataPagto == null)
            {
                cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDataPagto;
            }
            cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDataVecto;

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            // conexao.Desconectar();
        }

        public void ExcluirTodasasParcelas(int comcod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra where com_cod = @com_cod ;";
            cmd.Parameters.AddWithValue("@com_cod", comcod);

            // conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelascompra where com_cod = " +
                comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelascompra where pco_cod = @pco_cod and com_cod = @com_cod";
            cmd.Parameters.AddWithValue("@pco_cod", PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = PcoCod;
                modelo.ComCod = ComCod;
                modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
                modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}



