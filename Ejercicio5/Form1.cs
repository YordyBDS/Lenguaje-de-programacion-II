namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Ciudad seleccionada: Santiago";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Ciudad seleccionada: San Juan";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Ciudad seleccionada: Santo Domingo";
            }
        }
    }
}
