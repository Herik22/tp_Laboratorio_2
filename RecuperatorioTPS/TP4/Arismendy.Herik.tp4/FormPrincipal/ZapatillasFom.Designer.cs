

namespace FormPrincipal
{
    partial class ZapatillasFom
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
            this.GrillaSneakers = new System.Windows.Forms.DataGridView();
            this.SneakersStockButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCarritoButton = new System.Windows.Forms.Button();
            this.VerCarritobutton = new System.Windows.Forms.Button();
            this.GrillaBotines = new System.Windows.Forms.DataGridView();
            this.FinalizarPagobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSneakers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBotines)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaSneakers
            // 
            this.GrillaSneakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaSneakers.Location = new System.Drawing.Point(18, 14);
            this.GrillaSneakers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrillaSneakers.Name = "GrillaSneakers";
            this.GrillaSneakers.Size = new System.Drawing.Size(784, 169);
            this.GrillaSneakers.TabIndex = 0;
            
            // 
            // SneakersStockButton
            // 
            this.SneakersStockButton.Location = new System.Drawing.Point(69, 371);
            this.SneakersStockButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SneakersStockButton.Name = "SneakersStockButton";
            this.SneakersStockButton.Size = new System.Drawing.Size(171, 46);
            this.SneakersStockButton.TabIndex = 1;
            this.SneakersStockButton.Text = "STOCK SNEAKERS";
            this.SneakersStockButton.UseVisualStyleBackColor = true;
            this.SneakersStockButton.Click += new System.EventHandler(this.CargarStockSneakers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "STOCK BOTINES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CargarStockBotines_Click);
            // 
            // AddCarritoButton
            // 
            this.AddCarritoButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddCarritoButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarritoButton.Location = new System.Drawing.Point(832, 77);
            this.AddCarritoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCarritoButton.Name = "AddCarritoButton";
            this.AddCarritoButton.Size = new System.Drawing.Size(198, 68);
            this.AddCarritoButton.TabIndex = 3;
            this.AddCarritoButton.Text = "ADD AL CARRITO";
            this.AddCarritoButton.UseVisualStyleBackColor = false;
            this.AddCarritoButton.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // VerCarritobutton
            // 
            this.VerCarritobutton.Enabled = false;
            this.VerCarritobutton.Location = new System.Drawing.Point(832, 274);
            this.VerCarritobutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerCarritobutton.Name = "VerCarritobutton";
            this.VerCarritobutton.Size = new System.Drawing.Size(198, 36);
            this.VerCarritobutton.TabIndex = 4;
            this.VerCarritobutton.Text = "VER CARRITO";
            this.VerCarritobutton.UseVisualStyleBackColor = true;
            this.VerCarritobutton.Click += new System.EventHandler(this.MostrarCarrito_Click);
            // 
            // GrillaBotines
            // 
            this.GrillaBotines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBotines.Location = new System.Drawing.Point(18, 189);
            this.GrillaBotines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrillaBotines.Name = "GrillaBotines";
            this.GrillaBotines.Size = new System.Drawing.Size(784, 169);
            this.GrillaBotines.TabIndex = 5;
            // 
            // FinalizarPagobutton
            // 
            this.FinalizarPagobutton.Enabled = false;
            this.FinalizarPagobutton.Location = new System.Drawing.Point(826, 360);
            this.FinalizarPagobutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinalizarPagobutton.Name = "FinalizarPagobutton";
            this.FinalizarPagobutton.Size = new System.Drawing.Size(198, 70);
            this.FinalizarPagobutton.TabIndex = 6;
            this.FinalizarPagobutton.Text = "EFECTUAR PAGO";
            this.FinalizarPagobutton.UseVisualStyleBackColor = true;
            this.FinalizarPagobutton.Click += new System.EventHandler(this.FinalizarCompraButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1043, 451);
            this.Controls.Add(this.FinalizarPagobutton);
            this.Controls.Add(this.GrillaBotines);
            this.Controls.Add(this.VerCarritobutton);
            this.Controls.Add(this.AddCarritoButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SneakersStockButton);
            this.Controls.Add(this.GrillaSneakers);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FormularioZapatillas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSneakers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBotines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaSneakers;
        private System.Windows.Forms.Button SneakersStockButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCarritoButton;
        private System.Windows.Forms.Button VerCarritobutton;
        private System.Windows.Forms.DataGridView GrillaBotines;
        private System.Windows.Forms.Button FinalizarPagobutton;
    }
}

