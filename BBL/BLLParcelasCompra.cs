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
    public class BLLParcelasCompra
    {
        private DALConexao conexao;
        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra  é obrigatório");
            }
            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela  é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferios ao ano atual");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra  é obrigatório");
            }
            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela  é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferios ao ano atual");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra  é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }
        public void EfetuaPagamentoCompra(int comCod, int pcoCod, DateTime dtPagto)
        {
            if (dtPagto != null)
            {
                DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
                DALobj.EfetuaPagamentoCompra(comCod, pcoCod, dtPagto);
            }
            else
                throw new Exception("Data pagamento  é obrigatório");
        }

        public void ExcluirTodasAsParcelas(int comCod)
        {
            if (comCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirTodasasParcelas(comCod);
        }
        public DataTable Localizar(int comcod)
        {
            
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int pcocod, int comcod)
        {
            if (pcocod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(pcocod, comcod);
        }
    }
}