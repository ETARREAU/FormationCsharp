using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //Par convention: Classes, méthode, Interface -- pour le nommage on utilise le PascalCase : MaClasse
        //pour les variable: on utilise le camelCase : maVariable

        //Une classe donnée peut posséder 2 types de méthodes:
        //Une méthode d'instance: accessible via une instance de la classe en question - instancier une classe = créer un objet de cette classe
        //Une méthode de classe: une méthode static (une méthode de classe) - pas besoin d'instancier la classe pour avoir accès aux méthodes static

        //visibilité [static] Type-Retour (void) Nom_Méthode(paramétres) {instructions}

        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>renvoie un entier</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //Surchage d'une méthode: pouvoir définir la même méthode (mm signature) dans la même avec uniquement la liste des paramétres qui change

        public static int Somme(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void Afficher(string chaine)
        {
            Console.WriteLine(chaine);
        }

        //Définir une méthode qui liste le contenu d'un tableau d'entiers

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        //Une méthode qui renvoie la somme des éléments d'un tableau d'entiers
        public static int Somme(int[] tab)
        {
            return tab.Sum();
        }
        public static int SommeElements(int[] tab)
        {
            int somme2 = 0;
            foreach (var item in tab)
            {
                somme2 += item;
            }
            return somme2;
        }


        //Une méthode qui renvoie la moyenne des élémenets d'un tableau d'entiers
        public static double Mean(int[] tab)
        {
            return (double)tab.Average();
        }

        public static double Moyenne(int[] tab)
        {
            double somme = 0;
            foreach (var item in tab)
            {
                somme += item;
            }
            return somme / tab.Length;
        }

        //Une méthode qui renvoie l'élément le plus petit d'un tableau d'entiers
        public static int Min(int[] tab)
        {
            return tab.Min();
        }

        public static int Minimum(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (min>tab[i])
                {
                    min = tab[i];
                }
            }
            return min;
        }

        //Paramètres optionnels d'une méthode.
        //z est un paramètre optionnel: il possède une valeur par default et doivent etre definis en fin / après la liste des paramètre.
        public static int SommeOptionel(int x, int y, int z=10)
        {
            return x + y + z;
        }

        //Méthode qui permute 2 entiers
        // ref -> passe les paramètre par référence et permet de modifier directement les valeur stocker dans Program.cs
        // Les mots clé s'utilise uniquement 
        public static void Permuter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Paramètre de sortie d'une méthode
        public static double Calculer(double a, double b, out double somme, out double moyenne)
        {
            somme = a + b;
            moyenne = (a + b) / 2;
            return a * b;
        }
    }
}
