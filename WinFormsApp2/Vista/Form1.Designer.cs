namespace WinFormsApp2
{
    partial class Form1
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
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxCalificacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Calificacion = new Label();
            buttonAñadir = new Button();
            buttonEliminar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(122, 77);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(122, 138);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(125, 27);
            textBoxEdad.TabIndex = 1;
            // 
            // textBoxCalificacion
            // 
            textBoxCalificacion.Location = new Point(122, 194);
            textBoxCalificacion.Name = "textBoxCalificacion";
            textBoxCalificacion.Size = new Size(125, 27);
            textBoxCalificacion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 138);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // Calificacion
            // 
            Calificacion.AutoSize = true;
            Calificacion.Location = new Point(12, 201);
            Calificacion.Name = "Calificacion";
            Calificacion.Size = new Size(86, 20);
            Calificacion.TabIndex = 5;
            Calificacion.Text = "Calificacion";
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(109, 267);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(160, 29);
            buttonAñadir.TabIndex = 6;
            buttonAñadir.Text = "Añadir Alumno";
            buttonAñadir.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(99, 327);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(170, 50);
            buttonEliminar.TabIndex = 7;
            buttonEliminar.Text = "ELiminar ultimo estudiante";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(334, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 322);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAñadir);
            Controls.Add(Calificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCalificacion);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxCalificacion;
        private Label label1;
        private Label label2;
        private Label Calificacion;
        private Button buttonAñadir;
        private Button buttonEliminar;
        private DataGridView dataGridView1;
    }
}
