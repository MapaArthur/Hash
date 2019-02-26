using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_WindowsForms
{
    public class MultaGravissima : Multa
    {
        public MultaGravissima(string placa, DateTime data, uint pontos, double valor) : base(placa, data, pontos, valor)
        {
        }

        public override string ToString()
        {
            return base.ToString(); //O ToString deve retornar as informações base + o tipo da multa que é gravíssima. 
        }
    }
}