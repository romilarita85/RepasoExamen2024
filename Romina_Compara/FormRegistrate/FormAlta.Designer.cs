namespace FormRegistrate
{
    partial class FormAlta
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
            gpb_datosIngresante = new GroupBox();
            num_edad = new NumericUpDown();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            lbl_edad = new Label();
            lbl_apellido = new Label();
            lbl_nombre = new Label();
            gpb_genero = new GroupBox();
            rdb_noBinario = new RadioButton();
            rdb_femenino = new RadioButton();
            rdb_masculino = new RadioButton();
            gpb_cursos = new GroupBox();
            chk_java = new CheckBox();
            chk_node = new CheckBox();
            chk_phyton = new CheckBox();
            chk_angular = new CheckBox();
            chk_c = new CheckBox();
            lbl_pais = new Label();
            lst_paises = new ListBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            gpb_datosIngresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            gpb_genero.SuspendLayout();
            gpb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_datosIngresante
            // 
            gpb_datosIngresante.Controls.Add(num_edad);
            gpb_datosIngresante.Controls.Add(txt_apellido);
            gpb_datosIngresante.Controls.Add(txt_nombre);
            gpb_datosIngresante.Controls.Add(lbl_edad);
            gpb_datosIngresante.Controls.Add(lbl_apellido);
            gpb_datosIngresante.Controls.Add(lbl_nombre);
            gpb_datosIngresante.Location = new Point(71, 55);
            gpb_datosIngresante.Name = "gpb_datosIngresante";
            gpb_datosIngresante.Size = new Size(262, 200);
            gpb_datosIngresante.TabIndex = 0;
            gpb_datosIngresante.TabStop = false;
            gpb_datosIngresante.Text = "Datos del ingresante";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(104, 124);
            num_edad.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            num_edad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(120, 23);
            num_edad.TabIndex = 5;
            num_edad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(104, 89);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(120, 23);
            txt_apellido.TabIndex = 4;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(104, 54);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(120, 23);
            txt_nombre.TabIndex = 3;
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(37, 127);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 2;
            lbl_edad.Text = "Edad";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(37, 92);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 1;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(37, 57);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // gpb_genero
            // 
            gpb_genero.Controls.Add(rdb_noBinario);
            gpb_genero.Controls.Add(rdb_femenino);
            gpb_genero.Controls.Add(rdb_masculino);
            gpb_genero.Location = new Point(365, 55);
            gpb_genero.Name = "gpb_genero";
            gpb_genero.Size = new Size(227, 143);
            gpb_genero.TabIndex = 0;
            gpb_genero.TabStop = false;
            gpb_genero.Text = "Genero";
            // 
            // rdb_noBinario
            // 
            rdb_noBinario.AutoSize = true;
            rdb_noBinario.Location = new Point(36, 93);
            rdb_noBinario.Name = "rdb_noBinario";
            rdb_noBinario.Size = new Size(81, 19);
            rdb_noBinario.TabIndex = 2;
            rdb_noBinario.TabStop = true;
            rdb_noBinario.Text = "No binario";
            rdb_noBinario.UseVisualStyleBackColor = true;
            // 
            // rdb_femenino
            // 
            rdb_femenino.AutoSize = true;
            rdb_femenino.Location = new Point(36, 68);
            rdb_femenino.Name = "rdb_femenino";
            rdb_femenino.Size = new Size(78, 19);
            rdb_femenino.TabIndex = 1;
            rdb_femenino.TabStop = true;
            rdb_femenino.Text = "Femenino";
            rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            rdb_masculino.AutoSize = true;
            rdb_masculino.Location = new Point(36, 43);
            rdb_masculino.Name = "rdb_masculino";
            rdb_masculino.Size = new Size(80, 19);
            rdb_masculino.TabIndex = 0;
            rdb_masculino.TabStop = true;
            rdb_masculino.Text = "Masculino";
            rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_cursos
            // 
            gpb_cursos.Controls.Add(chk_java);
            gpb_cursos.Controls.Add(chk_node);
            gpb_cursos.Controls.Add(chk_phyton);
            gpb_cursos.Controls.Add(chk_angular);
            gpb_cursos.Controls.Add(chk_c);
            gpb_cursos.Location = new Point(365, 212);
            gpb_cursos.Name = "gpb_cursos";
            gpb_cursos.Size = new Size(227, 157);
            gpb_cursos.TabIndex = 0;
            gpb_cursos.TabStop = false;
            gpb_cursos.Text = "Cursos";
            // 
            // chk_java
            // 
            chk_java.AutoSize = true;
            chk_java.Location = new Point(36, 124);
            chk_java.Name = "chk_java";
            chk_java.Size = new Size(78, 19);
            chk_java.TabIndex = 4;
            chk_java.Text = "JavaScript";
            chk_java.UseVisualStyleBackColor = true;
            // 
            // chk_node
            // 
            chk_node.AutoSize = true;
            chk_node.Location = new Point(36, 99);
            chk_node.Name = "chk_node";
            chk_node.Size = new Size(66, 19);
            chk_node.TabIndex = 3;
            chk_node.Text = "Node.js";
            chk_node.UseVisualStyleBackColor = true;
            // 
            // chk_phyton
            // 
            chk_phyton.AutoSize = true;
            chk_phyton.Location = new Point(36, 74);
            chk_phyton.Name = "chk_phyton";
            chk_phyton.Size = new Size(64, 19);
            chk_phyton.TabIndex = 2;
            chk_phyton.Text = "Phyton";
            chk_phyton.UseVisualStyleBackColor = true;
            // 
            // chk_angular
            // 
            chk_angular.AutoSize = true;
            chk_angular.Location = new Point(36, 49);
            chk_angular.Name = "chk_angular";
            chk_angular.Size = new Size(68, 19);
            chk_angular.TabIndex = 1;
            chk_angular.Text = "Angular";
            chk_angular.UseVisualStyleBackColor = true;
            // 
            // chk_c
            // 
            chk_c.AutoSize = true;
            chk_c.Location = new Point(36, 24);
            chk_c.Name = "chk_c";
            chk_c.Size = new Size(41, 19);
            chk_c.TabIndex = 0;
            chk_c.Text = "C#";
            chk_c.UseVisualStyleBackColor = true;
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(71, 275);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 1;
            lbl_pais.Text = "Pais";
            // 
            // lst_paises
            // 
            lst_paises.FormattingEnabled = true;
            lst_paises.ItemHeight = 15;
            lst_paises.Location = new Point(71, 306);
            lst_paises.Name = "lst_paises";
            lst_paises.Size = new Size(262, 94);
            lst_paises.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(379, 395);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(508, 395);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 5;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(lst_paises);
            Controls.Add(lbl_pais);
            Controls.Add(gpb_genero);
            Controls.Add(gpb_cursos);
            Controls.Add(gpb_datosIngresante);
            Name = "FormAlta";
            Text = "Alta alumno";
            Load += FormAlta_Load;
            gpb_datosIngresante.ResumeLayout(false);
            gpb_datosIngresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            gpb_genero.ResumeLayout(false);
            gpb_genero.PerformLayout();
            gpb_cursos.ResumeLayout(false);
            gpb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_datosIngresante;
        private GroupBox gpb_genero;
        private GroupBox gpb_cursos;
        private Label lbl_edad;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private Label lbl_pais;
        private ListBox lst_paises;
        private Button btn_cancelar;
        private NumericUpDown num_edad;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private RadioButton rdb_noBinario;
        private RadioButton rdb_femenino;
        private RadioButton rdb_masculino;
        private CheckBox chk_java;
        private CheckBox chk_node;
        private CheckBox chk_phyton;
        private CheckBox chk_angular;
        private CheckBox chk_c;
        protected Button btn_aceptar;
    }
}
