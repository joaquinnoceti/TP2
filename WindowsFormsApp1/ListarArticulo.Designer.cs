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
            // 
            // ListarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 422);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvListArticulos);
            this.Name = "ListarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListarArticulo";
            this.Load += new System.EventHandler(this.ListarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
    }
}