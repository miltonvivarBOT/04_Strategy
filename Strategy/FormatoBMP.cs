using PatronStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronStrategy.Strategy
{
    class FormatoBMP : IAlmacenarImagen
    {
        public string GuardarImagen(string nombreArchivo)
        {
            return nombreArchivo+".bmp";
        }
    }
}
