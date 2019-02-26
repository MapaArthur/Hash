namespace TF_WindowsForms
{
    partial class ReguVeiculoControl
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
            this.txt_placa = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_regular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.txt_placa.Location = new System.Drawing.Point(194, 30);
            this.txt_placa.Mask = "LLL-0000";
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(185, 33);
            this.txt_placa.TabIndex = 13;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(385, 30);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(116, 33);
            this.btn_pesquisar.TabIndex = 12;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Placa do Veículo";
            // 
            // label_regular
            // 
            this.label_regular.AutoSize = true;
            this.label_regular.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label_regular.Location = new System.Drawing.Point(149, 117);
            this.label_regular.Name = "label_regular";
            this.label_regular.Size = new System.Drawing.Size(87, 25);
            this.label_regular.TabIndex = 15;
            this.label_regular.Text = "sim/não";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Regular:";
            // 
            // ReguVeiculoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_regular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label1);
            this.Name = "ReguVeiculoControl";
            this.Size = new System.Drawing.Size(1222, 858);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_placa;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_regular;
        private System.Windows.Forms.Label label2;
    }
}
