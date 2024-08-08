using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasite
{
    public class Role
    {
        protected string nom;
        protected Equipe equipe;
        protected List<ObjetType> stuff;

        public Role(string nom, Equipe equipe, List<ObjetType> stuff)
        {
            this.nom = nom;
            this.equipe = equipe;
            this.stuff = stuff;
        }

        public string AfficherRole()
        {
            return nom;
        }

    }
}
