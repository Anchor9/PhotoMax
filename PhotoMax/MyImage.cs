﻿using System;
using System.Drawing;
using ExifLib;

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
            ExifReader reader = new ExifReader(path);
            Image file = Image.FromFile(path);

            //Obtenemos height y width
            Height = file.Height;
            Width = file.Width;
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