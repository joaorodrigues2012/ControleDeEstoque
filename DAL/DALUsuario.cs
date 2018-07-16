using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        public bool aut;
        private DALConexao conexao;
        public string cargo;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(usu_nome,usu_senha,usu_login,usu_tipo," +
                "usu_cep,usu_endereco,usu_bairro,usu_fone,usu_cel,usu_email,usu_endnumero," +
                "usu_cidade,usu_estado) values (@usu_nome,@usu_senha,@usu_login,@usu_tipo," +
                "@usu_cep,@usu_endereco,@usu_bairro,@usu_fone,@usu_cel,@usu_email,@usu_endnumero," +
                "@usu_cidade,@usu_estado); select @@IDENTITY";

            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_tipo", modelo.UsuTipo);
            cmd.Parameters.AddWithValue("@usu_cep", modelo.UsuCep);
            cmd.Parameters.AddWithValue("@usu_endereco", modelo.UsuEndereco);
            cmd.Parameters.AddWithValue("@usu_bairro", modelo.UsuBairro);
            cmd.Parameters.AddWithValue("@usu_fone", modelo.UsuFone);
            cmd.Parameters.AddWithValue("@usu_cel", modelo.UsuCelular);
            cmd.Parameters.AddWithValue("@usu_email", modelo.UsuEmail);
            cmd.Parameters.AddWithValue("@usu_endnumero", modelo.UsuEndNumero);
            cmd.Parameters.AddWithValue("@usu_cidade", modelo.UsuCidade);
            cmd.Parameters.AddWithValue("@usu_estado", modelo.UsuEstado);
            conexao.Conectar();
            modelo.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set usu_nome = @usu_nome,usu_senha = @usu_senha,usu_login = @usu_login,usu_tipo = @usu_tipo," +
                "usu_cep = @usu_cep,usu_endereco = @usu_endereco,usu_bairro = @usu_bairro,usu_fone = @usu_fone,usu_cel = @usu_cel,usu_email = @usu_email,usu_endnumero = @usu_endnumero," +
                "usu_cidade = @usu_cidade,usu_estado = @usu_estado where usu_cod = @codigo";

            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_tipo", modelo.UsuTipo);
            cmd.Parameters.AddWithValue("@usu_cep", modelo.UsuCep);
            cmd.Parameters.AddWithValue("@usu_endereco", modelo.UsuEndereco);
            cmd.Parameters.AddWithValue("@usu_bairro", modelo.UsuBairro);
            cmd.Parameters.AddWithValue("@usu_fone", modelo.UsuFone);
            cmd.Parameters.AddWithValue("@usu_cel", modelo.UsuCelular);
            cmd.Parameters.AddWithValue("@usu_email", modelo.UsuEmail);
            cmd.Parameters.AddWithValue("@usu_endnumero", modelo.UsuEndNumero);
            cmd.Parameters.AddWithValue("@usu_cidade", modelo.UsuCidade);
            cmd.Parameters.AddWithValue("@usu_estado", modelo.UsuEstado);
            cmd.Parameters.AddWithValue("@codigo", modelo.UsuCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();


        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNome(String valor)
        {

            return Localizar(valor);
        }
        public DataTable LocalizarPorTipo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_tipo like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuTipo = Convert.ToString(registro["usu_tipo"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
                modelo.UsuLogin = Convert.ToString(registro["usu_login"]);
                modelo.UsuCep = Convert.ToString(registro["usu_cep"]);
                modelo.UsuEstado = Convert.ToString(registro["usu_estado"]);
                modelo.UsuCidade = Convert.ToString(registro["usu_cidade"]);
                modelo.UsuEndereco = Convert.ToString(registro["usu_endereco"]);
                modelo.UsuBairro = Convert.ToString(registro["usu_bairro"]);
                modelo.UsuFone = Convert.ToString(registro["usu_fone"]);
                modelo.UsuCelular = Convert.ToString(registro["usu_cel"]);
                modelo.UsuEmail = Convert.ToString(registro["usu_email"]);
                modelo.UsuEndNumero = Convert.ToString(registro["usu_endnumero"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }



        public int VerificaLoginDuplicado(String valor) //0 - não existe || numero > 0 existe
        {
            int r = 0; //0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_login = @usu_login";
            cmd.Parameters.AddWithValue("@usu_login", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["usu_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public void Autenticar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_senha = @usu_senha and usu_login = @usu_login and usu_tipo = @usu_tipo";

            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_tipo", modelo.UsuTipo);

            conexao.Conectar();
            modelo.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());


            conexao.Desconectar();
        }
        public DataTable LocalizarPorUsuario(int usuario)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario  where usu_cod = " +
                usuario.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloUsuario CarregaModeloUsuario(string tipo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_tipo = @usu_tipo";
            cmd.Parameters.AddWithValue("@usu_tipo", tipo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuTipo = Convert.ToString(registro["usu_tipo"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
                modelo.UsuLogin = Convert.ToString(registro["usu_login"]);
                modelo.UsuCep = Convert.ToString(registro["usu_cep"]);
                modelo.UsuEstado = Convert.ToString(registro["usu_estado"]);
                modelo.UsuCidade = Convert.ToString(registro["usu_cidade"]);
                modelo.UsuEndereco = Convert.ToString(registro["usu_endereco"]);
                modelo.UsuBairro = Convert.ToString(registro["usu_bairro"]);
                modelo.UsuFone = Convert.ToString(registro["usu_fone"]);
                modelo.UsuCelular = Convert.ToString(registro["usu_cel"]);
                modelo.UsuEmail = Convert.ToString(registro["usu_email"]);
                modelo.UsuEndNumero = Convert.ToString(registro["usu_endnumero"]);


            }
            conexao.Desconectar();
            return modelo;

        }
        public DataTable LocalizarUs(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select usu_tipo,usu_cod from usuario where usu_login like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
