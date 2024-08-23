namespace tarea2
{
    partial class RegistrarExtras
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
            textBoxIdPlato = new TextBox();
            label2 = new Label();
            textBoxDescripcion = new TextBox();
            label3 = new Label();
            textBoxIdCategoria = new TextBox();
            textBoxPrecio = new TextBox();
            label4 = new Label();
            comboBoxEstado = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            dataGridViewIds = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIds).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 268);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Id plato extra";
            // 
            // textBoxIdPlato
            // 
            textBoxIdPlato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdPlato.Location = new Point(12, 286);
            textBoxIdPlato.Name = "textBoxIdPlato";
            textBoxIdPlato.Size = new Size(756, 23);
            textBoxIdPlato.TabIndex = 1;
            textBoxIdPlato.KeyPress += textBoxIdPlato_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 312);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.Location = new Point(12, 330);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(756, 23);
            textBoxDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 356);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 4;
            label3.Text = "Id de la categoria del plato extra";
            // 
            // textBoxIdCategoria
            // 
            textBoxIdCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdCategoria.Location = new Point(12, 374);
            textBoxIdCategoria.Name = "textBoxIdCategoria";
            textBoxIdCategoria.Size = new Size(756, 23);
            textBoxIdCategoria.TabIndex = 5;
            textBoxIdCategoria.KeyPress += textBoxIdCategoria_KeyPress;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrecio.Location = new Point(14, 462);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(756, 23);
            textBoxPrecio.TabIndex = 6;
            textBoxPrecio.KeyPress += textBoxPrecio_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 400);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBoxEstado.Location = new Point(12, 418);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(756, 23);
            comboBoxEstado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 444);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 500);
            button1.Name = "button1";
            button1.Size = new Size(755, 23);
            button1.TabIndex = 10;
            button1.Text = "Registrar Extra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewIds
            // 
            dataGridViewIds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewIds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIds.Location = new Point(233, 27);
            dataGridViewIds.Name = "dataGridViewIds";
            dataGridViewIds.RowTemplate.Height = 25;
            dataGridViewIds.Size = new Size(388, 232);
            dataGridViewIds.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 9);
            label6.Name = "label6";
            label6.Size = new Size(167, 15);
            label6.TabIndex = 12;
            label6.Text = "Lista de categorias disponibles";
            label6.Click += label6_Click;
            // 
            // RegistrarExtras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 535);
            Controls.Add(label6);
            Controls.Add(dataGridViewIds);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBoxEstado);
            Controls.Add(label4);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxIdCategoria);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(textBoxIdPlato);
            Controls.Add(label1);
            Name = "RegistrarExtras";
            Text = "RegistrarExtras";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdPlato;
        private Label label2;
        private TextBox textBoxDescripcion;
        private Label label3;
        private TextBox textBoxIdCategoria;
        private TextBox textBoxPrecio;
        private Label label4;
        private ComboBox comboBoxEstado;
        private Label label5;
        private Button button1;
        private DataGridView dataGridViewIds;
        private Label label6;
    }
}