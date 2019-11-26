using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class Elementos : Pelicula
    {
        public Elementos(string titulo, int año, string genero, string sinopsis, string director, string ranting)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Sinopsis = sinopsis;
            this.Director = director;
            this.Ranting = ranting;
        }
        public Elementos(string titulo, int año, string genero, string descripcion, string temporadas, string productor, string ranting)

        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Descripcion = descripcion;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Ranting = ranting;
        }
    }
}
