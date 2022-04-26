namespace WindowsFormsApp4
{
    partial class ManipulacaoDiretorios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomePasCriar = new System.Windows.Forms.Label();
            this.lblNomePasDel = new System.Windows.Forms.Label();
            this.lblPastaOrigem = new System.Windows.Forms.Label();
            this.lblPastaDestino = new System.Windows.Forms.Label();
            this.txtNomeCriar = new System.Windows.Forms.TextBox();
            this.txtNomeDel = new System.Windows.Forms.TextBox();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.btnNovaPasta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomePasCriar
            // 
            this.lblNomePasCriar.AutoSize = true;
            this.lblNomePasCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePasCriar.Location = new System.Drawing.Point(139, 53);
            this.lblNomePasCriar.Name = "lblNomePasCriar";
            this.lblNomePasCriar.Size = new System.Drawing.Size(138, 24);
            this.lblNomePasCriar.TabIndex = 0;
            this.lblNomePasCriar.Text = "Nome da Pasta";
            // 
            // lblNomePasDel
            // 
            this.lblNomePasDel.AutoSize = true;
            this.lblNomePasDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePasDel.Location = new System.Drawing.Point(139, 138);
            this.lblNomePasDel.Name = "lblNomePasDel";
            this.lblNomePasDel.Size = new System.Drawing.Size(138, 24);
            this.lblNomePasDel.TabIndex = 0;
            this.lblNomePasDel.Text = "Nome da Pasta";
            // 
            // lblPastaOrigem
            // 
            this.lblPastaOrigem.AutoSize = true;
            this.lblPastaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaOrigem.Location = new System.Drawing.Point(337, 237);
            this.lblPastaOrigem.Name = "lblPastaOrigem";
            this.lblPastaOrigem.Size = new System.Drawing.Size(180, 24);
            this.lblPastaOrigem.TabIndex = 0;
            this.lblPastaOrigem.Text = "Nome Pasta Origem";
            // 
            // lblPastaDestino
            // 
            this.lblPastaDestino.AutoSize = true;
            this.lblPastaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaDestino.Location = new System.Drawing.Point(337, 323);
            this.lblPastaDestino.Name = "lblPastaDestino";
            this.lblPastaDestino.Size = new System.Drawing.Size(180, 24);
            this.lblPastaDestino.TabIndex = 0;
            this.lblPastaDestino.Text = "Nome Pasta Destino";
            // 
            // txtNomeCriar
            // 
            this.txtNomeCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCriar.Location = new System.Drawing.Point(118, 80);
            this.txtNomeCriar.Name = "txtNomeCriar";
            this.txtNomeCriar.Size = new System.Drawing.Size(186, 29);
            this.txtNomeCriar.TabIndex = 1;
            // 
            // txtNomeDel
            // 
            this.txtNomeDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDel.Location = new System.Drawing.Point(118, 165);
            this.txtNomeDel.Name = "txtNomeDel";
            this.txtNomeDel.Size = new System.Drawing.Size(186, 29);
            this.txtNomeDel.TabIndex = 1;
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaOrigem.Location = new System.Drawing.Point(341, 264);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(186, 29);
            this.txtPastaOrigem.TabIndex = 1;
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaDestino.Location = new System.Drawing.Point(341, 350);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(186, 29);
            this.txtPastaDestino.TabIndex = 1;
            // 
            // btnNovaPasta
            // 
            this.btnNovaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPasta.Location = new System.Drawing.Point(341, 71);
            this.btnNovaPasta.Name = "btnNovaPasta";
            this.btnNovaPasta.Size = new System.Drawing.Size(171, 38);
            this.btnNovaPasta.TabIndex = 2;
            this.btnNovaPasta.Text = "Criar Nova Pasta";
            this.btnNovaPasta.UseVisualStyleBackColor = true;
            this.btnNovaPasta.Click += new System.EventHandler(this.btnNovaPasta_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deletar Pasta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(616, 293);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(171, 38);
            this.btnMover.TabIndex = 2;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(134, 266);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(132, 24);
            this.lblNomeArquivo.TabIndex = 0;
            this.lblNomeArquivo.Text = "Nome Arquivo";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArquivo.Location = new System.Drawing.Point(113, 293);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(186, 29);
            this.txtNomeArquivo.TabIndex = 1;
            // 
            // ManipulacaoDiretorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(866, 525);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNovaPasta);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.txtNomeDel);
            this.Controls.Add(this.txtNomeCriar);
            this.Controls.Add(this.lblPastaDestino);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.lblPastaOrigem);
            this.Controls.Add(this.lblNomePasDel);
            this.Controls.Add(this.lblNomePasCriar);
            this.Name = "ManipulacaoDiretorios";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePasCriar;
        private System.Windows.Forms.Label lblNomePasDel;
        private System.Windows.Forms.Label lblPastaOrigem;
        private System.Windows.Forms.Label lblPastaDestino;
        private System.Windows.Forms.TextBox txtNomeCriar;
        private System.Windows.Forms.TextBox txtNomeDel;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Button btnNovaPasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
    }
}

