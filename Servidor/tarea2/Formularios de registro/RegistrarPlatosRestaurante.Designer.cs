namespace tarea2
{
    partial class RegistrarPlatosRestaurante
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
            label2 = new Label();
            label3 = new Label();
            textBoxIdAsignacion = new TextBox();
            label5 = new Label();
            textBoxIdPlato = new TextBox();
            dataGridViewPlatos = new DataGridView();
            btnRegistrar = new Button();
            comboBoxRestaurante = new ComboBox();
            dataGridViewRestaurantes = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 241);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Id de asignacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 188);
            label2.Name = "label2";
            label2.Size = new Size(228, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione uno de los restaurantes activos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(871, 4);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 2;
            label3.Text = "Lista de platos disponibles";
            // 
            // textBoxIdAsignacion
            // 
            textBoxIdAsignacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdAsignacion.Location = new Point(5, 259);
            textBoxIdAsignacion.Name = "textBoxIdAsignacion";
            textBoxIdAsignacion.Size = new Size(1137, 23);
            textBoxIdAsignacion.TabIndex = 3;
            textBoxIdAsignacion.KeyPress += textBoxIdAsignacion_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 285);
            label5.Name = "label5";
            label5.Size = new Size(285, 15);
            label5.TabIndex = 7;
            label5.Text = "Digite el id del plato que desea agregar al restaurante";
            // 
            // textBoxIdPlato
            // 
            textBoxIdPlato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdPlato.Location = new Point(5, 303);
            textBoxIdPlato.Name = "textBoxIdPlato";
            textBoxIdPlato.Size = new Size(1137, 23);
            textBoxIdPlato.TabIndex = 8;
            textBoxIdPlato.KeyPress += textBoxIdPlato_KeyPress;
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Location = new Point(706, 22);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.RowTemplate.Height = 25;
            dataGridViewPlatos.Size = new Size(436, 150);
            dataGridViewPlatos.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Location = new Point(5, 332);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(1137, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar plato a restaurante";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // comboBoxRestaurante
            // 
            comboBoxRestaurante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRestaurante.FormattingEnabled = true;
            comboBoxRestaurante.Location = new Point(5, 206);
            comboBoxRestaurante.Name = "comboBoxRestaurante";
            comboBoxRestaurante.Size = new Size(1137, 23);
            comboBoxRestaurante.TabIndex = 12;
            // 
            // dataGridViewRestaurantes
            // 
            dataGridViewRestaurantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRestaurantes.Location = new Point(5, 22);
            dataGridViewRestaurantes.Name = "dataGridViewRestaurantes";
            dataGridViewRestaurantes.RowTemplate.Height = 25;
            dataGridViewRestaurantes.Size = new Size(551, 150);
            dataGridViewRestaurantes.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 4);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 14;
            label4.Text = "Lista de Restaurantes";
            // 
            // RegistrarPlatosRestaurante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 638);
            Controls.Add(label4);
            Controls.Add(dataGridViewRestaurantes);
            Controls.Add(comboBoxRestaurante);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(textBoxIdPlato);
            Controls.Add(label5);
            Controls.Add(textBoxIdAsignacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarPlatosRestaurante";
            Text = "PlatosRestaurante";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxIdAsignacion;
        private Label label5;
        private TextBox textBoxIdPlato;
        private DataGridView dataGridViewPlatos;
        private Button btnRegistrar;
        private ComboBox comboBoxRestaurante;
        private DataGridView dataGridViewRestaurantes;
        private Label label4;
    }
}