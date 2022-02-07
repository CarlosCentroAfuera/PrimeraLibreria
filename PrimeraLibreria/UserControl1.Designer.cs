namespace PrimeraLibreria
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(105, 37);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(279, 20);
            this.text1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.text1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(506, 169);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox textBox2;

        public void setText1(System.Windows.Forms.TextBox textBox)
        {
            text1 = textBox;
        }

        public void setText2(System.Windows.Forms.TextBox textBox)
        {
            textBox2 = textBox;
        }

        public System.Windows.Forms.TextBox getTextBox1()
        {
            return text1;
        }

        public System.Windows.Forms.TextBox getTextBox2()
        {
            return textBox2;
        }

        [System.ComponentModel.Category("Comportamiento")]
        public int numVeces { get; set; }

    }
}
