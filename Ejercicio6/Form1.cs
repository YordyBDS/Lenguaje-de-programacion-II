namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Verde");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;

                case "Azul":
                    this.BackColor = Color.Blue;
                    break;

                case "Verde":
                    this.BackColor = Color.Green;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
    }
}
