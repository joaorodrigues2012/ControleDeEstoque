namespace GUI
{
    partial class frmColsultaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tbParcelas = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPFinal = new System.Windows.Forms.DateTimePicker();
            this.dtPInicial = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.pnCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tbParcelas.SuspendLayout();
            this.pnData.SuspendLayout();
            this.pnCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(0, 0);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(1028, 375);
            this.dgvParcelas.TabIndex = 13;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(0, 2);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(1029, 375);
            this.dgvItens.TabIndex = 13;
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.dgvDados);
            this.tpVenda.Location = new System.Drawing.Point(4, 32);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(1031, 339);
            this.tpVenda.TabIndex = 0;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(1, 0);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1030, 375);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 32);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(1031, 339);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da venda";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpVenda);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tbParcelas);
            this.tbcDados.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.tbcDados.Location = new System.Drawing.Point(32, 317);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(1039, 375);
            this.tbcDados.TabIndex = 22;
            // 
            // tbParcelas
            // 
            this.tbParcelas.Controls.Add(this.dgvParcelas);
            this.tbParcelas.Location = new System.Drawing.Point(4, 32);
            this.tbParcelas.Name = "tbParcelas";
            this.tbParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tbParcelas.Size = new System.Drawing.Size(1031, 339);
            this.tbParcelas.TabIndex = 2;
            this.tbParcelas.Text = "Parcelas da venda";
            this.tbParcelas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(391, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data final";
            // 
            // dtPFinal
            // 
            this.dtPFinal.Location = new System.Drawing.Point(395, 72);
            this.dtPFinal.Name = "dtPFinal";
            this.dtPFinal.Size = new System.Drawing.Size(338, 29);
            this.dtPFinal.TabIndex = 17;
            // 
            // dtPInicial
            // 
            this.dtPInicial.Location = new System.Drawing.Point(4, 72);
            this.dtPInicial.Name = "dtPInicial";
            this.dtPInicial.Size = new System.Drawing.Size(338, 29);
            this.dtPInicial.TabIndex = 16;
            // 
            // btLocData
            // 
            this.btLocData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLocData.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.btLocData.Location = new System.Drawing.Point(738, 57);
            this.btLocData.Margin = new System.Windows.Forms.Padding(2);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(47, 44);
            this.btLocData.TabIndex = 15;
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Inicial";
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.label3);
            this.pnData.Controls.Add(this.dtPFinal);
            this.pnData.Controls.Add(this.dtPInicial);
            this.pnData.Controls.Add(this.btLocData);
            this.pnData.Controls.Add(this.label4);
            this.pnData.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.pnData.ForeColor = System.Drawing.Color.Navy;
            this.pnData.Location = new System.Drawing.Point(38, 172);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(933, 112);
            this.pnData.TabIndex = 21;
            this.pnData.Visible = false;
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbCliNome.ForeColor = System.Drawing.Color.Red;
            this.lbCliNome.Location = new System.Drawing.Point(368, 71);
            this.lbCliNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(26, 37);
            this.lbCliNome.TabIndex = 16;
            this.lbCliNome.Text = "-";
            // 
            // btLocCliente
            // 
            this.btLocCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLocCliente.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.btLocCliente.Location = new System.Drawing.Point(292, 64);
            this.btLocCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(47, 44);
            this.btLocCliente.TabIndex = 15;
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(6, 64);
            this.txtCliCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliCod.Multiline = true;
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(282, 44);
            this.txtCliCod.TabIndex = 15;
            // 
            // pnCliente
            // 
            this.pnCliente.Controls.Add(this.lbCliNome);
            this.pnCliente.Controls.Add(this.btLocCliente);
            this.pnCliente.Controls.Add(this.txtCliCod);
            this.pnCliente.Controls.Add(this.label2);
            this.pnCliente.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.pnCliente.ForeColor = System.Drawing.Color.Navy;
            this.pnCliente.Location = new System.Drawing.Point(32, 172);
            this.pnCliente.Name = "pnCliente";
            this.pnCliente.Size = new System.Drawing.Size(933, 112);
            this.pnCliente.TabIndex = 20;
            this.pnCliente.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Código";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.rbGeral.ForeColor = System.Drawing.Color.Navy;
            this.rbGeral.Location = new System.Drawing.Point(4, 54);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(249, 41);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.rbParcelas.ForeColor = System.Drawing.Color.Navy;
            this.rbParcelas.Location = new System.Drawing.Point(669, 54);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(278, 41);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(32, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 92);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por";
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.rbData.ForeColor = System.Drawing.Color.Navy;
            this.rbData.Location = new System.Drawing.Point(432, 54);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(215, 41);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da venda";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.rbCliente.ForeColor = System.Drawing.Color.Navy;
            this.rbCliente.Location = new System.Drawing.Point(271, 54);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(123, 41);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(457, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Listagem de Vendas";
            // 
            // frmColsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmColsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColsultaVenda";
            this.Load += new System.EventHandler(this.frmColsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            this.tbcDados.ResumeLayout(false);
            this.tbParcelas.ResumeLayout(false);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.pnCliente.ResumeLayout(false);
            this.pnCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tbParcelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPFinal;
        private System.Windows.Forms.DateTimePicker dtPInicial;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Panel pnCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Label label1;
    }
}