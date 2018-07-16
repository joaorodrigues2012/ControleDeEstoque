using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {

         public static String servidor = @"DESKTOP-5P1B6CO";
       // public static String servidor = @"USER\SQLEXPRESS";
        public static String banco = "bd_tcc";
        public static String usuario = "sa";
        public static String senha = "zp/qsql";
        public static String StringDeConexao
        {
            get
            {
              return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
     
               //return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='E:\\FATEC\\FATEC\\DAIANE\\ControleDeEstoqueTCC\\DAL\\controle_tcc.mdf';Integrated Security=True;Connect Timeout=30";
                
            }
        }
    }
}
