using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLVenda
    {
        private DALConexao conexao;
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor total da  venda  é obrigatório");
            }
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente  é obrigatório");
            }
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas  é obrigatório");
            }
            if (modelo.VenNFiscal <= 0)
            {
                throw new Exception("O numero da nota fiscal e obrigatorio");
            }

            DALVendas DALobj = new DALVendas(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor total da  venda  é obrigatório");
            }
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente  é obrigatório");
            }
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas  é obrigatório");
            }
            if (modelo.VenNFiscal <= 0)
            {
                throw new Exception("O numero da nota fiscal e obrigatorio");
            }

            DALVendas DALobj = new DALVendas(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {

            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O valor do codigo é obrigatório");
                }
                DALVendas DALobj = new DALVendas(conexao);
                DALobj.Excluir(codigo);
            }
            catch
            {
                MessageBox.Show("Erro local BLL.");

            }


        }
        public Boolean CancelarVenda(int codigo)
        {

            if (codigo <= 0)
            {
                throw new Exception("O valor do codigo é obrigatório");
            }
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.CancelarVenda(codigo);
        }
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.LocalizarPorParcelasEmAberto();
        }
        public int QauantidadeParcelasNaoPagas(int Codigo)
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.QauantidadeParcelasNaoPagas(Codigo);
        }
        /* public int QauantidadeParcelasNaoPagas(int codigo)
         {
             if (codigo <= 0)
             {
                 throw new Exception("O valor do codigo é obrigatório");
             }
             DALVendas DALobj = new DALVendas(conexao);
             return DALobj.QauantidadeParcelasNaoPagas(codigo);
         }*/
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }



        public DataTable Localizar(int codigo)
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.Localizar(codigo);
        }
        public DataTable Localizar(String nome)
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.Localizar(nome);
        }
        public DataTable Localizar()
        {
            DALVendas DALobj = new DALVendas(conexao);
            return DALobj.Localizar();
        }

    }
}
