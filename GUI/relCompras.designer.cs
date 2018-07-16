namespace GUI
{
    partial class relCompras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdataFinnal = new System.Windows.Forms.DateTimePicker();
            this.Buscar = new System.Windows.Forms.Button();
            this.txtDatainni = new System.Windows.Forms.DateTimePicker();
            this.reportViewerCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPFinal = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_tccDataSet = new GUI.bd_tccDataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new GUI.bd_tccDataSetTableAdapters.produtoTableAdapter();
            this.compraTableAdapter = new GUI.bd_tccDataSetTableAdapters.compraTableAdapter();
            this.rel_CompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rel_CompraTableAdapter = new GUI.bd_tccDataSetTableAdapters.rel_CompraTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel_CompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdataFinnal);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.txtDatainni);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(19, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(351, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Data Inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdataFinnal
            // 
            this.txtdataFinnal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.txtdataFinnal.Location = new System.Drawing.Point(355, 53);
            this.txtdataFinnal.Name = "txtdataFinnal";
            this.txtdataFinnal.Size = new System.Drawing.Size(342, 29);
            this.txtdataFinnal.TabIndex = 20;
            this.txtdataFinnal.ValueChanged += new System.EventHandler(this.txtdataFinnal_ValueChanged);
            // 
            // Buscar
            // 
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Buscar.Image = global::GUI.Properties.Resources.localizar3_fw;
            this.Buscar.Location = new System.Drawing.Point(703, 53);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(120, 32);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txtDatainni
            // 
            this.txtDatainni.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.txtDatainni.Location = new System.Drawing.Point(7, 53);
            this.txtDatainni.Name = "txtDatainni";
            this.txtDatainni.Size = new System.Drawing.Size(342, 29);
            this.txtDatainni.TabIndex = 19;
            this.txtDatainni.ValueChanged += new System.EventHandler(this.txtDatainni_ValueChanged);
            // 
            // reportViewerCompra
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rel_CompraBindingSource;
            this.reportViewerCompra.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCompra.LocalReport.ReportEmbeddedResource = "GUI.ReportCompra.rdlc";
            this.reportViewerCompra.Location = new System.Drawing.Point(19, 195);
            this.reportViewerCompra.Name = "reportViewerCompra";
            this.reportViewerCompra.Size = new System.Drawing.Size(1366, 650);
            this.reportViewerCompra.TabIndex = 3;
            this.reportViewerCompra.Load += new System.EventHandler(this.reportViewerCompra_Load);
            // 
            // dtPFinal
            // 
            this.dtPFinal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dtPFinal.Location = new System.Drawing.Point(1043, 18);
            this.dtPFinal.Name = "dtPFinal";
            this.dtPFinal.Size = new System.Drawing.Size(342, 29);
            this.dtPFinal.TabIndex = 18;
            this.dtPFinal.ValueChanged += new System.EventHandler(this.dtPFinal_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(12, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(430, 37);
            this.label12.TabIndex = 19;
            this.label12.Text = "Relatório de compra  por periodo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.bd_tccDataSet;
            this.produtoBindingSource.CurrentChanged += new System.EventHandler(this.produtoBindingSource_CurrentChanged);
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
            this.compraBindingSource.CurrentChanged += new System.EventHandler(this.compraBindingSource_CurrentChanged);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // rel_CompraBindingSource
            // 
            this.rel_CompraBindingSource.DataMember = "rel_Compra";
            this.rel_CompraBindingSource.DataSource = this.bd_tccDataSet;
            // 
            // rel_CompraTableAdapter
            // 
            this.rel_CompraTableAdapter.ClearBeforeFill = true;
            // 
            // relCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 857);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtPFinal);
            this.Controls.Add(this.reportViewerCompra);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "relCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "relCompras";
            this.Load += new System.EventHandler(this.relCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_tccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel_CompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bd_tccDataSet bd_tccDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Buscar;
        private bd_tccDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private bd_tccDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCompra;
        private System.Windows.Forms.DateTimePicker dtPFinal;
        private System.Windows.Forms.DateTimePicker txtdataFinnal;
        private System.Windows.Forms.DateTimePicker txtDatainni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource rel_CompraBindingSource;
        private bd_tccDataSetTableAdapters.rel_CompraTableAdapter rel_CompraTableAdapter;
    }
}