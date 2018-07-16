﻿using BLL;
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
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else {
                dgvDados.DataSource = bll.LocalizarCPFCNPJ(txtValor.Text);
            }
            
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[0].HeaderText = "Código";

            dgvDados.Columns[1].Width = 250;
            dgvDados.Columns[1].HeaderText = "Nome";

            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[2].HeaderText = "CPF/CNPJ";

            dgvDados.Columns[3].Width = 150;
            dgvDados.Columns[3].HeaderText = "RG/IE";

            dgvDados.Columns[4].HeaderText = "Razão social";
            dgvDados.Columns[5].HeaderText = "Tipo";
            dgvDados.Columns[6].HeaderText = "Cep";
            dgvDados.Columns[7].HeaderText = "Endereço";
            dgvDados.Columns[8].HeaderText = "Bairro";

            
            dgvDados.Columns[9].HeaderText = "Fone";

            dgvDados.Columns[10].Width = 150;
            dgvDados.Columns[10].HeaderText = "Celular";
     
            dgvDados.Columns[11].Width = 250;
            dgvDados.Columns[11].HeaderText = "E-mail";

            dgvDados.Columns[12].HeaderText = "Numero";
            dgvDados.Columns[13].HeaderText = "Cidade";
            dgvDados.Columns[14].HeaderText = "Estado";

            dgvDados.Columns[13].Visible = false;
            dgvDados.Columns[12].Visible = false;
            dgvDados.Columns[14].Visible = false;
            dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[4].Visible = false;
           
            dgvDados.Columns[9].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[3].Visible = false;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
