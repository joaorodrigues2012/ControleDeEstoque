namespace GUI
{
    partial class rel_ContaAReceber
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listaContasAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_tccDataSet = new GUI.bd_tccDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaContaAPagar = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.dtPFinal = new System.Windows.Forms.DateTimePicker();
            this.reportViewerContasAReceber = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label12 = new System.Windows.Forms.Label();
            this.listaContasAPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaContasAPagarTableAdapter = new GUI.bd_tccDataSetTableAdapters.listaContasAPagarTableAdapter();
            this.relatorio_vendas_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new GUI.bd_tccDataSetTableAdapters.compraTableAdapter();
            this.produtoTableAdapter = new GUI.bd_tccDataSetTableAdapters.produtoTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new GUI.bd_tccDataSetTableAdapters.vendaTableAdapter();
            this.relatorio_vendas_clienteTableAdapter = new GUI.bd_tccDataSetTableAdapters.relatorio_vendas_clienteTableAdapter();
            this.clienteTableAdapter = new GUI.bd_tccDataSetTableAdapters.clienteTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaContasAReceberTableAdapter = new GUI.bd_tccDataSetTableAdapters.listaContasAReceberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_vendas_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaContasAReceberBindingSource
            // 
            this.listaContasAReceberBindingSource.DataMember = "listaContasAReceber";
            this.listaContasAReceberBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // bd_tccDataSet
            // 
            this.bd_tccDataSet.DataSetName = "bd_tccDataSet";
            this.bd_tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaContaAPagar);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 113);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtBuscaContaAPagar
            // 
            this.txtBuscaContaAPagar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtBuscaContaAPagar.Location = new System.Drawing.Point(6, 63);
            this.txtBuscaContaAPagar.Multiline = true;
            this.txtBuscaContaAPagar.Name = "txtBuscaContaAPagar";
            this.txtBuscaContaAPagar.Size = new System.Drawing.Size(519, 44);
            this.txtBuscaContaAPagar.TabIndex = 4;
            // 
            // Buscar
            // 
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Buscar.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.Buscar.Location = new System.Drawing.Point(531, 75);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(120, 32);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dtPFinal
            // 
            this.dtPFinal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dtPFinal.Location = new System.Drawing.Point(1059, 22);
            this.dtPFinal.Name = "dtPFinal";
            this.dtPFinal.Size = new System.Drawing.Size(342, 29);
            this.dtPFinal.TabIndex = 34;
            // 
            // reportViewerContasAReceber
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listaContasAReceberBindingSource;
            this.reportViewerContasAReceber.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerContasAReceber.LocalReport.ReportEmbeddedResource = "GUI.ReportContasReceber.rdlc";
            this.reportViewerContasAReceber.Location = new System.Drawing.Point(35, 199);
            this.reportViewerContasAReceber.Name = "reportViewerContasAReceber";
            this.reportViewerContasAReceber.Size = new System.Drawing.Size(1366, 650);
            this.reportViewerContasAReceber.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(28, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(400, 37);
            this.label12.TabIndex = 35;
            this.label12.Text = "Relatório de Contas a Receber";
            // 
            // listaContasAPagarBindingSource
            // 
            this.listaContasAPagarBindingSource.DataMember = "listaContasAPagar";
            this.listaContasAPagarBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // listaContasAPagarTableAdapter
            // 
            this.listaContasAPagarTableAdapter.ClearBeforeFill = true;
            // 
            // relatorio_vendas_clienteBindingSource
            // 
            this.relatorio_vendas_clienteBindingSource.DataMember = "relatorio_vendas_cliente";
            this.relatorio_vendas_clienteBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // relatorio_vendas_clienteTableAdapter
            // 
            this.relatorio_vendas_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // listaContasAReceberTableAdapter
            // 
            this.listaContasAReceberTableAdapter.ClearBeforeFill = true;
            // 
            // rel_ContaAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 865);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtPFinal);
            this.Controls.Add(this.reportViewerContasAReceber);
            this.Controls.Add(this.label12);
            this.Name = "rel_ContaAReceber";
            this.Text = "rel_ContasAReceber";
            this.Load += new System.EventHandler(this.rel_ContasAReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasAPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_vendas_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_tccDataSetTableAdapters.listaContasAPagarTableAdapter listaContasAPagarTableAdapter;
        private System.Windows.Forms.BindingSource relatorio_vendas_clienteBindingSource;
        private bd_tccDataSet bd_tccDataSet;
        private bd_tccDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private bd_tccDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private bd_tccDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private bd_tccDataSetTableAdapters.relatorio_vendas_clienteTableAdapter relatorio_vendas_clienteTableAdapter;
        private bd_tccDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaContaAPagar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DateTimePicker dtPFinal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerContasAReceber;
        private System.Windows.Forms.BindingSource listaContasAPagarBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource listaContasAReceberBindingSource;
        private bd_tccDataSetTableAdapters.listaContasAReceberTableAdapter listaContasAReceberTableAdapter;
    }
}