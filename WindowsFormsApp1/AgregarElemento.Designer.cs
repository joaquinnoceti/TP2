namespace WindowsFormsApp1
{
    partial class AgregarElemento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.lblAterisco1 = new System.Windows.Forms.Label();
            this.lblAterisco2 = new System.Windows.Forms.Label();
            this.lblAterisco3 = new System.Windows.Forms.Label();
            this.lblAterisco4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio";
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(95, 35);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(147, 20);
            this.txtCodArt.TabIndex = 0;
            this.txtCodArt.TextChanged += new System.EventHandler(this.txtCodArt_TextChanged);
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(95, 61);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(147, 20);
            this.txtNombreArt.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(94, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(147, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(94, 141);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(147, 21);
            this.cboxMarca.TabIndex = 4;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(94, 168);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(147, 21);
            this.cboxCategoria.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(188, 224);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(315, 35);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(217, 183);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 9;
            this.pbxArticulo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 224);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(30, 117);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 11;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Location = new System.Drawing.Point(95, 115);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(147, 20);
            this.tbxUrlImagen.TabIndex = 3;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // lblAterisco1
            // 
            this.lblAterisco1.AutoSize = true;
            this.lblAterisco1.Location = new System.Drawing.Point(242, 35);
            this.lblAterisco1.Name = "lblAterisco1";
            this.lblAterisco1.Size = new System.Drawing.Size(11, 13);
            this.lblAterisco1.TabIndex = 12;
            this.lblAterisco1.Text = "*";
            // 
            // lblAterisco2
            // 
            this.lblAterisco2.AutoSize = true;
            this.lblAterisco2.Location = new System.Drawing.Point(242, 58);
            this.lblAterisco2.Name = "lblAterisco2";
            this.lblAterisco2.Size = new System.Drawing.Size(11, 13);
            this.lblAterisco2.TabIndex = 13;
            this.lblAterisco2.Text = "*";
            // 
            // lblAterisco3
            // 
            this.lblAterisco3.AutoSize = true;
            this.lblAterisco3.Location = new System.Drawing.Point(242, 84);
            this.lblAterisco3.Name = "lblAterisco3";
            this.lblAterisco3.Size = new System.Drawing.Size(11, 13);
            this.lblAterisco3.TabIndex = 14;
            this.lblAterisco3.Text = "*";
            // 
            // lblAterisco4
            // 
            this.lblAterisco4.AutoSize = true;
            this.lblAterisco4.Location = new System.Drawing.Point(242, 198);
            this.lblAterisco4.Name = "lblAterisco4";
            this.lblAterisco4.Size = new System.Drawing.Size(11, 13);
            this.lblAterisco4.TabIndex = 15;
            this.lblAterisco4.Text = "*";
            // 
            // AgregarElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 279);
            this.Controls.Add(this.lblAterisco4);
            this.Controls.Add(this.lblAterisco3);
            this.Controls.Add(this.lblAterisco2);
            this.Controls.Add(this.lblAterisco1);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarElemento";
            this.Load += new System.EventHandler(this.AgregarElemento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.Label lblAterisco1;
        private System.Windows.Forms.Label lblAterisco2;
        private System.Windows.Forms.Label lblAterisco3;
        private System.Windows.Forms.Label lblAterisco4;
    }
}