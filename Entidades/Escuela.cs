using System.Collections.Generic;

namespace IntentoCasa.Entidades
{
    public class Escuela
    {
        public string id { get; private set; }

        public string Nombre { get; set; }

        public int AnoCreacion  { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TipoEscuela Tipo { get; set; }

        public List<Curso> Cursos { get; set; }


        public Escuela(string Nombre, int AñoCreación,string pais, string ciudad, TipoEscuela tipo=TipoEscuela.Primaria)
        {
            (this.Nombre,this.AnoCreacion, this.Pais, this.Ciudad, this.Tipo)=(Nombre, AñoCreación,pais, ciudad, tipo);
            this.id = System.Guid.NewGuid().ToString();
            
        }

        public override string ToString()
        {
            return $"Nombre:{Nombre} Año de Creación:{AnoCreacion} Tipo:{Tipo}\nPais:{Pais} Ciudad:{Ciudad}";
        }
    }
}