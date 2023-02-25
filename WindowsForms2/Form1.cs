using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {  
            InitializeComponent(); 
        }
        public int shot_cnt;
        public List<double[]> shot;
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);
            Point p0 = new Point(0, 500);
            Point Ox = new Point(1000, 500);
            Point Oy = new Point(0, 0);
            g.DrawLine(pen, p0, Ox);
            g.DrawLine(pen, Ox.X, Ox.Y, Ox.X - 10, Ox.Y - 10);
            g.DrawLine(pen, Ox.X, Ox.Y, Ox.X - 10, Ox.Y + 10);
            g.DrawLine(pen, p0, Oy);
            g.DrawLine(pen, Oy.X, Oy.Y, Oy.X + 10, Oy.Y + 10);

            g.DrawString("0", DefaultFont, Brushes.Black, p0);
            Point y1 = new Point(0, 10);
            g.DrawString("1", DefaultFont, Brushes.Black, y1);
            Point yy = new Point(10, 0);
            g.DrawString("y", DefaultFont, Brushes.Black, yy);
            g.DrawString("x", DefaultFont, Brushes.Black, Ox);

            g.DrawLine(pen, 0, 100, 5, 100);
            g.DrawLine(pen, 0, 200, 5, 200);
            g.DrawLine(pen, 0, 300, 5, 300);
            g.DrawLine(pen, 0, 400, 5, 400);
            Point y8 = new Point(5, 100);
            Point y6 = new Point(5, 200);
            Point y4 = new Point(5, 300);
            Point y2 = new Point(5, 400);
            g.DrawString("0.2", DefaultFont, Brushes.Black, y2);
            g.DrawString("0.4", DefaultFont, Brushes.Black, y4);
            g.DrawString("0.6", DefaultFont, Brushes.Black, y6);
            g.DrawString("0.8", DefaultFont, Brushes.Black, y8);

            if (shot_cnt != 0)
            {
                DrawStrokes(shot_cnt);
                DrawFuncs(shot, shot_cnt);
            }

        }
        public void DrawStrokes(int shots_cnt)
        {
            Graphics g = CreateGraphics();
            for (int i=1; i<=shots_cnt; i++)
            {   
                Pen pen = new Pen(Brushes.Black,3);
                //g.DrawLine(pen, 10, 10, 100, 100);
                Point l1=new Point(1000/shots_cnt*i, 500-5);
                Point l2=new Point(1000 / shots_cnt * i , 500+ 5);
                g.DrawLine(pen,l1,l2);
                g.DrawString(i.ToString(), DefaultFont, Brushes.Black,l2.X,l2.Y);
            }
        }
        public void DrawFuncs(List<double[]> shot,int shot_cnt)
        {
            Graphics g = CreateGraphics();
            Pen pen1 = new Pen(Brushes.Red, 3);
            Pen pen2 = new Pen(Brushes.Green, 3);
            Pen pen3 = new Pen(Brushes.Blue, 3);
            Pen pen4 = new Pen(Brushes.Violet, 3);
            
            List<Point> points1= new List<Point>();
            List<Point> points2 = new List<Point>();
            List<Point> points3 = new List<Point>();
            List<Point> points4 = new List<Point>();
            for (int i=0; i <= shot_cnt; i++)
            {
                double[] arr = shot[i];
                Point l1 = new Point(1000 / shot_cnt * i, 500-(int)(arr[0]*500));
                Point l2 = new Point(1000 / shot_cnt * i,500-(int)(arr[1]*500));
                Point l3 = new Point(1000 / shot_cnt * i,500-(int)(arr[2]*500));
                Point l4 = new Point(1000 / shot_cnt * i, 500 - (int)(arr[3] * 500));
                points1.Add(l1);
                points2.Add(l2);
                points3.Add(l3);
                points4.Add(l4);
            }
            for (int i=1; i<points1.Count;i++)
            {
                g.DrawLine(pen1, points1[i - 1], points1[i]);
                g.DrawLine(pen2, points2[i - 1], points2[i]);
                g.DrawLine(pen3, points3[i - 1], points3[i]);
                g.DrawLine(pen4, points4[i - 1], points4[i]);

                if (i < 5)
                {
                    g.DrawString("S1",DefaultFont,Brushes.Black,points1[i-1].X,points1[i-1].Y);
                    g.DrawString("S2",DefaultFont,Brushes.Black,points2[i-1].X,points2[i-1].Y);
                    g.DrawString("S3",DefaultFont,Brushes.Black,points3[i-1].X,points3[i-1].Y);
                    g.DrawString("S4",DefaultFont,Brushes.Black,points4[i-1].X, points4[i - 1].Y);
                }
                
            }
        }
    }
}
