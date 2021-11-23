using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaCandidato.Controllers
{
    public abstract class ControllerGeneric<T> : Controller where T : class, new()
    {
        //Abstrair todos os métodos 
        public ControllerGeneric()
        {
            
        }
    }
}