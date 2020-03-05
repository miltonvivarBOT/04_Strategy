using PatronStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronStrategy
{
    class Contexto
    {
        private IAlmacenarImagen _Extension;
        
        public IAlmacenarImagen almacenarImagen
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        public string GuardarImagen(string nombreImagen)
        {
            return almacenarImagen.GuardarImagen(nombreImagen);
        }

        public void MostrarMensajeGuardado(string nombreconExtension)
        {
            Console.WriteLine("Se ha guardado la imagen {0}", nombreconExtension);
        }
    }
}
