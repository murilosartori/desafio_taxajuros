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
    /// Controlador Calcula Juros
    /// </summary>
    [Route("calculajuros")]
    public class CalculaJurosController : ControllerBase
    {
        readonly AppJurosComposto app = new AppJurosComposto();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        [HttpGet]
        public CalculaJuros GetCalculaJurosComposto(decimal valorInicial, int tempo)
        {
            return app.CalculaJurosComposto(valorInicial, tempo);
        }
    }
}
