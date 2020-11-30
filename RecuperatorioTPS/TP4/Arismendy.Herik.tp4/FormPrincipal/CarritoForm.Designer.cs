
namespace FormPrincipal
{
    partial class CarritoForm
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
            this.labelCarrito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCarrito
            // 
            this.labelCarrito.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelCarrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCarrito.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrito.Location = new System.Drawing.Point(12, 20);
            this.labelCarrito.Name = "labelCarrito";
            this.labelCarrito.Size = new System.Drawing.Size(245, 333);
            this.labelCarrito.TabIndex = 0;
            this.labelCarrito.Text = "PRODUCTOS";
            this.labelCarrito.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // CarritoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.labelCarrito);
            this.Name = "CarritoForm";
            this.Text = "CarritoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCarrito;
    }
}