namespace tarea2
{
    partial class ConsultarRestaurante
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
            dataGridViewRestaurantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de restaurantes";
            // 
            // dataGridViewRestaurantes
            // 
            dataGridViewRestaurantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRestaurantes.Location = new Point(170, 42);
            dataGridViewRestaurantes.Name = "dataGridViewRestaurantes";
            dataGridViewRestaurantes.RowTemplate.Height = 25;
            dataGridViewRestaurantes.Size = new Size(560, 396);
            dataGridViewRestaurantes.TabIndex = 1;
            // 
            // ConsultarRestaurante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRestaurantes);
            Controls.Add(label1);
            Name = "ConsultarRestaurante";
            Text = "ConsultarRestaurante";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewRestaurantes;
    }
}