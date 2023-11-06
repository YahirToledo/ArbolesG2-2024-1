namespace ArbolesG2_2024_1
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
            this.ptbArbol = new System.Windows.Forms.PictureBox();
            this.txtbNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbArbol
            // 
            this.ptbArbol.BackColor = System.Drawing.Color.White;
            this.ptbArbol.Location = new System.Drawing.Point(12, 112);
            this.ptbArbol.Name = "ptbArbol";
            this.ptbArbol.Size = new System.Drawing.Size(776, 421);
            this.ptbArbol.TabIndex = 0;
            this.ptbArbol.TabStop = false;
            // 
            // txtbNodo
            // 
            this.txtbNodo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNodo.Location = new System.Drawing.Point(341, 40);
            this.txtbNodo.Name = "txtbNodo";
            this.txtbNodo.Size = new System.Drawing.Size(117, 32);
            this.txtbNodo.TabIndex = 1;
            this.txtbNodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNodo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un numero entero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "P - Preorden\r\nO - Posorden\r\nI - Inorder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNodo);
            this.Controls.Add(this.ptbArbol);
            this.Name = "Form1";
            this.Text = "Arbol";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbArbol;
        private System.Windows.Forms.TextBox txtbNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

