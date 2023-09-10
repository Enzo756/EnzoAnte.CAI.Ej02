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
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(12, 27);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(230, 23);
            cmbMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 9);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(258, 27);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(259, 10);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(365, 10);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 5;
            lblAño.Text = "Año";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(364, 27);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(471, 10);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(470, 27);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(414, 71);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(495, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 168);
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
            Name = "FormPrincipal";
            Text = "Prototipos - Ejercicio 2";
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
    }
}