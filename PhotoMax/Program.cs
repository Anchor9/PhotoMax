using System;
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


            string path = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/hola.jpg";

            ExifLib.ExifReader reader = new ExifLib.ExifReader(path);

            //Obtenemos height y width

            // obtenemos ISO


            var gps = ImageMetadataReader.ReadMetadata(path)
                              .OfType<GpsDirectory>()
                              .FirstOrDefault();
            var location = gps.GetGeoLocation();

            double lat = location.Latitude;
            double lon = location.Longitude;
            string Location = string.Format("{0}\n{1}", lat, lon);

            Console.WriteLine(Location);
        }

    }
}