using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SideStars1
{
    public class Peliculas
    {
        public string Titulo { get; set; }
        public DateTime Fecha  { get; set; }
        public string  Genero  { get; set; }
        public string Idioma { get; set; }
        public Enum Duracion { get; set; }
        public string Calidad { get; set; }
        public string Sinopsis { get; set; }
    }
}