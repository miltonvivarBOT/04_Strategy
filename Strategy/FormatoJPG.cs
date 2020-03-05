using PatronStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronStrategy.Strategy
{
    class FormatoJPG : IAlmacenarImagen
    {
        public string GuardarImagen(string nombreArchivo)
        {
            return nombreArchivo+".jpg";
        }
    }
}
