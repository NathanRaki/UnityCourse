using System;

namespace TD3
{
    class Program
    {
        // Exercice 1
        public class Boss
        {
            public int pointsAttaque; // Attribut
            private int id; // Attribut
            string nom; // Attribut
            int vitesse; // Attribut
            public Boss() // Constructeur
            {
                pointsAttaque = 200;
                int vitesse = 5; // Variable
                string code = nom + id; // Variable
                Console.WriteLine(code);
            }
        }
        // Exercice 2
        public class Ennemi
        {
            // Added private to every attribute
            private int pointsAttaque;
            private double vitesse;
            private int id;
            private float vie;

            // Getters & Setters
            public int PointsAttaque { get => pointsAttaque; set => pointsAttaque = value; }
            public double Vitesse { get => vitesse; set => vitesse = value; }
            public int Id { get => id; set => id = value; }
            public float Vie { get => vie; set => vie = value; }

            // Modified functions and constructor to public
            public Ennemi()
            {
                vie = 100;
                Vitesse = 5;
                PointsAttaque = 25;
            }
            public float attaque(string target)
            {
                Random rand = new Random();
                int percent = rand.Next(0, 101);
                float degats = PointsAttaque * (percent / 100f);
                Console.WriteLine("\tL'Ennemi attaque " + target + " à " + percent + "% de son potentiel.");
                return degats;
            }
            public void defend() { Console.WriteLine(" Je me défend "); }
            public void incrementerPointAttaque()
            {
                Console.WriteLine(" Je prépare mon attaque! ");
                PointsAttaque++;
            }
            public override string ToString()
            {
                return "Ennemi \n" + "\tHP: " + (int)vie + "\n" + "\tVitesse: " + vitesse + "\n" + "\tAttaque: " + pointsAttaque;
            }
        }

        // Exercice 3
        public class Allie
        {
            private int pointsAttaque;
            private float vie;
            private int id;

            public int PointsAttaque { get => pointsAttaque; set => pointsAttaque = value; }
            public float Vie { get => vie; set => vie = value; }
            public int Id { get => id; set => id = value; }

            public Allie()
            {
                pointsAttaque = 10;
                vie = 75;
                id = 0;
            }
            public float attaque()
            {
                Random rand = new Random();
                int percent = rand.Next(0, 101);
                float degats = PointsAttaque * (percent / 100.0f);
                Console.WriteLine("\tL'Allie attaque à " + percent + "% de son potentiel.");
                return degats;
            }
            public void defend() { Console.WriteLine(" Je me défend "); }
            public override string ToString()
            {
                return "Allie: \n" + "\tHP: " + (int)vie + "\n" + "\tAttaque: " + pointsAttaque;
            }
        }
        public class Personnage
        {
            private float vie;
            private double vitesse;
            private int id;

            public float Vie { get => vie; set => vie = value; }
            public double Vitesse { get => vitesse; set => vitesse = value; }
            public int Id { get => id; set => id = value; }

            public Personnage()
            {
                vie = 75;
                vitesse = 15;
                id = 0;
            }

            public void marche() { Console.WriteLine(" J'avance. "); }
            public void arrete() { Console.WriteLine(" Je m'arrete. "); }
            public void soin() { vie += 30; }
            public override string ToString()
            {
                return "Personnage: \n" + "\tHP: " + (int)vie + "\n" + "\tVitesse: " + vitesse;
            }
        }

        static void Main(string[] args)
        {
            Personnage personnage = new Personnage();
            Ennemi ennemi = new Ennemi();
            Allie allie = new Allie();

            int N = 10;
            Console.WriteLine("Vous devez survivre " + N + " tours.\n");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Tour " + (i + 1));
                Console.WriteLine(personnage.ToString());
                Console.WriteLine(allie.ToString());
                Console.WriteLine(ennemi.ToString());
                Console.WriteLine("Actions possibles :");
                Console.WriteLine("\tH: Soigne le Personnage");
                Console.WriteLine("\tD: Demande à l'Allie de proteger le Personnage. Le Personnage se soigne.");
                Console.WriteLine("\tA: Demande à l'Allie d'attaquer l'Ennemi.");

                Console.WriteLine("-------------------");
                string action = Console.ReadLine();

                if (action == "H" || action == "D")
                    personnage.soin();
                else if (action == "A")
                    ennemi.Vie -= allie.attaque();

                if (ennemi.Vie <= 0) { Console.WriteLine("C'est gagné !"); break; }

                if (action != "D")
                    personnage.Vie -= ennemi.attaque("Personnage");
                else
                    allie.Vie -= ennemi.attaque("Allie");

                if (personnage.Vie <= 0) { Console.WriteLine("C'est perdu !"); break; }
                Console.WriteLine("-------------------\n");
            }
            if (personnage.Vie > 0 && ennemi.Vie > 0) { Console.WriteLine("C'est gagné !"); }
        }
    }
}
