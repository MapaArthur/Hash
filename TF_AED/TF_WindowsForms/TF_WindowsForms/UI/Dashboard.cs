using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TF_WindowsForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            inicialControl1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            inicialControl1.BringToFront();
        }

        private void btn_PesquisarCondutor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_PesquisarCondutor.Height;
            SidePanel.Top = btn_PesquisarCondutor.Top;
            pesqCondutorControl1.BringToFront();
        }

        private void btn_PesquisarVeiculo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_PesquisarVeiculo.Height;
            SidePanel.Top = btn_PesquisarVeiculo.Top;
            pesqVeiculoControl1.BringToFront();
        }

        private void btn_MultasCondutor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_MultasCondutor.Height;
            SidePanel.Top = btn_MultasCondutor.Top;
            multasCondutorControl1.BringToFront();
        }

        private void btn_MultasVeiculo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_MultasVeiculo.Height;
            SidePanel.Top = btn_MultasVeiculo.Top;
            multasVeiculoControl1.BringToFront();
        }

        private void btn_RegulaCondutor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_RegulaCondutor.Height;
            SidePanel.Top = btn_RegulaCondutor.Top;
            reguCondutorControl1.BringToFront();
        }

        private void btn_RegularVeiculo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_RegularVeiculo.Height;
            SidePanel.Top = btn_RegularVeiculo.Top;
            reguCondutorControl1.BringToFront();
        }

        private void btn_VeiculosSemMultas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_VeiculosSemMultas.Height;
            SidePanel.Top = btn_VeiculosSemMultas.Top;
            veiculosSemMultasControl1.BringToFront();
        }
    }
}
