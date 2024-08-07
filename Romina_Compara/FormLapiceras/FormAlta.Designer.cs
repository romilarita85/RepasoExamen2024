namespace FormLapiceras
{
    partial class FormAlta
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
            lbl_color = new Label();
            lbl_precio = new Label();
            cmb_colores = new ComboBox();
            num_precio = new NumericUpDown();
            gpb_marcas = new GroupBox();
            rdb_rotring = new RadioButton();
            rdb_parker = new RadioButton();
            rdb_fader = new RadioButton();
            rdb_filgo = new RadioButton();
            rdb_bic = new RadioButton();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            gpb_marcas.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(59, 81);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 0;
            lbl_color.Text = "Color";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(59, 134);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(40, 15);
            lbl_precio.TabIndex = 1;
            lbl_precio.Text = "Precio";
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(143, 73);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(137, 23);
            cmb_colores.TabIndex = 2;
            // 
            // num_precio
            // 
            num_precio.Location = new Point(143, 126);
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(136, 23);
            num_precio.TabIndex = 3;
            // 
            // gpb_marcas
            // 
            gpb_marcas.Controls.Add(rdb_rotring);
            gpb_marcas.Controls.Add(rdb_parker);
            gpb_marcas.Controls.Add(rdb_fader);
            gpb_marcas.Controls.Add(rdb_filgo);
            gpb_marcas.Controls.Add(rdb_bic);
            gpb_marcas.Location = new Point(315, 52);
            gpb_marcas.Name = "gpb_marcas";
            gpb_marcas.Size = new Size(256, 185);
            gpb_marcas.TabIndex = 4;
            gpb_marcas.TabStop = false;
            gpb_marcas.Text = "Marca";
            // 
            // rdb_rotring
            // 
            rdb_rotring.AutoSize = true;
            rdb_rotring.Location = new Point(67, 130);
            rdb_rotring.Name = "rdb_rotring";
            rdb_rotring.Size = new Size(64, 19);
            rdb_rotring.TabIndex = 4;
            rdb_rotring.TabStop = true;
            rdb_rotring.Text = "Rotring";
            rdb_rotring.UseVisualStyleBackColor = true;
            // 
            // rdb_parker
            // 
            rdb_parker.AutoSize = true;
            rdb_parker.Location = new Point(67, 105);
            rdb_parker.Name = "rdb_parker";
            rdb_parker.Size = new Size(58, 19);
            rdb_parker.TabIndex = 3;
            rdb_parker.TabStop = true;
            rdb_parker.Text = "Parker";
            rdb_parker.UseVisualStyleBackColor = true;
            // 
            // rdb_fader
            // 
            rdb_fader.AutoSize = true;
            rdb_fader.Location = new Point(67, 80);
            rdb_fader.Name = "rdb_fader";
            rdb_fader.Size = new Size(92, 19);
            rdb_fader.TabIndex = 2;
            rdb_fader.TabStop = true;
            rdb_fader.Text = "Faber Castell";
            rdb_fader.UseVisualStyleBackColor = true;
            // 
            // rdb_filgo
            // 
            rdb_filgo.AutoSize = true;
            rdb_filgo.Location = new Point(67, 55);
            rdb_filgo.Name = "rdb_filgo";
            rdb_filgo.Size = new Size(51, 19);
            rdb_filgo.TabIndex = 1;
            rdb_filgo.TabStop = true;
            rdb_filgo.Text = "Filgo";
            rdb_filgo.UseVisualStyleBackColor = true;
            // 
            // rdb_bic
            // 
            rdb_bic.AutoSize = true;
            rdb_bic.Location = new Point(67, 30);
            rdb_bic.Name = "rdb_bic";
            rdb_bic.Size = new Size(41, 19);
            rdb_bic.TabIndex = 0;
            rdb_bic.TabStop = true;
            rdb_bic.Text = "Bic";
            rdb_bic.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(143, 271);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 33);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(387, 271);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(96, 33);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 349);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_marcas);
            Controls.Add(num_precio);
            Controls.Add(cmb_colores);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_color);
            Name = "FormAlta";
            Text = "Alta lapicera";
            Load += FormAlta_Load;
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            gpb_marcas.ResumeLayout(false);
            gpb_marcas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_color;
        private Label lbl_precio;
        private ComboBox cmb_colores;
        private NumericUpDown num_precio;
        private GroupBox gpb_marcas;
        private RadioButton rdb_rotring;
        private RadioButton rdb_parker;
        private RadioButton rdb_fader;
        private RadioButton rdb_filgo;
        private RadioButton rdb_bic;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}