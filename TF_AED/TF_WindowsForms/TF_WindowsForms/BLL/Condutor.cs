using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataStructuresLibrary;

namespace TF_WindowsForms
{
    public sealed class Condutor: Data, IRegularizavel
    {
        private string nome;
        private List multas;
        private string cnh;
        private DateTime dataValidade;

        public Condutor(string nome, string cnh, DateTime dataValidade)
        {
            throw new System.NotImplementedException();
        }
        public string Nome { get => nome; }
        public List Multas { get => multas; }
        public string CNH { get => cnh; set => cnh = value; }
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }


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