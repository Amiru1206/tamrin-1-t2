namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int x = int.Parse(textBox1.Text);
                string y = Fibo(x);

            static string Fibo(int x)
            {
                int f1 = 0, f2 = 1;
                if (x == 1)
                    return f1.ToString();
                else if (x == 2)
                    return f2.ToString();
                else if (x >= 3)
                    return (int.Parse(Fibo(x - 1)) + int.Parse(Fibo(x - 2))).ToString();
                else
                    return "error";
            }
            MessageBox.Show(y);
        }
    }
}