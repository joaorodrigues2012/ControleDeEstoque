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
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 290;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 700;
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
           /* btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 290;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 700;
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text == "")

            {
                MessageBox.Show("Digite algo para pesquizar");
                foreach (DataGridViewRow row in dgvDados.Rows)
                    if (!row.IsNewRow) dgvDados.Rows.Remove(row);
            }
            else
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                dgvDados.DataSource = bll.Localizar(txtValor.Text);

                dgvDados.Columns[0].HeaderText = "Código";
                dgvDados.Columns[0].Width = 290;
                dgvDados.Columns[1].HeaderText = "Categoria";
                dgvDados.Columns[1].Width = 700;
            }
        }
    }
}
