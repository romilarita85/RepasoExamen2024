namespace FormComputadora
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
            gpb_hardware = new GroupBox();
            num_disco = new NumericUpDown();
            num_memoriaRam = new NumericUpDown();
            cmb_procesadores = new ComboBox();
            lbl_disco = new Label();
            lbl_memoriaRam = new Label();
            lbl_procesador = new Label();
            gpb_sitemaOp = new GroupBox();
            rdb_mac = new RadioButton();
            rdb_linux = new RadioButton();
            rdw_windows = new RadioButton();
            gpb_programas = new GroupBox();
            chk_avast = new CheckBox();
            chk_dropbox = new CheckBox();
            chk_winrar = new CheckBox();
            chk_adobe = new CheckBox();
            chk_office = new CheckBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpb_hardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_memoriaRam).BeginInit();
            gpb_sitemaOp.SuspendLayout();
            gpb_programas.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_hardware
            // 
            gpb_hardware.Controls.Add(num_disco);
            gpb_hardware.Controls.Add(num_memoriaRam);
            gpb_hardware.Controls.Add(cmb_procesadores);
            gpb_hardware.Controls.Add(lbl_disco);
            gpb_hardware.Controls.Add(lbl_memoriaRam);
            gpb_hardware.Controls.Add(lbl_procesador);
            gpb_hardware.Location = new Point(63, 45);
            gpb_hardware.Name = "gpb_hardware";
            gpb_hardware.Size = new Size(391, 320);
            gpb_hardware.TabIndex = 0;
            gpb_hardware.TabStop = false;
            gpb_hardware.Text = "Hardware";
            // 
            // num_disco
            // 
            num_disco.Location = new Point(143, 178);
            num_disco.Name = "num_disco";
            num_disco.Size = new Size(149, 23);
            num_disco.TabIndex = 5;
            // 
            // num_memoriaRam
            // 
            num_memoriaRam.Location = new Point(143, 132);
            num_memoriaRam.Name = "num_memoriaRam";
            num_memoriaRam.Size = new Size(149, 23);
            num_memoriaRam.TabIndex = 4;
            // 
            // cmb_procesadores
            // 
            cmb_procesadores.FormattingEnabled = true;
            cmb_procesadores.Location = new Point(143, 82);
            cmb_procesadores.Name = "cmb_procesadores";
            cmb_procesadores.Size = new Size(150, 23);
            cmb_procesadores.TabIndex = 3;
            // 
            // lbl_disco
            // 
            lbl_disco.AutoSize = true;
            lbl_disco.Location = new Point(47, 186);
            lbl_disco.Name = "lbl_disco";
            lbl_disco.Size = new Size(36, 15);
            lbl_disco.TabIndex = 2;
            lbl_disco.Text = "Disco";
            // 
            // lbl_memoriaRam
            // 
            lbl_memoriaRam.AutoSize = true;
            lbl_memoriaRam.Location = new Point(47, 140);
            lbl_memoriaRam.Name = "lbl_memoriaRam";
            lbl_memoriaRam.Size = new Size(82, 15);
            lbl_memoriaRam.TabIndex = 1;
            lbl_memoriaRam.Text = "Memoria Ram";
            // 
            // lbl_procesador
            // 
            lbl_procesador.AutoSize = true;
            lbl_procesador.Location = new Point(47, 90);
            lbl_procesador.Name = "lbl_procesador";
            lbl_procesador.Size = new Size(66, 15);
            lbl_procesador.TabIndex = 0;
            lbl_procesador.Text = "Procesador";
            // 
            // gpb_sitemaOp
            // 
            gpb_sitemaOp.Controls.Add(rdb_mac);
            gpb_sitemaOp.Controls.Add(rdb_linux);
            gpb_sitemaOp.Controls.Add(rdw_windows);
            gpb_sitemaOp.Location = new Point(470, 45);
            gpb_sitemaOp.Name = "gpb_sitemaOp";
            gpb_sitemaOp.Size = new Size(187, 135);
            gpb_sitemaOp.TabIndex = 0;
            gpb_sitemaOp.TabStop = false;
            gpb_sitemaOp.Text = "Sistema Operativo";
            // 
            // rdb_mac
            // 
            rdb_mac.AutoSize = true;
            rdb_mac.Location = new Point(24, 90);
            rdb_mac.Name = "rdb_mac";
            rdb_mac.Size = new Size(65, 19);
            rdb_mac.TabIndex = 2;
            rdb_mac.TabStop = true;
            rdb_mac.Text = "Mac Os";
            rdb_mac.UseVisualStyleBackColor = true;
            // 
            // rdb_linux
            // 
            rdb_linux.AutoSize = true;
            rdb_linux.Location = new Point(24, 65);
            rdb_linux.Name = "rdb_linux";
            rdb_linux.Size = new Size(54, 19);
            rdb_linux.TabIndex = 1;
            rdb_linux.TabStop = true;
            rdb_linux.Text = "Linux";
            rdb_linux.UseVisualStyleBackColor = true;
            // 
            // rdw_windows
            // 
            rdw_windows.AutoSize = true;
            rdw_windows.Location = new Point(24, 40);
            rdw_windows.Name = "rdw_windows";
            rdw_windows.Size = new Size(74, 19);
            rdw_windows.TabIndex = 0;
            rdw_windows.TabStop = true;
            rdw_windows.Text = "Windows";
            rdw_windows.UseVisualStyleBackColor = true;
            // 
            // gpb_programas
            // 
            gpb_programas.Controls.Add(chk_avast);
            gpb_programas.Controls.Add(chk_dropbox);
            gpb_programas.Controls.Add(chk_winrar);
            gpb_programas.Controls.Add(chk_adobe);
            gpb_programas.Controls.Add(chk_office);
            gpb_programas.Location = new Point(470, 191);
            gpb_programas.Name = "gpb_programas";
            gpb_programas.Size = new Size(187, 174);
            gpb_programas.TabIndex = 0;
            gpb_programas.TabStop = false;
            gpb_programas.Text = "Programas";
            // 
            // chk_avast
            // 
            chk_avast.AutoSize = true;
            chk_avast.Location = new Point(24, 132);
            chk_avast.Name = "chk_avast";
            chk_avast.Size = new Size(55, 19);
            chk_avast.TabIndex = 4;
            chk_avast.Text = "Avast";
            chk_avast.UseVisualStyleBackColor = true;
            // 
            // chk_dropbox
            // 
            chk_dropbox.AutoSize = true;
            chk_dropbox.Location = new Point(24, 107);
            chk_dropbox.Name = "chk_dropbox";
            chk_dropbox.Size = new Size(72, 19);
            chk_dropbox.TabIndex = 3;
            chk_dropbox.Text = "DropBox";
            chk_dropbox.UseVisualStyleBackColor = true;
            // 
            // chk_winrar
            // 
            chk_winrar.AutoSize = true;
            chk_winrar.Location = new Point(24, 82);
            chk_winrar.Name = "chk_winrar";
            chk_winrar.Size = new Size(61, 19);
            chk_winrar.TabIndex = 2;
            chk_winrar.Text = "Winrar";
            chk_winrar.UseVisualStyleBackColor = true;
            // 
            // chk_adobe
            // 
            chk_adobe.AutoSize = true;
            chk_adobe.Location = new Point(24, 57);
            chk_adobe.Name = "chk_adobe";
            chk_adobe.Size = new Size(100, 19);
            chk_adobe.TabIndex = 1;
            chk_adobe.Text = "Adobe Reader";
            chk_adobe.UseVisualStyleBackColor = true;
            // 
            // chk_office
            // 
            chk_office.AutoSize = true;
            chk_office.Location = new Point(24, 32);
            chk_office.Name = "chk_office";
            chk_office.Size = new Size(58, 19);
            chk_office.TabIndex = 0;
            chk_office.Text = "Office";
            chk_office.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(400, 400);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(112, 39);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(545, 400);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 39);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 478);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_sitemaOp);
            Controls.Add(gpb_programas);
            Controls.Add(gpb_hardware);
            Name = "FormAlta";
            Text = "Alta computadora";
            Load += FormAlta_Load;
            gpb_hardware.ResumeLayout(false);
            gpb_hardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_memoriaRam).EndInit();
            gpb_sitemaOp.ResumeLayout(false);
            gpb_sitemaOp.PerformLayout();
            gpb_programas.ResumeLayout(false);
            gpb_programas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_hardware;
        private NumericUpDown num_disco;
        private NumericUpDown num_memoriaRam;
        private ComboBox cmb_procesadores;
        private Label lbl_disco;
        private Label lbl_memoriaRam;
        private Label lbl_procesador;
        private GroupBox gpb_sitemaOp;
        private GroupBox gpb_programas;
        private Button btn_cancelar;
        private Button btn_agregar;
        private RadioButton rdb_mac;
        private RadioButton rdb_linux;
        private RadioButton rdw_windows;
        private CheckBox chk_avast;
        private CheckBox chk_dropbox;
        private CheckBox chk_winrar;
        private CheckBox chk_adobe;
        private CheckBox chk_office;
    }
}