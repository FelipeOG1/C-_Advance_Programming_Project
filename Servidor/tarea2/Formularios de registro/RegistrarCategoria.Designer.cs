namespace tarea2
{
    partial class RegistrarCategoria
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
            textBoxDescripcion = new TextBox();
            label3 = new Label();
            comboBoxEstado = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de la categoria";
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.Location = new Point(12, 27);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(278, 23);
            textBoxId.TabIndex = 1;
           
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion categoria";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.Location = new Point(12, 71);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(278, 23);
            textBoxDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBoxEstado.Location = new Point(12, 115);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(278, 23);
            comboBoxEstado.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Location = new Point(12, 144);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(278, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registar Categoria";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBoxEstado);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "RegistrarCategoria";
            Text = "RegistrarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxDescripcion;
        private Label label3;
        private ComboBox comboBoxEstado;
        private Button btnRegistrar;
    }
}