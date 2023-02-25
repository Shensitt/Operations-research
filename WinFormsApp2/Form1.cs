using System.Drawing;
    namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);
            Point p0=new Point(0, 500);
            Point Ox = new Point(1000, 500);
            Point Oy = new Point(0, 0);
            g.DrawLine(pen,p0,Ox);
            g.DrawLine(pen,Ox.X,Ox.Y,Ox.X-10,Ox.Y-10);
            g.DrawLine(pen, Ox.X, Ox.Y, Ox.X - 10, Ox.Y + 10);
            g.DrawLine(pen, p0, Oy);
            g.DrawLine(pen, Oy.X, Oy.Y, Oy.X + 10, Oy.Y + 10);

            g.DrawString("0", DefaultFont, Brushes.Black, p0);
            Point y1 = new Point(0,10);
            g.DrawString("1", DefaultFont, Brushes.Black, y1);
            Point yy = new Point(10, 0);
            g.DrawString("y", DefaultFont, Brushes.Black, yy);
            g.DrawString("x", DefaultFont, Brushes.Black, Ox);

            g.DrawLine(pen,0,100,5,100);
            g.DrawLine(pen,0,200,5,200);
            g.DrawLine(pen,0,300,5,300);
            g.DrawLine(pen,0,400,5,400);
            Point y8 = new Point(5,100);
            Point y6 = new Point(5,200);
            Point y4 = new Point(5,300);
            Point y2 = new Point(5, 400);
            g.DrawString("0.2", DefaultFont, Brushes.Black, y2);
            g.DrawString("0.4", DefaultFont, Brushes.Black, y4);
            g.DrawString("0.6", DefaultFont, Brushes.Black, y6);
            g.DrawString("0.8", DefaultFont, Brushes.Black, y8);
        }
    }
}