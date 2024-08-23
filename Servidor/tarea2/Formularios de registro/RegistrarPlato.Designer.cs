namespace tarea2
{
    partial class RegistrarPlato
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
            label4 = new Label();
            textBoxId = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxNombre = new TextBox();
            textBoxIdCategoria = new TextBox();
            TablaCategorias = new DataGridView();
            label5 = new Label();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 256);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Id del plato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 356);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 400);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 3;
            label4.Text = "Id a de la categoria a la que pertenence";
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.Location = new Point(12, 274);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(687, 23);
            textBoxId.TabIndex = 4;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPrecio.Location = new Point(12, 318);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(687, 23);
            textBoxPrecio.TabIndex = 5;
            textBoxPrecio.KeyPress += textBoxPrecio_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(12, 374);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(687, 23);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxIdCategoria
            // 
            textBoxIdCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIdCategoria.Location = new Point(12, 418);
            textBoxIdCategoria.Name = "textBoxIdCategoria";
            textBoxIdCategoria.Size = new Size(687, 23);
            textBoxIdCategoria.TabIndex = 7;
            // 
            // TablaCategorias
            // 
            TablaCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TablaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaCategorias.Location = new Point(182, 42);
            TablaCategorias.Name = "TablaCategorias";
            TablaCategorias.RowTemplate.Height = 25;
            TablaCategorias.Size = new Size(367, 175);
            TablaCategorias.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 9);
            label5.Name = "label5";
            label5.Size = new Size(218, 15);
            label5.TabIndex = 9;
            label5.Text = "Lista de categorias de platos disponibles";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Location = new Point(12, 463);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(687, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar Plato";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistrarPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 515);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(TablaCategorias);
            Controls.Add(textBoxIdCategoria);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarPlato";
            Text = "RegistrarPlato";
            ((System.ComponentModel.ISupportInitialize)TablaCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxId;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private TextBox textBoxIdCategoria;
        private DataGridView TablaCategorias;
        private Label label5;
        private Button btnRegistrar;
    }
}