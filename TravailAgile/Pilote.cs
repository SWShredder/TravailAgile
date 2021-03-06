﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailAgile
{
    class Pilote
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Permet d'afficher les détails d'une carte en substituant valet, dame ou roi selon la valeur.
        /// </summary>
        /// <param name="carte">Représente une carte à jouer</param>
        static void Afficher(ICarte carte)
        {
            string valeurCarte = "";
            switch (carte.Valeur)
            {
                case 11:
                    valeurCarte = "Valet";
                    break;
                case 12:
                    valeurCarte = "Dame";
                    break;
                case 13:
                    valeurCarte = "Roi";
                    break;
                case 14:
                    valeurCarte = "Joker";
                    break;
                default:
                    valeurCarte = carte.Valeur.ToString();
                    break;

            }
            Console.WriteLine($"{valeurCarte} de {carte.Couleur}");
        }
    }
}
