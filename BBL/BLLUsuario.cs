using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Usuario é obrigatório");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("O CPF ou CNPJ do Usuario é obrigatório");
            }
           // if (modelo.UsuTipo == "Física")
          //  {
            //    if (Validacao.IsCpf(modelo.UsuCpfCnpj) == false)
              //  {
               //     throw new Exception("O CPF está Invalido");
              //  }
          //  }
         //   else
        //    {
           //     if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
            //    {
              //      throw new Exception("O CNPJ está Invalido");
             //   }
           // }
            //vereificar cpf cnpj
            if (modelo.UsuLogin.Trim().Length == 0)
            {
                throw new Exception("O Login é obrigatório");
            }
            if (modelo.UsuFone.Trim().Length == 0)
            {
                throw new Exception("O fone  é obrigatório");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatório");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Usuario é obrigatório");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuario é obrigatório");
            }
            //vereificar cpf cnpj
            if (modelo.UsuLogin.Trim().Length == 0)
            {
                throw new Exception("O Login do é obrigatório");
            }
            if (modelo.UsuFone.Trim().Length == 0)
            {
                throw new Exception("O fone do Usuario é obrigatório");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatório");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);
        }
        public void Autenticar(ModeloUsuario modelo)
        {
            
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Autenticar(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorNome(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorTipo(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarPorTipo(valor);
        }
        public int VerificaLoginDuplicado(String valor) //0 - não existe || numero > 0 existe
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.VerificaLoginDuplicado(valor);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }
        public ModeloUsuario CarregaModeloUsuario(string cpfcnpj)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(cpfcnpj);
        }
        public DataTable LocalizarPorUsuario(int usuario)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarPorUsuario(usuario);
        }
        public DataTable LocalizarUs(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarUs(valor);
        }

    }
}
