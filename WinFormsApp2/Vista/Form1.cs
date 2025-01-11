using WinFormsApp2.Modelo;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public string NombreEstudiante => textBoxNombre.Text;
        public string Edad => textBoxEdad.Text;
        public string CalificacionEstudiante => textBoxCalificacion.Text;

        public EventHandler AñadirEstudianteClick;
        public EventHandler EliminarEstudianteClick;
        public event EventHandler EliminarEstudianteSeleccionadoClick;
        public Form1()
        {
            InitializeComponent();
            buttonAñadir.Click += (s, e) => AñadirEstudianteClick?.Invoke(this, EventArgs.Empty);
            buttonEliminar.Click += (s, e) => EliminarEstudianteClick?.Invoke(this, EventArgs.Empty);
        }
        public void MostrarPersonas(List<EstudianteModel> personas)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
        }
        //public void DeseleccionarFila()
        //{
        //    dataGridView1.ClearSelection();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Cuando cliques en uno de los elementos del datagridview y le das a un boton de eliminar seleccionado elismine justo ese