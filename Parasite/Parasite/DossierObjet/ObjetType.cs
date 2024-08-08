using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasite
{
    public abstract class ObjetType
    {
        protected string nom;

        public abstract void Utiliser(Role roleRequis, Role roleDuJoueur, Joueur cible);
    }
}
