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
   public class BLLCompra
    {
        private DALConexao conexao;
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCompra modelo)
        {
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da  compra  é obrigatório");
            }
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor  é obrigatório");
            }
            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas  é obrigatório");
            }
            // if (modelo.ComData !=DateTime.Now)
            //    {
            //      throw new Exception("O valor da data não corresponde com a data atual");
            //     }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O valor do código  é obrigatório");
            }
            if (modelo.ComTotal<= 0)
            {
                throw new Exception("O valor da  compra  é obrigatório");
            }
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor  é obrigatório");
            }
            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas  é obrigatório");
            }

           // if (modelo.ComData !=DateTime.Now)
        //    {
          //      throw new Exception("O valor da data não corresponde com a data atual");
       //     }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(codigo);
        }
        public DataTable Localizar(String nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(nome);
        }
        public DataTable Localizar()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar();
        }
        public DataTable Localizar(DateTime dtinicial,DateTime dtfinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarPorParcelasEmAberto();
        }
        public int QauantidadeParcelasNaoPagas(int Codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.QauantidadeParcelasNaoPagas(Codigo);
        }
        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra    (conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}

