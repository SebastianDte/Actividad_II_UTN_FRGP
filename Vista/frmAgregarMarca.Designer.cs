﻿namespace Vista
{
    partial class frmAgregarMarca
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
            this.lbDescripcionNuevaMarca = new System.Windows.Forms.Label();
            this.btnAceptarNuevaMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDescripcionNuevaMarca
            // 
            this.lbDescripcionNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescripcionNuevaMarca.AutoSize = true;
            this.lbDescripcionNuevaMarca.Location = new System.Drawing.Point(2, 124);
            this.lbDescripcionNuevaMarca.Name = "lbDescripcionNuevaMarca";
            this.lbDescripcionNuevaMarca.Size = new System.Drawing.Size(44, 13);
            this.lbDescripcionNuevaMarca.TabIndex = 3;
            this.lbDescripcionNuevaMarca.Text = "Nombre";
            // 
            // btnAceptarNuevaMarca
            // 
            this.btnAceptarNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptarNuevaMarca.BackColor = System.Drawing.Color.Beige;
            this.btnAceptarNuevaMarca.Location = new System.Drawing.Point(68, 158);
            this.btnAceptarNuevaMarca.Name = "btnAceptarNuevaMarca";
            this.btnAceptarNuevaMarca.Size = new System.Drawing.Size(71, 23);
            this.btnAceptarNuevaMarca.TabIndex = 6;
            this.btnAceptarNuevaMarca.Text = "Aceptar";
            this.btnAceptarNuevaMarca.UseVisualStyleBackColor = false;
            this.btnAceptarNuevaMarca.Click += new System.EventHandler(this.btnAgregarNuevaMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Beige;
            this.btnCancelar.Location = new System.Drawing.Point(308, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(68, 124);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(316, 20);
            this.txtbDescripcion.TabIndex = 9;
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(431, 234);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarNuevaMarca);
            this.Controls.Add(this.lbDescripcionNuevaMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 491);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcas";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDescripcionNuevaMarca;
        private System.Windows.Forms.Button btnAceptarNuevaMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtbDescripcion;
    }
}