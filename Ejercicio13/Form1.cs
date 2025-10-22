namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iniciar = 0;
        bool detener = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            detener = false;
            iniciar = 0;
            while (iniciar <= 10)
            {
                progressBar1.Value = iniciar * 10;
                Thread.Sleep(500);
                iniciar++;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            detener = true;
        }
    }
}
