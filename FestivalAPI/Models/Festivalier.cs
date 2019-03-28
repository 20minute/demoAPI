using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalAPI.Models
{
    public class Festivalier: Personne
    {
        public string DateNaissance { get; set; }
        public string Genre { get; set; }
        public int Telephone { get; set; }
    }
}