using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCalculaJuros;

namespace RepositoryCalculaJuros
{
    public class RepositoryShowMeTheCode
    {
        public ShowMeTheCode GetShowCode()
        {
            ShowMeTheCode dadosGit = new ShowMeTheCode
            {
                name = "Murilo Sartori",
                urlGit = "https://github.com/murilosartori/desafio_taxajuros"
            };
            return dadosGit;
        }
    }
}
