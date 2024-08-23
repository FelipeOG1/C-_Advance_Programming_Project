namespace tarea2
{
    partial class RegistrarCliente
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
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxPrimerApe = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxSegundoApe = new TextBox();
            label5 = new Label();
            dateTimePickerCliente = new DateTimePicker();
            btnRegistrar = new Button();
            label6 = new Label();
            comboBoxGenero = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Id del cliente";
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.Location = new Point(12, 27);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(481, 23);
            textBoxId.TabIndex = 1;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del cliente";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(12, 71);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(481, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxPrimerApe
            // 
            textBoxPrimerApe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrimerApe.Location = new Point(12, 115);
            textBoxPrimerApe.Name = "textBoxPrimerApe";
            textBoxPrimerApe.Size = new Size(481, 23);
            textBoxPrimerApe.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Primer apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Segundo apellido";
            // 
            // textBoxSegundoApe
            // 
            textBoxSegundoApe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSegundoApe.Location = new Point(12, 159);
            textBoxSegundoApe.Name = "textBoxSegundoApe";
            textBoxSegundoApe.Size = new Size(481, 23);
            textBoxSegundoApe.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha de nacimiento";
            // 
            // dateTimePickerCliente
            // 
            dateTimePickerCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerCliente.Location = new Point(12, 203);
            dateTimePickerCliente.Name = "dateTimePickerCliente";
            dateTimePickerCliente.Size = new Size(481, 23);
            dateTimePickerCliente.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Location = new Point(12, 307);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(481, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar cliente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "H", "M" });
            comboBoxGenero.Location = new Point(12, 247);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(481, 23);
            comboBoxGenero.TabIndex = 12;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(comboBoxGenero);
            Controls.Add(label6);
            Controls.Add(btnRegistrar);
            Controls.Add(dateTimePickerCliente);
            Controls.Add(label5);
            Controls.Add(textBoxSegundoApe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPrimerApe);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "RegistrarCliente";
            Text = "RegistrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxPrimerApe;
        private Label label3;
        private Label label4;
        private TextBox textBoxSegundoApe;
        private Label label5;
        private DateTimePicker dateTimePickerCliente;
        private Button btnRegistrar;
        private Label label6;
        private ComboBox comboBoxGenero;
    }
}