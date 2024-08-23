namespace tarea2
{
    partial class ConsultarPlatosRestaurante
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
            dataGridViewPlatosRestaurante = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatosRestaurante).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de platos por restaurante";
            // 
            // dataGridViewPlatosRestaurante
            // 
            dataGridViewPlatosRestaurante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatosRestaurante.Location = new Point(268, 48);
            dataGridViewPlatosRestaurante.Name = "dataGridViewPlatosRestaurante";
            dataGridViewPlatosRestaurante.RowTemplate.Height = 25;
            dataGridViewPlatosRestaurante.Size = new Size(474, 390);
            dataGridViewPlatosRestaurante.TabIndex = 1;
            // 
            // ConsultarPlatosRestaurante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(dataGridViewPlatosRestaurante);
            Controls.Add(label1);
            Name = "ConsultarPlatosRestaurante";
            Text = "ConsultarPlatosRestaurante";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatosRestaurante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPlatosRestaurante;
    }
}