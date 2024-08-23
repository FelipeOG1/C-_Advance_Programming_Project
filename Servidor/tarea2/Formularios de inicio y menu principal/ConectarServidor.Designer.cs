namespace tarea2.Formularios_de_inicio_y_menu_principal
{
    partial class ConectarServidor
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
            lblEstado = new Label();
            btnIniciar = new Button();
            btnApagar = new Button();
            lstClientesConectados = new ListBox();
            btnMenu = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(396, 73);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(55, 15);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Apagado";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(295, 115);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(428, 115);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // lstClientesConectados
            // 
            lstClientesConectados.FormattingEnabled = true;
            lstClientesConectados.ItemHeight = 15;
            lstClientesConectados.Location = new Point(320, 194);
            lstClientesConectados.Name = "lstClientesConectados";
            lstClientesConectados.Size = new Size(169, 244);
            lstClientesConectados.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(573, 395);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(195, 23);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Abrir Menus de servidor";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 167);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 6;
            label2.Text = "ID de los clientes conectados";
            // 
            // ConectarServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnMenu);
            Controls.Add(lstClientesConectados);
            Controls.Add(btnApagar);
            Controls.Add(btnIniciar);
            Controls.Add(lblEstado);
            Controls.Add(label1);
            Name = "ConectarServidor";
            Text = "ConectarServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEstado;
        private Button btnIniciar;
        private Button btnApagar;
        private ListBox lstClientesConectados;
        private Button btnMenu;
        private Label label2;
    }
}