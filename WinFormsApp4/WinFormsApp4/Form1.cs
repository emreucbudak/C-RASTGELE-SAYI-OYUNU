namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = Convert.ToInt32(textBox1.Text);
            if ( a == b )
            {
                MessageBox.Show("Doðru Bildiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yanlýþ Bildiniz Sayý = " + a, "Maalesef", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
