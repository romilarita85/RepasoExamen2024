﻿namespace FormRegistrate
{
    partial class FormPrincipal
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
            dgv_lstIngresantes = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lstIngresantes).BeginInit();
            SuspendLayout();
            // 
            // dgv_lstIngresantes
            // 
            dgv_lstIngresantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lstIngresantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lstIngresantes.Location = new Point(49, 51);
            dgv_lstIngresantes.Name = "dgv_lstIngresantes";
            dgv_lstIngresantes.Size = new Size(703, 327);
            dgv_lstIngresantes.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(311, 402);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(174, 40);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 465);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_lstIngresantes);
            Name = "FormPrincipal";
            Text = "Lista de ingresantes";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lstIngresantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lstIngresantes;
        private Button btn_agregar;
    }
}