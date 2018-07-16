namespace GUI
{
    partial class frmMovimentacaoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoCompra));
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.txtNFIscal = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDataCmpra = new System.Windows.Forms.DateTimePicker();
            this.cbTPag = new System.Windows.Forms.ComboBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLFornecedor = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btLocProd = new System.Windows.Forms.Button();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.txtTotalFinalParcelas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btCancelarFinal = new System.Windows.Forms.Button();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbItens = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMaisFornecedor = new System.Windows.Forms.Button();
            this.lbFornecedor11 = new System.Windows.Forms.Label();
            this.lbProduto11 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lbCodBarras = new System.Windows.Forms.Label();
            this.ptbVenda = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.ptbVenda);
            this.pnDados.Controls.Add(this.txtCodBarras);
            this.pnDados.Controls.Add(this.lbCodBarras);
            this.pnDados.Controls.Add(this.pnFinalizaCompra);
            this.pnDados.Controls.Add(this.lbProduto11);
            this.pnDados.Controls.Add(this.lbFornecedor11);
            this.pnDados.Controls.Add(this.btnMaisFornecedor);
            this.pnDados.Controls.Add(this.lbItens);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lbProduto);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.lbFornecedor);
            this.pnDados.Controls.Add(this.btLFornecedor);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.dtDataIni);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.cbTPag);
            this.pnDados.Controls.Add(this.dtDataCmpra);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.txtNFIscal);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.txtComCod);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(9, 79);
            this.pnDados.Size = new System.Drawing.Size(1404, 621);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(9, 727);
            this.pnBotoes.Size = new System.Drawing.Size(1164, 108);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btCancelar.Location = new System.Drawing.Point(775, 17);
            this.btCancelar.Size = new System.Drawing.Size(103, 73);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btSalvar.Location = new System.Drawing.Point(628, 17);
            this.btSalvar.Size = new System.Drawing.Size(103, 73);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btExcluir.Location = new System.Drawing.Point(481, 17);
            this.btExcluir.Size = new System.Drawing.Size(103, 73);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btAlterar.Location = new System.Drawing.Point(329, 17);
            this.btAlterar.Size = new System.Drawing.Size(103, 73);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btLocalizar.Location = new System.Drawing.Point(184, 17);
            this.btLocalizar.Size = new System.Drawing.Size(103, 73);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btInserir.Location = new System.Drawing.Point(28, 17);
            this.btInserir.Size = new System.Drawing.Size(103, 73);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // txtForCod
            // 
            this.txtForCod.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtForCod.Location = new System.Drawing.Point(28, 157);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(281, 44);
            this.txtForCod.TabIndex = 2;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbRsocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbRsocial.Location = new System.Drawing.Point(28, 117);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(252, 37);
            this.lbRsocial.TabIndex = 42;
            this.lbRsocial.Text = "Código fornecedor";
            // 
            // txtNFIscal
            // 
            this.txtNFIscal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtNFIscal.Location = new System.Drawing.Point(425, 59);
            this.txtNFIscal.Name = "txtNFIscal";
            this.txtNFIscal.Size = new System.Drawing.Size(281, 44);
            this.txtNFIscal.TabIndex = 1;
            this.txtNFIscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFIscal_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbNome.Location = new System.Drawing.Point(419, 17);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(184, 37);
            this.lbNome.TabIndex = 40;
            this.lbNome.Text = "Nº nota fiscal";
            // 
            // txtComCod
            // 
            this.txtComCod.Enabled = false;
            this.txtComCod.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtComCod.Location = new System.Drawing.Point(28, 59);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(281, 44);
            this.txtComCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Código compra";
            // 
            // dtDataCmpra
            // 
            this.dtDataCmpra.Enabled = false;
            this.dtDataCmpra.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dtDataCmpra.Location = new System.Drawing.Point(785, 74);
            this.dtDataCmpra.Name = "dtDataCmpra";
            this.dtDataCmpra.Size = new System.Drawing.Size(370, 29);
            this.dtDataCmpra.TabIndex = 44;
            // 
            // cbTPag
            // 
            this.cbTPag.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.cbTPag.FormattingEnabled = true;
            this.cbTPag.Location = new System.Drawing.Point(223, 539);
            this.cbTPag.Name = "cbTPag";
            this.cbTPag.Size = new System.Drawing.Size(189, 45);
            this.cbTPag.TabIndex = 11;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Arial Narrow", 44F, System.Drawing.FontStyle.Bold);
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Red;
            this.txtTotalCompra.Location = new System.Drawing.Point(838, 509);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(317, 75);
            this.txtTotalCompra.TabIndex = 12;
            this.txtTotalCompra.TextChanged += new System.EventHandler(this.txtTotalCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(752, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 46;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(217, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 37);
            this.label3.TabIndex = 48;
            this.label3.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 37);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nº parcelas";
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(28, 540);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(159, 45);
            this.cbNParcelas.TabIndex = 10;
            // 
            // dtDataIni
            // 
            this.dtDataIni.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dtDataIni.Location = new System.Drawing.Point(212, 307);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(350, 29);
            this.dtDataIni.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(205, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 52;
            this.label5.Text = "Data inicial da compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(783, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 37);
            this.label6.TabIndex = 53;
            this.label6.Text = "Data da compra";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            this.dgvItens.Location = new System.Drawing.Point(28, 357);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(1127, 140);
            this.dgvItens.TabIndex = 54;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.FillWeight = 120F;
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 380;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            this.forQtde.Width = 200;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitário";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 200;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 200;
            // 
            // btLFornecedor
            // 
            this.btLFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btLFornecedor.Image")));
            this.btLFornecedor.Location = new System.Drawing.Point(315, 157);
            this.btLFornecedor.Name = "btLFornecedor";
            this.btLFornecedor.Size = new System.Drawing.Size(42, 44);
            this.btLFornecedor.TabIndex = 3;
            this.btLFornecedor.UseVisualStyleBackColor = true;
            this.btLFornecedor.Click += new System.EventHandler(this.btLFornecedor_Click);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbFornecedor.ForeColor = System.Drawing.Color.Red;
            this.lbFornecedor.Location = new System.Drawing.Point(13, 204);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(0, 15);
            this.lbFornecedor.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1099, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_____________________";
            // 
            // txtProCod
            // 
            this.txtProCod.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtProCod.Location = new System.Drawing.Point(944, 157);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(163, 44);
            this.txtProCod.TabIndex = 5;
            this.txtProCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProCod_KeyDown);
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(935, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 37);
            this.label8.TabIndex = 58;
            this.label8.Text = "Código  produto";
            // 
            // btLocProd
            // 
            this.btLocProd.Image = ((System.Drawing.Image)(resources.GetObject("btLocProd.Image")));
            this.btLocProd.Location = new System.Drawing.Point(1113, 157);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(42, 44);
            this.btLocProd.TabIndex = 6;
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbProduto.ForeColor = System.Drawing.Color.Red;
            this.lbProduto.Location = new System.Drawing.Point(422, 204);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(0, 15);
            this.lbProduto.TabIndex = 61;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtQtde.Location = new System.Drawing.Point(568, 292);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(138, 44);
            this.txtQtde.TabIndex = 7;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(561, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 37);
            this.label10.TabIndex = 62;
            this.label10.Text = "Quantidade";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(790, 292);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(283, 44);
            this.txtValor.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(812, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 37);
            this.label11.TabIndex = 64;
            this.label11.Text = "Valor unitário";
            // 
            // btAddProd
            // 
            this.btAddProd.Image = global::GUI.Properties.Resources.Novo;
            this.btAddProd.Location = new System.Drawing.Point(1079, 292);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(76, 44);
            this.btAddProd.TabIndex = 9;
            this.btAddProd.Text = "+";
            this.btAddProd.UseVisualStyleBackColor = true;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.txtTotalFinalParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.btCancelarFinal);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label14);
            this.pnFinalizaCompra.Controls.Add(this.label13);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(3, 3);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(1164, 621);
            this.pnFinalizaCompra.TabIndex = 2;
            this.pnFinalizaCompra.Visible = false;
            // 
            // txtTotalFinalParcelas
            // 
            this.txtTotalFinalParcelas.Enabled = false;
            this.txtTotalFinalParcelas.Font = new System.Drawing.Font("Arial Narrow", 44F, System.Drawing.FontStyle.Bold);
            this.txtTotalFinalParcelas.ForeColor = System.Drawing.Color.Red;
            this.txtTotalFinalParcelas.Location = new System.Drawing.Point(677, 498);
            this.txtTotalFinalParcelas.Name = "txtTotalFinalParcelas";
            this.txtTotalFinalParcelas.Size = new System.Drawing.Size(457, 75);
            this.txtTotalFinalParcelas.TabIndex = 65;
            this.txtTotalFinalParcelas.TextChanged += new System.EventHandler(this.txtTotalFinalParcelas_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(582, 536);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 37);
            this.label16.TabIndex = 64;
            this.label16.Text = "Total:";
            // 
            // btCancelarFinal
            // 
            this.btCancelarFinal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btCancelarFinal.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelarFinal.Location = new System.Drawing.Point(181, 500);
            this.btCancelarFinal.Name = "btCancelarFinal";
            this.btCancelarFinal.Size = new System.Drawing.Size(103, 73);
            this.btCancelarFinal.TabIndex = 61;
            this.btCancelarFinal.Text = "Cancelar";
            this.btCancelarFinal.UseVisualStyleBackColor = true;
            this.btCancelarFinal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btSalvarFinal.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvarFinal.Location = new System.Drawing.Point(28, 500);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(103, 73);
            this.btSalvarFinal.TabIndex = 60;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.UseVisualStyleBackColor = true;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(28, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 37);
            this.label14.TabIndex = 59;
            this.label14.Text = "Parcelas da compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1093, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________________";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(28, 149);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(1102, 335);
            this.dgvParcelas.TabIndex = 1;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            this.pco_cod.Width = 390;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 390;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 279;
            // 
            // lbItens
            // 
            this.lbItens.AutoSize = true;
            this.lbItens.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbItens.ForeColor = System.Drawing.Color.Red;
            this.lbItens.Location = new System.Drawing.Point(28, 317);
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(181, 37);
            this.lbItens.TabIndex = 184;
            this.lbItens.Text = "Itens compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 34F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(354, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(487, 55);
            this.label9.TabIndex = 2;
            this.label9.Text = "Movimentação de compra";
            // 
            // btnMaisFornecedor
            // 
            this.btnMaisFornecedor.Image = global::GUI.Properties.Resources.botao_inserir;
            this.btnMaisFornecedor.Location = new System.Drawing.Point(363, 157);
            this.btnMaisFornecedor.Name = "btnMaisFornecedor";
            this.btnMaisFornecedor.Size = new System.Drawing.Size(42, 44);
            this.btnMaisFornecedor.TabIndex = 197;
            this.btnMaisFornecedor.UseVisualStyleBackColor = true;
            this.btnMaisFornecedor.Click += new System.EventHandler(this.btnMaisFornecedor_Click);
            // 
            // lbFornecedor11
            // 
            this.lbFornecedor11.AutoSize = true;
            this.lbFornecedor11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbFornecedor11.ForeColor = System.Drawing.Color.Red;
            this.lbFornecedor11.Location = new System.Drawing.Point(28, 204);
            this.lbFornecedor11.Name = "lbFornecedor11";
            this.lbFornecedor11.Size = new System.Drawing.Size(26, 37);
            this.lbFornecedor11.TabIndex = 198;
            this.lbFornecedor11.Text = "-";
            // 
            // lbProduto11
            // 
            this.lbProduto11.AutoSize = true;
            this.lbProduto11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbProduto11.ForeColor = System.Drawing.Color.Red;
            this.lbProduto11.Location = new System.Drawing.Point(428, 204);
            this.lbProduto11.Name = "lbProduto11";
            this.lbProduto11.Size = new System.Drawing.Size(26, 37);
            this.lbProduto11.TabIndex = 199;
            this.lbProduto11.Text = "-";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtCodBarras.Location = new System.Drawing.Point(425, 157);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(513, 44);
            this.txtCodBarras.TabIndex = 4;
            this.txtCodBarras.Leave += new System.EventHandler(this.txtCodBarras_Leave);
            // 
            // lbCodBarras
            // 
            this.lbCodBarras.AutoSize = true;
            this.lbCodBarras.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbCodBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbCodBarras.Location = new System.Drawing.Point(419, 117);
            this.lbCodBarras.Name = "lbCodBarras";
            this.lbCodBarras.Size = new System.Drawing.Size(198, 37);
            this.lbCodBarras.TabIndex = 201;
            this.lbCodBarras.Text = "Código Barras";
            // 
            // ptbVenda
            // 
            this.ptbVenda.Location = new System.Drawing.Point(1198, 30);
            this.ptbVenda.Name = "ptbVenda";
            this.ptbVenda.Size = new System.Drawing.Size(192, 211);
            this.ptbVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVenda.TabIndex = 202;
            this.ptbVenda.TabStop = false;
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.label9);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Movimentação: Formulário de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.TextBox txtNFIscal;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTPag;
        private System.Windows.Forms.DateTimePicker dtDataCmpra;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Button btLFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Button btCancelarFinal;
        private System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Label lbItens;
        private System.Windows.Forms.TextBox txtTotalFinalParcelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMaisFornecedor;
        private System.Windows.Forms.Label lbFornecedor11;
        private System.Windows.Forms.Label lbProduto11;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lbCodBarras;
        private System.Windows.Forms.PictureBox ptbVenda;
    }
}
