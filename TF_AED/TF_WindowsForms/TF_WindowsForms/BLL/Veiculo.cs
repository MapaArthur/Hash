using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataStructuresLibrary;

namespace TF_WindowsForms
{
    public class Veiculo : Data, IRegularizavel
    {
        private List impostos;
        private string placa;

        protected Veiculo(string placa)
        {

        }

        public List Impostos { get => impostos;}
        public string Placa { get => placa; }

        public override int CompareTo(Data obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Data other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public bool VerificarRegularidade()
        {
            throw new NotImplementedException();
        }
    }
}