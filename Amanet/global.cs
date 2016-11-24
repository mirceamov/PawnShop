using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Amanet
{
    class global
    {
        public enum StareContracte
        {
            ACTIV, FINALIZAT
        };

        public static string instanta = "";
        public static string db = "";
        public static string user = "";
        public static string pass = "";

        public static string conString = "";

        /// <summary>
        /// Functia retuneaza true daca parametrul este un numar de 6 cifre. Altfel returneaza false.
        /// </summary>
        /// <param name="_caractere"></param>
        /// <returns></returns>
        public static bool EsteNumarCI(string _caractere)
        {
            return Regex.IsMatch(_caractere, @"^[0-9]{6}$");

        }
    }
}
