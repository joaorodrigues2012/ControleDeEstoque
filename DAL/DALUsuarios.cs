using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuarios
    {
        private DALConexao conexao;
       
        public DALUsuarios(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuarios modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuarios(usu_nome,usu_login,usu_grupo,usu_senha) values "+
                "(@usu_nome,@usu_login,@usu_grupo,@usu_senha); select @@IDENTITY";

            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
           
            conexao.Conectar();
            modelo.UsuId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuarios modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuarios set usu_nome = @usu_nome,usu_login = @usu_login,usu_grupo = @usu_grupo,usu_senha = @usu_senha," +
               " where usu_id = @codigo";

            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@codigo", modelo.UsuId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();


        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuarios where usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
