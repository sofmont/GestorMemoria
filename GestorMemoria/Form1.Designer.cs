namespace GestorMemoria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpArreglos;
        private System.Windows.Forms.GroupBox grpObjetos;
        private System.Windows.Forms.GroupBox grpResultados;

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAmpliar;
        private System.Windows.Forms.Button btnReducir;

        private System.Windows.Forms.Button btnCrearObjetos;
        private System.Windows.Forms.Button btnModificar;

        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpArreglos = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grpArreglos.SuspendLayout();
            this.grpObjetos.SuspendLayout();
            this.grpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(850, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MEMORIA ESTÁTICA VS. MEMORIA DINÁMICA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 58);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(830, 30);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpArreglos
            // 
            this.grpArreglos.Controls.Add(this.btnCrear);
            this.grpArreglos.Controls.Add(this.btnAmpliar);
            this.grpArreglos.Controls.Add(this.btnReducir);
            this.grpArreglos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpArreglos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.grpArreglos.Location = new System.Drawing.Point(30, 105);
            this.grpArreglos.Name = "grpArreglos";
            this.grpArreglos.Size = new System.Drawing.Size(400, 190);
            this.grpArreglos.TabIndex = 2;
            this.grpArreglos.TabStop = false;
            this.grpArreglos.Text = "A. Redimensionamiento de arreglos";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(25, 40);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(155, 45);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear arreglo";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnAmpliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmpliar.FlatAppearance.BorderSize = 0;
            this.btnAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmpliar.ForeColor = System.Drawing.Color.White;
            this.btnAmpliar.Location = new System.Drawing.Point(205, 40);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(155, 45);
            this.btnAmpliar.TabIndex = 1;
            this.btnAmpliar.Text = "Ampliar a 5";
            this.btnAmpliar.UseVisualStyleBackColor = false;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAmpliar_Click);
            // 
            // btnReducir
            // 
            this.btnReducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(110)))), ((int)(((byte)(55)))));
            this.btnReducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReducir.FlatAppearance.BorderSize = 0;
            this.btnReducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReducir.ForeColor = System.Drawing.Color.White;
            this.btnReducir.Location = new System.Drawing.Point(25, 105);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(335, 45);
            this.btnReducir.TabIndex = 2;
            this.btnReducir.Text = "Reducir a 2 elementos";
            this.btnReducir.UseVisualStyleBackColor = false;
            this.btnReducir.Click += new System.EventHandler(this.btnReducir_Click);
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.btnCrearObjetos);
            this.grpObjetos.Controls.Add(this.btnModificar);
            this.grpObjetos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.grpObjetos.Location = new System.Drawing.Point(460, 105);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(410, 190);
            this.grpObjetos.TabIndex = 3;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "B. Memoria dinámica y referencias";
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnCrearObjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearObjetos.FlatAppearance.BorderSize = 0;
            this.btnCrearObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearObjetos.ForeColor = System.Drawing.Color.White;
            this.btnCrearObjetos.Location = new System.Drawing.Point(25, 40);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(350, 45);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear objetos Alumno";
            this.btnCrearObjetos.UseVisualStyleBackColor = false;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(25, 105);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(350, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar mediante referencia";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lstResultados);
            this.grpResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.grpResultados.Location = new System.Drawing.Point(30, 315);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(840, 255);
            this.grpResultados.TabIndex = 4;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados de las pruebas";
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.Color.White;
            this.lstResultados.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstResultados.HorizontalScrollbar = true;
            this.lstResultados.ItemHeight = 26;
            this.lstResultados.Location = new System.Drawing.Point(20, 35);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(800, 186);
            this.lstResultados.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(710, 580);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar resultados";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.lblEstado.Location = new System.Drawing.Point(30, 585);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(650, 30);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado: esperando ejecución...";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 23);
            this.lblDescripcion.TabIndex = 0;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.grpArreglos);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(916, 689);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 1.2 - Memoria estática y dinámica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpArreglos.ResumeLayout(false);
            this.grpObjetos.ResumeLayout(false);
            this.grpResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

