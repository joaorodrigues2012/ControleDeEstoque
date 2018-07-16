using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaUsuario : Form
    {
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        private void btLocalizar_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorTipo(txtValor.Text);
            }
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[0].HeaderText = "Código";

            dgvDados.Columns[1].Width = 250;
            dgvDados.Columns[1].HeaderText = "Nome";

            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[2].HeaderText = "Senha";

            dgvDados.Columns[3].HeaderText = "Login";
            dgvDados.Columns[4].HeaderText = "Tipo";
            dgvDados.Columns[5].HeaderText = "Cep";
            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[7].HeaderText = "Bairro";
            dgvDados.Columns[8].HeaderText = "Fone";
            dgvDados.Columns[9].HeaderText = "Celular";

            dgvDados.Columns[10].HeaderText = "E_mail";
            dgvDados.Columns[10].Width = 150;

            dgvDados.Columns[11].HeaderText = "Numero";

            dgvDados.Columns[12].Width = 250;
            dgvDados.Columns[12].HeaderText = "Cidade";

            dgvDados.Columns[13].HeaderText = "Estado";
           

           
           // dgvDados.Columns[12].Visible = false;
          
           /*dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[4].Visible = false;

            dgvDados.Columns[9].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[3].Visible = false;
            */
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
