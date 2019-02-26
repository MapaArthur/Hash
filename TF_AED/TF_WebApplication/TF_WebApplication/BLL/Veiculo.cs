using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DataStructuresLibrary;
namespace TF_WebApplication
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