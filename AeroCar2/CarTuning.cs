using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace AeroCar2
{
    class CarTuning
    {
        private Image Main;
        public int TypesTuning;
        private ArrayList AL;

        public CarTuning(Image main)
        {
            this.Main = main;
            this.TypesTuning = (int)main.Height / 50;
            this.AL = new ArrayList(); 
            this.analyzingMainImg();
        }

        public Image getImg(int type, int item)
        {

            if (type != 0 && item == 0)
                return (Image)null;
            if (type != 0)
                item--;

            return (Image)getBitmapRegion(item * 100, type * 50, 100, 50, this.Main);
        }

        public int getTypesTuning()
        {
            return this.TypesTuning;
        }

        public int getCountTuning(int n)
        {
            return (int)this.AL[n];
        }

        private void analyzingMainImg()
        {
            int weight = 100;
            int height = 50;
            
            for (int y = 0; y < this.TypesTuning; y++)
            {
                int x = 0;
                while (true)
                {
                    if (!checkTuning((Image)getBitmapRegion(x * weight, y * height, weight, height, this.Main)))
                    {
                        break;
                    }
                    x++;
                }
                this.AL.Add(x);
            }
            return;
        }

        private Color getAlphaPixel(Color oldC, Color newC)
        {
            //out = alpha / 255 * new + (1 - alpha / 255) * old
            double R = (float)newC.A / 255.0 * newC.R + (1 - (float)newC.A / 255.0) * oldC.R;
            double G = (float)newC.A / 255.0 * newC.G + (1 - (float)newC.A / 255.0) * oldC.G;
            double B = (float)newC.A / 255.0 * newC.B + (1 - (float)newC.A / 255.0) * oldC.B;
            if (R > 255)
                R = 255.0;
            if (G > 255)
                G = 255.0;
            if (B > 255)
                B = 255.0;
            Color c = Color.FromArgb(255, (byte)R, (byte)G, (byte)B);
            
            return c;
        }

        public Bitmap createTuning(Image car, Image tuning)
        {
            Bitmap bp_car = new Bitmap(car);
            
            if (tuning == null)
            {
                return bp_car;
            }
            Bitmap bp_tuning = new Bitmap(tuning);

            for (int x = 0; x < bp_car.Width; x++)
            {
                for (int y = 0; y < bp_car.Height; y++)
                {
                    Color c = bp_tuning.GetPixel(x, y);

                    if (c.Name != "0")
                    {
                        bp_car.SetPixel(x, y, getAlphaPixel(bp_car.GetPixel(x, y), c));
                    }
                }
            }

            return bp_car;
        }

        private Bitmap getBitmapRegion(int x, int y, int w, int h, Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Rectangle rect = new Rectangle(x, y, w, h);
            Bitmap region = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(region))
            {
                g.DrawImage(bmp, 0, 0, rect, GraphicsUnit.Pixel);
            }
            return region;
        }

        private bool checkTuning(Image img)
        {
            Bitmap b = new Bitmap(img);
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    Color c = b.GetPixel(x, y);
                    if (!(c.A == 0 || (c.B == 255 && c.R == 255 && c.G == 255)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
