namespace FormAlumnos
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
            lst_alumnos = new ListBox();
            lst_materias = new ListBox();
            lbl_alumnos = new Label();
            lbl_materias = new Label();
            btn_agregarAlumno = new Button();
            btn_agregarMateria = new Button();
            btn_estadoAcad = new Button();
            SuspendLayout();
            // 
            // lst_alumnos
            // 
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.ItemHeight = 15;
            lst_alumnos.Location = new Point(45, 73);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(204, 319);
            lst_alumnos.TabIndex = 0;
            // 
            // lst_materias
            // 
            lst_materias.FormattingEnabled = true;
            lst_materias.ItemHeight = 15;
            lst_materias.Location = new Point(303, 73);
            lst_materias.Name = "lst_materias";
            lst_materias.Size = new Size(205, 319);
            lst_materias.TabIndex = 1;
            // 
            // lbl_alumnos
            // 
            lbl_alumnos.AutoSize = true;
            lbl_alumnos.Location = new Point(116, 37);
            lbl_alumnos.Name = "lbl_alumnos";
            lbl_alumnos.Size = new Size(55, 15);
            lbl_alumnos.TabIndex = 2;
            lbl_alumnos.Text = "Alumnos";
            // 
            // lbl_materias
            // 
            lbl_materias.AutoSize = true;
            lbl_materias.Location = new Point(375, 37);
            lbl_materias.Name = "lbl_materias";
            lbl_materias.Size = new Size(52, 15);
            lbl_materias.TabIndex = 3;
            lbl_materias.Text = "Materias";
            // 
            // btn_agregarAlumno
            // 
            btn_agregarAlumno.Location = new Point(91, 407);
            btn_agregarAlumno.Name = "btn_agregarAlumno";
            btn_agregarAlumno.Size = new Size(100, 39);
            btn_agregarAlumno.TabIndex = 4;
            btn_agregarAlumno.Text = "Agegar alumno";
            btn_agregarAlumno.UseVisualStyleBackColor = true;
            btn_agregarAlumno.Click += btn_agregarAlumno_Click;
            // 
            // btn_agregarMateria
            // 
            btn_agregarMateria.Location = new Point(360, 407);
            btn_agregarMateria.Name = "btn_agregarMateria";
            btn_agregarMateria.Size = new Size(103, 39);
            btn_agregarMateria.TabIndex = 5;
            btn_agregarMateria.Text = "Agregar materia";
            btn_agregarMateria.UseVisualStyleBackColor = true;
            btn_agregarMateria.Click += btn_agregarMateria_Click;
            // 
            // btn_estadoAcad
            // 
            btn_estadoAcad.Location = new Point(561, 391);
            btn_estadoAcad.Name = "btn_estadoAcad";
            btn_estadoAcad.Size = new Size(163, 38);
            btn_estadoAcad.TabIndex = 6;
            btn_estadoAcad.Text = "Estado academico";
            btn_estadoAcad.UseVisualStyleBackColor = true;
            btn_estadoAcad.Click += btn_estadoAcad_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 471);
            Controls.Add(btn_estadoAcad);
            Controls.Add(btn_agregarMateria);
            Controls.Add(btn_agregarAlumno);
            Controls.Add(lbl_materias);
            Controls.Add(lbl_alumnos);
            Controls.Add(lst_materias);
            Controls.Add(lst_alumnos);
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_alumnos;
        private ListBox lst_materias;
        private Label lbl_alumnos;
        private Label lbl_materias;
        private Button btn_agregarAlumno;
        private Button btn_agregarMateria;
        private Button btn_estadoAcad;
    }
}
