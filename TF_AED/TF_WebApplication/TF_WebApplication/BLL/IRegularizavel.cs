using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace TF_WebApplication
{
    public interface IRegularizavel
    {
        bool VerificarRegularidade();
    }
}