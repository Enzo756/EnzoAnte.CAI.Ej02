namespace EnzoAnte.CAI.Ej02
{
    public partial class FormPrincipal : Form
    {
        Ejercicio02Model modelo;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio02Model(); //el Modelo va a ser el que maneja, reciba y haga todo con los datos. El formulario solo lo muestra
        }
    }
}