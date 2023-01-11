namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIREMOS NUESTAR ACCIONES AL PULSAR EL BOTON
            //TENEMOS PROPIEDADES DE TIPO PRIMITIVO
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Boton pulsado!!!";
            //TENEMOS PROPIEDADES DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor=Color.YellowGreen;
            this.btnPulsar.BackColor = Color.Red;
        }
    }
}