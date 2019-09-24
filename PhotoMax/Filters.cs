using System;
using System.Drawing;





namespace PhotoMax
{
    public class Filters
    {
        public Filters()
        {
        }

        public void Sepia(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    double promedio = (rojo + verde + azul) / 3;

                    Color sepia = Color.FromArgb((byte)promedio, (byte)(promedio * 0.95), (byte)(promedio * 0.82));

                    bitmap.SetPixel(x, y, sepia);

                }
            }
        }

        public void GreyScale(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    int promedio = (rojo + verde + azul) / 3;

                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, promedio, promedio, promedio));
                }
            }
        }


    }
}