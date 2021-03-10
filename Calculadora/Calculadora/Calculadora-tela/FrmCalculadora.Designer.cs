namespace Calculadora
{
    partial class frmCalculadora
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
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnApagarUm = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnApagarAcao = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNumero9 = new System.Windows.Forms.Button();
            this.btnNumero8 = new System.Windows.Forms.Button();
            this.btnNumero7 = new System.Windows.Forms.Button();
            this.btnNumero6 = new System.Windows.Forms.Button();
            this.btnNumero5 = new System.Windows.Forms.Button();
            this.btnNumero4 = new System.Windows.Forms.Button();
            this.btnNumero3 = new System.Windows.Forms.Button();
            this.btnNumero2 = new System.Windows.Forms.Button();
            this.btnNumero1 = new System.Windows.Forms.Button();
            this.btnNumero0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.lblAnteriorAcao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(298, -4);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(25, 30);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(268, 3);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(24, 21);
            this.lblMinimizar.TabIndex = 1;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Calculadora";
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.White;
            this.btnDivisao.Location = new System.Drawing.Point(248, 157);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 46);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacao.Location = new System.Drawing.Point(248, 209);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 46);
            this.btnMultiplicacao.TabIndex = 5;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.White;
            this.btnSubtracao.Location = new System.Drawing.Point(248, 261);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 46);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = " — ";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.White;
            this.btnAdicao.Location = new System.Drawing.Point(248, 313);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 46);
            this.btnAdicao.TabIndex = 7;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(248, 365);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 46);
            this.btnIgual.TabIndex = 8;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnApagarUm
            // 
            this.btnApagarUm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApagarUm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarUm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarUm.ForeColor = System.Drawing.Color.White;
            this.btnApagarUm.Location = new System.Drawing.Point(167, 157);
            this.btnApagarUm.Name = "btnApagarUm";
            this.btnApagarUm.Size = new System.Drawing.Size(75, 46);
            this.btnApagarUm.TabIndex = 9;
            this.btnApagarUm.Text = "⌫";
            this.btnApagarUm.UseVisualStyleBackColor = false;
            this.btnApagarUm.Click += new System.EventHandler(this.btnApagarUm_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApagarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarTudo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTudo.ForeColor = System.Drawing.Color.White;
            this.btnApagarTudo.Location = new System.Drawing.Point(86, 157);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(75, 46);
            this.btnApagarTudo.TabIndex = 10;
            this.btnApagarTudo.Text = "C";
            this.btnApagarTudo.UseVisualStyleBackColor = false;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // btnApagarAcao
            // 
            this.btnApagarAcao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApagarAcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarAcao.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAcao.ForeColor = System.Drawing.Color.White;
            this.btnApagarAcao.Location = new System.Drawing.Point(5, 157);
            this.btnApagarAcao.Name = "btnApagarAcao";
            this.btnApagarAcao.Size = new System.Drawing.Size(75, 46);
            this.btnApagarAcao.TabIndex = 11;
            this.btnApagarAcao.Text = "CE";
            this.btnApagarAcao.UseVisualStyleBackColor = false;
            this.btnApagarAcao.Click += new System.EventHandler(this.btnApagarAcao_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.DimGray;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(5, 81);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(318, 50);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // btnNumero9
            // 
            this.btnNumero9.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero9.ForeColor = System.Drawing.Color.White;
            this.btnNumero9.Location = new System.Drawing.Point(167, 209);
            this.btnNumero9.Name = "btnNumero9";
            this.btnNumero9.Size = new System.Drawing.Size(75, 46);
            this.btnNumero9.TabIndex = 13;
            this.btnNumero9.Text = "9";
            this.btnNumero9.UseVisualStyleBackColor = false;
            this.btnNumero9.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero8
            // 
            this.btnNumero8.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero8.ForeColor = System.Drawing.Color.White;
            this.btnNumero8.Location = new System.Drawing.Point(86, 209);
            this.btnNumero8.Name = "btnNumero8";
            this.btnNumero8.Size = new System.Drawing.Size(75, 46);
            this.btnNumero8.TabIndex = 14;
            this.btnNumero8.Text = "8";
            this.btnNumero8.UseVisualStyleBackColor = false;
            this.btnNumero8.Click += new System.EventHandler(this.btnNumero8_Click);
            // 
            // btnNumero7
            // 
            this.btnNumero7.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero7.ForeColor = System.Drawing.Color.White;
            this.btnNumero7.Location = new System.Drawing.Point(5, 209);
            this.btnNumero7.Name = "btnNumero7";
            this.btnNumero7.Size = new System.Drawing.Size(75, 46);
            this.btnNumero7.TabIndex = 15;
            this.btnNumero7.Text = "7";
            this.btnNumero7.UseVisualStyleBackColor = false;
            this.btnNumero7.Click += new System.EventHandler(this.btnNumero7_Click);
            // 
            // btnNumero6
            // 
            this.btnNumero6.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero6.ForeColor = System.Drawing.Color.White;
            this.btnNumero6.Location = new System.Drawing.Point(167, 261);
            this.btnNumero6.Name = "btnNumero6";
            this.btnNumero6.Size = new System.Drawing.Size(75, 46);
            this.btnNumero6.TabIndex = 16;
            this.btnNumero6.Text = "6";
            this.btnNumero6.UseVisualStyleBackColor = false;
            this.btnNumero6.Click += new System.EventHandler(this.btnNumero6_Click);
            // 
            // btnNumero5
            // 
            this.btnNumero5.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero5.ForeColor = System.Drawing.Color.White;
            this.btnNumero5.Location = new System.Drawing.Point(86, 261);
            this.btnNumero5.Name = "btnNumero5";
            this.btnNumero5.Size = new System.Drawing.Size(75, 46);
            this.btnNumero5.TabIndex = 17;
            this.btnNumero5.Text = "5";
            this.btnNumero5.UseVisualStyleBackColor = false;
            this.btnNumero5.Click += new System.EventHandler(this.btnNumero5_Click);
            // 
            // btnNumero4
            // 
            this.btnNumero4.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero4.ForeColor = System.Drawing.Color.White;
            this.btnNumero4.Location = new System.Drawing.Point(5, 261);
            this.btnNumero4.Name = "btnNumero4";
            this.btnNumero4.Size = new System.Drawing.Size(75, 46);
            this.btnNumero4.TabIndex = 18;
            this.btnNumero4.Text = "4";
            this.btnNumero4.UseVisualStyleBackColor = false;
            this.btnNumero4.Click += new System.EventHandler(this.btnNumero4_Click);
            // 
            // btnNumero3
            // 
            this.btnNumero3.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero3.ForeColor = System.Drawing.Color.White;
            this.btnNumero3.Location = new System.Drawing.Point(167, 313);
            this.btnNumero3.Name = "btnNumero3";
            this.btnNumero3.Size = new System.Drawing.Size(75, 46);
            this.btnNumero3.TabIndex = 19;
            this.btnNumero3.Text = "3";
            this.btnNumero3.UseVisualStyleBackColor = false;
            this.btnNumero3.Click += new System.EventHandler(this.btnNumero3_Click);
            // 
            // btnNumero2
            // 
            this.btnNumero2.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero2.ForeColor = System.Drawing.Color.White;
            this.btnNumero2.Location = new System.Drawing.Point(86, 313);
            this.btnNumero2.Name = "btnNumero2";
            this.btnNumero2.Size = new System.Drawing.Size(75, 46);
            this.btnNumero2.TabIndex = 20;
            this.btnNumero2.Text = "2";
            this.btnNumero2.UseVisualStyleBackColor = false;
            this.btnNumero2.Click += new System.EventHandler(this.btnNumero2_Click);
            // 
            // btnNumero1
            // 
            this.btnNumero1.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero1.ForeColor = System.Drawing.Color.White;
            this.btnNumero1.Location = new System.Drawing.Point(5, 313);
            this.btnNumero1.Name = "btnNumero1";
            this.btnNumero1.Size = new System.Drawing.Size(75, 46);
            this.btnNumero1.TabIndex = 21;
            this.btnNumero1.Text = "1";
            this.btnNumero1.UseVisualStyleBackColor = false;
            this.btnNumero1.Click += new System.EventHandler(this.btnNumero1_Click);
            // 
            // btnNumero0
            // 
            this.btnNumero0.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNumero0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumero0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumero0.ForeColor = System.Drawing.Color.White;
            this.btnNumero0.Location = new System.Drawing.Point(86, 365);
            this.btnNumero0.Name = "btnNumero0";
            this.btnNumero0.Size = new System.Drawing.Size(75, 46);
            this.btnNumero0.TabIndex = 22;
            this.btnNumero0.Text = "0";
            this.btnNumero0.UseVisualStyleBackColor = false;
            this.btnNumero0.Click += new System.EventHandler(this.btnNumero0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVirgula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.White;
            this.btnVirgula.Location = new System.Drawing.Point(167, 364);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(75, 46);
            this.btnVirgula.TabIndex = 23;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMaisMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaisMenos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.ForeColor = System.Drawing.Color.White;
            this.btnMaisMenos.Location = new System.Drawing.Point(5, 364);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(75, 46);
            this.btnMaisMenos.TabIndex = 24;
            this.btnMaisMenos.Text = "±";
            this.btnMaisMenos.UseVisualStyleBackColor = false;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // lblAnteriorAcao
            // 
            this.lblAnteriorAcao.BackColor = System.Drawing.Color.DimGray;
            this.lblAnteriorAcao.ForeColor = System.Drawing.Color.White;
            this.lblAnteriorAcao.Location = new System.Drawing.Point(5, 63);
            this.lblAnteriorAcao.Name = "lblAnteriorAcao";
            this.lblAnteriorAcao.Size = new System.Drawing.Size(318, 18);
            this.lblAnteriorAcao.TabIndex = 25;
            this.lblAnteriorAcao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmCalculadora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(328, 420);
            this.Controls.Add(this.lblAnteriorAcao);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNumero0);
            this.Controls.Add(this.btnNumero1);
            this.Controls.Add(this.btnNumero2);
            this.Controls.Add(this.btnNumero3);
            this.Controls.Add(this.btnNumero4);
            this.Controls.Add(this.btnNumero5);
            this.Controls.Add(this.btnNumero6);
            this.Controls.Add(this.btnNumero7);
            this.Controls.Add(this.btnNumero8);
            this.Controls.Add(this.btnNumero9);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnApagarAcao);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnApagarUm);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMinimizar);
            this.Controls.Add(this.lblFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCalculadora_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCalculadora_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCalculadora_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnApagarUm;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Button btnApagarAcao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNumero9;
        private System.Windows.Forms.Button btnNumero8;
        private System.Windows.Forms.Button btnNumero7;
        private System.Windows.Forms.Button btnNumero6;
        private System.Windows.Forms.Button btnNumero5;
        private System.Windows.Forms.Button btnNumero4;
        private System.Windows.Forms.Button btnNumero3;
        private System.Windows.Forms.Button btnNumero2;
        private System.Windows.Forms.Button btnNumero1;
        private System.Windows.Forms.Button btnNumero0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Label lblAnteriorAcao;
    }
}

