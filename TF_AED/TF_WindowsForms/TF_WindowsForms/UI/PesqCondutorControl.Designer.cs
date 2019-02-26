namespace TF_WindowsForms
{
    partial class PesqCondutorControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_cnh = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_cnh = new System.Windows.Forms.Label();
            this.label_dataCnh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNH do Condutor";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(395, 30);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(116, 33);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // txt_cnh
            // 
            this.txt_cnh.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.txt_cnh.Location = new System.Drawing.Point(204, 30);
            this.txt_cnh.Mask = "0000000000";
            this.txt_cnh.Name = "txt_cnh";
            this.txt_cnh.Size = new System.Drawing.Size(185, 33);
            this.txt_cnh.TabIndex = 3;
            this.txt_cnh.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label2.Location = new System.Drawing.Point(97, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label3.Location = new System.Drawing.Point(97, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNH: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label4.Location = new System.Drawing.Point(97, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Validade CNH: ";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label_nome.Location = new System.Drawing.Point(218, 167);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(64, 25);
            this.label_nome.TabIndex = 7;
            this.label_nome.Text = "nome";
            // 
            // label_cnh
            // 
            this.label_cnh.AutoSize = true;
            this.label_cnh.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label_cnh.Location = new System.Drawing.Point(218, 217);
            this.label_cnh.Name = "label_cnh";
            this.label_cnh.Size = new System.Drawing.Size(46, 25);
            this.label_cnh.TabIndex = 8;
            this.label_cnh.Text = "cnh";
            // 
            // label_dataCnh
            // 
            this.label_dataCnh.AutoSize = true;
            this.label_dataCnh.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label_dataCnh.Location = new System.Drawing.Point(346, 267);
            this.label_dataCnh.Name = "label_dataCnh";
            this.label_dataCnh.Size = new System.Drawing.Size(52, 25);
            this.label_dataCnh.TabIndex = 9;
            this.label_dataCnh.Text = "data";
            // 
            // PesqCondutorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_dataCnh);
            this.Controls.Add(this.label_cnh);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cnh);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label1);
            this.Name = "PesqCondutorControl";
            this.Size = new System.Drawing.Size(1222, 858);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.MaskedTextBox txt_cnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_cnh;
        private System.Windows.Forms.Label label_dataCnh;
    }
}
