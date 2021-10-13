
namespace VentasExpress
{
    partial class Ventas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.listBoxFactura = new System.Windows.Forms.ListBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 283);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(645, 300);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Green;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSell.Location = new System.Drawing.Point(94, 203);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(444, 54);
            this.btnSell.TabIndex = 34;
            this.btnSell.Text = "Realizar venta";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.txtSearch.Location = new System.Drawing.Point(193, 97);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 43);
            this.txtSearch.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Venta:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(203, 34);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 25);
            this.lblWelcome.TabIndex = 36;
            this.lblWelcome.Text = "Formulario de ventas";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(190, 164);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(12, 17);
            this.lblError.TabIndex = 37;
            this.lblError.Text = ".";
            // 
            // listBoxFactura
            // 
            this.listBoxFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFactura.FormattingEnabled = true;
            this.listBoxFactura.HorizontalScrollbar = true;
            this.listBoxFactura.ItemHeight = 16;
            this.listBoxFactura.Location = new System.Drawing.Point(751, 262);
            this.listBoxFactura.Name = "listBoxFactura";
            this.listBoxFactura.Size = new System.Drawing.Size(319, 320);
            this.listBoxFactura.TabIndex = 45;
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.Color.White;
            this.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(751, 93);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(319, 174);
            this.txtFactura.TabIndex = 44;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "FACTURA";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 596);
            this.Controls.Add(this.listBoxFactura);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvDatos;
        public System.Windows.Forms.Button btnSell;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox listBoxFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
    }
}