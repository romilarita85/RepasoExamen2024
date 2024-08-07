namespace FormLapiceras
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
            dgv_lapiceras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lapiceras).BeginInit();
            SuspendLayout();
            // 
            // dgv_lapiceras
            // 
            dgv_lapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lapiceras.Location = new Point(60, 47);
            dgv_lapiceras.Name = "dgv_lapiceras";
            dgv_lapiceras.Size = new Size(683, 307);
            dgv_lapiceras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(357, 390);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(118, 38);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_lapiceras);
            Name = "FormPrincipal";
            Text = "Lista de lapiceras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lapiceras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lapiceras;
        private Button btn_agregar;
    }
}
