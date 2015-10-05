namespace Animacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.checkBoxAnim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel.Location = new System.Drawing.Point(3, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(428, 494);
            this.panel.TabIndex = 0;
            // 
            // btnCirculo
            // 
            this.btnCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculo.Location = new System.Drawing.Point(47, 525);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(125, 26);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Añadir Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // checkBoxAnim
            // 
            this.checkBoxAnim.AutoSize = true;
            this.checkBoxAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnim.Location = new System.Drawing.Point(290, 525);
            this.checkBoxAnim.Name = "checkBoxAnim";
            this.checkBoxAnim.Size = new System.Drawing.Size(102, 24);
            this.checkBoxAnim.TabIndex = 3;
            this.checkBoxAnim.Text = "Animacion";
            this.checkBoxAnim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(438, 563);
            this.Controls.Add(this.checkBoxAnim);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.CheckBox checkBoxAnim;
    }
}

