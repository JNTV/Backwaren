using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backwaren
{
    class BackwarenListe : List<Backware>
    {
        /// <summary>
        /// Durschnitt der Kalorien wird berechnet.
        /// </summary>
        /// <returns>Durchschnittskalorien</returns>
        public double Durchschnitt() {
            int avergeCalories = 0;
            for (int i = 0; i < Count; i++)
            {
                avergeCalories += this[i].Kalorien;
            }
            avergeCalories /= Count;
            return avergeCalories;
        }
    }
}
