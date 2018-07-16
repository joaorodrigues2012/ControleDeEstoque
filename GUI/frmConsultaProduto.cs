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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValorBusca.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].HeaderText = "Cód-Barras";
            dgvDados.Columns[1].Width = 120;
            dgvDados.Columns[2].HeaderText = "Produto";
            dgvDados.Columns[2].Width = 170;
            dgvDados.Columns[3].HeaderText = "Descrição";
            dgvDados.Columns[3].Width = 200;
           dgvDados.Columns[4].HeaderText = "Foto";
           dgvDados.Columns[4].Width = 10;
            dgvDados.Columns[5].HeaderText = "Valor Venda";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Valor Pago";
            dgvDados.Columns[6].Width = 80;
           
            dgvDados.Columns[7].HeaderText = "Qtde";
            dgvDados.Columns[7].Width = 80;
            dgvDados.Columns[8].HeaderText = "Unid_Medida";
            dgvDados.Columns[8].Width = 140;
            dgvDados.Columns[9].HeaderText = "Categoria";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "Sub_Categoria";
            dgvDados.Columns[10].Width = 100;



            //ocultar campos da Grid
          

            dgvDados.Columns["pro_foto"].Visible = false;
           // dgvDados.Columns["pro_valorpago"].Visible = true;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;

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
