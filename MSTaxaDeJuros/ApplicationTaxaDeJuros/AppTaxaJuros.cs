using DomainTaxaDeJuros;
using RepositoryTaxaDeJuros;

namespace ApplicationTaxaDeJuros
{
    public class AppTaxaJuros
    {
        readonly RepositoryTaxaJuros repository = new RepositoryTaxaJuros();

        public TaxaJuros GetTaxaJuros()
        {
            return repository.GetTaxaJuros();
        }
    }
}
