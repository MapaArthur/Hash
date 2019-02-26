using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_WindowsForms
{
    public class Seguro : Imposto
    {
        public Seguro(DateTime ano) : base(ano)
        {
        }

        public override string ToString()
        {
            return base.ToString(); //O ToString deve retornar as informações base + o tipo de imposto que o seguro. 
        }
    }
}