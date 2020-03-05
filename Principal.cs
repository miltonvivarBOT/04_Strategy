using PatronStrategy.Interfaces;
using PatronStrategy.Strategy;
using System;

namespace PatronStrategy
{
    class Principal
    {
        static void Main(string[] args)
        {
            string cNombreImagen = "";
            int iTipoImagen = 0;
            

            Console.WriteLine("Ingrese el nombre de la imagen");
            cNombreImagen = Console.ReadLine();
            Console.WriteLine("Seleccion el tipo de imagen\n1)BMP\n2)JPG");
            iTipoImagen = Convert.ToInt32(Console.ReadLine());

            Contexto context = new Contexto();
            IAlmacenarImagen almacenar = null;
            if (iTipoImagen == 1)
                almacenar = new FormatoBMP();
            if (iTipoImagen == 2)
                almacenar = new FormatoJPG();
            


            context.almacenarImagen = almacenar;
            context.MostrarMensajeGuardado(context.GuardarImagen(cNombreImagen));

        }
    }
}
