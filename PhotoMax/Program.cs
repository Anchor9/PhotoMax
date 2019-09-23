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
           

            string path = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/Pintua.jpg";

            ExifLib.ExifReader reader = new ExifLib.ExifReader(path);

            //Obtenemos height y width

            // obtenemos ISO
            int isos;
            object isos1;
            reader.GetTagValue<object>(ExifTags.PhotographicSensitivity, out isos1);
            isos = (int)Convert.ToUInt64(isos1);

            Console.WriteLine(isos);
            //focal
            object fl;
            reader.GetTagValue<object>(ExifTags.FocalLength, out fl);
            double focal;
            focal = Convert.ToDouble(fl);
            Console.WriteLine(focal);


            //exposure time
            double et;
            reader.GetTagValue(ExifTags.ExposureTime, out et);
            Console.WriteLine(et);

            string make;

            reader.GetTagValue(ExifTags.Make, out make);
            Console.WriteLine(make);

            DateTime datatime;
            
            reader.GetTagValue(ExifTags.DateTime, out datatime);


            string artist;

            reader.GetTagValue(ExifTags.Artist, out artist);
            Console.WriteLine(artist);

            string copy;
            reader.GetTagValue(ExifTags.Copyright, out copy);
            Console.WriteLine(copy);

            string camera;
            reader.GetTagValue(ExifTags.Model, out camera);
            Console.WriteLine(camera);

            double aperture;

            reader.GetTagValue(ExifTags.FNumber, out aperture);
            Console.WriteLine(aperture);

            var gps = ImageMetadataReader.ReadMetadata(path)
                              .OfType<GpsDirectory>()
                              .FirstOrDefault();

            

        }

    }
}
