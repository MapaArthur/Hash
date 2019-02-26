namespace TF_WindowsForms
{
    partial class Dashboard
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
            this.Panel_MenuEsq = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_VeiculosSemMultas = new System.Windows.Forms.Button();
            this.btn_RegularVeiculo = new System.Windows.Forms.Button();
            this.btn_RegulaCondutor = new System.Windows.Forms.Button();
            this.btn_MultasVeiculo = new System.Windows.Forms.Button();
            this.btn_MultasCondutor = new System.Windows.Forms.Button();
            this.btn_PesquisarVeiculo = new System.Windows.Forms.Button();
            this.btn_PesquisarCondutor = new System.Windows.Forms.Button();
            this.panel_MenuSuperior = new System.Windows.Forms.Panel();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.veiculosSemMultasControl1 = new TF_WindowsForms.VeiculosSemMultasControl();
            this.reguVeiculoControl1 = new TF_WindowsForms.ReguVeiculoControl();
            this.reguCondutorControl1 = new TF_WindowsForms.ReguCondutorControl();
            this.multasVeiculoControl1 = new TF_WindowsForms.MultasVeiculoControl();
            this.multasCondutorControl1 = new TF_WindowsForms.MultasCondutorControl();
            this.pesqVeiculoControl1 = new TF_WindowsForms.PesqVeiculoControl();
            this.pesqCondutorControl1 = new TF_WindowsForms.PesqCondutorControl();
            this.inicialControl1 = new TF_WindowsForms.InicialControl();
            this.Panel_MenuEsq.SuspendLayout();
            this.panel_dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MenuEsq
            // 
            this.Panel_MenuEsq.BackColor = System.Drawing.Color.MidnightBlue;
            this.Panel_MenuEsq.Controls.Add(this.SidePanel);
            this.Panel_MenuEsq.Controls.Add(this.btn_home);
            this.Panel_MenuEsq.Controls.Add(this.btn_VeiculosSemMultas);
            this.Panel_MenuEsq.Controls.Add(this.btn_RegularVeiculo);
            this.Panel_MenuEsq.Controls.Add(this.btn_RegulaCondutor);
            this.Panel_MenuEsq.Controls.Add(this.btn_MultasVeiculo);
            this.Panel_MenuEsq.Controls.Add(this.btn_MultasCondutor);
            this.Panel_MenuEsq.Controls.Add(this.btn_PesquisarVeiculo);
            this.Panel_MenuEsq.Controls.Add(this.btn_PesquisarCondutor);
            this.Panel_MenuEsq.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_MenuEsq.Location = new System.Drawing.Point(0, 0);
            this.Panel_MenuEsq.Name = "Panel_MenuEsq";
            this.Panel_MenuEsq.Size = new System.Drawing.Size(196, 870);
            this.Panel_MenuEsq.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 12);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 106);
            this.SidePanel.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(196, 106);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Inicial";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_VeiculosSemMultas
            // 
            this.btn_VeiculosSemMultas.FlatAppearance.BorderSize = 0;
            this.btn_VeiculosSemMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VeiculosSemMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VeiculosSemMultas.ForeColor = System.Drawing.Color.White;
            this.btn_VeiculosSemMultas.Location = new System.Drawing.Point(0, 754);
            this.btn_VeiculosSemMultas.Name = "btn_VeiculosSemMultas";
            this.btn_VeiculosSemMultas.Size = new System.Drawing.Size(196, 106);
            this.btn_VeiculosSemMultas.TabIndex = 6;
            this.btn_VeiculosSemMultas.Text = "Veículos sem Multas";
            this.btn_VeiculosSemMultas.UseVisualStyleBackColor = true;
            this.btn_VeiculosSemMultas.Click += new System.EventHandler(this.btn_VeiculosSemMultas_Click);
            // 
            // btn_RegularVeiculo
            // 
            this.btn_RegularVeiculo.FlatAppearance.BorderSize = 0;
            this.btn_RegularVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegularVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegularVeiculo.ForeColor = System.Drawing.Color.White;
            this.btn_RegularVeiculo.Location = new System.Drawing.Point(0, 648);
            this.btn_RegularVeiculo.Name = "btn_RegularVeiculo";
            this.btn_RegularVeiculo.Size = new System.Drawing.Size(196, 106);
            this.btn_RegularVeiculo.TabIndex = 5;
            this.btn_RegularVeiculo.Text = "Regularidade do Veículo";
            this.btn_RegularVeiculo.UseVisualStyleBackColor = true;
            this.btn_RegularVeiculo.Click += new System.EventHandler(this.btn_RegularVeiculo_Click);
            // 
            // btn_RegulaCondutor
            // 
            this.btn_RegulaCondutor.FlatAppearance.BorderSize = 0;
            this.btn_RegulaCondutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegulaCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegulaCondutor.ForeColor = System.Drawing.Color.White;
            this.btn_RegulaCondutor.Location = new System.Drawing.Point(0, 542);
            this.btn_RegulaCondutor.Name = "btn_RegulaCondutor";
            this.btn_RegulaCondutor.Size = new System.Drawing.Size(196, 106);
            this.btn_RegulaCondutor.TabIndex = 4;
            this.btn_RegulaCondutor.Text = "Regularidade do Condutor";
            this.btn_RegulaCondutor.UseVisualStyleBackColor = true;
            this.btn_RegulaCondutor.Click += new System.EventHandler(this.btn_RegulaCondutor_Click);
            // 
            // btn_MultasVeiculo
            // 
            this.btn_MultasVeiculo.FlatAppearance.BorderSize = 0;
            this.btn_MultasVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MultasVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MultasVeiculo.ForeColor = System.Drawing.Color.White;
            this.btn_MultasVeiculo.Location = new System.Drawing.Point(0, 436);
            this.btn_MultasVeiculo.Name = "btn_MultasVeiculo";
            this.btn_MultasVeiculo.Size = new System.Drawing.Size(196, 106);
            this.btn_MultasVeiculo.TabIndex = 3;
            this.btn_MultasVeiculo.Text = "Multas do Veículo";
            this.btn_MultasVeiculo.UseVisualStyleBackColor = true;
            this.btn_MultasVeiculo.Click += new System.EventHandler(this.btn_MultasVeiculo_Click);
            // 
            // btn_MultasCondutor
            // 
            this.btn_MultasCondutor.FlatAppearance.BorderSize = 0;
            this.btn_MultasCondutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MultasCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MultasCondutor.ForeColor = System.Drawing.Color.White;
            this.btn_MultasCondutor.Location = new System.Drawing.Point(0, 330);
            this.btn_MultasCondutor.Name = "btn_MultasCondutor";
            this.btn_MultasCondutor.Size = new System.Drawing.Size(196, 106);
            this.btn_MultasCondutor.TabIndex = 2;
            this.btn_MultasCondutor.Text = "Multas do Condutor";
            this.btn_MultasCondutor.UseVisualStyleBackColor = true;
            this.btn_MultasCondutor.Click += new System.EventHandler(this.btn_MultasCondutor_Click);
            // 
            // btn_PesquisarVeiculo
            // 
            this.btn_PesquisarVeiculo.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btn_PesquisarVeiculo.Location = new System.Drawing.Point(0, 224);
            this.btn_PesquisarVeiculo.Name = "btn_PesquisarVeiculo";
            this.btn_PesquisarVeiculo.Size = new System.Drawing.Size(196, 106);
            this.btn_PesquisarVeiculo.TabIndex = 1;
            this.btn_PesquisarVeiculo.Text = "Pesquisar Veículo";
            this.btn_PesquisarVeiculo.UseVisualStyleBackColor = true;
            this.btn_PesquisarVeiculo.Click += new System.EventHandler(this.btn_PesquisarVeiculo_Click);
            // 
            // btn_PesquisarCondutor
            // 
            this.btn_PesquisarCondutor.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarCondutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarCondutor.ForeColor = System.Drawing.Color.White;
            this.btn_PesquisarCondutor.Location = new System.Drawing.Point(0, 118);
            this.btn_PesquisarCondutor.Name = "btn_PesquisarCondutor";
            this.btn_PesquisarCondutor.Size = new System.Drawing.Size(196, 106);
            this.btn_PesquisarCondutor.TabIndex = 0;
            this.btn_PesquisarCondutor.Text = "Pesquisar  Condutor";
            this.btn_PesquisarCondutor.UseVisualStyleBackColor = true;
            this.btn_PesquisarCondutor.Click += new System.EventHandler(this.btn_PesquisarCondutor_Click);
            // 
            // panel_MenuSuperior
            // 
            this.panel_MenuSuperior.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MenuSuperior.Location = new System.Drawing.Point(196, 0);
            this.panel_MenuSuperior.Name = "panel_MenuSuperior";
            this.panel_MenuSuperior.Size = new System.Drawing.Size(1222, 15);
            this.panel_MenuSuperior.TabIndex = 1;
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.Controls.Add(this.veiculosSemMultasControl1);
            this.panel_dashboard.Controls.Add(this.reguVeiculoControl1);
            this.panel_dashboard.Controls.Add(this.reguCondutorControl1);
            this.panel_dashboard.Controls.Add(this.multasVeiculoControl1);
            this.panel_dashboard.Controls.Add(this.multasCondutorControl1);
            this.panel_dashboard.Controls.Add(this.pesqVeiculoControl1);
            this.panel_dashboard.Controls.Add(this.pesqCondutorControl1);
            this.panel_dashboard.Controls.Add(this.inicialControl1);
            this.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_dashboard.Location = new System.Drawing.Point(196, 12);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Size = new System.Drawing.Size(1222, 858);
            this.panel_dashboard.TabIndex = 9;
            // 
            // veiculosSemMultasControl1
            // 
            this.veiculosSemMultasControl1.Location = new System.Drawing.Point(0, 0);
            this.veiculosSemMultasControl1.Name = "veiculosSemMultasControl1";
            this.veiculosSemMultasControl1.Size = new System.Drawing.Size(1222, 858);
            this.veiculosSemMultasControl1.TabIndex = 7;
            // 
            // reguVeiculoControl1
            // 
            this.reguVeiculoControl1.Location = new System.Drawing.Point(0, 0);
            this.reguVeiculoControl1.Name = "reguVeiculoControl1";
            this.reguVeiculoControl1.Size = new System.Drawing.Size(1222, 858);
            this.reguVeiculoControl1.TabIndex = 6;
            // 
            // reguCondutorControl1
            // 
            this.reguCondutorControl1.Location = new System.Drawing.Point(0, 0);
            this.reguCondutorControl1.Name = "reguCondutorControl1";
            this.reguCondutorControl1.Size = new System.Drawing.Size(1222, 858);
            this.reguCondutorControl1.TabIndex = 5;
            // 
            // multasVeiculoControl1
            // 
            this.multasVeiculoControl1.Location = new System.Drawing.Point(0, 0);
            this.multasVeiculoControl1.Name = "multasVeiculoControl1";
            this.multasVeiculoControl1.Size = new System.Drawing.Size(1222, 858);
            this.multasVeiculoControl1.TabIndex = 4;
            // 
            // multasCondutorControl1
            // 
            this.multasCondutorControl1.Location = new System.Drawing.Point(0, 0);
            this.multasCondutorControl1.Name = "multasCondutorControl1";
            this.multasCondutorControl1.Size = new System.Drawing.Size(1222, 858);
            this.multasCondutorControl1.TabIndex = 3;
            // 
            // pesqVeiculoControl1
            // 
            this.pesqVeiculoControl1.Location = new System.Drawing.Point(0, 0);
            this.pesqVeiculoControl1.Name = "pesqVeiculoControl1";
            this.pesqVeiculoControl1.Size = new System.Drawing.Size(1222, 858);
            this.pesqVeiculoControl1.TabIndex = 2;
            // 
            // pesqCondutorControl1
            // 
            this.pesqCondutorControl1.Location = new System.Drawing.Point(0, 0);
            this.pesqCondutorControl1.Name = "pesqCondutorControl1";
            this.pesqCondutorControl1.Size = new System.Drawing.Size(1222, 858);
            this.pesqCondutorControl1.TabIndex = 1;
            // 
            // inicialControl1
            // 
            this.inicialControl1.Location = new System.Drawing.Point(0, 0);
            this.inicialControl1.Name = "inicialControl1";
            this.inicialControl1.Size = new System.Drawing.Size(1222, 858);
            this.inicialControl1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1418, 870);
            this.Controls.Add(this.panel_dashboard);
            this.Controls.Add(this.panel_MenuSuperior);
            this.Controls.Add(this.Panel_MenuEsq);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Panel_MenuEsq.ResumeLayout(false);
            this.panel_dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MenuEsq;
        private System.Windows.Forms.Button btn_VeiculosSemMultas;
        private System.Windows.Forms.Button btn_RegularVeiculo;
        private System.Windows.Forms.Button btn_RegulaCondutor;
        private System.Windows.Forms.Button btn_MultasVeiculo;
        private System.Windows.Forms.Button btn_MultasCondutor;
        private System.Windows.Forms.Button btn_PesquisarVeiculo;
        private System.Windows.Forms.Button btn_PesquisarCondutor;
        private System.Windows.Forms.Panel panel_MenuSuperior;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.Panel SidePanel;
        private PesqCondutorControl pesqCondutorControl1;
        private InicialControl inicialControl1;
        private PesqVeiculoControl pesqVeiculoControl1;
        private MultasCondutorControl multasCondutorControl1;
        private MultasVeiculoControl multasVeiculoControl1;
        private ReguCondutorControl reguCondutorControl1;
        private ReguVeiculoControl reguVeiculoControl1;
        private VeiculosSemMultasControl veiculosSemMultasControl1;
    }
}

