namespace GUI
{
    partial class rel_Clieentes
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_tccDataSet = new GUI.bd_tccDataSet();
            this.relatorio_vendas_clienteTableAdapter = new GUI.bd_tccDataSetTableAdapters.relatorio_vendas_clienteTableAdapter();
            this.compraTableAdapter = new GUI.bd_tccDataSetTableAdapters.compraTableAdapter();
            this.produtoTableAdapter = new GUI.bd_tccDataSetTableAdapters.produtoTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPFinal = new System.Windows.Forms.DateTimePicker();
            this.vendaTableAdapter = new GUI.bd_tccDataSetTableAdapters.vendaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.relatorio_vendas_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label12 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new GUI.bd_tccDataSetTableAdapters.clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_vendas_clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bd_tccDataSet;
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // bd_tccDataSet
            // 
            this.bd_tccDataSet.DataSetName = "bd_tccDataSet";
            this.bd_tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorio_vendas_clienteTableAdapter
            // 
            this.relatorio_vendas_clienteTableAdapter.ClearBeforeFill = true;
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
            this.produtoBindingSource.CurrentChanged += new System.EventHandler(this.produtoBindingSource_CurrentChanged);
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.bd_tccDataSet;
            this.compraBindingSource.CurrentChanged += new System.EventHandler(this.compraBindingSource_CurrentChanged);
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.bd_tccDataSet;
            this.vendaBindingSource.CurrentChanged += new System.EventHandler(this.vendaBindingSource_CurrentChanged);
            // 
            // dtPFinal
            // 
            this.dtPFinal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dtPFinal.Location = new System.Drawing.Point(1059, 22);
            this.dtPFinal.Name = "dtPFinal";
            this.dtPFinal.Size = new System.Drawing.Size(342, 29);
            this.dtPFinal.TabIndex = 26;
            this.dtPFinal.ValueChanged += new System.EventHandler(this.dtPFinal_ValueChanged);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaCliente);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 113);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtBuscaCliente.Location = new System.Drawing.Point(6, 63);
            this.txtBuscaCliente.Multiline = true;
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(519, 44);
            this.txtBuscaCliente.TabIndex = 4;
            this.txtBuscaCliente.TextChanged += new System.EventHandler(this.txtBuscaCliente_TextChanged);
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
            // relatorio_vendas_clienteBindingSource
            // 
            this.relatorio_vendas_clienteBindingSource.DataMember = "relatorio_vendas_cliente";
            this.relatorio_vendas_clienteBindingSource.DataSource = this.bd_tccDataSet;
            this.relatorio_vendas_clienteBindingSource.CurrentChanged += new System.EventHandler(this.relatorio_vendas_clienteBindingSource_CurrentChanged);
            // 
            // reportViewerCliente
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.reportViewerCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCliente.LocalReport.ReportEmbeddedResource = "GUI.Report_Cliente.rdlc";
            this.reportViewerCliente.Location = new System.Drawing.Point(35, 199);
            this.reportViewerCliente.Name = "reportViewerCliente";
            this.reportViewerCliente.Size = new System.Drawing.Size(1366, 650);
            this.reportViewerCliente.TabIndex = 25;
            this.reportViewerCliente.Load += new System.EventHandler(this.reportViewerCliente_Load);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(28, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 37);
            this.label12.TabIndex = 27;
            this.label12.Text = "Relatório de Clientes";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // rel_Clieentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.dtPFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerCliente);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "rel_Clieentes";
            this.Text = "rel_Clieentes";
            this.Load += new System.EventHandler(this.rel_Clieentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio_vendas_clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_tccDataSetTableAdapters.relatorio_vendas_clienteTableAdapter relatorio_vendas_clienteTableAdapter;
        private bd_tccDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private bd_tccDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bd_tccDataSet bd_tccDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.DateTimePicker dtPFinal;
        private bd_tccDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource relatorio_vendas_clienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bd_tccDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
    }
}