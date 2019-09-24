using System;
using System.Drawing;
using System.Linq;
using ExifLib;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

namespace PhotoMax
{
    class Program
    {


        static void Main(string[] args)
        {


            string path = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/Pintua.jpg";
            string newpath = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/PEPE.jpg";
            Filters filtros = new Filters();

            Bitmap imagenreal = new Bitmap(path);
            Bitmap imageneditada = new Bitmap(path);

            filtros.GreyScale(imageneditada);
            imageneditada.Save(newpath);
            Console.WriteLine("trabajen");
        }

    }
}