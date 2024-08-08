using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasite.Objet.Objets
{
    public class KitDeSoin : ObjetType
    {
        public override void Utiliser(Role roleRequis, Role roleDuJoueur, Joueur cible)
        {
            if (roleRequis == roleDuJoueur)
            {
                cible.AddPv(75);
            }
            else
            {
                cible.AddPv(25);
            }
        }
    }
}
