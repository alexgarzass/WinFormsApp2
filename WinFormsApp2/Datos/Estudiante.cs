using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Modelo;
using WinFormsApp2.Presentador;

namespace WinFormsApp2.Datos
{
    internal class Estudiante
    {
        public List<EstudianteModel> EstudianteModels { get; set; } = new List<EstudianteModel>();

        public void AddPersona(string name, double calificacion , int age)
        {
            int id = EstudianteModels.Count+1;
            var estudiante = new EstudianteModel(id, name, age, calificacion);
            EstudianteModels.Add(estudiante);
        }
        public void RemoveLastAnimal()
        {
            if (EstudianteModels.Any())
            {
                EstudianteModels.RemoveAt(EstudianteModels.Count - 1);
            }
        }
        public void EliminarEstudianteSeleccionado()
        {

        }
        public string[] GetPersonas()
        {
            return EstudianteModels
                .Select(persona => $"Nombre: {persona.Name}, Calificacion: {persona.Calificacion}, Edad: {persona.Edad} años")
                .ToArray();

        }
    }
}
