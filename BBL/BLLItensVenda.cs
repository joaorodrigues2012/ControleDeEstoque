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
   public class BLLItensVenda
    {
        private DALConexao conexao;
        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("A valor deve ser maior que zero");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("A valor deve ser maior que zero");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O c´digo do produto é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();


            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodosOsItens(int vencod)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            DALobj.ExcluirTodosOsItens(vencod);
        }
        public DataTable Localizar(int vencod)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.Localizar(vencod);
        }
        public ModeloItensVenda CarregaModeloItensCompra(int ItcCod, int VenCod, int ProCod)
        {
            DALItensVenda DALobj = new DALItensVenda(conexao);
            return DALobj.CarregaModeloItensVenda(ItcCod, VenCod, ProCod);
        }
    }
}
