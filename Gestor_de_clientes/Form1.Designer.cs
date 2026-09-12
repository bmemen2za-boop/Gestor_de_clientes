namespace Gestor_de_clientes
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
            Txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_direccion = new TextBox();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_direccion = new Label();
            Btn_guardar = new Button();
            Btn_cancelar = new Button();
            SuspendLayout();
            // 
            // Txt_nombre
            // 
            Txt_nombre.Location = new Point(167, 77);
            Txt_nombre.Name = "Txt_nombre";
            Txt_nombre.Size = new Size(166, 23);
            Txt_nombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(167, 118);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(166, 23);
            txt_apellido.TabIndex = 1;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(167, 159);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(401, 23);
            txt_direccion.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(97, 85);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(97, 126);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 4;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(97, 167);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 5;
            lbl_direccion.Text = "Direccion";
            // 
            // Btn_guardar
            // 
            Btn_guardar.Location = new Point(112, 220);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(75, 23);
            Btn_guardar.TabIndex = 6;
            Btn_guardar.Text = "Guardar";
            Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            Btn_cancelar.Location = new Point(241, 220);
            Btn_cancelar.Name = "Btn_cancelar";
            Btn_cancelar.Size = new Size(75, 23);
            Btn_cancelar.TabIndex = 7;
            Btn_cancelar.Text = "Cancelar";
            Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_cancelar);
            Controls.Add(Btn_guardar);
            Controls.Add(lbl_direccion);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_direccion);
            Controls.Add(txt_apellido);
            Controls.Add(Txt_nombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_direccion;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_direccion;
        private Button Btn_guardar;
        private Button Btn_cancelar;
    }
}
