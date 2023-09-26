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
            modelo = new Ejercicio02Model(); //el "Presentador" (esta clase en la que estamos) va a ser el que maneja, reciba y haga todo con los datos que le otorga el "Modelo". El "Formulario" solo lo muestra
            //cmbMarca.Items.AddRange(modelo.Marcas); //---- Esta Instrucción sirve para agregar elementos al combobox.
            cmbMarca.SelectedIndex = 0;

            lblNombreUsuario.Text = $"{modelo.NombreRealUsuario} ({modelo.NombreUsuario}) ";
            lblFechaActual.Text = modelo.FechaActual.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            modelo.MarcaIngresada = (string)this.cmbMarca.SelectedItem;
            modelo.ModeloIngresado = this.txtModelo.Text;
            modelo.AñoIngresado = this.txtAño.Text;
            modelo.PrecioIngresado = this.txtPrecio.Text;

            string mensaje = modelo.Validar(); //método valida y devuelve algún error o si está todo ok
            MessageBox.Show(mensaje);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Se dispone a cerrar el formulario. ¿Está usted seguro?", "Ejercicio02", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}