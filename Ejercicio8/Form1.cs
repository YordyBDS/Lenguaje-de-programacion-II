namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            textBox1.Text = $"numero de click: {contador}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
