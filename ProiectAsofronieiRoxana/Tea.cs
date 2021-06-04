using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsofronieiRoxana
{
    class Tea
    {
        public int id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public int servings { get; set; }
        public float price { get; set; }

        public string toString()
        {
            return id.ToString() + " - " + name + " - Companie: " + company + " - Numar portii: " + servings.ToString() + " Pret: " + price.ToString() + " lei";
        }
    }
}
