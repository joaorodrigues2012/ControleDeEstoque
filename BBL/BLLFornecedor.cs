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
    public class BLLFornecedor
    {
        private DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
           // if (Validacao.IsCnpj(modelo.ForCnpj) == false)
          //  {
             //   throw new Exception("O CNPJ está Invalido");
          //  }

            //vereificar cnpj
            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório");
            }
            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O fone do fornecedor é obrigatório");
            }
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
            //vereificar cpf cnpj
           // if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            //{
            //    throw new Exception("O CNPJ está Invalido");
          //  }
            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório");
            }
            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O fone do fornecedor é obrigatório");
            }
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }
        public DataTable LocalizarCPFCNPJ(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }
        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }
        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }
    }
}
