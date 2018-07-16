using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.ProCodBarras.Trim().Length == 0)
            {
                throw new Exception("O código dde barras do produto é obrigatório");
            }
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            DALProduto DALmodelo = new DALProduto(conexao);
            DALmodelo.Incluir(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProduto DALmodelo = new DALProduto(conexao);
            DALmodelo.Excluir(codigo);
        }
        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProCodBarras.Trim().Length == 0)
            {
                throw new Exception("O código dde barras do produto é obrigatório");
            }
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória");
            }

            if (modelo.ProValorVenda < 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }
            if (modelo.ProValorPago < 0)
            {
                throw new Exception("O valor pago do produto é obrigatório");
            }
            if (modelo.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto deve ser maior ou igual a zero");
            }

            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DALProduto DALmodelo = new DALProduto(conexao);
            DALmodelo.Alterar(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALProduto DALmodelo = new DALProduto(conexao);
            return DALmodelo.Localizar(valor);
        }
        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALmodelo = new DALProduto(conexao);
            return DALmodelo.CarregaModeloProduto(codigo);
        }
        public ModeloProduto CarregaModeloProdutocodBarras(string codigobarras)
        {
            DALProduto DALmodelo = new DALProduto(conexao);
            return DALmodelo.CarregaModeloProdutoCodBarras(codigobarras);
        }
        public int VerificaCodBarrasDuplicado(String valor) //0 - não existe || numero > 0 existe
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.VerificaCodBarrasDuplicado(valor);
        }

    }
}
