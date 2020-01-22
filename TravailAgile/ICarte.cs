using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailAgile
{
    public enum Couleur
    {
        Pique,
        Carreau,
        Coeur,
        Trefle
    }
    // On implémente IComparable pour gérer si une carte est pareil comme une autre ou si elle vient avant ou après une autre.
    public interface ICarte : IComparable
    {
        // Represente la valeur de la carte Valet = 11, Dame = 12, Roi = 13, Joker = 14, etc;
        int Valeur { get; }
        // Représente le symbole ou la couleur soit Pique, trefle, coeur, carreau.
        Couleur Couleur { get; }
    }

    public interface ICarteBuilder
    {
        ICarte New(int valeur, Couleur couleur);
    }
}
