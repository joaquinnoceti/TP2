namespace WindowsFormsApp1
{
    partial class ListarArticulo
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
            this.dgvListArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListArticulos
            // 
            this.dgvListArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListArticulos.Location = new System.Drawing.Point(20, 53);
            this.dgvListArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListArticulos.MultiSelect = false;
            this.dgvListArticulos.Name = "dgvListArticulos";
            this.dgvListArticulos.RowHeadersWidth = 51;
            this.dgvListArticulos.RowTemplate.Height = 24;
            this.dgvListArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListArticulos.Size = new System.Drawing.Size(524, 231);
            this.dgvListArticulos.TabIndex = 0;
            this.dgvListArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListArticulos_CellContentClick);
            this.dgvListArticulos.SelectionChanged += new System.EventHandler(this.dgvListArticulos_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(578, 53);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(202, 231);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            this.pbArticulo.Click += new System.EventHandler(this.pbArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(149, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEliminar.Location = new System.Drawing.Point(20, 324);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(123, 13);
            this.lblEliminar.TabIndex = 3;
            this.lblEliminar.Text = "Eliminar Seleccionado ->";
            // 
            // ListarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 422);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvListArticulos);
            this.Name = "ListarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListarArticulo";
            this.Load += new System.EventHandler(this.ListarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminar;
    }
}