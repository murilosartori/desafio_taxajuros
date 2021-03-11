using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCalculaJuros;
using RepositoryCalculaJuros;

namespace ApplicationCalculaJuros
{
    public class AppShowMeTheCode
    {
        readonly RepositoryShowMeTheCode repository = new RepositoryShowMeTheCode();

        public ShowMeTheCode GetGit()
        {
            return repository.GetShowCode();
        }
    }
}
