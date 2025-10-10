using System.ComponentModel;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void validar()
        {
            float dato;
            if (float.TryParse(textBox1.Text, out dato))
            {
                MessageBox.Show($"{dato} es un numero");
            }
            else
            {
                MessageBox.Show($"debe agregar un numero");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
