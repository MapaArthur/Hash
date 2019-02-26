using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_WindowsForms
{
    public partial class VeiculosSemMultasControl : UserControl
    {
        public VeiculosSemMultasControl()
        {
            InitializeComponent();
            //Exemplo de como inserir na ListView:
            ListViewItem novoItem = new ListViewItem("AAA-1234");
            listView1.Items.Add(novoItem);
            novoItem = new ListViewItem("BBB-1234");
            listView1.Items.Add(novoItem);
            novoItem = new ListViewItem("CCC-1234");
            listView1.Items.Add(novoItem);
            // Fim do exemplo
        }
    }
}
