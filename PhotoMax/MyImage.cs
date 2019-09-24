using System;
using System.Drawing;
using System.Linq;
using ExifLib;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

namespace PhotoMax
{
    public class MyImage
    {
        private int iso;
        private float focalLength;
        private string flash;
        private double exposureTime;
        private double aperture;
        private DateTime dataTime;
        private string cameraModel;
        private string artist;
        private string copyright;
        private string geotag;
        private int rank;
        private string climate;
        private bool animal;
        private int height;
        private int width;
        private string make;

        public MyImage(string path)
        {
            ExifLib.ExifReader reader = new ExifLib.ExifReader(path);
            Image file = Image.FromFile(path);



            // obtenemos ISO
            int isos;
            object isos1;
            reader.GetTagValue<object>(ExifTags.PhotographicSensitivity, out isos1);
            isos = (int)Convert.ToUInt64(isos1);
            //focal
            object fl;
            reader.GetTagValue<object>(ExifTags.FocalLength, out fl);
            double focal;
            focal = Convert.ToDouble(fl);
            //exposure time
            double et;
            reader.GetTagValue(ExifTags.ExposureTime, out et);
            //MAKER
            string maker;
            reader.GetTagValue(ExifTags.Make, out maker);
            // DATETIME
            DateTime datatime;
            reader.GetTagValue(ExifTags.DateTime, out datatime);
            // Artist 
            string artista;
            reader.GetTagValue(ExifTags.Artist, out artista);
            Artist = artista;
            //Copyright
            string copy;
            reader.GetTagValue(ExifTags.Copyright, out copy);
            //Camera  model
            string camera;
            reader.GetTagValue(ExifTags.Model, out camera);
            CameraModel = camera;
            //Aperture
            double apertures;
            reader.GetTagValue(ExifTags.FNumber, out apertures);
            // GPS 

            var gps = ImageMetadataReader.ReadMetadata(path)
                              .OfType<GpsDirectory>()
                              .FirstOrDefault();
            if (gps != null)
            {
                var location = gps.GetGeoLocation();
                double lat = location.Latitude;
                double lon = location.Longitude;
                string Location = string.Format("{0}\n{1}", lat, lon);
                Geotag = Location;
            }
            else
            {
                Geotag = null;
            }





            // SETTERS
            Height = file.Height;
            Width = file.Width;
            Iso = isos;
            FocalLength = (float)focal;
            ExposureTime = et;
            Make = maker;
            DataTime = datatime;
            Artist = artista;
            Copyright = copy;
            CameraModel = camera;
            Aperture = apertures;
           
        }

        public double Aperture
        {
            get => aperture;
            set => aperture = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Iso
        {
            get => iso;
            set => iso = value;
        }

        public float FocalLength
        {
            get => focalLength;
            set => focalLength = value;
        }

        public string Flash
        {
            get => flash;
            set => flash = value;
        }
        public double ExposureTime
        {
            get => exposureTime;
            set => exposureTime = value;
        }
        public DateTime DataTime
        {
            get => dataTime;
            set => dataTime = value;
        }
        public string CameraModel
        {
            get => cameraModel;
            set => cameraModel = value;
        }
        public string Artist
        {
            get => artist;
            set => artist = value;
        }
        public string Copyright
        {
            get => copyright;
            set => copyright = value;
        }
        public string Geotag
        {
            get => geotag;
            set => geotag = value;
        }
        public int Rank
        {
            get => rank;
            set => rank = value;
        }
        public string Climate
        {
            get => climate;
            set => climate = value;
        }
        public bool Animal
        {
            get => animal;
            set => animal = value;
        }
        public string Make
        {
            get => make;
            set => make = value;
        }

        
    }
}