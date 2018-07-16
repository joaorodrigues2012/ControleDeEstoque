namespace GUI
{
    partial class relItensDasCompras
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.itenscompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_tccDataSet = new GUI.bd_tccDataSet();
            this.relItensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.pnFornecedor = new System.Windows.Forms.Panel();
            this.lbForNome = new System.Windows.Forms.Label();
            this.btLocFornecedor = new System.Windows.Forms.Button();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPFinal = new System.Windows.Forms.DateTimePicker();
            this.dtPInicial = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpCompra = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.itenscompraTableAdapter = new GUI.bd_tccDataSetTableAdapters.itenscompraTableAdapter();
            this.relItensVendaTableAdapter = new GUI.bd_tccDataSetTableAdapters.relItensVendaTableAdapter();
            this.listaContasAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaContasAReceberTableAdapter = new GUI.bd_tccDataSetTableAdapters.listaContasAReceberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itenscompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relItensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnFornecedor.SuspendLayout();
            this.pnData.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itenscompraBindingSource
            // 
            this.itenscompraBindingSource.DataMember = "itenscompra";
            this.itenscompraBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // bd_tccDataSet
            // 
            this.bd_tccDataSet.DataSetName = "bd_tccDataSet";
            this.bd_tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relItensVendaBindingSource
            // 
            this.relItensVendaBindingSource.DataMember = "relItensVenda";
            this.relItensVendaBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(0, 0);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1028, 241);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.ForeColor = System.Drawing.Color.Navy;
            this.rbData.Location = new System.Drawing.Point(181, 75);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(62, 27);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedor.ForeColor = System.Drawing.Color.Navy;
            this.rbFornecedor.Location = new System.Drawing.Point(6, 30);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(117, 27);
            this.rbFornecedor.TabIndex = 0;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbFornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(1069, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 130);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeral.ForeColor = System.Drawing.Color.Navy;
            this.rbGeral.Location = new System.Drawing.Point(6, 75);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(169, 27);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParcelas.ForeColor = System.Drawing.Color.Navy;
            this.rbParcelas.Location = new System.Drawing.Point(144, 30);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(159, 27);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas e aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // pnFornecedor
            // 
            this.pnFornecedor.Controls.Add(this.lbForNome);
            this.pnFornecedor.Controls.Add(this.btLocFornecedor);
            this.pnFornecedor.Controls.Add(this.txtForCod);
            this.pnFornecedor.Controls.Add(this.label2);
            this.pnFornecedor.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.pnFornecedor.ForeColor = System.Drawing.Color.Navy;
            this.pnFornecedor.Location = new System.Drawing.Point(12, 67);
            this.pnFornecedor.Name = "pnFornecedor";
            this.pnFornecedor.Size = new System.Drawing.Size(784, 112);
            this.pnFornecedor.TabIndex = 14;
            this.pnFornecedor.Visible = false;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.lbForNome.ForeColor = System.Drawing.Color.Red;
            this.lbForNome.Location = new System.Drawing.Point(332, 70);
            this.lbForNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(26, 37);
            this.lbForNome.TabIndex = 16;
            this.lbForNome.Text = "-";
            // 
            // btLocFornecedor
            // 
            this.btLocFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLocFornecedor.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.btLocFornecedor.Location = new System.Drawing.Point(270, 63);
            this.btLocFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btLocFornecedor.Name = "btLocFornecedor";
            this.btLocFornecedor.Size = new System.Drawing.Size(47, 44);
            this.btLocFornecedor.TabIndex = 15;
            this.btLocFornecedor.UseVisualStyleBackColor = true;
            this.btLocFornecedor.Click += new System.EventHandler(this.btLocFornecedor_Click);
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(4, 63);
            this.txtForCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtForCod.Multiline = true;
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(262, 44);
            this.txtForCod.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Código";
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
            this.pnData.Location = new System.Drawing.Point(12, 70);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(784, 112);
            this.pnData.TabIndex = 17;
            this.pnData.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(383, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data final";
            // 
            // dtPFinal
            // 
            this.dtPFinal.Location = new System.Drawing.Point(386, 72);
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
            this.btLocData.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btLocData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLocData.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.btLocData.Location = new System.Drawing.Point(729, 59);
            this.btLocData.Margin = new System.Windows.Forms.Padding(2);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(47, 42);
            this.btLocData.TabIndex = 15;
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Inicial";
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpCompra);
            this.tbcDados.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.tbcDados.Location = new System.Drawing.Point(12, 188);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(1039, 272);
            this.tbcDados.TabIndex = 18;
            // 
            // tpCompra
            // 
            this.tpCompra.Controls.Add(this.dgvDados);
            this.tpCompra.Location = new System.Drawing.Point(4, 32);
            this.tpCompra.Name = "tpCompra";
            this.tpCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompra.Size = new System.Drawing.Size(1031, 236);
            this.tpCompra.TabIndex = 0;
            this.tpCompra.Text = "Compras";
            this.tpCompra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Relatório de Itens da compra";
            // 
            // reportViewerCompra
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.itenscompraBindingSource;
            this.reportViewerCompra.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerCompra.LocalReport.ReportEmbeddedResource = "GUI.ReportItensDasCompras.rdlc";
            this.reportViewerCompra.Location = new System.Drawing.Point(12, 466);
            this.reportViewerCompra.Name = "reportViewerCompra";
            this.reportViewerCompra.Size = new System.Drawing.Size(1366, 399);
            this.reportViewerCompra.TabIndex = 26;
            // 
            // itenscompraTableAdapter
            // 
            this.itenscompraTableAdapter.ClearBeforeFill = true;
            // 
            // relItensVendaTableAdapter
            // 
            this.relItensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // listaContasAReceberBindingSource
            // 
            this.listaContasAReceberBindingSource.DataMember = "listaContasAReceber";
            this.listaContasAReceberBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // listaContasAReceberTableAdapter
            // 
            this.listaContasAReceberTableAdapter.ClearBeforeFill = true;
            // 
            // relItensDasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.reportViewerCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "relItensDasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itenscompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relItensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnFornecedor.ResumeLayout(false);
            this.pnFornecedor.PerformLayout();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.Panel pnFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLocFornecedor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPFinal;
        private System.Windows.Forms.DateTimePicker dtPInicial;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource itenscompraBindingSource;
        private bd_tccDataSet bd_tccDataSet;
        private bd_tccDataSetTableAdapters.itenscompraTableAdapter itenscompraTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCompra;
        private System.Windows.Forms.BindingSource relItensVendaBindingSource;
        private bd_tccDataSetTableAdapters.relItensVendaTableAdapter relItensVendaTableAdapter;
        private System.Windows.Forms.BindingSource listaContasAReceberBindingSource;
        private bd_tccDataSetTableAdapters.listaContasAReceberTableAdapter listaContasAReceberTableAdapter;
    }
}