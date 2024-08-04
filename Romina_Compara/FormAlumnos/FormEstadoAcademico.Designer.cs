namespace FormAlumnos
{
    partial class FormEstadoAcademico
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
            lst_estadoAcad = new ListBox();
            SuspendLayout();
            // 
            // lst_estadoAcad
            // 
            lst_estadoAcad.FormattingEnabled = true;
            lst_estadoAcad.ItemHeight = 15;
            lst_estadoAcad.Location = new Point(97, 46);
            lst_estadoAcad.Name = "lst_estadoAcad";
            lst_estadoAcad.Size = new Size(378, 334);
            lst_estadoAcad.TabIndex = 0;
            // 
            // FormEstadoAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(lst_estadoAcad);
            Name = "FormEstadoAcademico";
            Text = "Estado academico";
            Load += FormEstadoAcademico_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_estadoAcad;
    }
}