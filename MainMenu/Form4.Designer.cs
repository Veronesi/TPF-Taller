namespace MainMenu
{
    partial class Form4
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
            this.listBoxTarjetas = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBlanquear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTarjetas
            // 
            this.listBoxTarjetas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTarjetas.FormattingEnabled = true;
            this.listBoxTarjetas.ItemHeight = 26;
            this.listBoxTarjetas.Location = new System.Drawing.Point(12, 12);
            this.listBoxTarjetas.Name = "listBoxTarjetas";
            this.listBoxTarjetas.Size = new System.Drawing.Size(620, 316);
            this.listBoxTarjetas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 335);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 45);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBlanquear
            // 
            this.btnBlanquear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanquear.Location = new System.Drawing.Point(510, 335);
            this.btnBlanquear.Name = "btnBlanquear";
            this.btnBlanquear.Size = new System.Drawing.Size(121, 45);
            this.btnBlanquear.TabIndex = 2;
            this.btnBlanquear.Text = "BLANQUEAR";
            this.btnBlanquear.UseVisualStyleBackColor = true;
            this.btnBlanquear.Click += new System.EventHandler(this.btnBlanquear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 391);
            this.Controls.Add(this.btnBlanquear);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBoxTarjetas);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTarjetas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBlanquear;
    }
}