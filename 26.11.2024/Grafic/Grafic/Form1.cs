namespace Grafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 8;
            double inf = -2, sup = 2;
            double steps = 1000;
            double h = Math.Abs(sup - inf) / steps;

            double[] f = { 1, 0, -1, 0, 1, 0, -1, 0 };
            double[] Tf = new double[1000];
            double[] points = new double[1000];
            double a = 0, u = 0;


            for (int j = 0; j < steps; j++)
            {
                Tf[0] = f[0];

                for (int i = 1; i < n; i++)
                {
                    Tf[i] = Tf[i - 1] + (1 / Factorial(i)) * Math.Pow((u + h * j) - a, i) * f[i];
                }

                points[j] = Tf[n];
            }

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grp = Graphics.FromImage(bmp);

            for (int i = 0; i < steps; i++)
            {
                double x = TranslateToCartesian(inf + h * i, points[i])[0];
                double y = TranslateToCartesian(inf + h * i, points[i])[1];
                grp.DrawEllipse(Pens.Black, (float)x, (float)y, 2, 2);
            }

            pictureBox1.Image = bmp;
        }
        public static double Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return (double)result;
        }

        public double[] TranslateToCartesian(double x, double y)
        {
            double[] result = new double[2];

            double cx = pictureBox1.Width / 2;
            double cy = pictureBox1.Height / 2;

            result[0] = x + cx;
            result[1] = -(y + cy);

            return result;
        }
    }
}