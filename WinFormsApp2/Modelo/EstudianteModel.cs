using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Datos;

namespace WinFormsApp2.Modelo
{
    public class EstudianteModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public EstudianteModel(int id, string name, int edad, double calificacion)
        {
            this.Id = id;   
            this.Name = name;
            this.Edad = edad;
            this.Calificacion = calificacion;
        }
        public EstudianteModel() { }
        public override string ToString()
        {
            return $" {Name},:{Edad}, {Calificacion}";
        }
    }
}
