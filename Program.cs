using System;
using static System.Console;
using IntentoCasa.Entidades;
using System.Collections.Generic;
using IntentoCasa.Util;

namespace IntentoCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela objEscuela = new Escuela("COBAEP", 1983,"México", "Puebla");
            
            Printer.Titulo(objEscuela.ToString());

            objEscuela.Cursos = new List<Curso>
            {
                new Curso {Nombre="101", Tipo = TipoCurso.Mañana},
                new Curso {Nombre="201", Tipo = TipoCurso.Mañana},
                new Curso {Nombre="301", Tipo = TipoCurso.Tarde}
            };
            Printer.Titulo("Estos son los cursos de la Escuela");
            ImprimeCursos(objEscuela);
        }

        private static void ImprimeCursos(Escuela escuela)
        {
            foreach(Curso item in escuela.Cursos)
            {
                WriteLine($"Nombre:{item.Nombre} ID:{item.id} Tipo:{item.Tipo}");
            }
        }
    }
}
