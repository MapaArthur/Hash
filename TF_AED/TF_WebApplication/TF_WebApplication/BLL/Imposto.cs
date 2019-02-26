using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DataStructuresLibrary;

namespace TF_WebApplication
{
    public class Imposto : Data
    {
        private string placa;
        private int tipo;
        private int ano;

        public Imposto(DateTime ano)
        {
            throw new System.NotImplementedException();
        }

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
    }
}