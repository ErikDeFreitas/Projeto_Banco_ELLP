namespace Login
{
    partial class Form_Trasferencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmarEnviar = new System.Windows.Forms.Button();
            this.txtBox_CPFConta = new System.Windows.Forms.TextBox();
            this.txtBox_ValorTrasferencia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "TRASFERENCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF Da Conta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor Da Trasferencia :";
            // 
            // btn_ConfirmarEnviar
            // 
            this.btn_ConfirmarEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(245)))));
            this.btn_ConfirmarEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ConfirmarEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarEnviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarEnviar.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmarEnviar.Location = new System.Drawing.Point(123, 353);
            this.btn_ConfirmarEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmarEnviar.Name = "btn_ConfirmarEnviar";
            this.btn_ConfirmarEnviar.Size = new System.Drawing.Size(288, 55);
            this.btn_ConfirmarEnviar.TabIndex = 16;
            this.btn_ConfirmarEnviar.Text = "Confirmar e Enviar";
            this.btn_ConfirmarEnviar.UseVisualStyleBackColor = false;
            this.btn_ConfirmarEnviar.Click += new System.EventHandler(this.btn_ConfirmarEnviar_Click);
            // 
            // txtBox_CPFConta
            // 
            this.txtBox_CPFConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.txtBox_CPFConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CPFConta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CPFConta.Location = new System.Drawing.Point(9, 123);
            this.txtBox_CPFConta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_CPFConta.Name = "txtBox_CPFConta";
            this.txtBox_CPFConta.Size = new System.Drawing.Size(517, 35);
            this.txtBox_CPFConta.TabIndex = 17;
            this.txtBox_CPFConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_ValorTrasferencia
            // 
            this.txtBox_ValorTrasferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.txtBox_ValorTrasferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ValorTrasferencia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ValorTrasferencia.Location = new System.Drawing.Point(9, 250);
            this.txtBox_ValorTrasferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_ValorTrasferencia.Name = "txtBox_ValorTrasferencia";
            this.txtBox_ValorTrasferencia.Size = new System.Drawing.Size(517, 35);
            this.txtBox_ValorTrasferencia.TabIndex = 18;
            this.txtBox_ValorTrasferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBox_ValorTrasferencia);
            this.panel2.Controls.Add(this.txtBox_CPFConta);
            this.panel2.Controls.Add(this.btn_ConfirmarEnviar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(259, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 432);
            this.panel2.TabIndex = 15;
            // 
            // Form_Trasferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1045, 614);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Trasferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Trasferencia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmarEnviar;
        private System.Windows.Forms.TextBox txtBox_CPFConta;
        private System.Windows.Forms.TextBox txtBox_ValorTrasferencia;
        private System.Windows.Forms.Panel panel2;
    }
}