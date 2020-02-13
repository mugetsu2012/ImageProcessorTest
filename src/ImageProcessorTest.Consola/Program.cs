using System;
using ImageMagick;

namespace ImageProcessorTest.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (MagickImage image = new MagickImage("C:\\Users\\Douglas Ortiz\\Desktop\\google-marker-trans.png"))
            {
                new Drawables()// Draw text on the image
                    .FontPointSize(50)
                    .Font("Arial")
                    .StrokeColor(new MagickColor("black"))
                    .FillColor(MagickColors.White)
                    .TextAlignment(TextAlignment.Center)
                    .Text(256, 64, "1")
                    .StrokeColor(new MagickColor(0, Quantum.Max, 0))
                    .Draw(image);

                image.Write("C:\\Users\\Douglas Ortiz\\Desktop\\google-marker-trans2.png");
            }
        }
    }
}
