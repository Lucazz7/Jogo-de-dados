
namespace Jogo__de_dados
{
    partial class Form1
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
            this.pontos1 = new System.Windows.Forms.Label();
            this.pontos2 = new System.Windows.Forms.Label();
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.bt_joga1 = new System.Windows.Forms.Button();
            this.btjoga2 = new System.Windows.Forms.Button();
            this.vencedor = new System.Windows.Forms.Label();
            this.btreiniciar = new System.Windows.Forms.Button();
            this.venc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorPartida = new System.Windows.Forms.TextBox();
            this.n_jogador1 = new System.Windows.Forms.TextBox();
            this.n_jogador2 = new System.Windows.Forms.TextBox();
            this.bt_listar = new System.Windows.Forms.Button();
            this.bt_resultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            this.SuspendLayout();
            // 
            // pontos1
            // 
            this.pontos1.AutoSize = true;
            this.pontos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos1.Location = new System.Drawing.Point(75, 53);
            this.pontos1.Name = "pontos1";
            this.pontos1.Size = new System.Drawing.Size(85, 25);
            this.pontos1.TabIndex = 0;
            this.pontos1.Text = "Pontos:";
            // 
            // pontos2
            // 
            this.pontos2.AutoSize = true;
            this.pontos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos2.Location = new System.Drawing.Point(413, 53);
            this.pontos2.Name = "pontos2";
            this.pontos2.Size = new System.Drawing.Size(85, 25);
            this.pontos2.TabIndex = 1;
            this.pontos2.Text = "Pontos:";
            // 
            // dado1
            // 
            this.dado1.Image = global::Jogo__de_dados.Properties.Resources.dado0;
            this.dado1.Location = new System.Drawing.Point(80, 86);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(87, 82);
            this.dado1.TabIndex = 2;
            this.dado1.TabStop = false;
            // 
            // dado2
            // 
            this.dado2.Image = global::Jogo__de_dados.Properties.Resources.dado0;
            this.dado2.Location = new System.Drawing.Point(418, 86);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(82, 82);
            this.dado2.TabIndex = 3;
            this.dado2.TabStop = false;
            this.dado2.Click += new System.EventHandler(this.dado2_Click);
            // 
            // bt_joga1
            // 
            this.bt_joga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_joga1.Location = new System.Drawing.Point(80, 209);
            this.bt_joga1.Name = "bt_joga1";
            this.bt_joga1.Size = new System.Drawing.Size(87, 37);
            this.bt_joga1.TabIndex = 6;
            this.bt_joga1.Text = "JOGAR!";
            this.bt_joga1.UseVisualStyleBackColor = true;
            this.bt_joga1.Click += new System.EventHandler(this.bt_joga1_Click);
            // 
            // btjoga2
            // 
            this.btjoga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btjoga2.Location = new System.Drawing.Point(416, 209);
            this.btjoga2.Name = "btjoga2";
            this.btjoga2.Size = new System.Drawing.Size(97, 39);
            this.btjoga2.TabIndex = 7;
            this.btjoga2.Text = "JOGAR!";
            this.btjoga2.UseVisualStyleBackColor = true;
            this.btjoga2.Click += new System.EventHandler(this.btjoga2_Click);
            // 
            // vencedor
            // 
            this.vencedor.AutoSize = true;
            this.vencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencedor.Location = new System.Drawing.Point(12, 12);
            this.vencedor.Name = "vencedor";
            this.vencedor.Size = new System.Drawing.Size(110, 25);
            this.vencedor.TabIndex = 8;
            this.vencedor.Text = "Vencedor:";
            this.vencedor.Click += new System.EventHandler(this.label5_Click);
            // 
            // btreiniciar
            // 
            this.btreiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreiniciar.Location = new System.Drawing.Point(227, 122);
            this.btreiniciar.Name = "btreiniciar";
            this.btreiniciar.Size = new System.Drawing.Size(119, 46);
            this.btreiniciar.TabIndex = 9;
            this.btreiniciar.Text = "REINICIAR!";
            this.btreiniciar.UseVisualStyleBackColor = true;
            this.btreiniciar.Click += new System.EventHandler(this.btreiniciar_Click);
            // 
            // venc
            // 
            this.venc.AutoSize = true;
            this.venc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venc.Location = new System.Drawing.Point(128, 14);
            this.venc.Name = "venc";
            this.venc.Size = new System.Drawing.Size(0, 25);
            this.venc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor da partida";
            // 
            // ValorPartida
            // 
            this.ValorPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorPartida.Location = new System.Drawing.Point(482, 12);
            this.ValorPartida.Name = "ValorPartida";
            this.ValorPartida.Size = new System.Drawing.Size(57, 29);
            this.ValorPartida.TabIndex = 12;
            this.ValorPartida.Text = "12";
            this.ValorPartida.TextChanged += new System.EventHandler(this.ValorPartida_TextChanged);
            // 
            // n_jogador1
            // 
            this.n_jogador1.Location = new System.Drawing.Point(67, 174);
            this.n_jogador1.Multiline = true;
            this.n_jogador1.Name = "n_jogador1";
            this.n_jogador1.Size = new System.Drawing.Size(112, 29);
            this.n_jogador1.TabIndex = 13;

            // 
            // n_jogador2
            // 
            this.n_jogador2.Location = new System.Drawing.Point(405, 174);
            this.n_jogador2.Multiline = true;
            this.n_jogador2.Name = "n_jogador2";
            this.n_jogador2.Size = new System.Drawing.Size(113, 28);
            this.n_jogador2.TabIndex = 14;
            // 
            // bt_listar
            // 
            this.bt_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_listar.Location = new System.Drawing.Point(212, 260);
            this.bt_listar.Name = "bt_listar";
            this.bt_listar.Size = new System.Drawing.Size(134, 46);
            this.bt_listar.TabIndex = 15;
            this.bt_listar.Text = "CADASTRAR";
            this.bt_listar.UseVisualStyleBackColor = true;
            this.bt_listar.Click += new System.EventHandler(this.bt_listar_Click);
            // 
            // bt_resultado
            // 
            this.bt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_resultado.Location = new System.Drawing.Point(375, 260);
            this.bt_resultado.Name = "bt_resultado";
            this.bt_resultado.Size = new System.Drawing.Size(164, 47);
            this.bt_resultado.TabIndex = 16;
            this.bt_resultado.Text = "Gerar Resultado";
            this.bt_resultado.UseVisualStyleBackColor = true;
            this.bt_resultado.Click += new System.EventHandler(this.bt_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.bt_resultado);
            this.Controls.Add(this.bt_listar);
            this.Controls.Add(this.n_jogador2);
            this.Controls.Add(this.n_jogador1);
            this.Controls.Add(this.ValorPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venc);
            this.Controls.Add(this.btreiniciar);
            this.Controls.Add(this.vencedor);
            this.Controls.Add(this.btjoga2);
            this.Controls.Add(this.bt_joga1);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.pontos2);
            this.Controls.Add(this.pontos1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pontos1;
        private System.Windows.Forms.Label pontos2;
        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.Button bt_joga1;
        private System.Windows.Forms.Button btjoga2;
        private System.Windows.Forms.Label vencedor;
        private System.Windows.Forms.Button btreiniciar;
        private System.Windows.Forms.Label venc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorPartida;
        private System.Windows.Forms.TextBox n_jogador1;
        private System.Windows.Forms.TextBox n_jogador2;
        private System.Windows.Forms.Button bt_listar;
        private System.Windows.Forms.Button bt_resultado;
    }
}

