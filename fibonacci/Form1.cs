namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = 1;
            int tal2 = 0;
            int tal3 = 0;

            textBox1.Text = "0";
            for (int i = 0; i <= 30; i++)
            {
                tal3 = tal1 + tal2;
                tal1 = tal2;
                tal2 = tal3;
                textBox1.Text = textBox1.Text + " " + tal3.ToString();
            }
        }
    }
}