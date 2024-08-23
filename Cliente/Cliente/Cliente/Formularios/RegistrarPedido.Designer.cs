namespace Cliente.Formularios
{
    partial class RegistrarPedido
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
            lblPlatos = new Label();
            dataGridViewPlatos = new DataGridView();
            cmbRestaurantes = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxPlatos = new ComboBox();
            dataGridViewExtras = new DataGridView();
            label4 = new Label();
            comboBoxExtras = new ComboBox();
            label5 = new Label();
            listBoxPedido = new ListBox();
            btnRealizarPedido = new Button();
            button1 = new Button();
            dataGridViewPedidos = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 290);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione uno de los restaurantes activos";
            // 
            // lblPlatos
            // 
            lblPlatos.AutoSize = true;
            lblPlatos.Location = new Point(174, 44);
            lblPlatos.Name = "lblPlatos";
            lblPlatos.Size = new Size(137, 15);
            lblPlatos.TabIndex = 2;
            lblPlatos.Text = "Lista de platos asociados";
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Location = new Point(33, 62);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.RowTemplate.Height = 25;
            dataGridViewPlatos.Size = new Size(458, 168);
            dataGridViewPlatos.TabIndex = 3;
            // 
            // cmbRestaurantes
            // 
            cmbRestaurantes.FormattingEnabled = true;
            cmbRestaurantes.Location = new Point(254, 282);
            cmbRestaurantes.Name = "cmbRestaurantes";
            cmbRestaurantes.Size = new Size(121, 23);
            cmbRestaurantes.TabIndex = 4;
            cmbRestaurantes.SelectedIndexChanged += cmbRestaurantes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(904, 44);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Lista de extras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 333);
            label2.Name = "label2";
            label2.Size = new Size(236, 15);
            label2.TabIndex = 6;
            label2.Text = "Seleccione alguno de los platos Disponibles";
            // 
            // comboBoxPlatos
            // 
            comboBoxPlatos.FormattingEnabled = true;
            comboBoxPlatos.Location = new Point(254, 330);
            comboBoxPlatos.Name = "comboBoxPlatos";
            comboBoxPlatos.Size = new Size(121, 23);
            comboBoxPlatos.TabIndex = 7;
            comboBoxPlatos.SelectedIndexChanged += comboBoxPlatos_SelectedIndexChanged;
            // 
            // dataGridViewExtras
            // 
            dataGridViewExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExtras.Location = new Point(739, 62);
            dataGridViewExtras.Name = "dataGridViewExtras";
            dataGridViewExtras.RowTemplate.Height = 25;
            dataGridViewExtras.Size = new Size(398, 168);
            dataGridViewExtras.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 376);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 9;
            label4.Text = "Seleccione algun extra";
            // 
            // comboBoxExtras
            // 
            comboBoxExtras.FormattingEnabled = true;
            comboBoxExtras.Location = new Point(254, 373);
            comboBoxExtras.Name = "comboBoxExtras";
            comboBoxExtras.Size = new Size(121, 23);
            comboBoxExtras.TabIndex = 10;
            comboBoxExtras.SelectedIndexChanged += comboBoxExtras_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 246);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 11;
            label5.Text = "Informacion del pedido";
            // 
            // listBoxPedido
            // 
            listBoxPedido.FormattingEnabled = true;
            listBoxPedido.ItemHeight = 15;
            listBoxPedido.Location = new Point(487, 264);
            listBoxPedido.Name = "listBoxPedido";
            listBoxPedido.Size = new Size(280, 274);
            listBoxPedido.TabIndex = 12;
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.Location = new Point(428, 556);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(373, 23);
            btnRealizarPedido.TabIndex = 13;
            btnRealizarPedido.Text = "Realizar Pedido";
            btnRealizarPedido.UseVisualStyleBackColor = true;
            btnRealizarPedido.Click += btnRealizarPedido_Click;
            // 
            // button1
            // 
            button1.Location = new Point(904, 556);
            button1.Name = "button1";
            button1.Size = new Size(177, 23);
            button1.TabIndex = 14;
            button1.Text = "Ver mis pedidos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(865, 264);
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.RowTemplate.Height = 25;
            dataGridViewPedidos.Size = new Size(240, 274);
            dataGridViewPedidos.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(932, 246);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 16;
            label6.Text = "Pedidos del cliente";
            // 
            // RegistrarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 591);
            Controls.Add(label6);
            Controls.Add(dataGridViewPedidos);
            Controls.Add(button1);
            Controls.Add(btnRealizarPedido);
            Controls.Add(listBoxPedido);
            Controls.Add(label5);
            Controls.Add(comboBoxExtras);
            Controls.Add(label4);
            Controls.Add(dataGridViewExtras);
            Controls.Add(comboBoxPlatos);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cmbRestaurantes);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(lblPlatos);
            Controls.Add(label1);
            Name = "RegistrarPedido";
            Text = "RegistrarPedido";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblPlatos;
        private DataGridView dataGridViewPlatos;
        private ComboBox cmbRestaurantes;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxPlatos;
        private DataGridView dataGridViewExtras;
        private Label label4;
        private ComboBox comboBoxExtras;
        private Label label5;
        private ListBox listBoxPedido;
        private Button btnRealizarPedido;
        private Button button1;
        private DataGridView dataGridViewPedidos;
        private Label label6;
    }
}