using ApplicationTaxaDeJuros;
using DomainTaxaDeJuros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceTaxaDeJuros.Controllers
{
    /// <summary>
    /// Controlador Taxa de Juros
    /// </summary>
    [Route("taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        readonly AppTaxaJuros app = new AppTaxaJuros();

        /// <summary>
        /// Retorna o valor da taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public TaxaJuros GetTaxaJuros()
        {
            return app.GetTaxaJuros();
        }
    }
}
