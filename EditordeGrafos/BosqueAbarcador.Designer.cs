namespace EditordeGrafos
{
    partial class BosqueAbarcador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoArista1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vertices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NodosVisi = new System.Windows.Forms.Label();
            this.Arista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoArista1,
            this.Vertices});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TipoArista1
            // 
            this.TipoArista1.HeaderText = "TipoArista";
            this.TipoArista1.Name = "TipoArista1";
            this.TipoArista1.Width = 79;
            // 
            // Vertices
            // 
            this.Vertices.HeaderText = "Vertices ";
            this.Vertices.Name = "Vertices";
            this.Vertices.Width = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NodosVisi
            // 
            this.NodosVisi.AutoSize = true;
            this.NodosVisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodosVisi.Location = new System.Drawing.Point(7, 9);
            this.NodosVisi.Name = "NodosVisi";
            this.NodosVisi.Size = new System.Drawing.Size(185, 25);
            this.NodosVisi.TabIndex = 3;
            this.NodosVisi.Text = "Nodos Visistados:";
            // 
            // Arista
            // 
            this.Arista.AutoSize = true;
            this.Arista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arista.Location = new System.Drawing.Point(24, 94);
            this.Arista.Name = "Arista";
            this.Arista.Size = new System.Drawing.Size(168, 25);
            this.Arista.TabIndex = 4;
            this.Arista.Text = "Tipo de Aristas: ";
            // 
            // BosqueAbarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 505);
            this.Controls.Add(this.Arista);
            this.Controls.Add(this.NodosVisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BosqueAbarcador";
            this.Text = "BosqueAbarcador";
            this.Load += new System.EventHandler(this.BosqueAbarcador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArista1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vertices;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NodosVisi;
        private System.Windows.Forms.Label Arista;
    }
}