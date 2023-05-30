namespace ProyectoMensajeros
{
    partial class Liquidacion
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
            this.dgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.txtIdMensajero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLiquidacion
            // 
            this.dgvLiquidacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLiquidacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiquidacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.dgvLiquidacion.Location = new System.Drawing.Point(257, 153);
            this.dgvLiquidacion.Name = "dgvLiquidacion";
            this.dgvLiquidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiquidacion.Size = new System.Drawing.Size(604, 332);
            this.dgvLiquidacion.TabIndex = 4;
            this.dgvLiquidacion.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLiquidacion_RowHeaderMouseClick);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnLiquidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidar.Enabled = false;
            this.btnLiquidar.FlatAppearance.BorderSize = 0;
            this.btnLiquidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLiquidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLiquidar.Location = new System.Drawing.Point(575, 86);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(286, 40);
            this.btnLiquidar.TabIndex = 5;
            this.btnLiquidar.Text = "LIQUIDAR";
            this.btnLiquidar.UseVisualStyleBackColor = false;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // txtIdMensajero
            // 
            this.txtIdMensajero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIdMensajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMensajero.ForeColor = System.Drawing.Color.White;
            this.txtIdMensajero.Location = new System.Drawing.Point(281, 88);
            this.txtIdMensajero.Name = "txtIdMensajero";
            this.txtIdMensajero.ReadOnly = true;
            this.txtIdMensajero.Size = new System.Drawing.Size(247, 31);
            this.txtIdMensajero.TabIndex = 6;
            // 
            // Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1085, 615);
            this.Controls.Add(this.txtIdMensajero);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.dgvLiquidacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liquidacion";
            this.Text = "Liquidacion";
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiquidacion;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.TextBox txtIdMensajero;
    }
}