namespace MainMenu
{
    partial class Form3
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
            this.btnBlanqueo = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlanqueo
            // 
            this.btnBlanqueo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanqueo.Location = new System.Drawing.Point(12, 77);
            this.btnBlanqueo.Name = "btnBlanqueo";
            this.btnBlanqueo.Size = new System.Drawing.Size(305, 52);
            this.btnBlanqueo.TabIndex = 0;
            this.btnBlanqueo.Text = "BLANQUEO DE PIN";
            this.btnBlanqueo.UseVisualStyleBackColor = true;
            this.btnBlanqueo.Click += new System.EventHandler(this.btnBlanqueo_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.Location = new System.Drawing.Point(12, 135);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(305, 52);
            this.btnSaldo.TabIndex = 1;
            this.btnSaldo.Text = "SALDO DE CUENTA CORRIENTE";
            this.btnSaldo.UseVisualStyleBackColor = true;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Location = new System.Drawing.Point(12, 193);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(305, 52);
            this.btnMovimientos.TabIndex = 2;
            this.btnMovimientos.Text = "ULTIMOS MOVIMIENTOS";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(305, 52);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 29);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(300, 26);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 316);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnBlanqueo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlanqueo;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelNombre;
    }
}