namespace AppCalculadora2
{
    partial class frmCalculadora
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btMultiplicacion = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.txtOperador1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResultado.Location = new System.Drawing.Point(103, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(595, 75);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 75);
            this.button1.TabIndex = 15;
            this.button1.Text = "&AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDivision
            // 
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(466, 209);
            this.btDivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(112, 112);
            this.btDivision.TabIndex = 14;
            this.btDivision.Text = "&/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(586, 209);
            this.btIgual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(112, 112);
            this.btIgual.TabIndex = 13;
            this.btIgual.Text = "&=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMultiplicacion
            // 
            this.btMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacion.Location = new System.Drawing.Point(346, 209);
            this.btMultiplicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMultiplicacion.Name = "btMultiplicacion";
            this.btMultiplicacion.Size = new System.Drawing.Size(112, 112);
            this.btMultiplicacion.TabIndex = 12;
            this.btMultiplicacion.Text = "&*";
            this.btMultiplicacion.UseVisualStyleBackColor = true;
            this.btMultiplicacion.Click += new System.EventHandler(this.btMultiplicacion_Click);
            // 
            // btResta
            // 
            this.btResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResta.Location = new System.Drawing.Point(223, 209);
            this.btResta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(112, 112);
            this.btResta.TabIndex = 11;
            this.btResta.Text = "&-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // btSuma
            // 
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(103, 209);
            this.btSuma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(112, 112);
            this.btSuma.TabIndex = 10;
            this.btSuma.Text = "&+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // txtOperador1
            // 
            this.txtOperador1.BackColor = System.Drawing.Color.Silver;
            this.txtOperador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador1.Location = new System.Drawing.Point(103, 124);
            this.txtOperador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperador1.Name = "txtOperador1";
            this.txtOperador1.Size = new System.Drawing.Size(595, 75);
            this.txtOperador1.TabIndex = 9;
            this.txtOperador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMultiplicacion);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.txtOperador1);
            this.Name = "frmCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btMultiplicacion;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.TextBox txtOperador1;
    }
}

