namespace Login.Extensões
{
    partial class Header
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Extrato = new System.Windows.Forms.Button();
            this.btn_Trasferencia = new System.Windows.Forms.Button();
            this.btn_Deposito = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Controls.Add(this.btn_Extrato);
            this.panel1.Controls.Add(this.btn_Trasferencia);
            this.panel1.Controls.Add(this.btn_Deposito);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 123);
            this.panel1.TabIndex = 14;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(864, 28);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(136, 55);
            this.btn_Sair.TabIndex = 19;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Extrato
            // 
            this.btn_Extrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_Extrato.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Extrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Extrato.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Extrato.ForeColor = System.Drawing.Color.White;
            this.btn_Extrato.Location = new System.Drawing.Point(675, 28);
            this.btn_Extrato.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Extrato.Name = "btn_Extrato";
            this.btn_Extrato.Size = new System.Drawing.Size(181, 55);
            this.btn_Extrato.TabIndex = 18;
            this.btn_Extrato.Text = "EXTRATO";
            this.btn_Extrato.UseVisualStyleBackColor = false;
            this.btn_Extrato.Click += new System.EventHandler(this.btn_Extrato_Click);
            // 
            // btn_Trasferencia
            // 
            this.btn_Trasferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_Trasferencia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Trasferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trasferencia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trasferencia.ForeColor = System.Drawing.Color.White;
            this.btn_Trasferencia.Location = new System.Drawing.Point(224, 28);
            this.btn_Trasferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Trasferencia.Name = "btn_Trasferencia";
            this.btn_Trasferencia.Size = new System.Drawing.Size(231, 55);
            this.btn_Trasferencia.TabIndex = 17;
            this.btn_Trasferencia.Text = "TRASFERENCIA";
            this.btn_Trasferencia.UseVisualStyleBackColor = false;
            this.btn_Trasferencia.Click += new System.EventHandler(this.btn_Trasferencia_Click);
            // 
            // btn_Deposito
            // 
            this.btn_Deposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_Deposito.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposito.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deposito.ForeColor = System.Drawing.Color.White;
            this.btn_Deposito.Location = new System.Drawing.Point(463, 28);
            this.btn_Deposito.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Deposito.Name = "btn_Deposito";
            this.btn_Deposito.Size = new System.Drawing.Size(204, 55);
            this.btn_Deposito.TabIndex = 16;
            this.btn_Deposito.Text = "DEPOSITO";
            this.btn_Deposito.UseVisualStyleBackColor = false;
            this.btn_Deposito.Click += new System.EventHandler(this.btn_Deposito_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(49, 28);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(167, 55);
            this.btn_Home.TabIndex = 15;
            this.btn_Home.Text = "HOME";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1074, 123);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Extrato;
        private System.Windows.Forms.Button btn_Trasferencia;
        private System.Windows.Forms.Button btn_Deposito;
        private System.Windows.Forms.Button btn_Home;
    }
}
