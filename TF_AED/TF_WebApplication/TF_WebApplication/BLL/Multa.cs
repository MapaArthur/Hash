﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DataStructuresLibrary;

namespace TF_WebApplication
{
    public class Multa : Data
    {
        private uint pontos;
        private double valor;

        public Multa(string placa, DateTime data, uint pontos, double valor)
        {
            throw new System.NotImplementedException();
        }

        public uint Pontos { get => pontos; }
        public double Valor { get => valor; }

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