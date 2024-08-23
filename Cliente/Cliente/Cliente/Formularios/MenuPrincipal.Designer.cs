namespace Cliente.Formularios
{
    partial class MenuPrincipal
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
            lblEstado = new Label();
            btnConectar = new Button();
            btnDesconectar = new Button();
            labelEstado = new Label();
            label3 = new Label();
            txtIdCliente = new TextBox();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(34, 50);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado:";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(466, 110);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(587, 110);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(82, 23);
            btnDesconectar.TabIndex = 2;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(111, 50);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(82, 15);
            labelEstado.TabIndex = 4;
            labelEstado.Text = "Desconectado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 98);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Id del cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(147, 90);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdCliente);
            Controls.Add(label3);
            Controls.Add(labelEstado);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(lblEstado);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private Button btnConectar;
        private Button btnDesconectar;
        private Label labelEstado;
        private Label label3;
        private TextBox txtIdCliente;
    }
}