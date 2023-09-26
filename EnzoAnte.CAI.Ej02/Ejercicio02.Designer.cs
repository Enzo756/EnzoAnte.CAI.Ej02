namespace EnzoAnte.CAI.Ej02
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbMarca = new ComboBox();
            lblMarca = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            lblAño = new Label();
            txtAño = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombreUsuario = new Label();
            lblFechaActual = new Label();
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Ford", "Fiat", "Chevrolet", "Audi" });
            cmbMarca.Location = new Point(10, 54);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(230, 23);
            cmbMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(10, 36);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(256, 54);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(257, 37);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(363, 37);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 5;
            lblAño.Text = "Año";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(362, 54);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(469, 37);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(468, 54);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(412, 98);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(493, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(12, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 15);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "[Nombre de Usuario]";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Location = new Point(468, 9);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(83, 15);
            lblFechaActual.TabIndex = 11;
            lblFechaActual.Text = "[Fecha Actual]";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 132);
            Controls.Add(lblFechaActual);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblAño);
            Controls.Add(txtAño);
            Controls.Add(lblModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblMarca);
            Controls.Add(cmbMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Prototipos - Ejercicio 2";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMarca;
        private Label lblMarca;
        private TextBox txtModelo;
        private Label lblModelo;
        private Label lblAño;
        private TextBox txtAño;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombreUsuario;
        private Label lblFechaActual;
    }
}