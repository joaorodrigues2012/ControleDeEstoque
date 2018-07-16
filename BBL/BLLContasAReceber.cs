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
  public  class BLLContasAReceber
    {
        private DALConexao conexao;
        public BLLContasAReceber(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloContasAReceber modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda  é obrigatório");
            }
            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela  é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferios ao ano atual");
            }

            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloContasAReceber modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda  é obrigatório");
            }
            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela  é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferios ao ano atual");
            }

            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            DALobj.Incluir(modelo);
        }
        public void Excluir(ModeloContasAReceber modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda  é obrigatório");
            }
            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodasAsParcelas(int venCod)
        {
            if (venCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            DALobj.ExcluirTodasAsParcelas(venCod);
        }
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloContasAReceber CarregaModeloParcelasVenda(int pvecod, int vencod)
        {
            if (pvecod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (vencod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            DALContasAReceber DALobj = new DALContasAReceber(conexao);
            return DALobj.CarregaModeloParcelasVenda(pvecod, vencod);
        }
        public void EfetuaRecebimentoVenda(int venCod, int pveCod, DateTime dtRecebimento)
        {
            if (dtRecebimento != null)
            {
                DALContasAReceber DALobj = new DALContasAReceber(conexao);
                DALobj.EfetuaRecebimentoVenda(venCod, pveCod, dtRecebimento);
            }
            else
                throw new Exception("Data recebimento  é obrigatório");
        }
    }
}