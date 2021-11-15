using System;

namespace CSharp
{
    class TD1
    {
        // Exercice 1
        static public void correction()
        {
            string prenom = "Nicolas"; string civilite = "M.";
            int age = 30; // This variable was only available in the first if statement
            if (prenom == "Nicolas") // == is for comparison
            {
                Console.WriteLine("Votre âge est : " + age);
            }
            if (civilite == "M.")
            { // Don't forget the {
                Console.WriteLine("Vous êtes un homme de " + age + " ans");
            }
            else if (civilite == "Mme")
            {
                Console.WriteLine("Vous êtes une femme de " + age + " ans");
            }
            if (age >= 18)
                Console.WriteLine(prenom + ", vous êtes majeur");
        }
        // Exercice 2
        static public void form()
        {
            string prenom = ""; string civilite = "";
            int age;

            string choice;
            Console.WriteLine("Quelle est votre civilité ?");
            Console.WriteLine("\t1: M. 2: Mme");
            choice = Console.ReadLine();
            if (choice == "1") { civilite = "M."; }
            else if (choice == "2") { civilite = "Mme"; }
            else
            {
                Console.WriteLine("Choix non reconnu.");
                Environment.Exit(1);
            }

            Console.WriteLine("Entrez votre prénom : ");
            prenom = Console.ReadLine();

            Console.WriteLine("Entrez votre âge : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (prenom == "Nicolas")
                Console.WriteLine("Votre âge est : " + age);

            if (civilite == "M.")
                Console.WriteLine("Vous êtes un homme de " + age + " ans");
            else if (civilite == "Mme")
                Console.WriteLine("Vous êtes une femme de " + age + " ans");

            if (age >= 18)
                Console.WriteLine(prenom + ", vous êtes majeur");

        }
        // Exercice 3
        class Pizza
        {
            float diametre;
            float prix;
            public Pizza() { diametre = 0f; prix = 0f; }
            public Pizza(float d, float p) { diametre = d; prix = p; }
            
            public float Rapport() { return diametre / prix; }
            public string toString()
            {
                string ret = "";
                ret += "Diametre: " + diametre + "cm \n";
                ret += "Prix: " + prix + "e \n";
                ret += "Diametre pour 1 euro: " + Rapport() + "cm \n";
                return ret;
            }
        }
        // Exercice 4
        static public int fact(int n)
        {
            if (n <= 1) { return 1; }
            return n * fact(n - 1);
        }
        static public void factToN(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.WriteLine("Factoriel de " + i + ": " + fact(i));
            Console.WriteLine("\n");
        }
        // Exercice 5
        static public void odd(int n)
        {
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if ((i+j) % 2 == 1) { Console.WriteLine("(" + i + "," + j + ")"); }
            Console.WriteLine("\n");
        }
        // Exercice 6
        static public void flatten(string s)
        {
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            Console.WriteLine("\n");
        }
        // Exercice 7
        static public string enleveConsonnes(string s)
        {
            string voyelles = "BCDFGHJKLMNPQRSTVWZbcdfghjklmnpqrstvwxz";
            string ret = "";
            for (int i = 0; i < s.Length; i++)
                if (!voyelles.Contains(s[i])) { ret += s[i]; }
            return ret;
        }
        static void Main(string[] args)
        {
            // Exercice 3
            Pizza p1 = new Pizza(30f, 10f);
            Pizza p2 = new Pizza(10f, 30f);

            Console.WriteLine("Pizza 1:");
            Console.WriteLine(p1.toString() + "\n");

            Console.WriteLine("Pizza 2:");
            Console.WriteLine(p2.toString() + "\n");

            string best = "";
            if (p1.Rapport() == p2.Rapport()) { best = "Les deux pizzas se valent."; }
            else
                best = (p1.Rapport() > p2.Rapport()) ? "La pizza 1 est la moins chère." : "La pizza 2 est la moins chère.";
            Console.WriteLine(best + "\n");

            // Exercice 4
            int n = 3;
            Console.WriteLine("Factorielle de " + n + ": " + fact(n) + "\n");
            factToN(n);

            // Exercice 5
            odd(3);

            // Exercice 6
            flatten("Hello");

            // Exercice 7
            Console.WriteLine(enleveConsonnes("Il fait toujours beau !"));
        }
    }
}
