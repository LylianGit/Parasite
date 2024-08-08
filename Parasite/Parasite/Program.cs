using System;

namespace Parasite // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Joueur j1 = new Joueur("j1");
            Joueur j2 = new Joueur("j2");
            Joueur j3 = new Joueur("j3");
            List<Joueur> joueurs = new List<Joueur>();
            joueurs.Add(j1);
            joueurs.Add(j2);
            joueurs.Add(j3);
            Jeu jeu = new Jeu(joueurs);
            Equipe ordre = new Equipe("Ordre");
            Equipe travailleur = new Equipe("Travailleur");
            Equipe parasite = new Equipe("Parasite");
            Role superviseur = new Role("Superviseur", travailleur, null);
            Role ouvrier = new Role("Ouvrier", travailleur, null);
            Role contaminé = new Role("Contaminé", parasite, null);
            List<Role> roles = new List<Role>();
            roles.Add(superviseur);
            roles.Add(ouvrier);
            roles.Add(contaminé);
            jeu.Distribuer_Roles_Aléatoires(roles, joueurs);
            foreach (Joueur j in joueurs)
            {
                Console.WriteLine(j.AfficherPseudo());
                Console.WriteLine(j.AfficherRole());
            }
            
        }
    }
}