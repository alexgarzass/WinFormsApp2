using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Datos;

namespace WinFormsApp2.Presentador
{
    internal class EstudiantePresentador
    {
        private readonly Form1 vista;
        private readonly Estudiante datos;

        public EstudiantePresentador(Form1 vista)
        {
            this.vista = vista;
            this.datos = new Estudiante();
            this.vista.AñadirEstudianteClick += OnAñadirEstudianteClick;
            this.vista.EliminarEstudianteClick += OnEliminarEstudianteClick;
            //this.vista.EliminarEstudianteSeleccionadoClick += OnEliminarEstudianteSeleccionadoClick;
            ActualizarVista();
        }
    
    public void OnAñadirEstudianteClick(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(vista.NombreEstudiante) ||
            !double.TryParse(vista.CalificacionEstudiante, out double calificacion) ||
            !int.TryParse(vista.Edad, out int edad))
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            datos.AddPersona(vista.NombreEstudiante, calificacion, edad);
            ActualizarVista();
        }
    public void OnEliminarEstudianteClick(object sender, EventArgs e)
        {
            datos.RemoveLastAnimal();
            ActualizarVista();
        }
    //public void OnEliminarEstudianteSeleccionadoClick(object sender, EventArgs e)
    //    {
    //        vista.DeseleccionarFila();
    //    }
     public void ActualizarVista()
        {
            vista.MostrarPersonas(datos.EstudianteModels); 

        }
    }

}
