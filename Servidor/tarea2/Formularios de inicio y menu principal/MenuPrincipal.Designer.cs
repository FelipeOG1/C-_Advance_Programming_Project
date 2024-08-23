namespace tarea2
{
    partial class MenuPrincipal
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
            menuStrip1 = new MenuStrip();
            btnRegistrarRestaurantes = new Button();
            btnRegistrarCategoria = new Button();
            btnRegistrarPlato = new Button();
            btnRegistrarCliente = new Button();
            btnRegistrarPlatosRestaurante = new Button();
            btnConsultarRestaurante = new Button();
            btnConsultarCategoria = new Button();
            btnConsultarPlato = new Button();
            btnConsultarCliente = new Button();
            btnConsultarPlatosRestaurante = new Button();
            btnRegistrarExtras = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(334, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnRegistrarRestaurantes
            // 
            btnRegistrarRestaurantes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarRestaurantes.Location = new Point(12, 51);
            btnRegistrarRestaurantes.Name = "btnRegistrarRestaurantes";
            btnRegistrarRestaurantes.Size = new Size(310, 23);
            btnRegistrarRestaurantes.TabIndex = 1;
            btnRegistrarRestaurantes.Text = "Registrar restaurante";
            btnRegistrarRestaurantes.UseVisualStyleBackColor = true;
            btnRegistrarRestaurantes.Click += btnRegistrarRestaurantes_Click;
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarCategoria.Location = new Point(12, 93);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(310, 23);
            btnRegistrarCategoria.TabIndex = 2;
            btnRegistrarCategoria.Text = "Registrar Categoría de Plato";
            btnRegistrarCategoria.UseVisualStyleBackColor = true;
            btnRegistrarCategoria.Click += btnRegistrarCategoria_Click;
            // 
            // btnRegistrarPlato
            // 
            btnRegistrarPlato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarPlato.Location = new Point(12, 132);
            btnRegistrarPlato.Name = "btnRegistrarPlato";
            btnRegistrarPlato.Size = new Size(310, 23);
            btnRegistrarPlato.TabIndex = 3;
            btnRegistrarPlato.Text = "Registrar Plato";
            btnRegistrarPlato.UseVisualStyleBackColor = true;
            btnRegistrarPlato.Click += btnRegistrarPlato_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarCliente.Location = new Point(12, 170);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(310, 23);
            btnRegistrarCliente.TabIndex = 4;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnRegistrarPlatosRestaurante
            // 
            btnRegistrarPlatosRestaurante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarPlatosRestaurante.Location = new Point(12, 247);
            btnRegistrarPlatosRestaurante.Name = "btnRegistrarPlatosRestaurante";
            btnRegistrarPlatosRestaurante.Size = new Size(310, 23);
            btnRegistrarPlatosRestaurante.TabIndex = 5;
            btnRegistrarPlatosRestaurante.Text = "Registrar Platos por Restaurante";
            btnRegistrarPlatosRestaurante.UseVisualStyleBackColor = true;
            btnRegistrarPlatosRestaurante.Click += btnRegistrarPlatosRestaurante_Click;
            // 
            // btnConsultarRestaurante
            // 
            btnConsultarRestaurante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultarRestaurante.Location = new Point(12, 289);
            btnConsultarRestaurante.Name = "btnConsultarRestaurante";
            btnConsultarRestaurante.Size = new Size(310, 23);
            btnConsultarRestaurante.TabIndex = 6;
            btnConsultarRestaurante.Text = "Consultar restaurante";
            btnConsultarRestaurante.UseVisualStyleBackColor = true;
            btnConsultarRestaurante.Click += btnConsultarRestaurante_Click;
            // 
            // btnConsultarCategoria
            // 
            btnConsultarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultarCategoria.Location = new Point(12, 328);
            btnConsultarCategoria.Name = "btnConsultarCategoria";
            btnConsultarCategoria.Size = new Size(310, 23);
            btnConsultarCategoria.TabIndex = 7;
            btnConsultarCategoria.Text = "Consultar categoria de plato";
            btnConsultarCategoria.UseVisualStyleBackColor = true;
            btnConsultarCategoria.Click += btnConsultarCategoria_Click;
            // 
            // btnConsultarPlato
            // 
            btnConsultarPlato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultarPlato.Location = new Point(12, 368);
            btnConsultarPlato.Name = "btnConsultarPlato";
            btnConsultarPlato.Size = new Size(310, 23);
            btnConsultarPlato.TabIndex = 8;
            btnConsultarPlato.Text = " Consultar platos";
            btnConsultarPlato.UseVisualStyleBackColor = true;
            btnConsultarPlato.Click += btnConsultarPlato_Click;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultarCliente.Location = new Point(12, 409);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(310, 23);
            btnConsultarCliente.TabIndex = 9;
            btnConsultarCliente.Text = "Consultar clientes";
            btnConsultarCliente.UseVisualStyleBackColor = true;
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // btnConsultarPlatosRestaurante
            // 
            btnConsultarPlatosRestaurante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultarPlatosRestaurante.Location = new Point(12, 453);
            btnConsultarPlatosRestaurante.Name = "btnConsultarPlatosRestaurante";
            btnConsultarPlatosRestaurante.Size = new Size(310, 23);
            btnConsultarPlatosRestaurante.TabIndex = 10;
            btnConsultarPlatosRestaurante.Text = "Consultar platos por restaurante";
            btnConsultarPlatosRestaurante.UseVisualStyleBackColor = true;
            btnConsultarPlatosRestaurante.Click += btnConsultarPlatosRestaurante_Click;
            // 
            // btnRegistrarExtras
            // 
            btnRegistrarExtras.Location = new Point(12, 209);
            btnRegistrarExtras.Name = "btnRegistrarExtras";
            btnRegistrarExtras.Size = new Size(310, 23);
            btnRegistrarExtras.TabIndex = 11;
            btnRegistrarExtras.Text = "Registrar extras";
            btnRegistrarExtras.UseVisualStyleBackColor = true;
            btnRegistrarExtras.Click += btnRegistrarExtras_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 492);
            button2.Name = "button2";
            button2.Size = new Size(310, 23);
            button2.TabIndex = 12;
            button2.Text = "Consultar Extras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 592);
            Controls.Add(button2);
            Controls.Add(btnRegistrarExtras);
            Controls.Add(btnConsultarPlatosRestaurante);
            Controls.Add(btnConsultarCliente);
            Controls.Add(btnConsultarPlato);
            Controls.Add(btnConsultarCategoria);
            Controls.Add(btnConsultarRestaurante);
            Controls.Add(btnRegistrarPlatosRestaurante);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(btnRegistrarPlato);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(btnRegistrarRestaurantes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnRegistrarRestaurantes;
        private Button btnRegistrarCategoria;
        private Button btnRegistrarPlato;
        private Button btnRegistrarCliente;
        private Button btnRegistrarPlatosRestaurante;
        private Button btnConsultarRestaurante;
        private Button btnConsultarCategoria;
        private Button btnConsultarPlato;
        private Button btnConsultarCliente;
        private Button btnConsultarPlatosRestaurante;
        private Button btnRegistrarExtras;
        private Button button2;
    }
}