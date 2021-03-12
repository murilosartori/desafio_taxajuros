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
            try
            {
                if (valorInicial != 0 && tempo != 0)
                {
                    return repository.CalculaJurosComposto(valorInicial, tempo);
                }
                else
                {
                    throw new Exception("Informe valores validos para calcular o juros.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro. " + ex.Message);
            }
        }
    }
}
