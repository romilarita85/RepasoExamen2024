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
            gpb_sitemaOp = new GroupBox();
            gpb_programas = new GroupBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            gpb_hardware.SuspendLayout();
            gpb_sitemaOp.SuspendLayout();
            gpb_programas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // gpb_hardware
            // 
            gpb_hardware.Controls.Add(numericUpDown2);
            gpb_hardware.Controls.Add(numericUpDown1);
            gpb_hardware.Controls.Add(comboBox1);
            gpb_hardware.Controls.Add(label3);
            gpb_hardware.Controls.Add(label2);
            gpb_hardware.Controls.Add(label1);
            gpb_hardware.Location = new Point(63, 45);
            gpb_hardware.Name = "gpb_hardware";
            gpb_hardware.Size = new Size(391, 320);
            gpb_hardware.TabIndex = 0;
            gpb_hardware.TabStop = false;
            gpb_hardware.Text = "Hardware";
            // 
            // gpb_sitemaOp
            // 
            gpb_sitemaOp.Controls.Add(radioButton3);
            gpb_sitemaOp.Controls.Add(radioButton2);
            gpb_sitemaOp.Controls.Add(radioButton1);
            gpb_sitemaOp.Location = new Point(470, 45);
            gpb_sitemaOp.Name = "gpb_sitemaOp";
            gpb_sitemaOp.Size = new Size(187, 135);
            gpb_sitemaOp.TabIndex = 0;
            gpb_sitemaOp.TabStop = false;
            gpb_sitemaOp.Text = "Sistema Operativo";
            // 
            // gpb_programas
            // 
            gpb_programas.Controls.Add(checkBox5);
            gpb_programas.Controls.Add(checkBox4);
            gpb_programas.Controls.Add(checkBox3);
            gpb_programas.Controls.Add(checkBox2);
            gpb_programas.Controls.Add(checkBox1);
            gpb_programas.Location = new Point(470, 191);
            gpb_programas.Name = "gpb_programas";
            gpb_programas.Size = new Size(187, 174);
            gpb_programas.TabIndex = 0;
            gpb_programas.TabStop = false;
            gpb_programas.Text = "Programas";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(400, 400);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(112, 39);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(545, 400);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 39);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 90);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 140);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 186);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(143, 132);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(149, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(143, 178);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(149, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 90);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(24, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(24, 57);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(24, 82);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(24, 107);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(24, 132);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
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
            Text = "FormAlta";
            gpb_hardware.ResumeLayout(false);
            gpb_hardware.PerformLayout();
            gpb_sitemaOp.ResumeLayout(false);
            gpb_sitemaOp.PerformLayout();
            gpb_programas.ResumeLayout(false);
            gpb_programas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_hardware;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gpb_sitemaOp;
        private GroupBox gpb_programas;
        private Button btn_cancelar;
        private Button btn_agregar;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}