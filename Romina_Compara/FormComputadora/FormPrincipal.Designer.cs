namespace FormComputadora
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
            dgv_computadoras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).BeginInit();
            SuspendLayout();
            // 
            // dgv_computadoras
            // 
            dgv_computadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_computadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_computadoras.Location = new Point(46, 37);
            dgv_computadoras.Name = "dgv_computadoras";
            dgv_computadoras.Size = new Size(842, 325);
            dgv_computadoras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(420, 390);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(128, 34);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_computadoras);
            Name = "Form1";
            Text = "Computadoras";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_computadoras;
        private Button btn_agregar;
    }
}
