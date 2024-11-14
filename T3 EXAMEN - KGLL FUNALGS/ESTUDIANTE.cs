using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN___KGLL_FUNALGS
{
    public class ESTUDIANTE
    {
        public int CODIGO {  get; set; }
        public string NOMBRE { get; set; }
        public string UNIVERSIDAD { get; set; }

        public override string ToString()
        {
            return $"{NOMBRE}   ({CODIGO})  - ({UNIVERSIDAD})";     
        }
    }
}
