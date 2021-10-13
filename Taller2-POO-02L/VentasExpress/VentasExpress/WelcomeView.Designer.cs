
namespace VentasExpress
{
    partial class WelcomeView
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultaInventario = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.btnVentaNueva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(343, 56);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Bienvenido";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(743, -2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 53);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultaInventario
            // 
            this.btnConsultaInventario.BackColor = System.Drawing.Color.Teal;
            this.btnConsultaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaInventario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultaInventario.Location = new System.Drawing.Point(287, 109);
            this.btnConsultaInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultaInventario.Name = "btnConsultaInventario";
            this.btnConsultaInventario.Size = new System.Drawing.Size(243, 60);
            this.btnConsultaInventario.TabIndex = 26;
            this.btnConsultaInventario.Text = "Consultar inventario";
            this.btnConsultaInventario.UseVisualStyleBackColor = false;
            this.btnConsultaInventario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.BackColor = System.Drawing.Color.Crimson;
            this.btnCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCambiarContra.Location = new System.Drawing.Point(549, 109);
            this.btnCambiarContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(243, 60);
            this.btnCambiarContra.TabIndex = 27;
            this.btnCambiarContra.Text = "Cambiar contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = false;
            this.btnCambiarContra.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVentaNueva
            // 
            this.btnVentaNueva.BackColor = System.Drawing.Color.Green;
            this.btnVentaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaNueva.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaNueva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVentaNueva.Location = new System.Drawing.Point(24, 109);
            this.btnVentaNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentaNueva.Name = "btnVentaNueva";
            this.btnVentaNueva.Size = new System.Drawing.Size(243, 60);
            this.btnVentaNueva.TabIndex = 28;
            this.btnVentaNueva.Text = "Venta nueva";
            this.btnVentaNueva.UseVisualStyleBackColor = false;
            this.btnVentaNueva.Click += new System.EventHandler(this.button4_Click);
            // 
            // WelcomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 245);
            this.Controls.Add(this.btnVentaNueva);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.btnConsultaInventario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeView";
            this.Load += new System.EventHandler(this.WelcomeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultaInventario;
        private System.Windows.Forms.Button btnCambiarContra;
        private System.Windows.Forms.Button btnVentaNueva;
    }
}