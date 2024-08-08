using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasite
{
    public class Jeu
    {
        private List<Joueur> joueurs;
        private List<Role> roles;
        
        public Jeu(List<Joueur> joueurs)
        {

        }

        public void Distribuer_Roles_Aléatoires(List<Role> roles, List<Joueur> joueurs)
        {
            var rand = new Random();
            int nbAleatoire;

            foreach (Joueur joueur in joueurs)
            {
                nbAleatoire = rand.Next(0, roles.Count);
                joueur.AttribuerRole(roles[nbAleatoire]);
                roles.Remove(roles[nbAleatoire]);
            }

        }
    }
}
