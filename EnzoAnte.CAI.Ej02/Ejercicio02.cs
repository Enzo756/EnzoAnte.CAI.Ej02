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
            // this.cmbMarca.Items.AddRange(modelo.Marcas); ---- Esta Instrucción sirve para agregar elementos al combobox.
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            modelo.MarcaIngresada = this.cmbMarca.SelectedItem.ToString();
            modelo.ModeloIngresado = this.txtModelo.Text;
            modelo.AñoIngresado = this.txtAño.Text;
            modelo.PrecioIngresado = this.txtPrecio.Text;

            string mensaje = modelo.Validar(); //método valida y devuelve algún error o si está todo ok
            MessageBox.Show(mensaje);
        }
    }
}