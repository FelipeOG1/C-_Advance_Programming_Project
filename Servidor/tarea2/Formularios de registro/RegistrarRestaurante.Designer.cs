namespace tarea2
{
    partial class RegistrarRestaurante
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
            btnRegistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxID = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNombre = new TextBox();
            comboBoxEstado = new ComboBox();
            label5 = new Label();
            textBoxTelefono = new TextBox();
            labelPrueba = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Location = new Point(16, 287);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(413, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "ID del restaurante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxID.Location = new Point(16, 27);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(413, 23);
            textBoxID.TabIndex = 5;
            textBoxID.KeyPress += textBoxID_KeyPress;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDireccion.Location = new Point(16, 129);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(413, 23);
            textBoxDireccion.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(16, 71);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(413, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBoxEstado.Location = new Point(16, 241);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(413, 23);
            comboBoxEstado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre del restaurante";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTelefono.Location = new Point(16, 185);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(413, 23);
            textBoxTelefono.TabIndex = 10;
            textBoxTelefono.KeyPress += textBoxTelefono_KeyPress;
            // 
            // labelPrueba
            // 
            labelPrueba.AutoSize = true;
            labelPrueba.Location = new Point(186, 335);
            labelPrueba.Name = "labelPrueba";
            labelPrueba.Size = new Size(63, 15);
            labelPrueba.TabIndex = 11;
            labelPrueba.Text = "txtPruebas";
            // 
            // RegistrarRestaurante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(labelPrueba);
            Controls.Add(textBoxTelefono);
            Controls.Add(label5);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Name = "RegistrarRestaurante";
            Text = "Registrar Restaurante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxID;
        private TextBox textBoxDireccion;
        private TextBox textBoxNombre;
        private ComboBox comboBoxEstado;
        private Label label5;
        private TextBox textBoxTelefono;
        private Label labelPrueba;
    }
}