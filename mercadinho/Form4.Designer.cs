namespace mercadinho
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo2 = new System.Windows.Forms.TextBox();
            this.txt_nome2 = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_limpar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRAR PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CÓDIGO DO PRODUTO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "VALOR :";
            // 
            // txt_codigo2
            // 
            this.txt_codigo2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo2.Location = new System.Drawing.Point(269, 78);
            this.txt_codigo2.Name = "txt_codigo2";
            this.txt_codigo2.Size = new System.Drawing.Size(174, 27);
            this.txt_codigo2.TabIndex = 7;
            this.txt_codigo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nome2
            // 
            this.txt_nome2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome2.Location = new System.Drawing.Point(112, 124);
            this.txt_nome2.Name = "txt_nome2";
            this.txt_nome2.Size = new System.Drawing.Size(241, 27);
            this.txt_nome2.TabIndex = 8;
            this.txt_nome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valor2
            // 
            this.txt_valor2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor2.Location = new System.Drawing.Point(124, 166);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(98, 27);
            this.txt_valor2.TabIndex = 9;
            this.txt_valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Red;
            this.btn_deletar.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.Black;
            this.btn_deletar.Location = new System.Drawing.Point(32, 220);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(104, 36);
            this.btn_deletar.TabIndex = 20;
            this.btn_deletar.Text = "DELETAR";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_salvar.Location = new System.Drawing.Point(142, 220);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(104, 36);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.BackColor = System.Drawing.Color.Yellow;
            this.btn_buscar2.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar2.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar2.Location = new System.Drawing.Point(252, 220);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(104, 36);
            this.btn_buscar2.TabIndex = 22;
            this.btn_buscar2.Text = "BUSCAR";
            this.btn_buscar2.UseVisualStyleBackColor = false;
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Cyan;
            this.btn_alterar.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.Black;
            this.btn_alterar.Location = new System.Drawing.Point(362, 220);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(117, 36);
            this.btn_alterar.TabIndex = 23;
            this.btn_alterar.Text = "ATUALIZAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_limpar2
            // 
            this.btn_limpar2.BackColor = System.Drawing.Color.Gray;
            this.btn_limpar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar2.ForeColor = System.Drawing.Color.Black;
            this.btn_limpar2.Location = new System.Drawing.Point(359, 121);
            this.btn_limpar2.Name = "btn_limpar2";
            this.btn_limpar2.Size = new System.Drawing.Size(104, 31);
            this.btn_limpar2.TabIndex = 24;
            this.btn_limpar2.Text = "LIMPAR";
            this.btn_limpar2.UseVisualStyleBackColor = false;
            this.btn_limpar2.Click += new System.EventHandler(this.btn_limpar2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(504, 268);
            this.Controls.Add(this.btn_limpar2);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar2);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.txt_nome2);
            this.Controls.Add(this.txt_codigo2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "CADASTRAR PRODUTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_codigo2;
        private System.Windows.Forms.TextBox txt_nome2;
        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_buscar2;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_limpar2;
    }
}