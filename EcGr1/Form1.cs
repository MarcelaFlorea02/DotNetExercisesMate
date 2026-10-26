namespace EcGr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, x;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            if (a == 0)
            {
                MessageBox.Show("a0 nu poate fi 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                a = float.Parse(textBox1.Text);
            }
            else
            {

                x = -b / a;

                MessageBox.Show("Rezultatul este: " + x.ToString());
            }
        }
    }
}
