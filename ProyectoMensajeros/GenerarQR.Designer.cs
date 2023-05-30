namespace ProyectoMensajeros
{
    partial class GenerarQR
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
            this.PanelResultado = new System.Windows.Forms.Panel();
            this.btnGuardarQR = new System.Windows.Forms.Button();
            this.btnGenerarQR = new System.Windows.Forms.Button();
            this.dgvMensajero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajero)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelResultado
            // 
            this.PanelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelResultado.BackColor = System.Drawing.Color.White;
            this.PanelResultado.Location = new System.Drawing.Point(97, 103);
            this.PanelResultado.Name = "PanelResultado";
            this.PanelResultado.Size = new System.Drawing.Size(265, 250);
            this.PanelResultado.TabIndex = 0;
            // 
            // btnGuardarQR
            // 
            this.btnGuardarQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnGuardarQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarQR.Enabled = false;
            this.btnGuardarQR.FlatAppearance.BorderSize = 0;
            this.btnGuardarQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnGuardarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGuardarQR.Location = new System.Drawing.Point(87, 406);
            this.btnGuardarQR.Name = "btnGuardarQR";
            this.btnGuardarQR.Size = new System.Drawing.Size(286, 40);
            this.btnGuardarQR.TabIndex = 2;
            this.btnGuardarQR.Text = "GUARDAR QR";
            this.btnGuardarQR.UseVisualStyleBackColor = false;
            this.btnGuardarQR.Click += new System.EventHandler(this.btnGuardarQR_Click);
            // 
            // btnGenerarQR
            // 
            this.btnGenerarQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnGenerarQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarQR.Enabled = false;
            this.btnGenerarQR.FlatAppearance.BorderSize = 0;
            this.btnGenerarQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGenerarQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.btnGenerarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGenerarQR.Location = new System.Drawing.Point(600, 406);
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Size = new System.Drawing.Size(286, 40);
            this.btnGenerarQR.TabIndex = 1;
            this.btnGenerarQR.Text = "GENERAR QR";
            this.btnGenerarQR.UseVisualStyleBackColor = false;
            this.btnGenerarQR.Click += new System.EventHandler(this.btnGenerarQR_Click);
            // 
            // dgvMensajero
            // 
            this.dgvMensajero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensajero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMensajero.BackgroundColor = System.Drawing.Color.White;
            this.dgvMensajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajero.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.dgvMensajero.Location = new System.Drawing.Point(422, 103);
            this.dgvMensajero.Name = "dgvMensajero";
            this.dgvMensajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensajero.Size = new System.Drawing.Size(578, 250);
            this.dgvMensajero.TabIndex = 3;
            this.dgvMensajero.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMensajero_RowHeaderMouseClick);
            // 
            // GenerarQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1066, 597);
            this.Controls.Add(this.dgvMensajero);
            this.Controls.Add(this.btnGuardarQR);
            this.Controls.Add(this.btnGenerarQR);
            this.Controls.Add(this.PanelResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarQR";
            this.Text = "GenerarQR";
            this.Load += new System.EventHandler(this.GenerarQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelResultado;
        private System.Windows.Forms.Button btnGuardarQR;
        private System.Windows.Forms.Button btnGenerarQR;
        private System.Windows.Forms.DataGridView dgvMensajero;
    }
}