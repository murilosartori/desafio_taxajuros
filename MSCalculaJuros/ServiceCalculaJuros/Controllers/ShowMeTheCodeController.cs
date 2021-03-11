using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCalculaJuros;
using DomainCalculaJuros;

namespace ServiceCalculaJuros.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("/showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        readonly AppShowMeTheCode app = new AppShowMeTheCode();

        [HttpGet]
        public ShowMeTheCode GetShowMeTheCode()
        {
            return app.GetGit();
        }
    }
}
