using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;





namespace GUI
{
    public partial class frmbackupBancoDeDados : Form
    {
        public frmbackupBancoDeDados()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;

                    string locaBackup = d.FileName;
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User ID=" + DadosDaConexao.usuario +
                        ";Password=" + DadosDaConexao.senha;

                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso");
                }
            }catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;

                    string locaBackup = d.FileName;
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User ID=" + DadosDaConexao.usuario +
                        ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
