using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppImplementacion
{
    internal class GestionFiguras
    {
        private Vector figura;
        private int estado;

        public GestionFiguras(Vector f)
        {
            this.figura = f;
            this.estado = 0;
        }

        public Vector getFigura()
        {
            return this.figura;
        }
    
        public void setEstado(int estado)
        {
            this.estado = estado;
        }
    }
}
