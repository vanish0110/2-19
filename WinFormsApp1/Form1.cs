namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0,1";
            textBox2.Text = "2,4";
            textBox3.Text = "-0,3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "a=" + a.ToString();
            double b = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "b=" + b.ToString();
            double x = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "x=" + x.ToString();
            double k = (a * x - Math.Sqrt(b)) / (5.7 * (x * x + b * b));
            double h = (Math.Abs(x + b) - a * a) / (x * x);
            double l = Math.Tan(b) * Math.Tan(b);
            double y = k - h * l;
            textBox4.Text += Environment.NewLine + "y=" + y.ToString();
        }
    }
}