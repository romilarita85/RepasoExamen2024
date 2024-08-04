namespace FormAuto
{
    partial class FormAuto
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
            lbl_marca = new Label();
            lbl_cantComb = new Label();
            lbl_color = new Label();
            txt_cantidad = new TextBox();
            txt_marca = new TextBox();
            cmb_colores = new ComboBox();
            btn_crear = new Button();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            lst_autos = new ListBox();
            SuspendLayout();
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(83, 119);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 0;
            lbl_marca.Text = "Marca";
            // 
            // lbl_cantComb
            // 
            lbl_cantComb.AutoSize = true;
            lbl_cantComb.Location = new Point(83, 181);
            lbl_cantComb.Name = "lbl_cantComb";
            lbl_cantComb.Size = new Size(140, 15);
            lbl_cantComb.TabIndex = 1;
            lbl_cantComb.Text = "Cantidad de combustible";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(83, 244);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 2;
            lbl_color.Text = "Color";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(234, 173);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(121, 23);
            txt_cantidad.TabIndex = 4;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(234, 116);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(121, 23);
            txt_marca.TabIndex = 5;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(234, 238);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(121, 23);
            cmb_colores.TabIndex = 6;
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(142, 378);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(98, 24);
            btn_crear.TabIndex = 7;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(444, 381);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(118, 21);
            btn_mostrar.TabIndex = 8;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(615, 381);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(118, 21);
            btn_limpiar.TabIndex = 9;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lst_autos
            // 
            lst_autos.FormattingEnabled = true;
            lst_autos.ItemHeight = 15;
            lst_autos.Location = new Point(403, 74);
            lst_autos.Name = "lst_autos";
            lst_autos.Size = new Size(367, 274);
            lst_autos.TabIndex = 10;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_autos);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_crear);
            Controls.Add(cmb_colores);
            Controls.Add(txt_marca);
            Controls.Add(txt_cantidad);
            Controls.Add(lbl_color);
            Controls.Add(lbl_cantComb);
            Controls.Add(lbl_marca);
            Name = "FormAuto";
            Text = "Mis autos";
            Load += FormAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_marca;
        private Label lbl_cantComb;
        private Label lbl_color;
        private TextBox txt_cantidad;
        private TextBox txt_marca;
        private ComboBox cmb_colores;
        private Button btn_crear;
        private Button btn_mostrar;
        private Button btn_limpiar;
        private ListBox lst_autos;
    }
}
