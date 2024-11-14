using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN___KGLL_FUNALGS
{
    internal class CITA
    {
        public int NUMERO {  get; set; }
        public ESTUDIANTE ESTUDIANTE { get; set;}
        public string ENFERMEDAD {  get; set; }
        public double PRECIO { get; set; }

        public override string ToString()
        {
            return $"Cita #{NUMERO}:    {ENFERMEDAD},   Estudiante: {ESTUDIANTE},   Precio: {PRECIO:C}";
        }
    }
}
