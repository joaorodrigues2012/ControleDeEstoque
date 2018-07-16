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
    public class BLLParcelasVenda
    {
        private DALConexao conexao;
        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVendas modelo)
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

            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasVendas modelo)
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

            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            DALobj.Incluir(modelo);
        }
        public void Excluir(ModeloParcelasVendas modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda  é obrigatório");
            }
            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodasAsParcelas(int venCod)
        {
            if (venCod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            DALobj.ExcluirTodasAsParcelas(venCod);
        }
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }

            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloParcelasVendas CarregaModeloParcelasVenda(int pvecod, int vencod)
        {
            if (pvecod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (vencod <= 0)
            {
                throw new Exception("O código da parcela  é obrigatório");
            }
            DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
            return DALobj.CarregaModeloParcelasVenda(pvecod, vencod);
        }
        public void EfetuaRecebimentoVenda(int venCod, int pveCod, DateTime dtRecebimento)
        {
            if (dtRecebimento != null)
            {
                DALParcelasVendas DALobj = new DALParcelasVendas(conexao);
                DALobj.EfetuaRecebimentoVenda(venCod, pveCod, dtRecebimento);
            }
            else
                throw new Exception("Data recebimento  é obrigatório");
        }
    }
}