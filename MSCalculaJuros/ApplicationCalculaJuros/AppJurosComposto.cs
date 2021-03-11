using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCalculaJuros;
using RepositoryCalculaJuros;

namespace ApplicationCalculaJuros
{
    public class AppJurosComposto
    {
        readonly RepositoryJurosComposto repository = new RepositoryJurosComposto();

        public CalculaJuros CalculaJurosComposto(decimal valorInicial, int tempo)
        {
            return RepositoryJurosComposto.CalculaJurosComposto(valorInicial, tempo);
        }
    }
}
