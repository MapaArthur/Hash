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
    public partial class MultasVeiculoControl : UserControl
    {
        public MultasVeiculoControl()
        {
            InitializeComponent();
            //Exemplo de como inserir na ListView:
            ListViewItem novoItem = new ListViewItem("Gravíssima");
            novoItem.SubItems.Add("02/03/2018");
            novoItem.SubItems.Add("R$ 200,00");
            listView1.Items.Add(novoItem);
            // Fim do exemplo
        }
    }
}
