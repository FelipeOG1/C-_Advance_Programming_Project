namespace tarea2
{
    partial class ConsultarExtras
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
            dataGridViewExtras = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExtras
            // 
            dataGridViewExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExtras.Location = new Point(167, 39);
            dataGridViewExtras.Name = "dataGridViewExtras";
            dataGridViewExtras.RowTemplate.Height = 25;
            dataGridViewExtras.Size = new Size(551, 399);
            dataGridViewExtras.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de extras";
            // 
            // ConsultarExtras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewExtras);
            Name = "ConsultarExtras";
            Text = "ConsultarExtras";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewExtras;
        private Label label1;
    }
}