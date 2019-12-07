using System;
using System.Drawing;
using System.Windows.Forms;

namespace Foutbal
{
    class SoccerStars
    {
        private Point[] k;
        private Bitmap bitmap;
        private Graphics graphics;
        private Image image,image1,image2;
        private Image fon;
        Random r = new Random();
        //private Brush brush;
        int w, h;
        float a, b, c;
        string sssss;
        private int radius = 50;
        private int s, s1, _x, _y, _xx = 10, _yy;
        private int[] q = new int[12];
        bool koptokUshlandi;
        int[] vaqt_x, vaqt_y, vaqt; int x1 = 0, y1 = 0, qoldiq = 0;

        public SoccerStars(int pwidth,int pheight)
        {
            //sw = new StreamWriter("p.txt");
            w = pwidth;
            h = pheight;
            k = new Point[12];
            vaqt = new int[12];
            vaqt_x = new int[12];
            vaqt_y = new int[12];
            bitmap = new Bitmap(w, h);
            graphics = Graphics.FromImage(bitmap);
            fon = Image.FromFile("res/stadion.jpg");
            koptokUshlandi = false;
            this.Tozalash();
        }
       public void Taktika_A(System.Windows.Forms.PictureBox p)
        {
            FonniChizish();
            graphics.DrawImage(image, 140, 90, radius, radius);
            graphics.DrawImage(image, 140, 270, radius, radius);
            graphics.DrawImage(image, 140, 450, radius, radius);
            graphics.DrawImage(image, 250, 200, radius, radius);
            graphics.DrawImage(image, 250, 350, radius, radius);
            graphics.DrawImage(image1, 880, 90, radius, radius);
            graphics.DrawImage(image1, 880, 270, radius, radius);
            graphics.DrawImage(image1, 880, 450, radius, radius);
            graphics.DrawImage(image1, 770, 200, radius, radius);
            graphics.DrawImage(image1, 770, 350, radius, radius);
            graphics.DrawImage(image2, 515, 266, radius, radius);
            k[0].X = 140; k[0].Y = 90;
            k[1].X = 140; k[1].Y = 270;
            k[2].X = 140; k[2].Y = 450;
            k[3].X = 250; k[3].Y = 200;
            k[4].X = 250; k[4].Y = 350;
            //
            k[5].X = 880 + 50; k[5].Y = 90 + 50;
            k[6].X = 880 + 50; k[6].Y = 270 + 50;
            k[7].X = 880 + 50; k[7].Y = 450 + 50;
            k[8].X = 770 + 50; k[8].Y = 200 + 50;
            k[9].X = 770 + 50; k[9].Y = 350 + 50;
            k[10].X = 515 + 50; k[10].Y = 266 + 50;

            Chizish(p);
        }

        public void MouseMove(int x, int y, PictureBox pictureBox1)
        {
            if (koptokUshlandi)
            {
                FonniChizish_L();
                graphics.DrawLine(new Pen(Color.Red, 3), _x, _y, x, y);
                Chizish(pictureBox1);
            }
        }

        private void FonniChizish_L()
        {
            graphics.Clear(Color.Transparent);
          //  graphics.DrawImage(fon, 0, 0, w, h);
            for (int i = 0; i < 12; i++)
            {
                if (i < 5) graphics.DrawImage(image, k[i].X - radius, k[i].Y - radius, radius, radius);
                else if (i < 10) graphics.DrawImage(image1, k[i].X - radius, k[i].Y - radius, radius, radius);
                else graphics.DrawImage(image2, k[i].X - radius, k[i].Y - radius, radius, radius);
            }
        }

        void FonniChizish()
        {
            graphics.Clear(Color.Transparent);
            graphics.DrawImage(fon, 0, 0, w, h);
        }

        public void Hisoblash()
        {
            image = Image.FromFile("res/top_2.png");
            image1 = Image.FromFile("res/top_3.png");
            image2 = Image.FromFile("res/top_1.png");
            this.FonniChizish();
            graphics.DrawImage(image, 140, 90, radius, radius);
            graphics.DrawImage(image, 140, 270, radius, radius);
            graphics.DrawImage(image, 140, 450, radius, radius);
            graphics.DrawImage(image, 250, 200, radius, radius);
            graphics.DrawImage(image, 250, 350, radius, radius);
            graphics.DrawImage(image1, 880, 90, radius, radius);
            graphics.DrawImage(image1, 880, 270, radius, radius);
            graphics.DrawImage(image1, 880, 450, radius, radius);
            graphics.DrawImage(image1, 770, 200, radius, radius);
            graphics.DrawImage(image1, 770, 350, radius, radius);
            graphics.DrawImage(image2, 515, 266, radius, radius);

            k[0].X = 140+50; k[0].Y = 90 + 50;
            k[1].X = 140 + 50; k[1].Y = 270 + 50;
            k[2].X = 140 + 50; k[2].Y = 450 + 50;
            k[3].X = 250 + 50; k[3].Y = 200 + 50;
            k[4].X = 250 + 50; k[4].Y = 350 + 50;
            //
            k[5].X = 880 + 50; k[5].Y = 90 + 50;
            k[6].X = 880 + 50; k[6].Y = 270 + 50;
            k[7].X = 880 + 50; k[7].Y = 450 + 50;
            k[8].X = 770 + 50; k[8].Y = 200 + 50;
            k[9].X = 770 + 50; k[9].Y = 350 + 50;
            k[10].X = 515 + 50; k[10].Y = 266 + 50;
            
        }
        public void Chizish(System.Windows.Forms.PictureBox p)
        {
            p.Image = bitmap;
        }
        public void MouseDown(int ex,int ey)
        {
           for (int i = 0; i < 12; i++)
                if (Math.Sqrt(Math.Pow(ex - k[i].X, 2) + Math.Pow(ey - k[i].Y, 2)) < radius)
                {
                        q[i] = i;
                        _x = ex;_y = ey;
                    koptokUshlandi = true;
                }
        }
        
        public void MouseUp(int ex, int ey, System.Windows.Forms.PictureBox p,ref bool mouseup)
        {
            if (koptokUshlandi)
            {
                FonniChizish();
                for (int i = 0; i < 12; i++)
                {
                    if (i == q[i])
                    {
                        a = (float)Math.Sqrt(Math.Pow(_x - ex, 2) + Math.Pow(_y - ey, 2));
                        s = (int)a;
                        if (_y < ey && _x > ex)      {
                            vaqt[i] = 1;
                        }
                        else if (_y > ey && _x < ex) {
                            vaqt[i] = 2;
                        }
                        else if (_y > ey && _x > ex) {
                            vaqt[i] = 3;
                        }
                        else if (_y < ey && _x < ex) {
                            vaqt[i] = 4;
                        }
                      //  vaqt_y[i] = (vaqt_x[i] - _x) * (ey - _y) / (ex - _x) + _y;
                        //vaqt_x[i] = _x;
///
                       //  MessageBox.Show(vaqt_y[i].ToString());

                        Tezlik(s, ref vaqt_x[i], ref vaqt_y[i], vaqt[i]);
                        mouseup = true;
                        qoldiq = s % 10;
                        
                        vaqt_x[i] = vaqt_x[i]+s/10; vaqt_y[i] = vaqt_y[i]+s/10;
                    }
                    if (i < 5) graphics.DrawImage(image, k[i].X - radius, k[i].Y - radius, radius, radius);
                    else if (i < 10) graphics.DrawImage(image1, k[i].X - radius, k[i].Y - radius, radius, radius);
                    else graphics.DrawImage(image2, k[i].X - radius, k[i].Y - radius, radius, radius);
                }
                Chizish(p);
                koptokUshlandi = false;
            }
        }

        private void Tezlik(int s, ref int vaqt_x, ref int vaqt_y,int vaqt)
        {
            if (s < 100)
            {
                if (vaqt == 1 || vaqt == 3)
                {
                    vaqt_x = 5; vaqt_y = 3;
                }
                else if (vaqt == 2 || vaqt == 4)
                {
                    vaqt_y = 5; vaqt_x = 3;
                }
            }
            else if (s > 100 && s < 250)
            {
                if (vaqt == 1 || vaqt == 3)
                {
                    vaqt_x = 7; vaqt_y = 4;
                }
                else if (vaqt == 2 || vaqt == 4)
                {
                    vaqt_y = 7; vaqt_x = 4;
                }
            }
            else if (s > 250){
                if (vaqt == 1 || vaqt == 3)
                {
                    vaqt_x = 11; vaqt_y = 8;
                }
                else if (vaqt == 2 || vaqt == 4)
                {
                    vaqt_y = 11; vaqt_x = 8;
                }
            }
        }

        public void Yurgazish(int sek,ref bool exx, System.Windows.Forms.PictureBox p,System.Windows.Forms.Label L)
        {
            sek++;
            FonniChizish();
            for (int i = 0; i < 12; i++)
            {
                if (i == q[i])
                {
                    if (vaqt[i] == 1)
                    {
                        k[i].X += vaqt_x[i];
                        if (k[i].X > w) {  k[i].X -= vaqt_x[i]; vaqt[i] = 4; }
                        if (k[i].Y < radius)
                        { k[i].Y += vaqt_y[i]; vaqt[i] = 3; }
                        else k[i].Y -= vaqt_y[i];
                        Tekshirish(k[i].X,k[i].Y,vaqt_x[i], vaqt_y[i], vaqt[i]);
                    }
                    else if (vaqt[i] == 2)
                    {
                        if (k[i].X<radius)
                        {  k[i].X += vaqt_x[i]; vaqt[i] = 3; }
                    else
                        k[i].X -= vaqt_x[i];
                        if (k[i].Y > h)
                        {   k[i].Y -= vaqt_y[i];    vaqt[i] = 4;  }
                     else   k[i].Y += vaqt_y[i];
                        Tekshirish(k[i].X, k[i].Y, vaqt_x[i], vaqt_y[i], vaqt[i]);

                    }
                    else if (vaqt[i] == 3)
                    {
                        if (k[i].X > w)
                        {    k[i].X -= vaqt_x[i];   vaqt[i] = 2; }
                        else k[i].X += vaqt_x[i];
                        if (k[i].Y> h)
                        {   k[i].Y -= vaqt_y[i];   vaqt[i] = 1; }
                        else
                            k[i].Y += vaqt_y[i];
                        Tekshirish(k[i].X, k[i].Y, vaqt_x[i], vaqt_y[i], vaqt[i]);
                    }
                    else
                    {
                        if (k[i].Y < radius)
                        {
                            k[i].Y += vaqt_y[i];
                            vaqt[i] = 2;
                        }
                        else k[i].Y -= vaqt_y[i];
                        if (k[i].X < radius)
                        {
                            k[i].X += vaqt_x[i];
                            vaqt[i] = 1;
                        }
                        else
                            k[i].X -= vaqt_x[i];
                        Tekshirish(k[i].X, k[i].Y, vaqt_x[i], vaqt_y[i], vaqt[i]);
                    }
                    if (sek % 5 == 0) { vaqt_x[i] = vaqt_x[i] - 1; vaqt_y[i] = vaqt_y[i] - 1; }
                    if (vaqt_x[i] < 0 || vaqt_y[i] < 0) { exx = true; q[i] = -1; vaqt[i] = -1; }
                }
                if (i < 5) graphics.DrawImage(image, k[i].X - radius, k[i].Y - radius, radius, radius);
                else if (i < 10) graphics.DrawImage(image1, k[i].X - radius, k[i].Y - radius, radius, radius);
                else {
                    if (k[i].Y > 227 && k[i].Y < 305 && k[i].X > 26 && k[i].X < 88 ) s1 = (int)Math.Abs(55 - k[i].X);
                    if (s1 < radius && s1 > 0)
                    {
                        L.Text = "Goooooooooooooooooool"; s1 = -1;
                    }
                    graphics.DrawImage(image2, k[i].X - radius, k[i].Y - radius, radius, radius);
                }
                
            }
            Chizish(p);
        }
        public void Tozalash()
        {
            for (int i = 0; i < 12; i++)
            {
                q[i] = -1;
                vaqt[i] = 0;
                vaqt_x[i] = -1;
                vaqt_y[i] = -1;
            }
        }

        private void Tekshirish(int x,int y,int k_x,int k_y,int yonalish)
        {
            for (int i = 0; i < 12; i++)
            {
                s = (int)Math.Sqrt(Math.Pow(x - k[i].X, 2) + Math.Pow(y - k[i].Y, 2));
                if (s < radius && k[i].Y!=y && k[i].X!=x)
                {
                    q[i] = i;
                    vaqt[i]= Yonalishni_aniqlash(x, y, k[i].X, k[i].Y);
                    vaqt_x[i] = 2;
                    vaqt_y[i] = 8;
                }
            }
        }

        private int Yonalishni_aniqlash(int x1, int y1, int x2, int y2)
        {
            int yon=0;
            if (y2 < y1 && x2 > x1)
            {
                yon = 1;
            }
            else if (y2 > y1 && x2 < x1)
            {
                yon = 2;
            }
            else if (y2 > y1 && x2 > x1)
            {
                yon = 3;
            }
            else if (y2 < y1 && x2 < x1)
            {
                yon = 4;
            }
            return yon;
        }
    }
}