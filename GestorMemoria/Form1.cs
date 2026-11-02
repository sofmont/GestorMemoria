using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorMemoria
{
    public partial class Form1 : Form
    {
        // Arreglo para demostrar el redimensionamiento
        private int[] numeros;

        // Objetos para demostrar memoria dinámica
        private Alumno alumno1;
        private Alumno alumno2;
        private Alumno referencia;

        public Form1()
        {
            InitializeComponent();
        }

        // PARTE A: CREAR ARREGLO
        private void btnCrear_Click(object sender, EventArgs e)
        {
            numeros = new int[] { 10, 20, 30 };

            lstResultados.Items.Clear();
            lstResultados.Items.Add("=== ARREGLO INICIAL ===");

            MostrarArreglo();

            lblEstado.Text = "Arreglo creado. Tamaño: "
                + numeros.Length;
        }

        // PARTE A: AMPLIAR ARREGLO
        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            if (numeros == null)
            {
                MessageBox.Show(
                    "Primero debes crear el arreglo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Array.Resize(ref numeros, 5);

            numeros[3] = 40;
            numeros[4] = 50;

            lstResultados.Items.Clear();
            lstResultados.Items.Add("=== ARREGLO AMPLIADO ===");

            MostrarArreglo();

            lblEstado.Text = "Arreglo ampliado. Tamaño: "
                + numeros.Length;
        }

        // PARTE A: REDUCIR ARREGLO
        private void btnReducir_Click(object sender, EventArgs e)
        {
            if (numeros == null)
            {
                MessageBox.Show(
                    "Primero debes crear el arreglo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Array.Resize(ref numeros, 2);

            lstResultados.Items.Clear();
            lstResultados.Items.Add("=== ARREGLO REDUCIDO ===");

            MostrarArreglo();

            lblEstado.Text = "Arreglo reducido. Tamaño: "
                + numeros.Length;
        }

        // Mostrar los elementos del arreglo
        private void MostrarArreglo()
        {
            lstResultados.Items.Add(
                "Cantidad de elementos: " + numeros.Length);

            lstResultados.Items.Add("------------------------");

            for (int i = 0; i < numeros.Length; i++)
            {
                lstResultados.Items.Add(
                    "Posición " + i + ": " + numeros[i]);
            }
        }

        // PARTE B: CREAR OBJETOS
        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            alumno1 = new Alumno("Carlos", 20);
            alumno2 = new Alumno("Mariana", 22);

            // La referencia apunta al mismo objeto que alumno1
            referencia = alumno1;

            lstResultados.Items.Clear();

            lstResultados.Items.Add(
                "=== OBJETOS EN MEMORIA DINÁMICA ===");

            lstResultados.Items.Add("");

            lstResultados.Items.Add("Alumno 1:");
            lstResultados.Items.Add(alumno1.ToString());

            lstResultados.Items.Add("");

            lstResultados.Items.Add("Alumno 2:");
            lstResultados.Items.Add(alumno2.ToString());

            lstResultados.Items.Add("");

            lstResultados.Items.Add(
                "Referencia asignada al Alumno 1.");

            lstResultados.Items.Add(
                "¿Apuntan al mismo objeto?: "
                + ReferenceEquals(alumno1, referencia));

            lblEstado.Text = "Se crearon dos objetos Alumno.";
        }

        // PARTE B: MODIFICAR MEDIANTE REFERENCIA
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (referencia == null)
            {
                MessageBox.Show(
                    "Primero debes crear los objetos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Modificar el objeto usando la segunda referencia
            referencia.Nombre = "Carlos Modificado";

            lstResultados.Items.Clear();

            lstResultados.Items.Add(
                "=== MODIFICACIÓN MEDIANTE REFERENCIA ===");

            lstResultados.Items.Add("");

            lstResultados.Items.Add(
                "Contenido de la referencia:");

            lstResultados.Items.Add(referencia.ToString());

            lstResultados.Items.Add("");

            lstResultados.Items.Add(
                "Contenido de alumno1:");

            lstResultados.Items.Add(alumno1.ToString());

            lstResultados.Items.Add("");

            lstResultados.Items.Add(
                "¿Son el mismo objeto?: "
                + ReferenceEquals(alumno1, referencia));

            lblEstado.Text =
                "El cambio se refleja en ambas referencias.";
        }

        // Limpiar resultados
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            lblEstado.Text = "Resultados limpiados.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    // Clase que representa un objeto Alumno
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Alumno(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre
                + " | Edad: " + Edad;
        }
    }
}
