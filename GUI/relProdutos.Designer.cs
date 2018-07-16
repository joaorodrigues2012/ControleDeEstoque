namespace GUI
{
    partial class relProdutos
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
            this.listaProdutoPorNomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_tccDataSet = new GUI.bd_tccDataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtoTableAdapter = new GUI.bd_tccDataSetTableAdapters.produtoTableAdapter();
            this.compraTableAdapter = new GUI.bd_tccDataSetTableAdapters.compraTableAdapter();
            this.listaProdutoPorNomeTableAdapter = new GUI.bd_tccDataSetTableAdapters.listaProdutoPorNomeTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaProduto = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaProdutoPorNomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProdutoPorNomeBindingSource
            // 
            this.listaProdutoPorNomeBindingSource.DataMember = "listaProdutoPorNome";
            this.listaProdutoPorNomeBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // bd_tccDataSet
            // 
            this.bd_tccDataSet.DataSetName = "bd_tccDataSet";
            this.bd_tccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // reportViewerProduto
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listaProdutoPorNomeBindingSource;
            this.reportViewerProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProduto.LocalReport.ReportEmbeddedResource = "GUI.Report_ListaProdPorNome.rdlc";
            this.reportViewerProduto.Location = new System.Drawing.Point(35, 199);
            this.reportViewerProduto.Name = "reportViewerProduto";
            this.reportViewerProduto.Size = new System.Drawing.Size(1366, 732);
            this.reportViewerProduto.TabIndex = 1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // listaProdutoPorNomeTableAdapter
            // 
            this.listaProdutoPorNomeTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(28, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 37);
            this.label12.TabIndex = 36;
            this.label12.Text = "Relatório de Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaProduto);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 113);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtBuscaProduto
            // 
            this.txtBuscaProduto.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.txtBuscaProduto.Location = new System.Drawing.Point(0, 63);
            this.txtBuscaProduto.Multiline = true;
            this.txtBuscaProduto.Name = "txtBuscaProduto";
            this.txtBuscaProduto.Size = new System.Drawing.Size(519, 44);
            this.txtBuscaProduto.TabIndex = 4;
            // 
            // Buscar
            // 
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Buscar.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.Buscar.Location = new System.Drawing.Point(525, 75);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(120, 32);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // relProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1420, 857);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reportViewerProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "relProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de produtos";
            this.Load += new System.EventHandler(this.relProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProdutoPorNomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bd_tccDataSet bd_tccDataSet;
        private bd_tccDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private bd_tccDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.BindingSource listaProdutoPorNomeBindingSource;
        private bd_tccDataSetTableAdapters.listaProdutoPorNomeTableAdapter listaProdutoPorNomeTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaProduto;
        private System.Windows.Forms.Button Buscar;
    }
}