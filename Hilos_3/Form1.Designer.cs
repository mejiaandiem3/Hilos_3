namespace Hilos_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnporceso1 = new System.Windows.Forms.Button();
            this.btnporceso2 = new System.Windows.Forms.Button();
            this.btnporceso3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnporceso1
            // 
            this.btnporceso1.Font = new System.Drawing.Font("Muthiara -Demo Version-", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporceso1.Location = new System.Drawing.Point(120, 309);
            this.btnporceso1.Name = "btnporceso1";
            this.btnporceso1.Size = new System.Drawing.Size(118, 55);
            this.btnporceso1.TabIndex = 0;
            this.btnporceso1.Text = "Proceso 1";
            this.btnporceso1.UseVisualStyleBackColor = true;
            this.btnporceso1.Click += new System.EventHandler(this.btnporceso1_Click);
            // 
            // btnporceso2
            // 
            this.btnporceso2.Font = new System.Drawing.Font("Muthiara -Demo Version-", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporceso2.Location = new System.Drawing.Point(265, 309);
            this.btnporceso2.Name = "btnporceso2";
            this.btnporceso2.Size = new System.Drawing.Size(118, 55);
            this.btnporceso2.TabIndex = 1;
            this.btnporceso2.Text = "Proceso 2";
            this.btnporceso2.UseVisualStyleBackColor = true;
            this.btnporceso2.Click += new System.EventHandler(this.btnporceso2_Click);
            // 
            // btnporceso3
            // 
            this.btnporceso3.Font = new System.Drawing.Font("Muthiara -Demo Version-", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporceso3.Location = new System.Drawing.Point(437, 309);
            this.btnporceso3.Name = "btnporceso3";
            this.btnporceso3.Size = new System.Drawing.Size(118, 55);
            this.btnporceso3.TabIndex = 2;
            this.btnporceso3.Text = "Proceso 3";
            this.btnporceso3.UseVisualStyleBackColor = true;
            this.btnporceso3.Click += new System.EventHandler(this.btnporceso3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnporceso3);
            this.Controls.Add(this.btnporceso2);
            this.Controls.Add(this.btnporceso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnporceso1;
        private System.Windows.Forms.Button btnporceso2;
        private System.Windows.Forms.Button btnporceso3;
    }
}

