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
   public class BLLContasAPagar
    {
        private DALConexao conexao;
        public BLLContasAPagar(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloContasAPagar modelo)
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

            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloContasAPagar modelo)
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

            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            DALobj.Incluir(modelo);
        }
        public void Excluir(ModeloContasAPagar modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra  é obrigatório");
            }
            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            DALobj.Excluir(modelo);
        }
        public void EfetuaPagamentoCompra(int comCod, int pcoCod, DateTime dtPagto)
        {
            if (dtPagto != null)
            {
                DALContasAPagar DALobj = new DALContasAPagar(conexao);
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

            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            DALobj.ExcluirTodasasParcelas(comCod);
        }
        public DataTable Localizar(int comcod)
        {

            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloContasAPagar CarregaModeloParcelasCompra(int pcocod, int comcod)
        {
            if (pcocod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            DALContasAPagar DALobj = new DALContasAPagar(conexao);
            return DALobj.CarregaModeloParcelasCompra(pcocod, comcod);
        }
    }
}
