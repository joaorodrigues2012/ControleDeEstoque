using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        //clitipo valor 0=pessoa fissica ,valor 1 juridica
        //contrutores
        public ModeloUsuario()
        {
            this.UsuCod = 0;
            this.UsuNome = "";
            this.UsuSenha = "";
            this.UsuLogin = "";
            this.UsuTipo = "";
            this.UsuCep = "";
            this.UsuEndereco = "";
            this.UsuBairro = "";
            this.UsuFone = "";
            this.UsuCelular = "";
            this.UsuEmail = "";
            this.UsuEndNumero = "";
            this.UsuCidade = "";
            this.UsuEstado = "";
        }
        //construtor recebendo parametros
        public ModeloUsuario(int cod, string nome, string senha, string login, string tipo, string cep,
            string endereco, string bairro, string fone, string celular, string email, string endnumero,
            string cidade, string estado)
        {
            this.UsuCod = cod;
            this.UsuNome = nome;
            this.UsuSenha = senha;
            this.UsuLogin = login;
          
            this.UsuTipo = tipo;
            this.UsuCep = cep;
            this.UsuEndereco = endereco;
            this.UsuBairro = bairro;
            this.UsuFone = fone;
            this.UsuCelular = celular;
            this.UsuEmail = email;
            this.UsuEndNumero = endnumero;
            this.UsuCidade = cidade;
            this.UsuEstado = estado;
        }
        //propriedades da classe
        private int usu_cod;
        public int UsuCod
        {
            get { return this.usu_cod; }
            set { this.usu_cod = value; }
        }
        private string usu_nome;
        public string UsuNome
        {
            get { return this.usu_nome; }
            set { this.usu_nome = value; }
        }
        private string usu_senha;
        public string UsuSenha
        {
            get { return this.usu_senha; }
            set { this.usu_senha = value; }
        }
        private string usu_login;
        public string UsuLogin
        {
            get { return this.usu_login; }
            set { this.usu_login = value; }
        }
       
        private string usu_tipo;
        public string UsuTipo
        {
            get { return this.usu_tipo; }
            set { this.usu_tipo = value; }
        }
        private string usu_cep;
        public string UsuCep
        {
            get { return this.usu_cep; }
            set { this.usu_cep = value; }
        }
        private string usu_endereco;
        public string UsuEndereco
        {
            get { return this.usu_endereco; }
            set { this.usu_endereco = value; }
        }
        private string usu_bairro;
        public string UsuBairro
        {
            get { return this.usu_bairro; }
            set { this.usu_bairro = value; }
        }
        private string usu_fone;
        public string UsuFone
        {
            get { return this.usu_fone; }
            set { this.usu_fone = value; }
        }
        private string usu_cel;
        public string UsuCelular
        {
            get { return this.usu_cel; }
            set { this.usu_cel = value; }
        }
        private string usu_email;
        public string UsuEmail
        {
            get { return this.usu_email; }
            set { this.usu_email = value; }
        }
        private string usu_ennumero;
        public string UsuEndNumero
        {
            get { return this.usu_ennumero; }
            set { this.usu_ennumero = value; }
        }
        private string usu_cidade;
        public string UsuCidade
        {
            get { return this.usu_cidade; }
            set { this.usu_cidade = value; }
        }
        private string usu_estado;
        public string UsuEstado
        {
            get { return this.usu_estado; }
            set { this.usu_estado = value; }
        }
    }
}
