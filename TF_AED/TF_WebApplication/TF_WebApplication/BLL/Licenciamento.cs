﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace TF_WebApplication
{
    public class Licenciamento : Imposto
    {
        public Licenciamento(DateTime ano) : base(ano)
        {
        }

        public override string ToString()
        {
            return base.ToString(); //O ToString deve retornar as informações base + o tipo de imposto que o licenciamento. 
        }
    }
}