using System;
using ExifLib;

namespace PhotoMax
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Image image1 = Image.FromFile("/Users/joaquinbarrientos/Projects/PruebasProyecto/PruebasProyecto/DSC_0528.JPG");
            //ExifReader reader = new ExifReader("/Users/joaquinbarrientos/Projects/PruebasProyecto/PruebasProyecto/DSC_0528.JPG");


            //DateTime dataTime;
            //reader.GetTagValue<DateTime>(ExifTags.DateTime, out dataTime);

            //object iso1;
            //int iso;
            //reader.GetTagValue<object>(ExifTags.PhotographicSensitivity, out iso1);
            //iso = (int)Convert.ToUInt64(iso1);
            //Console.WriteLine(is);
            //Console.WriteLine(dataTime);

            string path = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/Pintua.jpg";

            ExifReader reader = new ExifReader(path);

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





        }

    }
}
