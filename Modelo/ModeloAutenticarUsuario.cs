using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModeloAutenticarUsuario
    {
        //clitipo valor 0=pessoa fissica ,valor 1 juridica
        //contrutores
        public ModeloAutenticarUsuario()
        {
          
            this.AutLogin = "";
            this.AutSenha = "";
        }
        //construtor recebendo parametros
        public ModeloAutenticarUsuario( string login, string senha)
        {
            
            this.AutLogin = login;
            this.AutSenha = senha;
        }
        //propriedades da classe
        private string  aut_senha;
        public string AutSenha
        {
            get { return this.aut_senha; }
            set { this.aut_senha = value; }
        }
        private string aut_login;
        public string AutLogin
        {
            get { return this.aut_login; }
            set { this.aut_login = value; }
        }
       
        
    }
}
