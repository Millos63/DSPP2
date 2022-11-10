using System;
using System.Collections.Generic;
using System.Text;

namespace GenericoRestricciones
{
    class CEstudiante 
    {
        private double calificacion;

        public CEstudiante(double pCalificacion)
        {
            calificacion = pCalificacion;
        }

        public double getCalificacion()
        {
            return calificacion;
        }
    }
}
