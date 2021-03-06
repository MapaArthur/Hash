﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace TF_WebApplication
{
    public class MultaLeve : Multa
    {
        public MultaLeve(string placa, DateTime data, uint pontos, double valor) : base(placa, data, pontos, valor)
        {
        }

        public override string ToString()
        {
            return base.ToString(); //O ToString deve retornar as informações base + o tipo da multa que é leve. 
        }
    }
}