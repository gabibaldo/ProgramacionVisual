
namespace TrabajoPractico5
{
    partial class FormLibro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(85, 66);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(193, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(231, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(85, 119);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 21);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(194, 120);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(230, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(85, 172);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(46, 21);
            this.lblIsbn.TabIndex = 4;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(193, 173);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(231, 22);
            this.txtIsbn.TabIndex = 5;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(85, 226);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(67, 21);
            this.lblPaginas.TabIndex = 6;
            this.lblPaginas.Text = "Paginas";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(193, 227);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(231, 22);
            this.txtPaginas.TabIndex = 7;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.Location = new System.Drawing.Point(85, 283);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(63, 21);
            this.lblEdicion.TabIndex = 8;
            this.lblEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(193, 284);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(231, 22);
            this.txtEdicion.TabIndex = 9;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(85, 338);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(71, 21);
            this.lblEditorial.TabIndex = 10;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(193, 339);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(231, 22);
            this.txtEditorial.TabIndex = 11;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(85, 394);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(60, 21);
            this.lblCiudad.TabIndex = 12;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(193, 395);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(231, 22);
            this.txtCiudad.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(85, 451);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(40, 21);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(193, 450);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(231, 22);
            this.txtPais.TabIndex = 15;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(85, 507);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(68, 26);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(193, 507);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(231, 22);
            this.txtFecha.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(129, 559);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 30);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 615);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(271, 559);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 657);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormLibro";
            this.Text = "FormLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}