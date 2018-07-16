namespace GUI
{
    partial class frmbackupBancoDeDados
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
            this.btBackup = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBackup
            // 
            this.btBackup.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btBackup.ForeColor = System.Drawing.Color.Green;
            this.btBackup.Location = new System.Drawing.Point(26, 111);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(541, 99);
            this.btBackup.TabIndex = 0;
            this.btBackup.Text = "Backup do banco de dados";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btResta
            // 
            this.btResta.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btResta.ForeColor = System.Drawing.Color.Red;
            this.btResta.Location = new System.Drawing.Point(26, 289);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(541, 99);
            this.btResta.TabIndex = 1;
            this.btResta.Text = "Restaurar banco de dados";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Visible = false;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(547, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Backup e restauração  do banco de dados";
            // 
            // frmbackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btBackup);
            this.Name = "frmbackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do Banco de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Label label5;
    }
}