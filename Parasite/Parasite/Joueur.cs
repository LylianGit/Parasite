using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parasite
{
    public class Joueur
    {
        private string pseudo;
        private int pv;
        private Role role;

        public Joueur(string pseudo)
        {
            this.pseudo = pseudo;
            pv = 100;
        }

        public void AddPv(int pv)
        {
            this.pv = pv;
        }

        public void AttribuerRole(Role role)
        {
            this.role = role;
        }

        public string AfficherPseudo()
        {
            return pseudo;
        }

        public string AfficherRole()
        {
            return this.role.AfficherRole();
        }
    }
}
