namespace Sep21
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbturnopila = new System.Windows.Forms.Label();
            this.lbturnocola = new System.Windows.Forms.Label();
            this.lbPila = new System.Windows.Forms.ListBox();
            this.lbCola = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbCDantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cola";
            // 
            // lbturnopila
            // 
            this.lbturnopila.AutoSize = true;
            this.lbturnopila.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbturnopila.Location = new System.Drawing.Point(33, 332);
            this.lbturnopila.Name = "lbturnopila";
            this.lbturnopila.Size = new System.Drawing.Size(67, 24);
            this.lbturnopila.TabIndex = 2;
            this.lbturnopila.Text = "Turno:";
            // 
            // lbturnocola
            // 
            this.lbturnocola.AutoSize = true;
            this.lbturnocola.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbturnocola.Location = new System.Drawing.Point(263, 332);
            this.lbturnocola.Name = "lbturnocola";
            this.lbturnocola.Size = new System.Drawing.Size(67, 24);
            this.lbturnocola.TabIndex = 3;
            this.lbturnocola.Text = "Turno:";
            // 
            // lbPila
            // 
            this.lbPila.FormattingEnabled = true;
            this.lbPila.Location = new System.Drawing.Point(12, 46);
            this.lbPila.Name = "lbPila";
            this.lbPila.Size = new System.Drawing.Size(191, 277);
            this.lbPila.TabIndex = 4;
            // 
            // lbCola
            // 
            this.lbCola.FormattingEnabled = true;
            this.lbCola.Location = new System.Drawing.Point(236, 46);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(191, 277);
            this.lbCola.TabIndex = 5;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(126, 376);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(175, 46);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(452, 38);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(227, 30);
            this.txtItem.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(696, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 37);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbCDantidad
            // 
            this.lbCDantidad.AutoSize = true;
            this.lbCDantidad.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDantidad.Location = new System.Drawing.Point(489, 88);
            this.lbCDantidad.Name = "lbCDantidad";
            this.lbCDantidad.Size = new System.Drawing.Size(110, 23);
            this.lbCDantidad.TabIndex = 9;
            this.lbCDantidad.Text = "Elementos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 428);
            this.Controls.Add(this.lbCDantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lbCola);
            this.Controls.Add(this.lbPila);
            this.Controls.Add(this.lbturnocola);
            this.Controls.Add(this.lbturnopila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbturnopila;
        private System.Windows.Forms.Label lbturnocola;
        private System.Windows.Forms.ListBox lbPila;
        private System.Windows.Forms.ListBox lbCola;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbCDantidad;
    }
}

