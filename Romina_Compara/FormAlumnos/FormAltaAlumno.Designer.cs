namespace FormAlumnos
{
    partial class FormAltaAlumno
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
            lbl_legajo = new Label();
            lbl_nombre = new Label();
            lbl_apelldo = new Label();
            btn_agregar = new Button();
            btn_cancelar = new Button();
            txt_legajo = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            SuspendLayout();
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(73, 65);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 0;
            lbl_legajo.Text = "Legajo";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(73, 114);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apelldo
            // 
            lbl_apelldo.AutoSize = true;
            lbl_apelldo.Location = new Point(73, 159);
            lbl_apelldo.Name = "lbl_apelldo";
            lbl_apelldo.Size = new Size(51, 15);
            lbl_apelldo.TabIndex = 2;
            lbl_apelldo.Text = "Apellido";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(77, 207);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(257, 207);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_legajo
            // 
            txt_legajo.Location = new Point(215, 57);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(133, 23);
            txt_legajo.TabIndex = 6;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(215, 106);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(133, 23);
            txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(215, 151);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(133, 23);
            txt_apellido.TabIndex = 8;
            // 
            // FormAltaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 295);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_legajo);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_apelldo);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_legajo);
            Name = "FormAltaAlumno";
            Text = "Alta alumno";
            Load += FormAltaAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_legajo;
        private Label lbl_nombre;
        private Label lbl_apelldo;
        private Button btn_agregar;
        private Button btn_cancelar;
        private TextBox txt_legajo;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
    }
}