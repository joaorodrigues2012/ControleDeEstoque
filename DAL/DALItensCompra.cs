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
    public class DALItensCompra
    {
        private DALConexao conexao;
        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DALCompra DALCompra
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into itenscompra(itc_cod,itc_qtde,itc_valor,com_cod,pro_cod) values (@itc_cod,@itc_qtde,@itc_valor,@com_cod,@pro_cod);";
                
            cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@itc_qtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@itc_valor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
           // conexao.Conectar();
            cmd.ExecuteNonQuery();
           // conexao.Desconectar();
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update itenscompra set itc_qtde=@itc_qtde,itc_valor=@itc_valor where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod; ";
            cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@itc_qtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@itc_valor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
           // conexao.Desconectar();
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from  itensCompra where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod; ";
            cmd.Parameters.AddWithValue("@itc_cod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        public void ExcluirTodosOsItens(int ComCod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from  itensCompra where  com_cod = @com_cod; ";
            
            cmd.Parameters.AddWithValue("@com_cod",ComCod);
           
           // conexao.Conectar();
            cmd.ExecuteNonQuery();
           // conexao.Desconectar();
        }


        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select i.com_cod,i.itc_cod,i.pro_cod,p.pro_nome,i.itc_qtde,i.itc_valor from itenscompra i inner join produto p on p.pro_cod = i.pro_cod where i.com_cod =" +
                comcod.ToString(),conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod,int ComCod,int ProCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itenscompra where itc_cod = @itc_cod and com_cod = @com_cod and pro_cod = @pro_cod; ";
            cmd.Parameters.AddWithValue("@itc_cod", ItcCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            cmd.Parameters.AddWithValue("@pro_cod", ProCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = ItcCod;
                modelo.ProCod = ProCod;
                modelo.ComCod = ComCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
