using DomainTaxaDeJuros;
using System;

namespace RepositoryTaxaDeJuros
{
    public class RepositoryTaxaJuros
    {
        public TaxaJuros GetTaxaJuros()
        {
            return new TaxaJuros
            {
                valorTaxaJuros = 0.01M
            };
        } 
    }
}
